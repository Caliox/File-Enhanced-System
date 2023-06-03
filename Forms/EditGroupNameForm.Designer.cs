﻿namespace FileEnhanced.Forms
{
    partial class EditGroupNameForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGroupNameForm));
            this.ClientPnl = new System.Windows.Forms.Panel();
            this.TitleLbl = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.NewNameBox = new System.Windows.Forms.TextBox();
            this.Row2Lbl = new System.Windows.Forms.Label();
            this.OldNameBox = new System.Windows.Forms.TextBox();
            this.Row1Lbl = new System.Windows.Forms.Label();
            this.CancelBtn = new FileEnhanced.UserControls.RoundedButton();
            this.ConfirmBtn = new FileEnhanced.UserControls.RoundedButton();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
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
            this.ClientPnl.Size = new System.Drawing.Size(435, 30);
            this.ClientPnl.TabIndex = 0;
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
            this.TitleLbl.Text = "Edit Tag Group Name";
            this.TitleLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // 
            // MainPanel
            // 
            this.MainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainPanel.Controls.Add(this.NewNameBox);
            this.MainPanel.Controls.Add(this.Row2Lbl);
            this.MainPanel.Controls.Add(this.OldNameBox);
            this.MainPanel.Controls.Add(this.Row1Lbl);
            this.MainPanel.Controls.Add(this.CancelBtn);
            this.MainPanel.Controls.Add(this.ConfirmBtn);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 30);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(435, 112);
            this.MainPanel.TabIndex = 1;
            // 
            // NewNameBox
            // 
            this.NewNameBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NewNameBox.Location = new System.Drawing.Point(114, 40);
            this.NewNameBox.Name = "NewNameBox";
            this.NewNameBox.Size = new System.Drawing.Size(306, 25);
            this.NewNameBox.TabIndex = 5;
            // 
            // Row2Lbl
            // 
            this.Row2Lbl.AutoSize = true;
            this.Row2Lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Row2Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.Row2Lbl.Location = new System.Drawing.Point(3, 43);
            this.Row2Lbl.Name = "Row2Lbl";
            this.Row2Lbl.Size = new System.Drawing.Size(83, 19);
            this.Row2Lbl.TabIndex = 4;
            this.Row2Lbl.Text = "New Name";
            // 
            // OldNameBox
            // 
            this.OldNameBox.Enabled = false;
            this.OldNameBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OldNameBox.Location = new System.Drawing.Point(114, 9);
            this.OldNameBox.Name = "OldNameBox";
            this.OldNameBox.Size = new System.Drawing.Size(306, 25);
            this.OldNameBox.TabIndex = 5;
            // 
            // Row1Lbl
            // 
            this.Row1Lbl.AutoSize = true;
            this.Row1Lbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Row1Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(96)))), ((int)(((byte)(106)))));
            this.Row1Lbl.Location = new System.Drawing.Point(3, 12);
            this.Row1Lbl.Name = "Row1Lbl";
            this.Row1Lbl.Size = new System.Drawing.Size(107, 19);
            this.Row1Lbl.TabIndex = 4;
            this.Row1Lbl.Text = "Original Name";
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
            this.CancelBtn.Location = new System.Drawing.Point(253, 77);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(98, 27);
            this.CancelBtn.TabIndex = 2;
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
            this.ConfirmBtn.Location = new System.Drawing.Point(76, 77);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.ConfirmBtn.Size = new System.Drawing.Size(98, 27);
            this.ConfirmBtn.TabIndex = 3;
            this.ConfirmBtn.Text = "Confirm";
            this.ConfirmBtn.UseVisualStyleBackColor = false;
            this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
            // 
            // EditGroupNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 142);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ClientPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditGroupNameForm";
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
        private UserControls.RoundedButton CancelBtn;
        private UserControls.RoundedButton ConfirmBtn;
        private System.Windows.Forms.Label Row1Lbl;
        private System.Windows.Forms.TextBox OldNameBox;
        private System.Windows.Forms.TextBox NewNameBox;
        private System.Windows.Forms.Label Row2Lbl;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}