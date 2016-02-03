namespace FrontEndConfigGenerator
{
    partial class FrontEndConfigControl
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.processRemoveButton = new System.Windows.Forms.Button();
            this.processListBox = new System.Windows.Forms.ListBox();
            this.processAddButton = new System.Windows.Forms.Button();
            this.processTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tagRemoveButton = new System.Windows.Forms.Button();
            this.showTagNameCheckBox = new System.Windows.Forms.CheckBox();
            this.tagListBox = new System.Windows.Forms.ListBox();
            this.tagAddButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.absoluteHumidityValueTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dryBulbValueTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.absoluteHumidityTagTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dryBulbTagTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tagNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.generatorButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.okButton);
            this.groupBox1.Controls.Add(this.cancelButton);
            this.groupBox1.Controls.Add(this.processRemoveButton);
            this.groupBox1.Controls.Add(this.processListBox);
            this.groupBox1.Controls.Add(this.processAddButton);
            this.groupBox1.Controls.Add(this.processTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 164);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process";
            // 
            // okButton
            // 
            this.okButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.okButton.Location = new System.Drawing.Point(298, 135);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 5;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OnProcessOkButtonClick);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cancelButton.Enabled = false;
            this.cancelButton.Location = new System.Drawing.Point(381, 135);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.OnProcessCancelButtonClick);
            // 
            // processRemoveButton
            // 
            this.processRemoveButton.Location = new System.Drawing.Point(232, 43);
            this.processRemoveButton.Name = "processRemoveButton";
            this.processRemoveButton.Size = new System.Drawing.Size(44, 23);
            this.processRemoveButton.TabIndex = 4;
            this.processRemoveButton.Text = "←";
            this.processRemoveButton.UseVisualStyleBackColor = true;
            this.processRemoveButton.Click += new System.EventHandler(this.OnProcessRemoveButtonClick);
            // 
            // processListBox
            // 
            this.processListBox.FormattingEnabled = true;
            this.processListBox.ItemHeight = 12;
            this.processListBox.Location = new System.Drawing.Point(282, 15);
            this.processListBox.Name = "processListBox";
            this.processListBox.Size = new System.Drawing.Size(174, 112);
            this.processListBox.TabIndex = 3;
            this.processListBox.SelectedIndexChanged += new System.EventHandler(this.OnProcessListBoxSelectedIndexChanged);
            // 
            // processAddButton
            // 
            this.processAddButton.Location = new System.Drawing.Point(232, 14);
            this.processAddButton.Name = "processAddButton";
            this.processAddButton.Size = new System.Drawing.Size(44, 23);
            this.processAddButton.TabIndex = 2;
            this.processAddButton.Text = "→";
            this.processAddButton.UseVisualStyleBackColor = true;
            this.processAddButton.Click += new System.EventHandler(this.OnProcessAddButtonClick);
            // 
            // processTextBox
            // 
            this.processTextBox.Location = new System.Drawing.Point(126, 15);
            this.processTextBox.Name = "processTextBox";
            this.processTextBox.Size = new System.Drawing.Size(100, 22);
            this.processTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "name : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupComboBox);
            this.groupBox2.Controls.Add(this.tagRemoveButton);
            this.groupBox2.Controls.Add(this.showTagNameCheckBox);
            this.groupBox2.Controls.Add(this.tagListBox);
            this.groupBox2.Controls.Add(this.tagAddButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.absoluteHumidityValueTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dryBulbValueTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.absoluteHumidityTagTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dryBulbTagTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tagNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(4, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(460, 190);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tag";
            // 
            // tagRemoveButton
            // 
            this.tagRemoveButton.Enabled = false;
            this.tagRemoveButton.Location = new System.Drawing.Point(232, 81);
            this.tagRemoveButton.Name = "tagRemoveButton";
            this.tagRemoveButton.Size = new System.Drawing.Size(44, 23);
            this.tagRemoveButton.TabIndex = 5;
            this.tagRemoveButton.Text = "←";
            this.tagRemoveButton.UseVisualStyleBackColor = true;
            this.tagRemoveButton.Click += new System.EventHandler(this.OnTagRemoveButtonClick);
            // 
            // showTagNameCheckBox
            // 
            this.showTagNameCheckBox.AutoSize = true;
            this.showTagNameCheckBox.Enabled = false;
            this.showTagNameCheckBox.Location = new System.Drawing.Point(126, 163);
            this.showTagNameCheckBox.Name = "showTagNameCheckBox";
            this.showTagNameCheckBox.Size = new System.Drawing.Size(15, 14);
            this.showTagNameCheckBox.TabIndex = 15;
            this.showTagNameCheckBox.UseVisualStyleBackColor = true;
            // 
            // tagListBox
            // 
            this.tagListBox.Enabled = false;
            this.tagListBox.FormattingEnabled = true;
            this.tagListBox.ItemHeight = 12;
            this.tagListBox.Location = new System.Drawing.Point(282, 18);
            this.tagListBox.Name = "tagListBox";
            this.tagListBox.Size = new System.Drawing.Size(173, 160);
            this.tagListBox.TabIndex = 5;
            this.tagListBox.SelectedIndexChanged += new System.EventHandler(this.OnTagListBoxSelectedIndexChanged);
            // 
            // tagAddButton
            // 
            this.tagAddButton.Enabled = false;
            this.tagAddButton.Location = new System.Drawing.Point(232, 57);
            this.tagAddButton.Name = "tagAddButton";
            this.tagAddButton.Size = new System.Drawing.Size(44, 23);
            this.tagAddButton.TabIndex = 4;
            this.tagAddButton.Text = "→";
            this.tagAddButton.UseVisualStyleBackColor = true;
            this.tagAddButton.Click += new System.EventHandler(this.OnTagAddButtonClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "showTagName : ";
            // 
            // absoluteHumidityValueTextBox
            // 
            this.absoluteHumidityValueTextBox.Enabled = false;
            this.absoluteHumidityValueTextBox.Location = new System.Drawing.Point(126, 136);
            this.absoluteHumidityValueTextBox.Name = "absoluteHumidityValueTextBox";
            this.absoluteHumidityValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.absoluteHumidityValueTextBox.TabIndex = 13;
            this.absoluteHumidityValueTextBox.Text = "0.0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "absoluteHumidityValue : ";
            // 
            // dryBulbValueTextBox
            // 
            this.dryBulbValueTextBox.Enabled = false;
            this.dryBulbValueTextBox.Location = new System.Drawing.Point(126, 113);
            this.dryBulbValueTextBox.Name = "dryBulbValueTextBox";
            this.dryBulbValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.dryBulbValueTextBox.TabIndex = 11;
            this.dryBulbValueTextBox.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "dryBulbValue : ";
            // 
            // absoluteHumidityTagTextBox
            // 
            this.absoluteHumidityTagTextBox.Enabled = false;
            this.absoluteHumidityTagTextBox.Location = new System.Drawing.Point(126, 89);
            this.absoluteHumidityTagTextBox.Name = "absoluteHumidityTagTextBox";
            this.absoluteHumidityTagTextBox.Size = new System.Drawing.Size(100, 22);
            this.absoluteHumidityTagTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "absoulteHumidityTag : ";
            // 
            // dryBulbTagTextBox
            // 
            this.dryBulbTagTextBox.Enabled = false;
            this.dryBulbTagTextBox.Location = new System.Drawing.Point(126, 65);
            this.dryBulbTagTextBox.Name = "dryBulbTagTextBox";
            this.dryBulbTagTextBox.Size = new System.Drawing.Size(100, 22);
            this.dryBulbTagTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "dryBulbTag : ";
            // 
            // tagNameTextBox
            // 
            this.tagNameTextBox.Enabled = false;
            this.tagNameTextBox.Location = new System.Drawing.Point(126, 41);
            this.tagNameTextBox.Name = "tagNameTextBox";
            this.tagNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.tagNameTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "tagName : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "group : ";
            // 
            // generatorButton
            // 
            this.generatorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generatorButton.Enabled = false;
            this.generatorButton.Location = new System.Drawing.Point(301, 369);
            this.generatorButton.Name = "generatorButton";
            this.generatorButton.Size = new System.Drawing.Size(75, 23);
            this.generatorButton.TabIndex = 2;
            this.generatorButton.Text = "Generate";
            this.generatorButton.UseVisualStyleBackColor = true;
            this.generatorButton.Click += new System.EventHandler(this.OnGeneratorButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.Location = new System.Drawing.Point(384, 369);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.OnCloseButtonClick);
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(126, 18);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(100, 20);
            this.groupComboBox.TabIndex = 16;
            // 
            // FrontEndConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.generatorButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrontEndConfigControl";
            this.Size = new System.Drawing.Size(471, 404);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox processListBox;
        private System.Windows.Forms.Button processAddButton;
        private System.Windows.Forms.TextBox processTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox tagListBox;
        private System.Windows.Forms.Button tagAddButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox absoluteHumidityValueTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox dryBulbValueTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox absoluteHumidityTagTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox dryBulbTagTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tagNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generatorButton;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.CheckBox showTagNameCheckBox;
        private System.Windows.Forms.Button processRemoveButton;
        private System.Windows.Forms.Button tagRemoveButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox groupComboBox;
    }
}
