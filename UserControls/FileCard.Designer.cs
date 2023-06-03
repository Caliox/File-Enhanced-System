namespace FileEnhanced.UserControls
{
    partial class FileCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileCard));
            this.BottomLine = new System.Windows.Forms.Panel();
            this.FunZonePnl = new System.Windows.Forms.Panel();
            this.AddTagBtn = new FileEnhanced.UserControls.RoundedButton();
            this.EditDescBtn = new FileEnhanced.UserControls.RoundedButton();
            this.DetailBtn = new FileEnhanced.UserControls.RoundedButton();
            this.FirstRowPnl = new System.Windows.Forms.Panel();
            this.FileTypeBtn = new FileEnhanced.UserControls.RoundedButton();
            this.FileNameLbl = new System.Windows.Forms.Label();
            this.FileDescLbl = new System.Windows.Forms.Label();
            this.TagPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.FileInfoPnl = new System.Windows.Forms.Panel();
            this.UpdatedDateLbl = new System.Windows.Forms.Label();
            this.FileSizeLbl = new System.Windows.Forms.Label();
            this.FunZonePnl.SuspendLayout();
            this.FirstRowPnl.SuspendLayout();
            this.FileInfoPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BottomLine
            // 
            this.BottomLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(72)))), ((int)(((byte)(91)))));
            this.BottomLine.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomLine.Location = new System.Drawing.Point(0, 123);
            this.BottomLine.Name = "BottomLine";
            this.BottomLine.Size = new System.Drawing.Size(715, 1);
            this.BottomLine.TabIndex = 0;
            // 
            // FunZonePnl
            // 
            this.FunZonePnl.BackColor = System.Drawing.Color.White;
            this.FunZonePnl.Controls.Add(this.AddTagBtn);
            this.FunZonePnl.Controls.Add(this.EditDescBtn);
            this.FunZonePnl.Controls.Add(this.DetailBtn);
            this.FunZonePnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.FunZonePnl.Location = new System.Drawing.Point(0, 0);
            this.FunZonePnl.Name = "FunZonePnl";
            this.FunZonePnl.Size = new System.Drawing.Size(40, 123);
            this.FunZonePnl.TabIndex = 1;
            // 
            // AddTagBtn
            // 
            this.AddTagBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddTagBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.AddTagBtn.BorderRadius = 25;
            this.AddTagBtn.BorderSize = 0;
            this.AddTagBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddTagBtn.FlatAppearance.BorderSize = 0;
            this.AddTagBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTagBtn.ForeColor = System.Drawing.Color.White;
            this.AddTagBtn.Image = global::FileEnhanced.Properties.Resources.AddTag;
            this.AddTagBtn.Location = new System.Drawing.Point(8, 73);
            this.AddTagBtn.Name = "AddTagBtn";
            this.AddTagBtn.Size = new System.Drawing.Size(25, 25);
            this.AddTagBtn.TabIndex = 0;
            this.AddTagBtn.UseVisualStyleBackColor = false;
            this.AddTagBtn.Click += new System.EventHandler(this.AddTagBtn_Click);
            // 
            // EditDescBtn
            // 
            this.EditDescBtn.BackColor = System.Drawing.Color.Transparent;
            this.EditDescBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.EditDescBtn.BorderRadius = 25;
            this.EditDescBtn.BorderSize = 0;
            this.EditDescBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditDescBtn.FlatAppearance.BorderSize = 0;
            this.EditDescBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditDescBtn.ForeColor = System.Drawing.Color.White;
            this.EditDescBtn.Image = global::FileEnhanced.Properties.Resources.EditDesc;
            this.EditDescBtn.Location = new System.Drawing.Point(8, 34);
            this.EditDescBtn.Name = "EditDescBtn";
            this.EditDescBtn.Size = new System.Drawing.Size(25, 25);
            this.EditDescBtn.TabIndex = 0;
            this.EditDescBtn.UseVisualStyleBackColor = false;
            this.EditDescBtn.Click += new System.EventHandler(this.EditDescBtn_Click);
            // 
            // DetailBtn
            // 
            this.DetailBtn.BackColor = System.Drawing.Color.Transparent;
            this.DetailBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DetailBtn.BorderRadius = 25;
            this.DetailBtn.BorderSize = 0;
            this.DetailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DetailBtn.FlatAppearance.BorderSize = 0;
            this.DetailBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DetailBtn.ForeColor = System.Drawing.Color.White;
            this.DetailBtn.Image = global::FileEnhanced.Properties.Resources.OpenInResourceManager;
            this.DetailBtn.Location = new System.Drawing.Point(8, 0);
            this.DetailBtn.Name = "DetailBtn";
            this.DetailBtn.Size = new System.Drawing.Size(25, 25);
            this.DetailBtn.TabIndex = 0;
            this.DetailBtn.UseVisualStyleBackColor = false;
            this.DetailBtn.Click += new System.EventHandler(this.DetailBtn_Click);
            // 
            // FirstRowPnl
            // 
            this.FirstRowPnl.Controls.Add(this.FileTypeBtn);
            this.FirstRowPnl.Controls.Add(this.FileNameLbl);
            this.FirstRowPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstRowPnl.Location = new System.Drawing.Point(40, 0);
            this.FirstRowPnl.Name = "FirstRowPnl";
            this.FirstRowPnl.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.FirstRowPnl.Size = new System.Drawing.Size(675, 25);
            this.FirstRowPnl.TabIndex = 2;
            // 
            // FileTypeBtn
            // 
            this.FileTypeBtn.BackColor = System.Drawing.Color.Transparent;
            this.FileTypeBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(135)))), ((int)(((byte)(0)))));
            this.FileTypeBtn.BorderRadius = 20;
            this.FileTypeBtn.BorderSize = 1;
            this.FileTypeBtn.Enabled = false;
            this.FileTypeBtn.FlatAppearance.BorderSize = 0;
            this.FileTypeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FileTypeBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileTypeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
            this.FileTypeBtn.Location = new System.Drawing.Point(587, 1);
            this.FileTypeBtn.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.FileTypeBtn.Name = "FileTypeBtn";
            this.FileTypeBtn.Size = new System.Drawing.Size(85, 22);
            this.FileTypeBtn.TabIndex = 1;
            this.FileTypeBtn.Text = "Document";
            this.FileTypeBtn.UseVisualStyleBackColor = false;
            // 
            // FileNameLbl
            // 
            this.FileNameLbl.AutoSize = true;
            this.FileNameLbl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FileNameLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileNameLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.FileNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(105)))), ((int)(((byte)(220)))));
            this.FileNameLbl.Location = new System.Drawing.Point(0, 3);
            this.FileNameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.FileNameLbl.Name = "FileNameLbl";
            this.FileNameLbl.Size = new System.Drawing.Size(144, 19);
            this.FileNameLbl.TabIndex = 0;
            this.FileNameLbl.Text = "File Name.extension";
            this.FileNameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FileNameLbl.Click += new System.EventHandler(this.FileNameLbl_Click);
            this.FileNameLbl.MouseEnter += new System.EventHandler(this.FileNameLbl_MouseEnter);
            this.FileNameLbl.MouseLeave += new System.EventHandler(this.FileNameLbl_MouseLeave);
            // 
            // FileDescLbl
            // 
            this.FileDescLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FileDescLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.FileDescLbl.Location = new System.Drawing.Point(44, 34);
            this.FileDescLbl.Name = "FileDescLbl";
            this.FileDescLbl.Size = new System.Drawing.Size(668, 32);
            this.FileDescLbl.TabIndex = 3;
            this.FileDescLbl.Text = resources.GetString("FileDescLbl.Text");
            // 
            // TagPanel
            // 
            this.TagPanel.Location = new System.Drawing.Point(44, 70);
            this.TagPanel.Name = "TagPanel";
            this.TagPanel.Size = new System.Drawing.Size(671, 30);
            this.TagPanel.TabIndex = 4;
            // 
            // FileInfoPnl
            // 
            this.FileInfoPnl.Controls.Add(this.UpdatedDateLbl);
            this.FileInfoPnl.Controls.Add(this.FileSizeLbl);
            this.FileInfoPnl.Location = new System.Drawing.Point(44, 103);
            this.FileInfoPnl.Name = "FileInfoPnl";
            this.FileInfoPnl.Size = new System.Drawing.Size(671, 19);
            this.FileInfoPnl.TabIndex = 5;
            // 
            // UpdatedDateLbl
            // 
            this.UpdatedDateLbl.AutoSize = true;
            this.UpdatedDateLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.UpdatedDateLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.UpdatedDateLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.UpdatedDateLbl.Location = new System.Drawing.Point(49, 0);
            this.UpdatedDateLbl.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.UpdatedDateLbl.Name = "UpdatedDateLbl";
            this.UpdatedDateLbl.Size = new System.Drawing.Size(128, 13);
            this.UpdatedDateLbl.TabIndex = 1;
            this.UpdatedDateLbl.Text = "    Updated at xxxx-xx-xx";
            // 
            // FileSizeLbl
            // 
            this.FileSizeLbl.AutoSize = true;
            this.FileSizeLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.FileSizeLbl.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.FileSizeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.FileSizeLbl.Location = new System.Drawing.Point(0, 0);
            this.FileSizeLbl.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.FileSizeLbl.Name = "FileSizeLbl";
            this.FileSizeLbl.Size = new System.Drawing.Size(49, 13);
            this.FileSizeLbl.TabIndex = 0;
            this.FileSizeLbl.Text = "xx.xx MB";
            // 
            // FileCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FileInfoPnl);
            this.Controls.Add(this.TagPanel);
            this.Controls.Add(this.FileDescLbl);
            this.Controls.Add(this.FirstRowPnl);
            this.Controls.Add(this.FunZonePnl);
            this.Controls.Add(this.BottomLine);
            this.DoubleBuffered = true;
            this.Name = "FileCard";
            this.Size = new System.Drawing.Size(715, 124);
            this.Load += new System.EventHandler(this.FileCard_Load);
            this.FunZonePnl.ResumeLayout(false);
            this.FirstRowPnl.ResumeLayout(false);
            this.FirstRowPnl.PerformLayout();
            this.FileInfoPnl.ResumeLayout(false);
            this.FileInfoPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BottomLine;
        private System.Windows.Forms.Panel FunZonePnl;
        private RoundedButton DetailBtn;
        private RoundedButton EditDescBtn;
        private RoundedButton AddTagBtn;
        private System.Windows.Forms.Panel FirstRowPnl;
        private RoundedButton FileTypeBtn;
        private System.Windows.Forms.Label FileDescLbl;
        private System.Windows.Forms.FlowLayoutPanel TagPanel;
        private System.Windows.Forms.Panel FileInfoPnl;
        private System.Windows.Forms.Label UpdatedDateLbl;
        private System.Windows.Forms.Label FileSizeLbl;
        private System.Windows.Forms.Label FileNameLbl;
    }
}
