using System;
using System.Drawing;
using System.Windows.Forms;

namespace FileEnhanced.UserControls
{
    public class GroupTagButton : RadioButton
    {
        public GroupTagButton(string tag)
        {
            this.Text = tag;
            this.Appearance = Appearance.Button;
            this.BackColor = Color.FromArgb(241, 241, 242);
            this.ForeColor = Color.FromArgb(23, 134, 0);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.CheckedBackColor = Color.FromArgb(9, 105, 218);
            this.FlatAppearance.BorderSize = 0;
            this.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            this.Cursor = Cursors.Hand;
            this.AutoSize = true;
            this.Height = 25;
            this.CheckedChanged += GroupTagButton_CheckedChanged;
            this.MouseDown += GroupTagButton_MouseDown;
        }

        // Event
        public event EventHandler CheckedStatusChanged;
        public event MouseEventHandler MouseRightClicked;

        //右键单击删除此Button
        private void GroupTagButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                MouseRightClicked?.Invoke(this, e);
            }
        }

        //选中状态改变时更改字体颜色
        private void GroupTagButton_CheckedChanged(object sender, EventArgs e)
        {
            if (Checked)
            {
                this.ForeColor = Color.White;
                //由未选中变为选中，推送选中状态变化
                CheckedStatusChanged?.Invoke(this, EventArgs.Empty);
            }
            else this.ForeColor = Color.FromArgb(23, 134, 0);
        }
    }
}
