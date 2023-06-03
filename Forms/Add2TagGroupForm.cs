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

namespace FileEnhanced.Forms
{
    public partial class Add2TagGroupForm : Form
    {
        public Add2TagGroupForm(TagBtn tagBtn)
        {
            InitializeComponent();
            this.tagBtn = tagBtn;
            this.TitleLbl.Text = this.TitleLbl.Text.Replace("[]",$"[{tagBtn.Text}]");
            string[] groupName = Global.Instance.mainForm.TagGroupUC.GetAllTagGroupName();
            this.ComoBox.DataSource = groupName;
            this.ComoBox.SelectedIndex = -1;
        }

        private Point mPoint;
        private TagBtn tagBtn;

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
            this.Close();
            if(this.ComoBox.SelectedItem != null)
            {
                TagGroupCard selectedCard = Global.Instance.mainForm.TagGroupUC.GetTagGroupByName(this.ComoBox.SelectedItem.ToString());
                selectedCard.AddTagByName(tagBtn.Text);
            }
        }
    }
}
