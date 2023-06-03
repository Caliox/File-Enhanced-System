using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using FileEnhanced.Common;
using FileEnhanced.UserControls;

namespace FileEnhanced.Forms
{
    public enum SearchModel { Global,Local};
    public partial class FileEnhancedForm : Form
    {
        public FileEnhancedForm()
        {
            InitializeComponent();
            Global.Instance.mainForm = this;
        }

        // Fields and Properties 

        private Point mPoint;
        private LibraryUC libraryUC = null; //创建字段，避免频繁创建UC

        private LibCard activeLibCard = null;
        public LibCard ActiveLibCard
        {
            get => activeLibCard;
            set
            {
                activeLibCard = value;
                if (activeLibCard != null)
                    ActivedLibLbl.Text = activeLibCard.LibName;
                else
                    ActivedLibLbl.Text = "----------";
            }
        }

        private TagGroupUC tagGroupUC = null;
        public TagGroupUC TagGroupUC
        {
            get
            {
                if(tagGroupUC == null)
                {
                    string defaultPath = "TagGroups.xml";
                    if (!File.Exists(defaultPath))
                    {
                        XElement root = new XElement("TagGroups");
                        root.Save(defaultPath);
                    }
                    TagGroupUC newUC = new TagGroupUC(defaultPath);
                    newUC.CombineSearched += (sender, e) =>
                    {
                        string searchStr = (sender as TagGroupUC).SearchStr;
                        this.SearchBar.SearchText = searchStr;
                        SearchFiles(searchStr, true, true);
                    };
                    tagGroupUC = newUC;
                }
                return tagGroupUC;
            }
        }

        private int filterOutLen;
        public int FilterOutLen
        {
            get => filterOutLen;
            set
            {
                filterOutLen = value;
                this.FilterNumLbl.Text = filterOutLen.ToString();
            }
        }

        [DefaultValue(SearchModel.Global)]
        public SearchModel SearchModel { get; set; }
        public bool TagOnly = false;


        // Methods

        private void FuncBtn_Click(object sender, EventArgs e)
        {
            this.LibraryBtn.BorderSize = 0;
            this.TagGroupBtn.BorderSize = 0;
            this.SettingBtn.BorderSize = 0;
            this.HelpBtn.BorderSize = 0;

            RoundedButton btn = (RoundedButton)sender;
            btn.BorderSize = 1;

            switch (btn.Name)
            {
                case "LibraryBtn":
                    LoadLibraryUC();
                    break;
                case "TagGroupBtn":
                    LoadTagGroupUC();
                    break;
                case "SettingBtn":
                    this.FuncMainPnl.Controls.Clear();
                    this.FuncMainPnl.Controls.Add(new SettingUC());
                    break;
                case "HelpBtn":
                    this.FuncMainPnl.Controls.Clear();
                    this.FuncMainPnl.Controls.Add(new HelpUC());
                    break;
            }
        }
        public void LoadLibraryUC()
        {
            if (libraryUC == null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                string libraryXmlPath = config.AppSettings.Settings["LibraryXmlPath"].Value;
                if (string.IsNullOrEmpty(libraryXmlPath) || !File.Exists(libraryXmlPath))
                {
                    libraryXmlPath = Path.Combine(Application.StartupPath, "UserLibs.xml");
                    if (!File.Exists(libraryXmlPath))
                    {
                        XElement root = new XElement("UserLibs");
                        root.Save(libraryXmlPath);
                    }
                }
                LibraryUC newUC = new LibraryUC(libraryXmlPath);
                newUC.CardMainBtnClicked += OnLibCardClicked;
                libraryUC = newUC;
            }
            this.FuncMainPnl.Controls.Clear();
            this.FuncMainPnl.Controls.Add(libraryUC);
        }
        public void LoadTagGroupUC()
        {
            if(tagGroupUC == null)
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                string tagGroupXmlPath = config.AppSettings.Settings["TagGroupXmlPath"].Value;
                if(string.IsNullOrEmpty(tagGroupXmlPath) || !File.Exists(tagGroupXmlPath))
                {
                    tagGroupXmlPath = Path.Combine(Application.StartupPath, "TagGroups.xml");
                    if (!File.Exists(tagGroupXmlPath))
                    {
                        XElement root = new XElement("TagGroups");
                        root.Save(tagGroupXmlPath);
                    }
                }
                TagGroupUC newUC = new TagGroupUC(tagGroupXmlPath);
                newUC.CombineSearched += (sender, e) =>
                {
                    string searchStr = (sender as TagGroupUC).SearchStr;
                    this.SearchBar.SearchText = searchStr;
                    SearchFiles(searchStr, true, true);
                };
                tagGroupUC = newUC;
            }
            this.FuncMainPnl.Controls.Clear();
            this.FuncMainPnl.Controls.Add(tagGroupUC);
        }
        public void SearchFiles(string targetStr,bool global,bool tagOnly)
        {
            if (string.IsNullOrEmpty(targetStr)) return;
            List<FileCard> fileCards = new List<FileCard>();
            // 全局搜索
            if (global)
            {
                LibCard[] allLibs = this.libraryUC.GetAllLibCard().ToArray();
                foreach(LibCard lib in allLibs)
                {
                    FileCard[] resultArray = SearchFilesInOneLib(lib, targetStr, tagOnly);
                    if (resultArray.Length > 0)
                        fileCards.AddRange(resultArray);
                }
            }
            // 仅搜索当前活动库
            else if(ActiveLibCard != null)
            {
                fileCards.AddRange(SearchFilesInOneLib(ActiveLibCard, targetStr, tagOnly)); 
            }
            else
            {
                MessageBox.Show("No Library was Selected.\nSelect one Library by Click a Library Card or Use \"GlobalSearch\"."
                    , "Search Interrupted", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            this.FileCardPnl.Controls.Clear();
            if (fileCards.Count()==0)
                this.FilterOutLen = 0;
            else
                this.FileCardPnl.Controls.AddRange(fileCards.ToArray());
        }
        private FileCard[] SearchFilesInOneLib(LibCard libCard,string targetStr,bool tagOnly)
        {
            FileCard[] sourceFileCards = libCard?.GetFileCards();
            if(sourceFileCards == null || sourceFileCards.Length == 0) return null;

            string pattern = targetStr.Trim();
            string[] patternArray = null;
            if (pattern.Contains("|"))
            {
                pattern = string.Join("|", pattern.Split('|').Where(s => !string.IsNullOrEmpty(s)).Select(s => s.Trim()).ToArray());
            }
            if (pattern.Contains(";"))
                patternArray = pattern.Split(';').Where(s => !string.IsNullOrEmpty(s)).Select(s => s.Trim()).ToArray();

            // 执行筛选
            FileCard[] filterOut = null;
            // 优先处理“与”条件
            if(patternArray != null)
            {
                // 仅搜索标签
                if (tagOnly)
                {
                    filterOut = sourceFileCards.Where(c =>
                    {
                        foreach (string str in patternArray)
                        {
                            if (!c.Tags.Contains(str))
                                return false;
                        }
                        return true;
                    }).ToArray();
                }
                // 搜索文件名、标签、描述
                else
                {
                    filterOut = sourceFileCards.Where(c =>
                    {
                        foreach (string str in patternArray)
                        {
                            if (!(string.Concat(c.FileName, c.FileDesc, String.Join(";", c.Tags))).Contains(str))
                                return false;
                        }
                        return true;
                    }).ToArray();
                }
            }
            // 处理“或”条件
            else
            {
                // 仅搜索标签
                if (tagOnly)
                {
                    filterOut = sourceFileCards.Where(c => Regex.IsMatch(String.Join(";",c.Tags), pattern)).ToArray();
                }
                // 搜索文件名、标签、描述
                else
                {
                    filterOut = sourceFileCards.Where(c => Regex.IsMatch(string.Concat(c.FileName, c.FileDesc, String.Join(";", c.Tags)), pattern)).ToArray();
                }
            }
            return filterOut;
        }
        private void OnLibCardClicked(object sender, EventArgs e)
        { 
            this.FileCardPnl.Controls.Clear();
            LibCard lib = sender as LibCard;
            this.ActiveLibCard = lib;
            this.FileCardPnl.Controls.AddRange(lib.GetFileCards());
        }
        public void OnFileTagSearched(object sender, EventArgs e)
        {
            this.SearchBar.SearchText = (sender as TagBtn).Text;
            SearchFiles((sender as TagBtn).Text, this.SearchModel == SearchModel.Global ? true : false, true);
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ClientPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        private void ClientPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        private void FileEnhancedForm_Load(object sender, EventArgs e)
        {
            LoadLibraryUC();
        }
        private void SearchModelBtn_Click(object sender, EventArgs e)
        {
            if(this.SearchModel == SearchModel.Global)
            {
                this.SearchModel = SearchModel.Local;
                this.SearchModelBtn.Text = "Local";
                this.SearchModelBtn.BackColor = Color.FromArgb(9, 105, 218);
                this.SearchModelBtn.ForeColor = Color.White;
            }
            else
            {
                this.SearchModel = SearchModel.Global;
                this.SearchModelBtn.Text = "Global";
                this.SearchModelBtn.BackColor = Color.FromArgb(221, 244, 255);
                this.SearchModelBtn.ForeColor = Color.FromArgb(9, 127, 229);
            }
        }
        private void TagOnlyBtn_Click(object sender, EventArgs e)
        {
            if (this.TagOnly)
            {
                this.TagOnly = false;
                this.TagOnlyBtn.Text = "False";
                this.TagOnlyBtn.BackColor = Color.FromArgb(221, 244, 255);
                this.TagOnlyBtn.ForeColor = Color.FromArgb(9, 127, 229);
            }
            else
            {
                this.TagOnly = true;
                this.TagOnlyBtn.Text = "True";
                this.TagOnlyBtn.BackColor = Color.FromArgb(9, 105, 218);
                this.TagOnlyBtn.ForeColor = Color.White;
            }
        }
        private void FileCardPnl_ControlAdded(object sender, ControlEventArgs e)
        {
            this.FilterOutLen = this.FileCardPnl.Controls.Count;
        }
        private void SearchBar_SearchEvent(object sender, EventArgs e)
        {
            SearchFiles(this.SearchBar.SearchText, this.SearchModel == SearchModel.Global? true : false, this.TagOnly);
        }
        private void MinBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void GithubBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://github.com/Caliox/File-Enhanced-System");
        }
        private void GiteeBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://gitee.com/caliox/file-enhanced-system");
        }
    }
}







