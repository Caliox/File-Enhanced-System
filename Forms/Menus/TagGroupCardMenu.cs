using FileEnhanced.UserControls;
using System.Windows.Forms;
using FileEnhanced.Common;
using System;
using System.IO;

namespace FileEnhanced.Forms.Menus
{
    public partial class TagGroupCardMenu : Form
    {
        public TagGroupCardMenu(TagGroupCard tagGroupCard)
        {
            InitializeComponent();
            this.tagGroupCard = tagGroupCard;
        }

        // Fields and Properties

        private TagGroupCard tagGroupCard;

        // Methods

        private void LibCardMenu_Deactivate(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new EditGroupNameForm(tagGroupCard).ShowDialog();
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            if (MessageBox.Show("Are you Sure to Remove this TagGroup?", "Remove TagGroup", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                TagGroupUC tagGroupUC = Global.GetParentByType<TagGroupUC>(tagGroupCard);
                tagGroupUC.RemoveTagGroupByName(tagGroupCard.GroupName);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            new AddGroupTagForm(tagGroupCard).Show();
        }
        private void ClearBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            tagGroupCard.ClearSelection();
        }
    }
}
