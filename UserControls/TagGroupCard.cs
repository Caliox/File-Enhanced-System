using FileEnhanced.Forms.Menus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileEnhanced.UserControls
{
    public partial class TagGroupCard : UserControl
    {
        public TagGroupCard(string groupName, string tags)
        {
            InitializeComponent();
            this.GroupName = groupName;
            if(!string.IsNullOrEmpty(tags))
                this.Tags = tags;
        }

        // Fields and Properties
        private bool isShowing = false;
        public bool IsShowing
        {
            get => isShowing;
            set
            {
                isShowing = value;
                UpdateShowStatus();
            }
        }

        public string SelectedValue { get; set; }

        private string groupName;
        public string GroupName
        {
            get => groupName; 
            set
            {
                groupName = value;
                this.GroupNameLbl.Text = groupName;
            }
        }

        private string tags;
        public string Tags
        {
            get => tags;
            set
            {
                tags = value;
                TagfPnl.Controls.Clear();
                if (!string.IsNullOrEmpty(value))
                {
                    GroupTagButton[] btnArray = value.Split(';').Distinct().Select( t => new GroupTagButton(t)).ToArray();
                    foreach (GroupTagButton btn in btnArray)
                    {
                        //TagBtn选中状态切换事件处理方法
                        btn.CheckedStatusChanged += (sender, e) => GetSelectValue();
                        //TagBtn右键单机事件处理方法
                        btn.MouseRightClicked += (sender, e) => RemoveTagByName((sender as GroupTagButton).Text);
                    }
                    TagfPnl.Controls.AddRange(btnArray);
                }
            }
        }

        // Events

        public event EventHandler PropertyChanged;

        // Methods

        public void OnPropertyChanged()
        {
            PropertyChanged?.Invoke(this, EventArgs.Empty);
        }
        public void UpdateShowStatus()
        {
            if (isShowing)
            {
                this.Height = this.MaximumSize.Height;
                this.ShowBtn.Image = Properties.Resources.Less;
            }
            else
            {
                this.Height = this.MinimumSize.Height;
                this.ShowBtn.Image = Properties.Resources.More;
            }  
        }
        private void ModifyMinMaxHeight()
        {
            this.MaximumSize = new Size(this.GroupNamePnl.Width + this.GroupNamePnl.Margin.Left + this.GroupNamePnl.Margin.Right
                , this.GroupNamePnl.Height + this.TagPanel.Padding.Top + this.TagPanel.Padding.Bottom + this.TagfPnl.Height);
            this.MinimumSize = new Size(this.GroupNamePnl.Width + this.GroupNamePnl.Margin.Left + this.GroupNamePnl.Margin.Right
                , this.GroupNamePnl.Height);
            UpdateShowStatus();
        }
        private void GetSelectValue()
        {
            foreach (GroupTagButton child in TagfPnl.Controls)
            {
                if (child.Checked)
                {
                    SelectedValue = child.Text;
                    return;
                }
            }
            SelectedValue = null;
        }
        public void RemoveTagByName(string tag)
        {
            if(MessageBox.Show("Are you Sure to Remove this Tag?","Remove a Tag", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Tags = string.Join(";", this.Tags.Split(';').Where(t => t != tag).ToArray());
                OnPropertyChanged();
                ModifyMinMaxHeight();
            }
            
        }
        public void AddTagByName(string tag)
        {
            //检查该新增标签是否已存在
            foreach(GroupTagButton btn in TagfPnl.Controls)
            {
                if (btn.Text == tag)
                    return;
            }
            this.Tags += this.Tags == null ? tag : ";" + tag;
            OnPropertyChanged();
            ModifyMinMaxHeight();
        }
        public void ClearSelection()
        {
            foreach(GroupTagButton btn in TagfPnl.Controls)
            {
                btn.Checked = false;
            }
            this.SelectedValue = null;
        }
        public XElement Export2XML()
        {
            return new XElement("TagGroup"
                , new XElement("GroupName", GroupName)
                , new XElement("Tags", Tags));
        }
        public void UpdateGroupName(string newName)
        {
            this.GroupName = newName;
            OnPropertyChanged();
        }

        private void TagGroupCard_Load(object sender, EventArgs e)
        {
            ModifyMinMaxHeight();
            UpdateShowStatus();
        }
        private void ShowBtn_Click(object sender, EventArgs e)
        {
            IsShowing = !isShowing;
        }
        #region 鼠标进入离开样式
        private void SetMouseEnterStyle(object sender, EventArgs e)
        {
            this.GroupNamePnl.BackColor = Color.FromArgb(229, 229, 229);
            this.GroupNameLbl.BackColor = Color.FromArgb(229, 229, 229);
            this.ShowBtn.BackColor = Color.FromArgb(229, 229, 229);
            this.MenuBtn.BackColor = Color.FromArgb(229, 229, 229);
        }
        private void SetMouseLeaveStyle(object sender, EventArgs e)
        {
            this.GroupNamePnl.BackColor = Color.White;
            this.GroupNameLbl.BackColor = Color.White;
            this.ShowBtn.BackColor = Color.White;
            this.MenuBtn.BackColor = Color.White;
        }
        #endregion
        private void MenuBtn_Click(object sender, EventArgs e)
        {
            TagGroupCardMenu newMenu = new TagGroupCardMenu(this);
            newMenu.Location = new Point(Control.MousePosition.X, Control.MousePosition.Y + this.GroupNamePnl.Height / 2);
            newMenu.Show();
        }
    }
}
