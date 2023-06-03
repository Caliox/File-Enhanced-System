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
    public partial class AddFileTagForm : Form
    {
        public AddFileTagForm(FileCard fileCard)
        {
            InitializeComponent();
            this.fileCard = fileCard;
        }

        private Point mPoint;
        private FileCard fileCard;

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
            string str = this.TagTextBox.Text;
            if (!string.IsNullOrEmpty(str))
            {
                if(!str.Contains(";"))
                    fileCard.AddTagByName(str);
                else
                {
                    string[] tagArray = str.Split(';');
                    foreach(string tag in tagArray)
                        fileCard.AddTagByName(tag);
                }
            }
            this.Close();
        }
    }
}
