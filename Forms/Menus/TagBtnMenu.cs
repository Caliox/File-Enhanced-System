using FileEnhanced.Common;
using FileEnhanced.UserControls;
using System.Windows.Forms;

namespace FileEnhanced.Forms.Menus
{
    public partial class TagBtnMenu : Form
    {
        public TagBtnMenu(TagBtn tagBtn)
        {
            InitializeComponent();
            this.tagBtn = tagBtn;
        }
        private TagBtn tagBtn;

        private void TagBtnMenu_Deactivate(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            this.Close();
            tagBtn.OnSearchMe();
        }
        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            this.Close();
            new Add2TagGroupForm(tagBtn).Show();
        }
        private void BtnRemove_Click(object sender, System.EventArgs e)
        {
            this.Close();
            if(MessageBox.Show("Are you sure to remove this tag?","Remove tag",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                Global.GetParentByType<FileCard>(tagBtn).RemoveTagByName(tagBtn.Text);
        }
    }
}
