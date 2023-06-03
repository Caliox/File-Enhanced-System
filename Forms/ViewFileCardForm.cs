using FileEnhanced.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileEnhanced.Common;
using System.IO;

namespace FileEnhanced.Forms
{
    public partial class ViewFileCardForm : Form
    {
        public ViewFileCardForm(FileCard fileCard)
        {
            InitializeComponent();
            this.fileCard = fileCard;
            this.NameBox.Text = fileCard.FileName;
            this.PathBox.Text = fileCard.DirPath;
            this.AnyTagBox.Text = fileCard.AnyTag.ToString();
            this.ComboBox.DataSource = new string[] { "Document", "SnapShot", "Template" };
            GetFileType();
        }

        //Fields and Properties
        private Point mPoint;
        private FileCard fileCard;

        //Methods
        private void GetFileType()
        {
            if (this.fileCard.FileType == "SnapShot")
                this.ComboBox.SelectedIndex = 1;
            else if (this.fileCard.FileType == "Template")
                this.ComboBox.SelectedIndex = 2;
            else this.ComboBox.SelectedIndex = 0;
        }
        private void ClientPnl_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        private void ClientPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            this.fileCard.FileType = this.ComboBox.SelectedItem.ToString();
            this.fileCard.OnUpdated();
            this.Close();
        }
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!Directory.Exists(this.fileCard.DirPath))
            {
                MessageBox.Show($"Directory path:\n{this.fileCard.DirPath}\ndoes not exist.", "Fail to open in File Explorer",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            System.Diagnostics.Process.Start(this.fileCard.DirPath);
            this.Close();
        }
        private void ComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string type = this.ComboBox.SelectedItem.ToString();
            string extension = new FileInfo(this.fileCard.FullName).Extension;

            if(type == "SnapShot" && !new string[] { ".htm", ".html" }.Contains(extension))
            {
                MessageBox.Show("A SnapShot should be a \".html\" or \".htm\" file.",
                        "Fail to Update FileType", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetFileType();
            }
            else if(type == "Template" && extension != ".docx")
            {
                MessageBox.Show("A Template should be a \".docx\" file.",
                        "Fail to Use Template", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GetFileType();
            }
        }
    }
}
