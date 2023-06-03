using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;

namespace FileEnhanced.UserControls
{
    public partial class SettingUC : UserControl
    {
        public SettingUC()
        {
            InitializeComponent();

            string libraryXmlPath = ReadKeyValue(Application.ExecutablePath, "LibraryXmlPath");
            if (string.IsNullOrEmpty(libraryXmlPath))
                this.LibPathTextBox.Text = Path.Combine(Application.StartupPath, "UserLibs.xml");
            else
                this.LibPathTextBox.Text = libraryXmlPath;

            string tagGroupXmlPath = ReadKeyValue(Application.ExecutablePath, "TagGroupXmlPath");
            if (string.IsNullOrEmpty(tagGroupXmlPath))
                this.GroupXmlPathBox.Text = Path.Combine(Application.StartupPath, "TagGroups.xml");
            else
                this.GroupXmlPathBox.Text = tagGroupXmlPath;
        }

        public string  ReadKeyValue(string path, string keyName)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(path);
            return config.AppSettings.Settings[keyName].Value;
        }
        public void WriteKeyValue(string path, string keyName,string keyValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(path);
            foreach(string key in config.AppSettings.Settings.AllKeys)
            {
                if(key == keyName)
                {
                    config.AppSettings.Settings.Remove(key);
                }
            }
            config.AppSettings.Settings.Add(keyName, keyValue);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("AppSettings");
        }
        private void ExplororBtn_Click(object sender, EventArgs e)
        {
            if(this.OpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                RoundedButton btn = sender as RoundedButton;
                switch (btn.Name)
                {
                    case "LibExplororBtn":
                        this.LibPathTextBox.Text = this.OpenFileDialog.FileName;
                        break;
                    case "GroupExplororBtn":
                        this.GroupXmlPathBox.Text = this.OpenFileDialog.FileName;
                        break;
                }
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            WriteKeyValue(Application.ExecutablePath, "LibraryXmlPath", this.LibPathTextBox.Text);
            WriteKeyValue(Application.ExecutablePath, "TagGroupXmlPath", this.GroupXmlPathBox.Text);
            MessageBox.Show("Settings Updated!","Settings Updated",MessageBoxButtons.OK,MessageBoxIcon.None);
        }
    }
}