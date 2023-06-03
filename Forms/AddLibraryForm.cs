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

namespace FileEnhanced.Forms
{
    public partial class AddLibraryForm : Form
    {
        public AddLibraryForm(LibraryUC libCardsUC)
        {
            InitializeComponent();
            this.libCardsUC = libCardsUC;
        }

        // Fields and Properties
        private LibraryUC libCardsUC;

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
                    MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(this.LibPathBox.Text))
            {
                MessageBox.Show("Library Path is Empty!", "Fail to Create a New Library",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if(libCardsUC.AddLibByName(this.LibNameBox.Text, this.LibPathBox.Text))
                this.Close();
        }
    }
}
