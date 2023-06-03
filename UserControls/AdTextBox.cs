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
    public partial class AdTextBox : UserControl
    {
        public AdTextBox()
        {
            InitializeComponent();
        }

        public string AdText { get => Edit.Text; set => Edit.Text = value; }

        //重写布局方法
        protected override void OnLayout(LayoutEventArgs e)
        {
            base.OnLayout(e);

            //获取子控件
            if (this.Controls.Count == 0) return;
            Control c = this.Controls[0];

            //父窗口参数
            Padding p = this.Padding;
            int x = 0, y = 0;
            int w = this.Width, h = this.Height;
            w -= (p.Left + p.Right);
            x += p.Left;

            //计算文本框高度，使其显示在中间
            int h2 = c.PreferredSize.Height;
            if (h2 > h) h2 = h;
            y = (h - h2) / 2;
            c.Location = new Point(x, y);
            c.Size = new Size(w, h2);

            c.ForeColor = this.ForeColor;
            c.Font = this.Font;
            c.BackColor = this.BackColor;
        }
    }
}
