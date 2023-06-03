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
    public partial class EditFileDescForm : Form
    {
        public EditFileDescForm(FileCard fileCard)
        {
            InitializeComponent();
            this.fileCard = fileCard;
            this.DescTextBox.Text = fileCard.FileDesc;
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
            fileCard.SetDesc(this.DescTextBox.Text);
            fileCard.OnUpdated();
            this.Close();
        }
    }
}
