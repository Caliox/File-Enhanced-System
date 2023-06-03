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
    public partial class CreateTagGroupForm : Form
    {
        public CreateTagGroupForm(TagGroupUC tagGroupUC)
        {
            InitializeComponent();
            this.tagGroupUC = tagGroupUC;
        }

        private Point mPoint;
        private TagGroupUC tagGroupUC;

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
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(GroupNameBox.Text))
            {
                MessageBox.Show("Group Name is Empty!", "Fail to Create a New TagGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tagGroupUC.GetAllTagGroupName().Contains(GroupNameBox.Text))
            {
                MessageBox.Show($"TagGroup [{GroupNameBox.Text}] already exist.", "Fail to Create a New TagGroup", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            tagGroupUC.AddTagGroupByName(GroupNameBox.Text);
            this.Close();
        }
    }
}
