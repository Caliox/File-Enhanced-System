using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileEnhanced.UserControls
{
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        public string SearchText { get => SearchTextBox.AdText;set => SearchTextBox.AdText = value; }

        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            SearchTextBox.Font = this.Font;
            SearchTextBox.ForeColor = this.ForeColor;
        }

        public event EventHandler SearchEvent;

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            SearchEvent?.Invoke(this, e);
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SearchEvent?.Invoke(this,e);
        }
    }
}
