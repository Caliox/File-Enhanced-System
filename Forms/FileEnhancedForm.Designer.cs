namespace FileEnhanced.Forms
{
    partial class FileEnhancedForm
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileEnhancedForm));
            this.ClientPanel = new System.Windows.Forms.Panel();
            this.MinBtn = new System.Windows.Forms.Button();
            this.CloseBtn = new System.Windows.Forms.Button();
            this.FormNameLbl = new System.Windows.Forms.Label();
            this.IconBox = new System.Windows.Forms.PictureBox();
            this.MainBackPnl = new System.Windows.Forms.Panel();
            this.FileCardPnl = new System.Windows.Forms.FlowLayoutPanel();
            this.DefaultBackLbl = new System.Windows.Forms.Label();
            this.SearchPnl = new System.Windows.Forms.Panel();
            this.ActivedLibLbl = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.FilterNumLbl = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.HorizentalLine = new System.Windows.Forms.Panel();
            this.FuncPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FuncMainPnl = new System.Windows.Forms.Panel();
            this.VerticalLine = new System.Windows.Forms.Panel();
            this.SearchBar = new FileEnhanced.UserControls.SearchBar();
            this.SearchModelBtn = new FileEnhanced.UserControls.RoundedButton();
            this.TagOnlyBtn = new FileEnhanced.UserControls.RoundedButton();
            this.GiteeBtn = new FileEnhanced.UserControls.RoundedButton();
            this.GithubBtn = new FileEnhanced.UserControls.RoundedButton();
            this.HelpBtn = new FileEnhanced.UserControls.RoundedButton();
            this.SettingBtn = new FileEnhanced.UserControls.RoundedButton();
            this.TagGroupBtn = new FileEnhanced.UserControls.RoundedButton();
            this.LibraryBtn = new FileEnhanced.UserControls.RoundedButton();
            this.ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).BeginInit();
            this.MainBackPnl.SuspendLayout();
            this.FileCardPnl.SuspendLayout();
            this.SearchPnl.SuspendLayout();
            this.FuncPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(74)))), ((int)(((byte)(72)))));
            this.ClientPanel.Controls.Add(this.MinBtn);
            this.ClientPanel.Controls.Add(this.CloseBtn);
            this.ClientPanel.Controls.Add(this.FormNameLbl);
            this.ClientPanel.Controls.Add(this.IconBox);
            resources.ApplyResources(this.ClientPanel, "ClientPanel");
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientPanel_MouseDown);
            this.ClientPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientPanel_MouseMove);
            // 
            // MinBtn
            // 
            this.MinBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.MinBtn, "MinBtn");
            this.MinBtn.FlatAppearance.BorderSize = 0;
            this.MinBtn.Image = global::FileEnhanced.Properties.Resources.MinimizeButton;
            this.MinBtn.Name = "MinBtn";
            this.MinBtn.UseVisualStyleBackColor = true;
            this.MinBtn.Click += new System.EventHandler(this.MinBtn_Click);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.CloseBtn, "CloseBtn");
            this.CloseBtn.FlatAppearance.BorderSize = 0;
            this.CloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.CloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.UseVisualStyleBackColor = true;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // FormNameLbl
            // 
            resources.ApplyResources(this.FormNameLbl, "FormNameLbl");
            this.FormNameLbl.ForeColor = System.Drawing.Color.White;
            this.FormNameLbl.Name = "FormNameLbl";
            this.FormNameLbl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientPanel_MouseDown);
            this.FormNameLbl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientPanel_MouseMove);
            // 
            // IconBox
            // 
            resources.ApplyResources(this.IconBox, "IconBox");
            this.IconBox.Name = "IconBox";
            this.IconBox.TabStop = false;
            this.IconBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ClientPanel_MouseDown);
            this.IconBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ClientPanel_MouseMove);
            // 
            // MainBackPnl
            // 
            this.MainBackPnl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainBackPnl.Controls.Add(this.FileCardPnl);
            this.MainBackPnl.Controls.Add(this.SearchPnl);
            this.MainBackPnl.Controls.Add(this.FuncPnl);
            resources.ApplyResources(this.MainBackPnl, "MainBackPnl");
            this.MainBackPnl.Name = "MainBackPnl";
            // 
            // FileCardPnl
            // 
            resources.ApplyResources(this.FileCardPnl, "FileCardPnl");
            this.FileCardPnl.Controls.Add(this.DefaultBackLbl);
            this.FileCardPnl.Name = "FileCardPnl";
            this.FileCardPnl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.FileCardPnl_ControlAdded);
            // 
            // DefaultBackLbl
            // 
            resources.ApplyResources(this.DefaultBackLbl, "DefaultBackLbl");
            this.DefaultBackLbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.DefaultBackLbl.Name = "DefaultBackLbl";
            // 
            // SearchPnl
            // 
            this.SearchPnl.Controls.Add(this.SearchBar);
            this.SearchPnl.Controls.Add(this.SearchModelBtn);
            this.SearchPnl.Controls.Add(this.TagOnlyBtn);
            this.SearchPnl.Controls.Add(this.ActivedLibLbl);
            this.SearchPnl.Controls.Add(this.label12);
            this.SearchPnl.Controls.Add(this.FilterNumLbl);
            this.SearchPnl.Controls.Add(this.label11);
            this.SearchPnl.Controls.Add(this.label9);
            this.SearchPnl.Controls.Add(this.label8);
            this.SearchPnl.Controls.Add(this.HorizentalLine);
            resources.ApplyResources(this.SearchPnl, "SearchPnl");
            this.SearchPnl.Name = "SearchPnl";
            // 
            // ActivedLibLbl
            // 
            resources.ApplyResources(this.ActivedLibLbl, "ActivedLibLbl");
            this.ActivedLibLbl.ForeColor = System.Drawing.Color.Green;
            this.ActivedLibLbl.Name = "ActivedLibLbl";
            // 
            // label12
            // 
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // FilterNumLbl
            // 
            resources.ApplyResources(this.FilterNumLbl, "FilterNumLbl");
            this.FilterNumLbl.ForeColor = System.Drawing.Color.Green;
            this.FilterNumLbl.Name = "FilterNumLbl";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // HorizentalLine
            // 
            this.HorizentalLine.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.HorizentalLine, "HorizentalLine");
            this.HorizentalLine.Name = "HorizentalLine";
            // 
            // FuncPnl
            // 
            this.FuncPnl.Controls.Add(this.panel1);
            this.FuncPnl.Controls.Add(this.label2);
            this.FuncPnl.Controls.Add(this.label1);
            this.FuncPnl.Controls.Add(this.GiteeBtn);
            this.FuncPnl.Controls.Add(this.GithubBtn);
            this.FuncPnl.Controls.Add(this.HelpBtn);
            this.FuncPnl.Controls.Add(this.SettingBtn);
            this.FuncPnl.Controls.Add(this.TagGroupBtn);
            this.FuncPnl.Controls.Add(this.LibraryBtn);
            this.FuncPnl.Controls.Add(this.label5);
            this.FuncPnl.Controls.Add(this.label7);
            this.FuncPnl.Controls.Add(this.label6);
            this.FuncPnl.Controls.Add(this.label4);
            this.FuncPnl.Controls.Add(this.FuncMainPnl);
            this.FuncPnl.Controls.Add(this.VerticalLine);
            resources.ApplyResources(this.FuncPnl, "FuncPnl");
            this.FuncPnl.Name = "FuncPnl";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // FuncMainPnl
            // 
            resources.ApplyResources(this.FuncMainPnl, "FuncMainPnl");
            this.FuncMainPnl.Name = "FuncMainPnl";
            // 
            // VerticalLine
            // 
            this.VerticalLine.BackColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.VerticalLine, "VerticalLine");
            this.VerticalLine.Name = "VerticalLine";
            // 
            // SearchBar
            // 
            this.SearchBar.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.SearchBar, "SearchBar");
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.SearchText = "";
            this.SearchBar.SearchEvent += new System.EventHandler(this.SearchBar_SearchEvent);
            // 
            // SearchModelBtn
            // 
            this.SearchModelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.SearchModelBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.SearchModelBtn.BorderRadius = 8;
            this.SearchModelBtn.BorderSize = 0;
            this.SearchModelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchModelBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.SearchModelBtn, "SearchModelBtn");
            this.SearchModelBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(127)))), ((int)(((byte)(229)))));
            this.SearchModelBtn.Name = "SearchModelBtn";
            this.SearchModelBtn.UseVisualStyleBackColor = false;
            this.SearchModelBtn.Click += new System.EventHandler(this.SearchModelBtn_Click);
            // 
            // TagOnlyBtn
            // 
            this.TagOnlyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(244)))), ((int)(((byte)(255)))));
            this.TagOnlyBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.TagOnlyBtn.BorderRadius = 8;
            this.TagOnlyBtn.BorderSize = 0;
            this.TagOnlyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TagOnlyBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.TagOnlyBtn, "TagOnlyBtn");
            this.TagOnlyBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(127)))), ((int)(((byte)(229)))));
            this.TagOnlyBtn.Name = "TagOnlyBtn";
            this.TagOnlyBtn.UseVisualStyleBackColor = false;
            this.TagOnlyBtn.Click += new System.EventHandler(this.TagOnlyBtn_Click);
            // 
            // GiteeBtn
            // 
            this.GiteeBtn.BackColor = System.Drawing.Color.Transparent;
            this.GiteeBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GiteeBtn.BorderRadius = 20;
            this.GiteeBtn.BorderSize = 0;
            this.GiteeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GiteeBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.GiteeBtn, "GiteeBtn");
            this.GiteeBtn.ForeColor = System.Drawing.Color.White;
            this.GiteeBtn.Image = global::FileEnhanced.Properties.Resources.Gitee;
            this.GiteeBtn.Name = "GiteeBtn";
            this.GiteeBtn.UseVisualStyleBackColor = false;
            this.GiteeBtn.Click += new System.EventHandler(this.GiteeBtn_Click);
            // 
            // GithubBtn
            // 
            this.GithubBtn.BackColor = System.Drawing.Color.Transparent;
            this.GithubBtn.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.GithubBtn.BorderRadius = 20;
            this.GithubBtn.BorderSize = 0;
            this.GithubBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GithubBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.GithubBtn, "GithubBtn");
            this.GithubBtn.ForeColor = System.Drawing.Color.White;
            this.GithubBtn.Name = "GithubBtn";
            this.GithubBtn.UseVisualStyleBackColor = false;
            this.GithubBtn.Click += new System.EventHandler(this.GithubBtn_Click);
            // 
            // HelpBtn
            // 
            this.HelpBtn.BackColor = System.Drawing.Color.Transparent;
            this.HelpBtn.BorderColor = System.Drawing.Color.DarkCyan;
            this.HelpBtn.BorderRadius = 40;
            this.HelpBtn.BorderSize = 0;
            this.HelpBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.HelpBtn, "HelpBtn");
            this.HelpBtn.ForeColor = System.Drawing.Color.White;
            this.HelpBtn.Image = global::FileEnhanced.Properties.Resources.Help;
            this.HelpBtn.Name = "HelpBtn";
            this.HelpBtn.UseVisualStyleBackColor = false;
            this.HelpBtn.Click += new System.EventHandler(this.FuncBtn_Click);
            // 
            // SettingBtn
            // 
            this.SettingBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingBtn.BorderColor = System.Drawing.Color.DarkCyan;
            this.SettingBtn.BorderRadius = 40;
            this.SettingBtn.BorderSize = 0;
            this.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.SettingBtn, "SettingBtn");
            this.SettingBtn.ForeColor = System.Drawing.Color.White;
            this.SettingBtn.Image = global::FileEnhanced.Properties.Resources.Setting;
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.UseVisualStyleBackColor = false;
            this.SettingBtn.Click += new System.EventHandler(this.FuncBtn_Click);
            // 
            // TagGroupBtn
            // 
            this.TagGroupBtn.BackColor = System.Drawing.Color.Transparent;
            this.TagGroupBtn.BorderColor = System.Drawing.Color.DarkCyan;
            this.TagGroupBtn.BorderRadius = 40;
            this.TagGroupBtn.BorderSize = 0;
            this.TagGroupBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TagGroupBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.TagGroupBtn, "TagGroupBtn");
            this.TagGroupBtn.ForeColor = System.Drawing.Color.White;
            this.TagGroupBtn.Image = global::FileEnhanced.Properties.Resources.TagGroup;
            this.TagGroupBtn.Name = "TagGroupBtn";
            this.TagGroupBtn.UseVisualStyleBackColor = false;
            this.TagGroupBtn.Click += new System.EventHandler(this.FuncBtn_Click);
            // 
            // LibraryBtn
            // 
            this.LibraryBtn.BackColor = System.Drawing.Color.Transparent;
            this.LibraryBtn.BorderColor = System.Drawing.Color.DarkCyan;
            this.LibraryBtn.BorderRadius = 40;
            this.LibraryBtn.BorderSize = 0;
            this.LibraryBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LibraryBtn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.LibraryBtn, "LibraryBtn");
            this.LibraryBtn.ForeColor = System.Drawing.Color.White;
            this.LibraryBtn.Image = global::FileEnhanced.Properties.Resources.Library;
            this.LibraryBtn.Name = "LibraryBtn";
            this.LibraryBtn.UseVisualStyleBackColor = false;
            this.LibraryBtn.Click += new System.EventHandler(this.FuncBtn_Click);
            // 
            // FileEnhancedForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.MainBackPnl);
            this.Controls.Add(this.ClientPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileEnhancedForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FileEnhancedForm_Load);
            this.ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconBox)).EndInit();
            this.MainBackPnl.ResumeLayout(false);
            this.FileCardPnl.ResumeLayout(false);
            this.SearchPnl.ResumeLayout(false);
            this.SearchPnl.PerformLayout();
            this.FuncPnl.ResumeLayout(false);
            this.FuncPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ClientPanel;
        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Label FormNameLbl;
        private System.Windows.Forms.PictureBox IconBox;
        private System.Windows.Forms.Panel MainBackPnl;
        private System.Windows.Forms.Panel FuncPnl;
        private System.Windows.Forms.Panel VerticalLine;
        private System.Windows.Forms.Panel FuncMainPnl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel SearchPnl;
        private System.Windows.Forms.Panel HorizentalLine;
        private System.Windows.Forms.FlowLayoutPanel FileCardPnl;
        private System.Windows.Forms.Label DefaultBackLbl;
        private UserControls.RoundedButton LibraryBtn;
        private UserControls.RoundedButton HelpBtn;
        private UserControls.RoundedButton SettingBtn;
        private UserControls.RoundedButton TagGroupBtn;
        private UserControls.RoundedButton SearchModelBtn;
        private UserControls.RoundedButton TagOnlyBtn;
        private System.Windows.Forms.Label ActivedLibLbl;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label FilterNumLbl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private UserControls.SearchBar SearchBar;
        private System.Windows.Forms.Button MinBtn;
        private UserControls.RoundedButton GithubBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private UserControls.RoundedButton GiteeBtn;
        private System.Windows.Forms.Panel panel1;
    }
}

