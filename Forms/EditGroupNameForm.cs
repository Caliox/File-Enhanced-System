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
    public partial class EditGroupNameForm : Form
    {
        public EditGroupNameForm(TagGroupCard tagGroupCard)
        {
            InitializeComponent();
            this.tagGroupCard = tagGroupCard;
            this.OldNameBox.Text = tagGroupCard.GroupName;
        }

        // Fields and Properties
        private TagGroupCard tagGroupCard;

        // Methods
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.NewNameBox.Text))
            {
                MessageBox.Show("New Name is Empty!", "Fail to Update TagGroup Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Global.GetParentByType<TagGroupUC>(tagGroupCard).GetAllTagGroupName().Contains(NewNameBox.Text))
            {
                MessageBox.Show($"It Seems that TagGroup [{NewNameBox.Text}] already exist.", "Fail to Update TagGroup Name",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tagGroupCard.UpdateGroupName(NewNameBox.Text);
            this.Close();
        }
    }
}
