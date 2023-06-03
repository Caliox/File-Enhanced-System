namespace FileEnhanced.Forms
{
    partial class ViewFileCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFileCardForm));
            this.ClientPnl = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LinkLabel = new System.Windows.Forms.LinkLabel();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.AnyTagBox = new System.Windows.Forms.TextBox();
            this.PathBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Row1Lbl = new System.Windows.Forms.Label();
            this.CancelBtn = new FileEnhanced.UserControls.RoundedButton();
            this.ConfirmBtn = new FileEnhanced.UserControls.RoundedButton();
            this.ClientPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPnl
            // 
            this.ClientPnl.BackColor = System.Drawing.Color.White;
            this.ClientPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClientPnl.Controls.Add(this.TitleLbl);
            this.ClientPnl.Controls.Add(this.IconBox);
            this.ClientPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ClientPnl.Location = new System.Drawing.Point(0, 0);
            this.ClientPnl.Name = "ClientPnl";
            this.ClientPnl.Size = new System.Drawing.Size(437, 30);
            this.ClientPnl.TabIndex = 0;
            this.ClientPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientPnl_MouseDown);
            this.ClientPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientPnl_MouseMove);
            // 
            // TitleLbl
            // 
            this.TitleLbl.Dock = System.Windows.Forms.DockStyle.Left;
            this.TitleLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.TitleLbl.Location = new System.Drawing.Point(25, 0);
            this.TitleLbl.Name = "TitleLbl";
            this.TitleLbl.Size = new System.Drawing.Size(248, 28);
            this.TitleLbl.TabIndex = 2;
            this.TitleLbl.Text = "FileCard Details";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TitleLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientPnl_MouseDown);
            this.TitleLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientPnl_MouseMove);
            // 
            // IconBox
            // 
            this.IconBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.IconBox.ErrorImage = null;
            this.IconBox.Image = ((System.Drawing.Image)(resources.GetObject("IconBox.Image")));
            this.IconBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.IconBox.Location = new System.Drawing.Point(0, 0);
            this.IconBox.Name = "IconBox";
            this.IconBox.Size = new System.Drawing.Size(25, 28);
            this.IconBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.IconBox.TabIndex = 1;
            this.IconBox.TabStop = false;
            this.IconBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientPnl_MouseDown);
            this.IconBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientPnl_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.LinkLabel);
            this.MainPanel.Controls.Add(this.ComboBox);
            this.MainPanel.Controls.Add(this.AnyTagBox);
            this.MainPanel.Controls.Add(this.PathBox);
            this.MainPanel.Controls.Add(this.NameBox);
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.Row1Lbl);
            this.MainPanel.Controls.Add(this.CancelBtn);
            this.MainPanel.Controls.Add(this.ConfirmBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(437, 220);
            this.MainPanel.TabIndex = 1;
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LinkLabel.Location = new System.Drawing.Point(11, 152);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(89, 12);
            this.LinkLabel.TabIndex = 7;
            this.LinkLabel.TabStop = true;
            this.LinkLabel.Text = "Open Directory";
            this.LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel_LinkClicked);
            // 
            // ComboBox
            // 
            this.ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(97, 110);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(327, 23);
            this.ComboBox.TabIndex = 6;
            this.ComboBox.SelectionChangeCommitted += new System.EventHandler(this.ComboBox_SelectionChangeCommitted);
            // 
            // AnyTagBox
            // 
            this.AnyTagBox.Enabled = false;
            this.AnyTagBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AnyTagBox.Location = new System.Drawing.Point(97, 77);
            this.AnyTagBox.Name = "AnyTagBox";
            this.AnyTagBox.Size = new System.Drawing.Size(327, 23);
            this.AnyTagBox.TabIndex = 5;
            // 
            // PathBox
            // 
            this.PathBox.Enabled = false;
            this.PathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PathBox.Location = new System.Drawing.Point(97, 44);
            this.PathBox.Name = "PathBox";
            this.PathBox.Size = new System.Drawing.Size(327, 23);
            this.PathBox.TabIndex = 5;
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NameBox.Location = new System.Drawing.Point(96, 11);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(328, 23);
            this.NameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.label4.Location = new System.Drawing.Point(3, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "File Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.label2.Location = new System.Drawing.Point(3, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Any Tag:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.label1.Location = new System.Drawing.Point(3, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Directory：";
            // 
            // Row1Lbl
            // 
            this.Row1Lbl.AutoSize = true;
            this.Row1Lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Row1Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.Row1Lbl.Location = new System.Drawing.Point(3, 13);
            this.Row1Lbl.Name = "Row1Lbl";
            this.Row1Lbl.Size = new System.Drawing.Size(80, 19);
            this.Row1Lbl.TabIndex = 4;
            this.Row1Lbl.Text = "File Name:";
            // 
            // CancelBtn
            // 
            this.CancelBtn.BackColor = System.Drawing.Color.White;
            this.CancelBtn.BorderColor = System.Drawing.Color.Olive;
            this.CancelBtn.BorderRadius = 27;
            this.CancelBtn.BorderSize = 0;
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.FlatAppearance.BorderSize = 0;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.CancelBtn.Location = new System.Drawing.Point(256, 180);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(90, 27);
            this.CancelBtn.TabIndex = 3;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = false;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // ConfirmBtn
            // 
            this.ConfirmBtn.BackColor = System.Drawing.Color.White;
            this.ConfirmBtn.BorderColor = System.Drawing.Color.Olive;
            this.ConfirmBtn.BorderRadius = 27;
            this.ConfirmBtn.BorderSize = 0;
            this.ConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBtn.FlatAppearance.BorderSize = 0;
            this.ConfirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConfirmBtn.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ConfirmBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.ConfirmBtn.Location = new System.Drawing.Point(88, 180);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(90, 27);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // ViewFileCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 250);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ClientPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewFileCardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralPopupForm";
            this.ClientPnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientPnl;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Label TitleLbl;
        private System.Windows.Forms.Panel MainPanel;
        private UserControls.RoundedButton ConfirmBtn;
        private System.Windows.Forms.Label Row1Lbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.TextBox AnyTagBox;
        private System.Windows.Forms.TextBox PathBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label4;
        private UserControls.RoundedButton CancelBtn;
        private System.Windows.Forms.LinkLabel LinkLabel;
    }
}