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
    public partial class EditLibraryForm : Form
    {
        public EditLibraryForm(LibCard libCard)
        {
            InitializeComponent();
            this.libCard = libCard;
            this.LibNameBox.Text = libCard.LibName;
            this.LibPathBox.Text = libCard.Path;
        }

        // Fields and Properties
        private LibCard libCard;

        // Methods
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ExplororBtn_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog.ShowDialog() == DialogResult.OK)
                LibPathBox.Text = folderBrowserDialog.SelectedPath;
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.LibNameBox.Text))
            {
                MessageBox.Show("Library Name is Empty!", "Fail to Create a New Library",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.LibPathBox.Text))
            {
                MessageBox.Show("Library Path is Empty!", "Fail to Create a New Library",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LibNameBox.Text!=libCard.LibName && Global.GetParentByType<LibraryUC>(libCard).Contains(LibNameBox.Text))
            {
                MessageBox.Show($"Library [{this.LibNameBox.Text}] Already exist!", "Fail to Edit Library",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                Directory.CreateDirectory(this.LibPathBox.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Please check if the path you specified is correct.", "Fail to Edit Library",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            libCard.LibName = this.LibNameBox.Text;
            libCard.Path = this.LibPathBox.Text;
            libCard.CreateMetaFolder();
            libCard.OnUpdated();
            this.Close();
        }
    }
}
