using FileEnhanced.Common;
using FileEnhanced.Forms.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileEnhanced.UserControls
{
    public partial class LibCard : UserControl
    {
        public LibCard(string libName, string path)
        {
            InitializeComponent();
            this.MainBtn.Text = "        " + libName;
            this.Path = path;
            new ToolTip().SetToolTip(this.MainBtn,libName);
        }

        // Fields and Properties
        public string Path { get; set; }
        public string LibName
        {
            get => this.MainBtn.Text.Trim();
            set
            {
                this.MainBtn.Text = "        " + value;
            }
        }
        private bool isSelected = false;
        public bool IsSelected
        {
            get => isSelected;
            set
            {
                isSelected = value;
                if (isSelected)
                    this.MainBtn.ForeColor = Color.FromArgb(26, 13, 171);
                else 
                    this.MainBtn.ForeColor = SystemColors.ControlText;
            }
        }

        // Events
        public event EventHandler MainBtnClicked;
        public event EventHandler Updated;


        // Methods
        public void OnUpdated()
        {
            Updated?.Invoke(this, EventArgs.Empty);
        }
        public XElement Export2XML()
        {
            return new XElement("UserLib",
                new XElement("LibName",LibName),
                new XElement("Path",Path));
        }
        public FileCard[] GetFileCards()
        {
            if (!Directory.Exists(Path))
                return null;
            FileInfo[] files = new DirectoryInfo(Path).GetFiles();
            string[] fullNameArray = new string[files.Length];
            for (int i = 0; i < files.Length; i++)
            {
                fullNameArray[i] = files[i].FullName;
            }
            FileCard[] fileCards = new FileCard[fullNameArray.Length];
            for (int i = 0; i < fullNameArray.Length; i++)
            {
                string fileName = fullNameArray[i];
                InfoEntity infoEntity = GetInfo(fileName);
                MetaEntity metaEntity = GetMeta(infoEntity);

                FileCard fileCard = new FileCard(infoEntity.Name
                    , infoEntity.DirectoryName
                    , metaEntity?.FileType, metaEntity?.FileDesc
                    , metaEntity?.Tags,infoEntity.Size,infoEntity.LastWriteTime) ;
                fileCards[i] = fileCard;
            }
            return fileCards;
        }
        public void CreateMetaFolder()
        {
            try
            {
                Directory.CreateDirectory(System.IO.Path.Combine(Path, ".meta"));
            }
            catch
            {
                MessageBox.Show($"Please note that the Path of LibCard [{LibName}] may be incorrect.\nFatel errors may occur.",
                    "Fail to Create .meta Folder", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static InfoEntity GetInfo(string fileName)
        {
            if (!File.Exists(fileName)) return null;

            InfoEntity infoEntity = new InfoEntity();
            FileInfo file = new FileInfo(fileName);
            infoEntity.FullName = file.FullName;
            infoEntity.CreationTime = file.CreationTime.ToString();
            infoEntity.LastWriteTime = file.LastWriteTime.ToString();
            infoEntity.LastAccessTime = file.LastAccessTime.ToString();
            infoEntity.Extension = file.Extension;
            infoEntity.Name = file.Name;
            infoEntity.DirectoryName = file.DirectoryName;
            if (file.Length < 1024)
                infoEntity.Size = file.Length.ToString() + 'B';
            else if (file.Length >= 1024 && file.Length < Math.Pow(1024, 2))
                infoEntity.Size = (file.Length / 1024).ToString("#0.0") + "KB";
            else if (file.Length >= Math.Pow(1024, 2) && file.Length < Math.Pow(1024, 3))
                infoEntity.Size = (file.Length / Math.Pow(1024, 2)).ToString("#0.0") + "MB";
            else
                infoEntity.Size = (file.Length / Math.Pow(1024, 3)).ToString("#0.0") + "GB";
            return infoEntity;
        }
        public static MetaEntity GetMeta(InfoEntity infoEntity)
        {
            string path = System.IO.Path.Combine(infoEntity.DirectoryName, ".meta", ".meta.xml");
            if (!File.Exists(path))
            {
                new XElement("MetaCollection").Save(path);
                return null;
            }

            XElement root = XElement.Load(path);
            var res = from m in root.Elements("Meta")
                      where m.Element("FileName").Value == infoEntity.Name
                      select m;
            if (res.Count() == 0) return null;

            XElement fElement = res.ToArray()[0];
            MetaEntity metaEntity = new MetaEntity()
            {
                FileName = fElement.Element("FileName").Value,
                FileType = fElement.Element("FileType").Value,
                Tags = fElement.Element("Tags").Value == "" ? null : fElement.Element("Tags").Value.Split(';').Distinct().ToArray(),
                FileDesc = fElement.Element("FileDesc").Value
            };

            return metaEntity;
        }
        private void MainBtn_Click(object sender, EventArgs e)
        {
            MainBtnClicked?.Invoke(this, EventArgs.Empty);
        }
        private void MenuPic_Click(object sender, EventArgs e)
        {
            LibCardMenu newMenu = new LibCardMenu(this);
            newMenu.Location = new Point(Control.MousePosition.X, Control.MousePosition.Y + this.Height / 2);
            newMenu.Show();
        }
        private void MainBtn_MouseEnter(object sender, EventArgs e)
        {
            this.MenuPic.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void MainBtn_MouseLeave(object sender, EventArgs e)
        {
            this.MenuPic.BackColor = Color.White;
        }
        private void MenuPic_MouseEnter(object sender, EventArgs e)
        {
            this.MenuPic.BackColor = Color.FromArgb(229, 229, 229);
            this.MainBtn.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void MenuPic_MouseLeave(object sender, EventArgs e)
        {
            this.MenuPic.BackColor = Color.White;
            this.MainBtn.BackColor = Color.White;
        }
        private void LibCard_Load(object sender, EventArgs e)
        {
            CreateMetaFolder();
        }
    }
}
