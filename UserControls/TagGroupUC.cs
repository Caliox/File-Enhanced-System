using FileEnhanced.Common;
using FileEnhanced.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileEnhanced.UserControls
{
    public partial class TagGroupUC : UserControl
    {
        public TagGroupUC(string xmlPath)
        {
            InitializeComponent();
            this.xmlPath = xmlPath;

            TagGroupCard[] groupCards = LoadTagGroupFromXML(xmlPath);
            if (groupCards == null || groupCards.Length == 0) return;
            foreach (TagGroupCard groupCard in groupCards)
            {
                groupCard.PropertyChanged += (_sender, _e) => Write2XML();
            }
            SetTagGroupList(groupCards);

            new ToolTip().SetToolTip(this.SearchBtn, "Combine Search");
            new ToolTip().SetToolTip(this.CreatBtn, "Create a New Group");
        }

        // Fields and Properties 
        private string xmlPath;
        public string SearchStr { get; private set; }

        // Events
        public event EventHandler CombineSearched;


        // Methods
        public TagGroupCard[] LoadTagGroupFromXML(string file)
        {
            if (string.IsNullOrEmpty(file) || (!File.Exists(file))) return null;

            TagGroupCard[] tagGroupCards = null;
            XElement root = XElement.Load(file);
            tagGroupCards = root.Elements("TagGroup")
                    .Select(g => new TagGroupCard(g.Element("GroupName").Value, g.Element("Tags").Value))
                    .ToArray();
            return tagGroupCards;
        }
        public void SetTagGroupList(TagGroupCard[] tagGroups)
        {
            GroupPnl.Controls.Clear();
            GroupPnl.Controls.AddRange(tagGroups);
        }
        public void AddTagGroupByName(string groupName)
        {
            if (string.IsNullOrEmpty(groupName)) return;
            foreach (TagGroupCard tagGroup in GroupPnl.Controls)
            {
                if (tagGroup.GroupName == groupName) return;
            }
            TagGroupCard newTagGroup = new TagGroupCard(groupName, null);
            newTagGroup.PropertyChanged += (_sender, _e) => Write2XML();
            GroupPnl.Controls.Add(newTagGroup);
            Write2XML();
        }
        public void RemoveTagGroupByName(string groupName)
        {
            foreach (TagGroupCard tagGroup in GroupPnl.Controls)
            {
                if (tagGroup.GroupName == groupName)
                    GroupPnl.Controls.Remove(tagGroup);
                Write2XML();
            }
        }
        public TagGroupCard GetTagGroupByName(string groupName)
        {
            if(string.IsNullOrEmpty(groupName)) return null;
            return GroupPnl.Controls.OfType<TagGroupCard>().Where(t => t.GroupName == groupName).FirstOrDefault();
        }
        public string[] GetSelectedTags()
        {
            return GroupPnl.Controls.OfType<TagGroupCard>()
                .Where(t => !string.IsNullOrEmpty(t.SelectedValue))
                .Select(t => t.SelectedValue).ToArray();
        }
        public string[] GetAllTagGroupName()
        {
            return GroupPnl.Controls.OfType<TagGroupCard>().Select(t => t.GroupName).ToArray();
        }
        public void Write2XML()
        {
            TagGroupCard[] groupCards = GroupPnl.Controls.OfType<TagGroupCard>().ToArray();
            XElement[] tagGroups = groupCards.Select(g=>g.Export2XML()).ToArray();
            XElement root = new XElement("TagGroups");
            foreach (XElement tagGroup in tagGroups) root.Add(tagGroup);
            root.Save(xmlPath);
        }
        private void CombSearchBtn_Click(object sender, EventArgs e)
        {
            CombineSearched?.Invoke(this, EventArgs.Empty);
        }
        private void CreatBtn_Click(object sender, EventArgs e)
        {
            new CreateTagGroupForm(this).Show();
        }
        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string[] selectedArray = GetSelectedTags();
            if (selectedArray.Length > 0)
            {
                SearchStr = string.Join(";", selectedArray);
                CombineSearched?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
