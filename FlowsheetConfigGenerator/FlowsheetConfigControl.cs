using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace FlowsheetConfigGenerator
{
    public partial class FlowsheetConfigControl : UserControl
    {
        private List<Block> blockList;

        private List<Stream> streamList;

        private List<Link> linkList;

        private List<InitValue> initValueList;

        public Block SelectedBlock
        {
            get
            {
                Block item = (Block)this.blockListBox.SelectedItem;
                return item == null ? null : item;
            }
        }

        public Stream SelectedStream
        {
            get
            {
                Stream item = (Stream)this.streamListBox.SelectedItem;
                return item == null ? null : item;
            }
        }

        public Link SelectedLink
        {
            get
            {
                Link item = (Link)this.linkListBox.SelectedItem;
                return item == null ? null : item;
            }
        }

        public InitValue SelectedInitValue
        {
            get
            {
                InitValue item = (InitValue)this.initValueListBox.SelectedItem;
                return item == null ? null : item;
            }
        }

        public FlowsheetConfigControl()
        {
            InitializeComponent();
            this.blockList = new List<Block>();
            this.streamList = new List<Stream>();
            this.linkList = new List<Link>();
            this.initValueList = new List<InitValue>();
        }

        private void OnBlockAddButtonClick(object sender, EventArgs e)
        {
            if (this.blockNameTextBox.Text.Equals("") || this.unitopTextBox.Text.Equals(""))
            {
                return;
            }

            Block bb = this.blockList.SingleOrDefault(T => T.name.Equals(this.blockNameTextBox.Text));

            if (bb != null)
            {
                return;
            }

            Block block = new Block();
            block.name = this.blockNameTextBox.Text;
            block.unitop = this.unitopTextBox.Text;
            this.blockList.Add(block);
            this.blockListBox.Items.Add(block);
            ClearBlockSetting();
        }

        private void OnBlockRemoveButtonClick(object sender, EventArgs e)
        {
            if (SelectedBlock != null)
            {
                this.blockList.Remove(SelectedBlock);
                this.blockListBox.Items.Remove(SelectedBlock);
                ClearBlockSetting();
            }
        }

        private void ClearBlockSetting()
        {
            this.blockNameTextBox.Text = "";
            this.unitopTextBox.Text = "";
        }

        private void OnStreamAddBbuttonClick(object sender, EventArgs e)
        {
            if (this.streamNameTextBox.Text.Equals("") || this.descriptionTextBox.Text.Equals(""))
            {
                return;
            }

            Stream stream = new Stream();
            stream.name = this.streamNameTextBox.Text;
            stream.description = this.descriptionTextBox.Text;
            if (this.methodTextBox.Text.Equals(""))
            {
                stream.method = "null";
            }
            else
            {
                stream.method = this.methodTextBox.Text;
            }
            this.streamList.Add(stream);
            this.streamListBox.Items.Add(stream);
            ClearStreamSetting();
        }

        private void OnStreamRemoveButtonClick(object sender, EventArgs e)
        {
            if (SelectedStream != null)
            {
                this.streamList.Remove(SelectedStream);
                this.streamListBox.Items.Remove(SelectedStream);
                ClearStreamSetting();
            }
        }

        private void ClearStreamSetting()
        {
            this.streamNameTextBox.Text = "";
            this.descriptionTextBox.Text = "";
            this.methodTextBox.Text = "";
        }

        private void OnLinkAddButtonClick(object sender, EventArgs e)
        {
            if(this.linkStreamTextBox.Text.Equals(""))
            {
                return;
            }

            Link link = new Link();
            if (this.fromTextBox.Text.Equals(""))
            {
                link.from = "";
            }
            if (this.toTextBox.Text.Equals(""))
            {
                link.to = "";
            }
     
            link.stream = this.linkStreamTextBox.Text;
            link.from = this.fromTextBox.Text;
            link.to = this .toTextBox.Text;
            this.linkList.Add(link);
            this.linkListBox.Items.Add(link);
            ClearLinkSetting();
        }

        private void OnLinkRemoveButtonClick(object sender, EventArgs e)
        {
            if (SelectedLink != null)
            {
                this.linkList.Remove(SelectedLink);
                this.linkListBox.Items.Remove(SelectedLink);
                ClearLinkSetting();
            }
        }

        private void ClearLinkSetting()
        {
            this.linkStreamTextBox.Text = "";
            this.fromTextBox.Text = "";
            this.toTextBox.Text = "";
        }

        private void OnInitValueAddButtonClick(object sender, EventArgs e)
        {
            if (this.initValueNameTextBox.Text.Equals("") || this.initValueTextBox.Text.Equals(""))
            {
                return;
            }

            InitValue i = new InitValue();
            i.name = this.initValueNameTextBox.Text;

            double result;
            bool r = double.TryParse(this.initValueTextBox.Text,out result);
            if (!r)
            {
                MessageBox.Show("Value欄位資料格式錯誤!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            i.value = result;
            this.initValueList.Add(i);
            this.initValueListBox.Items.Add(i);
            ClearInitValueSetting();
        }

        private void OnInitValueRemoveButtonClick(object sender, EventArgs e)
        {
            if (SelectedInitValue != null)
            {
                this.initValueList.Remove(SelectedInitValue);
                this.initValueListBox.Items.Remove(SelectedInitValue);
                ClearInitValueSetting();
            }
        }

        private void ClearInitValueSetting()
        {
            this.initValueNameTextBox.Text = "";
            this.initValueTextBox.Text = "";
        }

        private void OnGenerateButtonClick(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "json files (*.json)|*.json";
                saveFileDialog1.FileName = "FlowsheetConfig";
                if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                    && saveFileDialog1.FileName.Length > 0)
                {
                    string path = saveFileDialog1.FileName;
                    RichTextBoxStreamType b = RichTextBoxStreamType.PlainText;
                    //richTextBox1.SaveFile(saveFileDialog1.FileName,
                    //    RichTextBoxStreamType.PlainText);

                    //  System.IO.File.WriteAllText(path, strJson);

                    RootObject root = new RootObject();
                    root.streams = this.streamList;
                    root.blocks = this.blockList;
                    root.links = this.linkList;
                    root.initValues = this.initValueList;
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


    public class Stream
    {
        public string name { get; set; }
        public string description { get; set; }
        public string method { get; set; }

        public override string ToString()
        {
            return name + " : " + description;
        }
    }

    public class Block
    {
        public string name { get; set; }
        public string unitop { get; set; }

        public override string ToString()
        {
            return name;
        }
    }

    public class Link
    {
        public string stream { get; set; }
        public string from { get; set; }
        public string to { get; set; }

        public override string ToString()
        {
            return stream + " : from " + from +" to " +to;
        }
    }

    public class InitValue
    {
        public string name { get; set; }
        public double value { get; set; }

        public override string ToString()
        {
            return name + " : " + value;
        }
    }

    public class RootObject
    {
        public List<Stream> streams { get; set; }
        public List<Block> blocks { get; set; }
        public List<Link> links { get; set; }
        public List<InitValue> initValues { get; set; }
    }

}
