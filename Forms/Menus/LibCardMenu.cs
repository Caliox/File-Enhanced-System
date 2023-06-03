using FileEnhanced.UserControls;
using System.Windows.Forms;
using FileEnhanced.Common;
using System;
using System.IO;

namespace FileEnhanced.Forms.Menus
{
    public partial class LibCardMenu : Form
    {
        public LibCardMenu(LibCard libCard)
        {
            InitializeComponent();
            this.libCard = libCard;
        }

        // Fields and Properties
        private LibCard libCard;

        // Methods
        private void LibCardMenu_Deactivate(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void OpenBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
            if (!Directory.Exists(libCard.Path))
            {
                MessageBox.Show("Library Path is invalid!\nTo protect the operation of the software,this Library will be removed.", 
                    "Path InValid",MessageBoxButtons.OK, MessageBoxIcon.Question);
                Global.GetParentByType<LibraryUC>(libCard).RemoveLibByName(libCard.LibName);
            }
            else
                System.Diagnostics.Process.Start(libCard.Path);
        }
        private void EditBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
            new EditLibraryForm(libCard).Show();
        }
        private void RemoveBtn_Click(object sender, System.EventArgs e)
        {
            this.Close();
            if(MessageBox.Show("Are you sure to remove this Library?","Remove a Library",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                Global.GetParentByType<LibraryUC>(libCard).RemoveLibByName(libCard.LibName);
        }
    }
}
