using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JsonGenerator;
using System.Xml;
using Newtonsoft.Json;

namespace FrontEndConfigGenerator
{
    public partial class FrontEndConfigControl : UserControl
    {
        private List<Process> processList;

        private List<Tag> tagList;

        public Process SelectedGroup
        {
            get
            {
                Process item = (Process)this.groupComboBox.SelectedItem;
                return item == null ? null : item;
            }
        }

        public Process SelectedProcess
        {
            get
            {
                Process item = (Process)this.processListBox.SelectedItem;
                return item == null ? null : item;
            }
        }

        public Tag SelectedTag
        {
            get
            {
                Tag item = (Tag)this.tagListBox.SelectedItem;
                return item == null ? null : item;
            }
        }

        public FrontEndConfigControl()
        {
            InitializeComponent();
            this.processList = new List<Process>();
            this.tagList = new List<Tag>();
        }

        private void ProcessGroupItemsEnableSetting(bool enabled)
        {
            this.processTextBox.Enabled = enabled;
            this.processAddButton.Enabled = enabled;
            this.processRemoveButton.Enabled = enabled;
            this.processListBox.Enabled = enabled;
        }

        private void TagGroupItemsEnableSetting(bool enabled)
        {
            this.groupComboBox.Enabled = enabled;
            this.tagNameTextBox.Enabled = enabled;
            this.dryBulbTagTextBox.Enabled = enabled;
            this.absoluteHumidityTagTextBox.Enabled = enabled;
            this.tagListBox.Enabled = enabled;
            this.tagAddButton.Enabled = enabled;
            this.tagRemoveButton.Enabled = enabled;
        }

        private void OnProcessAddButtonClick(object sender, EventArgs e)
        {           
            if (this.processTextBox.Text.Equals(""))
            {
                return;
            }

            Process pp = this.processList.SingleOrDefault(T => T.name.Equals(this.processTextBox.Text));

            if (pp != null)
            {
                MessageBox.Show("Process Name duplicate", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.processTextBox.Text = "";   
                return;
            }

            Process p = new Process();
            p.name = this.processTextBox.Text;
            this.processList.Add(p);
            this.processListBox.Items.Add(p);
            this.processTextBox.Text = "";   
        }

        private void OnProcessRemoveButtonClick(object sender, EventArgs e)
        {
            if (SelectedProcess == null)
            {
                return;
            }
            else
            {
                this.processList.Remove(SelectedProcess);
                this.processListBox.Items.Remove(SelectedProcess);
                this.processTextBox.Text = "";
            }
        }

        private void OnTagAddButtonClick(object sender, EventArgs e)
        {
            if (this.tagNameTextBox.Text.Equals("") || this.dryBulbTagTextBox.Text.Equals("")
                || this.absoluteHumidityTagTextBox.Text.Equals("") || this.dryBulbValueTextBox.Text.Equals("") || this.absoluteHumidityValueTextBox.Equals(""))
            {
                return;
            }
            else
            {
                string s = this.showTagNameCheckBox.Checked ? "show" : "hide";
               // this.tagListBox.Items.Add(this.groupTextBox.Text + " - " + this.tagNameTextBox.Text + " "+s);
                Tag t = new Tag();
                t.group = SelectedGroup.name;
                t.tagName = this.tagNameTextBox.Text;
                t.dryBulbTag = this.dryBulbTagTextBox.Text;
                t.absoluteHumidityTag = this.absoluteHumidityTagTextBox.Text;
                t.dryBulbValue = double.Parse(this.dryBulbValueTextBox.Text);
                t.absoluteHumidityValue = double.Parse(this.absoluteHumidityValueTextBox.Text);
                t.showTagName = this.showTagNameCheckBox.Checked;
                this.tagList.Add(t);
                this.tagListBox.Items.Add(t);
                this.tagNameTextBox.Text = "";
                this.dryBulbTagTextBox.Text = "";
                this.absoluteHumidityTagTextBox.Text = "";
            }
        }  

        private void OnTagRemoveButtonClick(object sender, EventArgs e)
        {
            if (SelectedTag == null)
            {
                return;
            }
            else
            {
                this.tagList.Remove(SelectedTag);
                this.tagListBox.Items.Remove(SelectedTag);
               
                this.tagNameTextBox.Text = "";
                this.dryBulbTagTextBox.Text = "";
                this.absoluteHumidityTagTextBox.Text = "";
            }
        }

        private void OnProcessOkButtonClick(object sender, EventArgs e)
        {
            if (this.processListBox.Items.Count == 0)
            {
                MessageBox.Show("至少加入一個Process", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ProcessGroupItemsEnableSetting(false);
            TagGroupItemsEnableSetting(true);
            this.okButton.Enabled = false;
            this.cancelButton.Enabled = true;
            this.generatorButton.Enabled = true;
            this.groupComboBox.Items.Clear();
            
            foreach(Process p in this.processListBox.Items)
            {
                this.groupComboBox.Items.Add(p);
            }

            this.groupComboBox.SelectedIndex = 0;
        }

        private void OnProcessCancelButtonClick(object sender, EventArgs e)
        {
            ProcessGroupItemsEnableSetting(true);
            TagGroupItemsEnableSetting(false);
            this.okButton.Enabled = true;
            this.cancelButton.Enabled = false;
            this.generatorButton.Enabled = false;
        }

        private void OnProcessListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            Process selectedItem = SelectedProcess;

            if (selectedItem != null)
            {
                this.processTextBox.Text = selectedItem.name;
            }
        }

        private void OnTagListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedTag != null)
            {
                Tag selectItem = SelectedTag;
                this.groupComboBox.Text = selectItem.group;
                this.tagNameTextBox.Text = selectItem.tagName;
                this.dryBulbTagTextBox.Text = selectItem.dryBulbTag;
                this.absoluteHumidityTagTextBox.Text = selectItem.absoluteHumidityTag;
            }
        }

        private void OnGeneratorButtonClick(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "json files (*.json)|*.json";
                saveFileDialog1.FileName = "FrontEndConfig";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                    && saveFileDialog1.FileName.Length > 0)
                {
                    string path = saveFileDialog1.FileName;
                    RichTextBoxStreamType b = RichTextBoxStreamType.PlainText;
                    //richTextBox1.SaveFile(saveFileDialog1.FileName,
                    //    RichTextBoxStreamType.PlainText);

                    //  System.IO.File.WriteAllText(path, strJson);

                    RootObject root = new RootObject();
                    root.tags = this.tagList;
                    root.process = this.processList;
                    string strJson = JsonConvert.SerializeObject(root, Newtonsoft.Json.Formatting.Indented);
                    System.IO.File.WriteAllText(path, strJson);
                    MessageBox.Show("Success", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnCloseButtonClick(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

    }
}
