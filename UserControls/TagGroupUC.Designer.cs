namespace FileEnhanced.UserControls
{
    partial class TagGroupUC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TagGroupUC));
            this.label1 = new System.Windows.Forms.Label();
            this.BackPnl = new System.Windows.Forms.Panel();
            this.GroupPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchBtn = new FileEnhanced.UserControls.RoundedButton();
            this.CreatBtn = new FileEnhanced.UserControls.RoundedButton();
            this.BackPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SAS Monospace", 16F);
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "TagGroup";
            // 
            // BackPnl
            // 
            this.BackPnl.Controls.Add(this.GroupPnl);
            this.BackPnl.Location = new System.Drawing.Point(0, 50);
            this.BackPnl.Margin = new System.Windows.Forms.Padding(4);
            this.BackPnl.Name = "BackPnl";
            this.BackPnl.Size = new System.Drawing.Size(254, 573);
            this.BackPnl.TabIndex = 3;
            // 
            // GroupPnl
            // 
            this.GroupPnl.AutoScroll = true;
            this.GroupPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.GroupPnl.Location = new System.Drawing.Point(0, 0);
            this.GroupPnl.Margin = new System.Windows.Forms.Padding(4);
            this.GroupPnl.Name = "GroupPnl";
            this.GroupPnl.Size = new System.Drawing.Size(274, 573);
            this.GroupPnl.TabIndex = 0;
            this.GroupPnl.WrapContents = false;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchBtn.BorderRadius = 40;
            this.SearchBtn.BorderSize = 0;
            this.SearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = global::FileEnhanced.Properties.Resources.CombineSearch;
            this.SearchBtn.Location = new System.Drawing.Point(163, 4);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(0);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(40, 40);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // CreatBtn
            // 
            this.CreatBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreatBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.CreatBtn.BorderRadius = 40;
            this.CreatBtn.BorderSize = 0;
            this.CreatBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreatBtn.FlatAppearance.BorderSize = 0;
            this.CreatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatBtn.ForeColor = System.Drawing.Color.White;
            this.CreatBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreatBtn.Image")));
            this.CreatBtn.Location = new System.Drawing.Point(203, 4);
            this.CreatBtn.Margin = new System.Windows.Forms.Padding(0);
            this.CreatBtn.Name = "CreatBtn";
            this.CreatBtn.Size = new System.Drawing.Size(40, 40);
            this.CreatBtn.TabIndex = 4;
            this.CreatBtn.UseVisualStyleBackColor = false;
            this.CreatBtn.Click += new System.EventHandler(this.CreatBtn_Click);
            // 
            // TagGroupUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.CreatBtn);
            this.Controls.Add(this.BackPnl);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TagGroupUC";
            this.Size = new System.Drawing.Size(274, 623);
            this.BackPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel BackPnl;
        private System.Windows.Forms.FlowLayoutPanel GroupPnl;
        private RoundedButton CreatBtn;
        private RoundedButton SearchBtn;
    }
}
