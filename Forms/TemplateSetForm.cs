using FileEnhanced.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FileEnhanced.Common;
using FileEnhanced.Models;
using System.IO;
using MiniSoftware;
using MSWord = Microsoft.Office.Interop.Word;
using System.Text.RegularExpressions;

namespace FileEnhanced.Forms
{
    public partial class TemplateSetForm : Form
    {
        public TemplateSetForm(string tempPath)
        {
            InitializeComponent();
            this.tempPath = tempPath;
            this.TitleLbl.Text = "Please Wait, Loading......";
            this.UpdateBtn.Enabled = false;
            new ToolTip().SetToolTip(this.UpdateBtn, "Replace Variables to Values you Assigned.");
        }

        //Fields and Properties
        private Point mPoint;
        private string tempPath;

        //Methods
        private void GetTemplateVars()
        {
            MSWord.Application wordApp = new MSWord.Application();
            MSWord.Document doc = wordApp.Documents.Open(this.tempPath);
            string allText = doc.Content.Text;

            //获取所有变量
            Regex regex = new Regex(@"\{\{(.+?)\}\}");
            MatchCollection matches = regex.Matches(allText);
            string[] variables = new string[matches.Count];
            for (int i = 0; i < matches.Count; i++)
                variables[i] = matches[i].Groups[1].Value;
            PlaceHolder[] dataSource = variables.Distinct().Select(s => new PlaceHolder(s, string.Empty)).ToArray();
            doc.Close();
            wordApp.Quit();

            //更新界面
            Action updateUI = () =>
            {
                this.dataGridView.DataSource = dataSource;
                this.TitleLbl.Text = "Template Startup";
                this.UpdateBtn.Enabled = true;
            };
            Invoke(updateUI);   
        }
        private Dictionary<string,object> GetItems()
        {
            if(this.dataGridView.RowCount==0) return null;

            Dictionary<string,object> varValuePairs = new Dictionary<string,object>();
            foreach(DataGridViewRow row in this.dataGridView.Rows)
            {
                if(!string.IsNullOrEmpty(row.Cells[1].Value.ToString()))
                {
                    varValuePairs.Add(row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString());
                }
            }
            return varValuePairs;
        }
        private void ClientPnl_MouseDown(object sender, MouseEventArgs e)
        {
            mPoint = new Point(e.X, e.Y);
        }
        private void ClientPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - mPoint.X, this.Location.Y + e.Y - mPoint.Y);
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> value = GetItems();
            string targetPath = string.Empty;

            if (this.SaveFileDialog.ShowDialog() == DialogResult.OK)
            {
                targetPath = this.SaveFileDialog.FileName;
            }
            else return;

            this.UpdateBtn.Enabled = false;
            this.CloseBtn.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            try
            {
                if (value?.Count > 0)
                {
                    //MiniWord.SaveAsByTemplate(targetPath, this.tempPath, value);

                    //Issue: 发现当页眉和中文中同时出现相同变量时，只有页眉能被正确更新，正文无法被更新
                    //解决方案：运行模板引擎两次
                    string medianPath = Path.Combine(Application.StartupPath, "Temp.docx");
                    MiniWord.SaveAsByTemplate(medianPath, this.tempPath, value);
                    MiniWord.SaveAsByTemplate(targetPath, medianPath, value);
                    File.Delete(medianPath);
                }
                else
                {
                    FileInfo template = new FileInfo(this.tempPath);
                    template.CopyTo(targetPath, true);
                }

                System.Diagnostics.Process.Start(targetPath);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally
            {
                this.UpdateBtn.Enabled = true;
                this.CloseBtn.Enabled = true;
                this.Cursor = Cursors.Default;
            }

            this.Close();
        }
        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Events
        private void TemplateSetForm_Load(object sender, EventArgs e)
        {
            Task getTemplateVarsTask = new Task(GetTemplateVars);
            getTemplateVarsTask.Start();
        }
    }
}
