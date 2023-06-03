namespace FileEnhanced.UserControls
{
    partial class LibCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibCard));
            this.MainBtn = new System.Windows.Forms.Button();
            this.MenuPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MenuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // MainBtn
            // 
            this.MainBtn.BackColor = System.Drawing.Color.White;
            this.MainBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MainBtn.FlatAppearance.BorderSize = 0;
            this.MainBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MainBtn.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainBtn.Image = ((System.Drawing.Image)(resources.GetObject("MainBtn.Image")));
            this.MainBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainBtn.Location = new System.Drawing.Point(0, 0);
            this.MainBtn.Name = "MainBtn";
            this.MainBtn.Size = new System.Drawing.Size(190, 30);
            this.MainBtn.TabIndex = 7;
            this.MainBtn.Text = "        Library Name";
            this.MainBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainBtn.UseVisualStyleBackColor = true;
            this.MainBtn.Click += new System.EventHandler(this.MainBtn_Click);
            this.MainBtn.MouseEnter += new System.EventHandler(this.MainBtn_MouseEnter);
            this.MainBtn.MouseLeave += new System.EventHandler(this.MainBtn_MouseLeave);
            // 
            // MenuPic
            // 
            this.MenuPic.BackColor = System.Drawing.Color.White;
            this.MenuPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.MenuPic.Image = global::FileEnhanced.Properties.Resources.Menu;
            this.MenuPic.Location = new System.Drawing.Point(190, 0);
            this.MenuPic.Name = "MenuPic";
            this.MenuPic.Size = new System.Drawing.Size(30, 30);
            this.MenuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MenuPic.TabIndex = 6;
            this.MenuPic.TabStop = false;
            this.MenuPic.Click += new System.EventHandler(this.MenuPic_Click);
            this.MenuPic.MouseEnter += new System.EventHandler(this.MenuPic_MouseEnter);
            this.MenuPic.MouseLeave += new System.EventHandler(this.MenuPic_MouseLeave);
            // 
            // LibCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainBtn);
            this.Controls.Add(this.MenuPic);
            this.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.Name = "LibCard";
            this.Size = new System.Drawing.Size(220, 30);
            this.Load += new System.EventHandler(this.LibCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MenuPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MainBtn;
        private System.Windows.Forms.PictureBox MenuPic;
    }
}
