namespace FileEnhanced.UserControls
{
    partial class TagGroupCard
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagGroupCard));
            this.GroupNamePnl = new System.Windows.Forms.Panel();
            this.GroupNameLbl = new System.Windows.Forms.Label();
            this.ShowBtn = new FileEnhanced.UserControls.RoundedButton();
            this.MenuBtn = new FileEnhanced.UserControls.RoundedButton();
            this.TagPanel = new System.Windows.Forms.Panel();
            this.TagfPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupNamePnl.SuspendLayout();
            this.TagPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupNamePnl
            // 
            this.GroupNamePnl.Controls.Add(this.GroupNameLbl);
            this.GroupNamePnl.Controls.Add(this.ShowBtn);
            this.GroupNamePnl.Controls.Add(this.MenuBtn);
            this.GroupNamePnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupNamePnl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupNamePnl.Location = new System.Drawing.Point(0, 0);
            this.GroupNamePnl.Margin = new System.Windows.Forms.Padding(0);
            this.GroupNamePnl.Name = "GroupNamePnl";
            this.GroupNamePnl.Size = new System.Drawing.Size(240, 35);
            this.GroupNamePnl.TabIndex = 1;
            // 
            // GroupNameLbl
            // 
            this.GroupNameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GroupNameLbl.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.GroupNameLbl.Location = new System.Drawing.Point(35, 0);
            this.GroupNameLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.GroupNameLbl.Name = "GroupNameLbl";
            this.GroupNameLbl.Size = new System.Drawing.Size(170, 35);
            this.GroupNameLbl.TabIndex = 1;
            this.GroupNameLbl.Text = "TagGroupName";
            this.GroupNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GroupNameLbl.MouseEnter += new System.EventHandler(this.SetMouseEnterStyle);
            this.GroupNameLbl.MouseLeave += new System.EventHandler(this.SetMouseLeaveStyle);
            // 
            // ShowBtn
            // 
            this.ShowBtn.BackColor = System.Drawing.Color.Transparent;
            this.ShowBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ShowBtn.BorderRadius = 35;
            this.ShowBtn.BorderSize = 0;
            this.ShowBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.ShowBtn.FlatAppearance.BorderSize = 0;
            this.ShowBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.ShowBtn.ForeColor = System.Drawing.Color.White;
            this.ShowBtn.Image = ((System.Drawing.Image)(resources.GetObject("ShowBtn.Image")));
            this.ShowBtn.Location = new System.Drawing.Point(205, 0);
            this.ShowBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(35, 35);
            this.ShowBtn.TabIndex = 0;
            this.ShowBtn.UseVisualStyleBackColor = false;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            this.ShowBtn.MouseEnter += new System.EventHandler(this.SetMouseEnterStyle);
            this.ShowBtn.MouseLeave += new System.EventHandler(this.SetMouseLeaveStyle);
            // 
            // MenuBtn
            // 
            this.MenuBtn.BackColor = System.Drawing.Color.Transparent;
            this.MenuBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.MenuBtn.BorderRadius = 35;
            this.MenuBtn.BorderSize = 0;
            this.MenuBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuBtn.FlatAppearance.BorderSize = 0;
            this.MenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.MenuBtn.ForeColor = System.Drawing.Color.White;
            this.MenuBtn.Image = global::FileEnhanced.Properties.Resources.Menu;
            this.MenuBtn.Location = new System.Drawing.Point(0, 0);
            this.MenuBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MenuBtn.Name = "MenuBtn";
            this.MenuBtn.Size = new System.Drawing.Size(35, 35);
            this.MenuBtn.TabIndex = 0;
            this.MenuBtn.UseVisualStyleBackColor = false;
            this.MenuBtn.Click += new System.EventHandler(this.MenuBtn_Click);
            this.MenuBtn.MouseEnter += new System.EventHandler(this.SetMouseEnterStyle);
            this.MenuBtn.MouseLeave += new System.EventHandler(this.SetMouseLeaveStyle);
            // 
            // TagPanel
            // 
            this.TagPanel.BackColor = System.Drawing.Color.White;
            this.TagPanel.Controls.Add(this.TagfPnl);
            this.TagPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TagPanel.Location = new System.Drawing.Point(0, 35);
            this.TagPanel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TagPanel.Name = "TagPanel";
            this.TagPanel.Padding = new System.Windows.Forms.Padding(1);
            this.TagPanel.Size = new System.Drawing.Size(240, 85);
            this.TagPanel.TabIndex = 2;
            // 
            // TagfPnl
            // 
            this.TagfPnl.AutoSize = true;
            this.TagfPnl.BackColor = System.Drawing.Color.White;
            this.TagfPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagfPnl.Location = new System.Drawing.Point(1, 1);
            this.TagfPnl.Margin = new System.Windows.Forms.Padding(0);
            this.TagfPnl.Name = "TagfPnl";
            this.TagfPnl.Size = new System.Drawing.Size(238, 0);
            this.TagfPnl.TabIndex = 0;
            // 
            // TagGroupCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TagPanel);
            this.Controls.Add(this.GroupNamePnl);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "TagGroupCard";
            this.Size = new System.Drawing.Size(240, 120);
            this.Load += new System.EventHandler(this.TagGroupCard_Load);
            this.GroupNamePnl.ResumeLayout(false);
            this.TagPanel.ResumeLayout(false);
            this.TagPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel GroupNamePnl;
        private System.Windows.Forms.Panel TagPanel;
        private System.Windows.Forms.FlowLayoutPanel TagfPnl;
        private RoundedButton MenuBtn;
        private RoundedButton ShowBtn;
        private System.Windows.Forms.Label GroupNameLbl;
    }
}
