using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using FileEnhanced.Forms;
using System.Xml.Linq;
using FileEnhanced.Common;

namespace FileEnhanced.UserControls
{
    public partial class FileCard : UserControl
    {
        public FileCard(string fileName,string dirPath,string fileType,string fileDesc
            ,string[] tags,string fileSize,string updatedDate)
        {
            InitializeComponent();

            this.FileName = fileName;
            this.DirPath = dirPath;
            if(!string.IsNullOrEmpty(fileType))
                this.FileType = fileType;
            else
                AutoSetFileType();
            this.FileSize = fileSize;
            this.UpdatedDate = updatedDate;
            this.originControlHeight = this.Height;
            this.minControlHeight = this.Height - this.TagPanel.Height + 5;
            this.originInfoPnlLocation = this.FileInfoPnl.Location;
            SetDesc(fileDesc);
            SetTags(tags);

            //为按钮添加提示文本;
            new ToolTip().SetToolTip(this.DetailBtn, "View Details");
            new ToolTip().SetToolTip(this.EditDescBtn, "Edit Description");
            new ToolTip().SetToolTip(this.AddTagBtn, "Add a Tag");
            new ToolTip().SetToolTip(this.FileNameLbl, this.FileNameLbl.Text);
        }

        // Fields and Properties

        //不指定文件描述时的默认展示文本，应具有特殊的浅色
        private static readonly string defaultDesc = @"No description for this file. You can add/edit the description by clicking the button located at the left side.";
        //控件的原始大小        
        private int originControlHeight;
        //文件无标签时的控件大小
        private int minControlHeight;
        //文件信息Panel的原始位置
        private Point originInfoPnlLocation;

        public bool AnyTag { get => this.TagPanel.Controls.Count != 0; }
        public string FileName { get => this.FileNameLbl.Text; set => this.FileNameLbl.Text = value; }
        //文件所在的文件夹路径
        public string DirPath { get; set; }
        public string FullName { get => Path.Combine(DirPath, FileName); }
        public string FileType
        {
            get => this.FileTypeBtn.Text;
            set
            {
                if (string.IsNullOrEmpty(value) || new string[] {"Template", "SnapShot"}.Contains(value) == false)
                {
                    this.FileTypeBtn.Visible = false;
                    this.FileTypeBtn.Text = "Document";
                }
                else
                {
                    this.FileTypeBtn.Text = value;
                    this.FileTypeBtn.Visible = true;
                }
            }
        }
        public string FileDesc
        {
            get
            {
                if (this.FileDescLbl.Text == defaultDesc) return null;
                else return this.FileDescLbl.Text;
            }
            set
            {
                SetDesc(value);
            }
        }
        public string[] Tags
        {
            get
            {
                return this.TagPanel.Controls.OfType<TagBtn>().Select(t => t.Text).ToArray();
            }
            set
            {
                SetTags(value);
            }
        }
        public string FileSize { get => this.FileSizeLbl.Text; set => this.FileSizeLbl.Text = value; }
        private string updatedDate;
        public string UpdatedDate
        {
            get => updatedDate;
            set
            {
                updatedDate = value;
                this.UpdatedDateLbl.Text = "    Updated at: " + updatedDate;
            }
        }


        // Events

        public event EventHandler Updated;

        // Methods

        //根据是否有标签调整控件的大小
        private void ChangeControlSize()
        {
            if (AnyTag)
            {
                this.Height = originControlHeight;
                this.FileInfoPnl.Location = originInfoPnlLocation;
                this.TagPanel.Visible = true;
            }
            else
            {
                this.FileInfoPnl.Location = new Point(this.TagPanel.Location.X, this.TagPanel.Location.Y + 5);
                this.TagPanel.Visible = false;
                this.Height = minControlHeight;
            }
        }
        //卡片更新时的回调方法
        public void OnUpdated()
        {
            Directory.CreateDirectory(Path.Combine(DirPath, ".meta"));
            string xmlPath = Path.Combine(DirPath, ".meta", ".meta.xml");
            if (!File.Exists(xmlPath))
            {
                XElement root = new XElement("MetaCollection",Export2XML());
                root.Save(xmlPath);
            }
            else
            {
                XElement root = XElement.Load(xmlPath);
                XElement target = (from m in root.Elements("Meta")
                                  where m.Element("FileName").Value == FileName && m.Element("DirPath").Value == DirPath
                                  select m).FirstOrDefault();
                if(target == null) root.Add(Export2XML());
                else target.ReplaceWith(Export2XML());
                root.Save(xmlPath);
            }
            Updated?.Invoke(this,EventArgs.Empty);
        }
        // 搜索标签按钮的方法
        public void SearchTagBtn(object sender, EventArgs e)
        {
            Global.Instance.mainForm.SearchFiles((sender as TagBtn).Text
                , Global.Instance.mainForm.SearchModel == SearchModel.Global ? true : false, true);
        }
        //设置Tags
        public void SetTags(string[] tags)
        {
            if (tags != null && tags.Length > 0)
            {
                TagBtn[] tagBtns = tags.Distinct().Select(s => new TagBtn(s)).ToArray();
                foreach (TagBtn tagBtn in tagBtns)
                {
                    tagBtn.SearchMe += SearchTagBtn;
                }
                this.TagPanel.Controls.AddRange(tagBtns);
            }
            ChangeControlSize();
        }
        //设置Description
        public void SetDesc(string desc)
        {
            if (string.IsNullOrEmpty(desc))
            {
                this.FileDescLbl.Text = defaultDesc;
                this.FileDescLbl.ForeColor = Color.FromArgb(227, 227, 227);
            }
            else
            {
                this.FileDescLbl.Text = desc;
                this.FileDescLbl.ForeColor = Color.FromArgb(64, 72, 91);
            }
        }
        //自动匹配FileType
        public void AutoSetFileType()
        {
            string extension = new FileInfo(this.FullName).Extension;
            if (new string[] { ".htm", ".html" }.Contains(extension))
            {
                this.FileType = "SnapShot";
            }
            else this.FileType = "Document";
        }
        //根据名称添加标签
        public void AddTagByName(string tag)
        {
            if (string.IsNullOrEmpty(tag)) return;
            foreach(TagBtn tagBtn in this.TagPanel.Controls)
            {
                if (tagBtn.Text == tag) return;
            }
            TagBtn newTagBtn = new TagBtn(tag);
            newTagBtn.SearchMe += SearchTagBtn;
            this.TagPanel.Controls.Add(newTagBtn);
            ChangeControlSize();
            OnUpdated();
        }
        //根据名称删除标签
        public void RemoveTagByName(string tag)
        {
            bool anyDeleted = false; 
            foreach(TagBtn tagBtn in this.TagPanel.Controls)
            {
                if(tagBtn.Text == tag)
                {
                    this.TagPanel.Controls.Remove(tagBtn);
                    anyDeleted = true;
                }
            }
            if (anyDeleted)
            {
                ChangeControlSize();
                OnUpdated();
            }
            
        }
        //导出为XML元素
        public XElement Export2XML()
        {
            return new XElement("Meta"
                , new XElement("FileName", FileName)
                , new XElement("DirPath", DirPath)
                , new XElement("FileType", FileType)
                , new XElement("FileDesc", FileDesc)
                , new XElement("Tags", string.Join(";", Tags))
                );
        }
        private void FileNameLbl_MouseEnter(object sender, EventArgs e)
        {
            this.FileNameLbl.Font = new Font("Segoe UI", 10F, ((FontStyle)((FontStyle.Bold | FontStyle.Underline))), GraphicsUnit.Point, ((byte)(134)));
        }
        private void FileNameLbl_MouseLeave(object sender, EventArgs e)
        {
            this.FileNameLbl.Font  = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
        }
        private void DetailBtn_Click(object sender, EventArgs e)
        {
            new ViewFileCardForm(this).Show();
        }
        private void EditDescBtn_Click(object sender, EventArgs e)
        {
            new EditFileDescForm(this).Show();
        }
        private void AddTagBtn_Click(object sender, EventArgs e)
        {
            new AddFileTagForm(this).Show();
        }
        private void FileNameLbl_Click(object sender, EventArgs e)
        {
            if (!File.Exists(this.FullName))
            {
                MessageBox.Show($"File does not exist.\n{this.FullName}"
                    ,"Fail to open file",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return ;
            }

            string extension = new FileInfo(this.FullName).Extension;

            if (this.FileType == "SnapShot")
            {
                if(new string[] { ".htm", ".html" }.Contains(extension))
                {
                    new FilePreviewForm(this.FullName).Show();
                }
                else
                {
                    MessageBox.Show("A SnapShot should be a \".html\" or \".htm\" file.",
                        "Fail to Open SnapShot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.FileType = "Document";
                }
            }
            else if(this.FileType == "Template")
            {
                if(extension == ".docx")
                {
                    new TemplateSetForm(this.FullName).Show();
                }
                else
                {
                    MessageBox.Show("A Template should be a \".docx\" file.",
                        "Fail to Use Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.FileType = "Document";
                }
            }
            else
                System.Diagnostics.Process.Start(this.FullName);
        }
        private void FileCard_Load(object sender, EventArgs e)
        {
            if (this.FileNameLbl.Width < 584)
            {
                this.FileTypeBtn.Location = new Point(this.FileNameLbl.Width + this.FileTypeBtn.Margin.Left,1);
            }
        }
    }
}
