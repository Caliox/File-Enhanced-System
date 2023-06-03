namespace FileEnhanced.UserControls
{
    partial class LibraryUC
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
            this.label1 = new System.Windows.Forms.Label();
            this.BackPnl = new System.Windows.Forms.Panel();
            this.LibPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.NewLibBtn = new FileEnhanced.UserControls.RoundedButton();
            this.BackPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SAS Monospace", 16F);
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library";
            // 
            // BackPnl
            // 
            this.BackPnl.Controls.Add(this.LibPnl);
            this.BackPnl.Location = new System.Drawing.Point(0, 50);
            this.BackPnl.Name = "BackPnl";
            this.BackPnl.Size = new System.Drawing.Size(254, 573);
            this.BackPnl.TabIndex = 2;
            // 
            // LibPnl
            // 
            this.LibPnl.AutoScroll = true;
            this.LibPnl.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LibPnl.Location = new System.Drawing.Point(0, 0);
            this.LibPnl.Name = "LibPnl";
            this.LibPnl.Size = new System.Drawing.Size(274, 573);
            this.LibPnl.TabIndex = 0;
            this.LibPnl.WrapContents = false;
            // 
            // NewLibBtn
            // 
            this.NewLibBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewLibBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.NewLibBtn.BorderRadius = 40;
            this.NewLibBtn.BorderSize = 0;
            this.NewLibBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewLibBtn.FlatAppearance.BorderSize = 0;
            this.NewLibBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewLibBtn.ForeColor = System.Drawing.Color.White;
            this.NewLibBtn.Image = global::FileEnhanced.Properties.Resources.NewLibrary;
            this.NewLibBtn.Location = new System.Drawing.Point(203, 4);
            this.NewLibBtn.Name = "NewLibBtn";
            this.NewLibBtn.Size = new System.Drawing.Size(40, 40);
            this.NewLibBtn.TabIndex = 1;
            this.NewLibBtn.UseVisualStyleBackColor = false;
            this.NewLibBtn.Click += new System.EventHandler(this.NewLibBtn_Click);
            // 
            // LibCardsUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.BackPnl);
            this.Controls.Add(this.NewLibBtn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LibCardsUC";
            this.Size = new System.Drawing.Size(274, 623);
            this.BackPnl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private RoundedButton NewLibBtn;
        private System.Windows.Forms.Panel BackPnl;
        private System.Windows.Forms.FlowLayoutPanel LibPnl;
    }
}
