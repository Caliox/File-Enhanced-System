using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEnhanced.Forms
{
    public partial class FilePreviewForm : Form
    {
        public FilePreviewForm(string file)
        {
            InitializeComponent();
            this.file = file;
            this.PathLbl.Text = file;
        }
        private string file;
        private void FilePreviewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.webBrowser.Dispose();
        }

        private void FilePreviewForm_Load(object sender, EventArgs e)
        {
            this.webBrowser.Url = new Uri(file);
        }

        private void InsertBtn_Click(object sender, EventArgs e)
        {
            this.webBrowser.Document.ExecCommand("SelectAll", false, null);
            this.webBrowser.Document.ExecCommand("Copy", false, null);
            this.webBrowser.Document.ExecCommand("Unselect", false, null);

            MessageBox.Show("All Text has been Copied to the ClipBoard.");
        }
    }
}
