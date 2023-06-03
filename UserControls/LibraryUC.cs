using FileEnhanced.Forms;
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
    public partial class LibraryUC : UserControl
    {
        public LibraryUC(string xmlPath)
        {
            InitializeComponent();
            new ToolTip().SetToolTip(this.NewLibBtn, "Create a New Library");
            this.xmlPath = xmlPath;
            LoadFromXML(xmlPath);
        }

        // Fields and Properties
        private string xmlPath;

        // Events
        public event EventHandler CardMainBtnClicked;

        // Methods
        private void OnCardMainBtnClicked(object sender,EventArgs e)
        {
            foreach (LibCard lib in this.LibPnl.Controls) lib.IsSelected = false;
            (sender as LibCard).IsSelected = true;
            CardMainBtnClicked?.Invoke(sender, e);
        }
        private void OnCardUpdated(object sender, EventArgs e)
        {
            Export2XML();
        }
        private void LoadFromXML(string file)
        {
            this.LibPnl.Controls.Clear();
            if (string.IsNullOrEmpty(file) || !File.Exists(file)) return;

            XElement root = XElement.Load(file);
            LibCard[] libArray = (from l in root.Elements("UserLib")
                                  select new LibCard(l.Element("LibName").Value, l.Element("Path").Value)).ToArray();
            foreach (LibCard lib in libArray)
            {
                lib.MainBtnClicked += OnCardMainBtnClicked;
                lib.Updated += OnCardUpdated;
            }
            this.LibPnl.Controls.AddRange(libArray);
        }
        public void Export2XML()
        {
            XElement root = new XElement("UserLibs");
            foreach(LibCard lib in this.LibPnl.Controls)
            {
                root.Add(lib.Export2XML());
            }
            root.Save(xmlPath);
        }
        public LibCard[] GetAllLibCard()
        {
            return LibPnl.Controls.OfType<LibCard>().Select(c => c as LibCard).ToArray();
        }
        public bool Contains(string libName)
        {
            foreach (LibCard lib in this.LibPnl.Controls)
            {
                if (lib.LibName == libName)
                    return true;
            }
            return false;
        }
        public bool AddLibByName(string libName,string Path)
        {
            if (!string.IsNullOrEmpty(libName))
            {
                if (Contains(libName))
                {
                    MessageBox.Show($"It Seems that Library [{libName}] Already Exist.", "Fail to Create a New Library",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                try
                {
                    Directory.CreateDirectory(Path);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please check if the path you specified is correct.", "Fail to Create a New Library",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                
                LibCard newCard = new LibCard(libName, Path);
                newCard.MainBtnClicked += OnCardMainBtnClicked;
                newCard.Updated += OnCardUpdated;
                this.LibPnl.Controls.Add(newCard);
                XElement root = XElement.Load(xmlPath);
                root.Add(newCard.Export2XML());
                root.Save(xmlPath);
                return true;
            }
            return false;
        }
        public void RemoveLibByName(string libName)
        {
            foreach(LibCard lib in this.LibPnl.Controls)
            {
                if (lib.LibName == libName)
                {
                    this.LibPnl.Controls.Remove(lib);
                }
            }
            XElement root = XElement.Load(xmlPath);
            foreach(XElement e in root.Elements("UserLib"))
            {
                if (e.Element("LibName").Value == libName)
                    e.Remove();
            }
            root.Save(xmlPath);
        }
        private void NewLibBtn_Click(object sender, EventArgs e)
        {
            new AddLibraryForm(this).Show();
        }
    }
}
