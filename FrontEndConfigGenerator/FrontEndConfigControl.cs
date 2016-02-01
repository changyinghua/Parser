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

        private void OnProcessAddButtonClick(object sender, EventArgs e)
        {
            if (this.processTextBox.Text.Equals(""))
            {
                return;
            }
            else if (this.processListBox.Items.Contains(this.processTextBox.Text))
            {
                return;
            }
            else
            {
               
                Process p = new Process();
                p.name = this.processTextBox.Text;
                this.processList.Add(p);
                this.processListBox.Items.Add(p);
            }
          
        }

        private void OnTagAddButtonClick(object sender, EventArgs e)
        {
            if (this.groupTextBox.Text.Equals("") || this.tagNameTextBox.Text.Equals("") || this.dryBulbTagTextBox.Text.Equals("")
                || this.absoluteHumidityTagTextBox.Text.Equals("") || this.dryBulbValueTextBox.Text.Equals("") || this.absoluteHumidityValueTextBox.Equals(""))
            {
                return;
            }
            else
            {
                string s = this.showTagNameCheckBox.Checked ? "show" : "hide";
               // this.tagListBox.Items.Add(this.groupTextBox.Text + " - " + this.tagNameTextBox.Text + " "+s);
                Tag t = new Tag();
                t.group = this.groupTextBox.Text;
                t.tagName = this.tagNameTextBox.Text;
                t.dryBulbTag = this.dryBulbTagTextBox.Text;
                t.absoluteHumidityTag = this.absoluteHumidityTagTextBox.Text;
                t.dryBulbValue = double.Parse(this.dryBulbValueTextBox.Text);
                t.absoluteHumidityValue = double.Parse(this.absoluteHumidityValueTextBox.Text);
                t.showTagName = this.showTagNameCheckBox.Checked;
                this.tagList.Add(t);
                this.tagListBox.Items.Add(t);
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
            }
        }
    }
}
