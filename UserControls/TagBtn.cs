using System;
using System.Drawing;
using System.Windows.Forms;
using FileEnhanced.Forms.Menus;

namespace FileEnhanced.UserControls
{
    public class TagBtn :Button
    {
        public TagBtn(string tag)
        {
            this.Text = tag;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.BackColor = Color.FromArgb(241, 241, 242);
            this.ForeColor = Color.FromArgb(23, 134, 0);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(134)));
            this.Cursor = Cursors.Hand;
            this.AutoSize = true;
            this.Height = 25;
            this.MaximumSize = new Size(0, 25);
            this.Click += TagBtn_Click;
        }

        public event EventHandler SearchMe;

        public void OnSearchMe()
        {
            SearchMe?.Invoke(this, EventArgs.Empty);
        }
        private void TagBtn_Click(object sender, EventArgs e)
        {
            TagBtnMenu newTagBtnMenu = new TagBtnMenu(this);
            newTagBtnMenu.Location = new Point(Control.MousePosition.X, Control.MousePosition.Y + this.Height/2);
            newTagBtnMenu.Show();
        }
    }
}
