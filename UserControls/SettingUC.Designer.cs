namespace FileEnhanced.UserControls
{
    partial class SettingUC
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
            this.LibPathTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GroupXmlPathBox = new System.Windows.Forms.TextBox();
            this.GroupExplororBtn = new FileEnhanced.UserControls.RoundedButton();
            this.LibExplororBtn = new FileEnhanced.UserControls.RoundedButton();
            this.UpdateBtn = new FileEnhanced.UserControls.RoundedButton();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(4, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Default Library File Path";
            // 
            // LibPathTextBox
            // 
            this.LibPathTextBox.Enabled = false;
            this.LibPathTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LibPathTextBox.Location = new System.Drawing.Point(7, 79);
            this.LibPathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LibPathTextBox.Multiline = true;
            this.LibPathTextBox.Name = "LibPathTextBox";
            this.LibPathTextBox.Size = new System.Drawing.Size(239, 64);
            this.LibPathTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SAS Monospace", 16F);
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(5, 156);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Default TagGroup File Path";
            // 
            // GroupXmlPathBox
            // 
            this.GroupXmlPathBox.Enabled = false;
            this.GroupXmlPathBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GroupXmlPathBox.Location = new System.Drawing.Point(8, 182);
            this.GroupXmlPathBox.Margin = new System.Windows.Forms.Padding(4);
            this.GroupXmlPathBox.Multiline = true;
            this.GroupXmlPathBox.Name = "GroupXmlPathBox";
            this.GroupXmlPathBox.Size = new System.Drawing.Size(238, 64);
            this.GroupXmlPathBox.TabIndex = 1;
            // 
            // GroupExplororBtn
            // 
            this.GroupExplororBtn.BackColor = System.Drawing.Color.Transparent;
            this.GroupExplororBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GroupExplororBtn.BorderRadius = 25;
            this.GroupExplororBtn.BorderSize = 0;
            this.GroupExplororBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GroupExplororBtn.FlatAppearance.BorderSize = 0;
            this.GroupExplororBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupExplororBtn.ForeColor = System.Drawing.Color.White;
            this.GroupExplororBtn.Image = global::FileEnhanced.Properties.Resources.ExploreFolder;
            this.GroupExplororBtn.Location = new System.Drawing.Point(178, 154);
            this.GroupExplororBtn.Margin = new System.Windows.Forms.Padding(4);
            this.GroupExplororBtn.Name = "GroupExplororBtn";
            this.GroupExplororBtn.Size = new System.Drawing.Size(25, 25);
            this.GroupExplororBtn.TabIndex = 7;
            this.GroupExplororBtn.UseVisualStyleBackColor = false;
            this.GroupExplororBtn.Click += new System.EventHandler(this.ExplororBtn_Click);
            // 
            // LibExplororBtn
            // 
            this.LibExplororBtn.BackColor = System.Drawing.Color.Transparent;
            this.LibExplororBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.LibExplororBtn.BorderRadius = 25;
            this.LibExplororBtn.BorderSize = 0;
            this.LibExplororBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibExplororBtn.FlatAppearance.BorderSize = 0;
            this.LibExplororBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LibExplororBtn.ForeColor = System.Drawing.Color.White;
            this.LibExplororBtn.Image = global::FileEnhanced.Properties.Resources.ExploreFolder;
            this.LibExplororBtn.Location = new System.Drawing.Point(159, 51);
            this.LibExplororBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LibExplororBtn.Name = "LibExplororBtn";
            this.LibExplororBtn.Size = new System.Drawing.Size(25, 25);
            this.LibExplororBtn.TabIndex = 7;
            this.LibExplororBtn.UseVisualStyleBackColor = false;
            this.LibExplororBtn.Click += new System.EventHandler(this.ExplororBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdateBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.UpdateBtn.BorderRadius = 32;
            this.UpdateBtn.BorderSize = 0;
            this.UpdateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateBtn.FlatAppearance.BorderSize = 0;
            this.UpdateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpdateBtn.ForeColor = System.Drawing.Color.White;
            this.UpdateBtn.Location = new System.Drawing.Point(8, 286);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(238, 32);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "Update Settings";
            this.UpdateBtn.UseVisualStyleBackColor = false;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Filter = "xml文件|*.xml";
            // 
            // SettingUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GroupExplororBtn);
            this.Controls.Add(this.LibExplororBtn);
            this.Controls.Add(this.GroupXmlPathBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LibPathTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SettingUC";
            this.Size = new System.Drawing.Size(254, 623);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LibPathTextBox;
        private RoundedButton LibExplororBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GroupXmlPathBox;
        private RoundedButton GroupExplororBtn;
        private RoundedButton UpdateBtn;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    }
}
