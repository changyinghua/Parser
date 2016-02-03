namespace FlowsheetConfigGenerator
{
    partial class FlowsheetConfigControl
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
            this.blockRemoveButton = new System.Windows.Forms.Button();
            this.blockAddButton = new System.Windows.Forms.Button();
            this.blockListBox = new System.Windows.Forms.ListBox();
            this.unitopTextBox = new System.Windows.Forms.TextBox();
            this.blockNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.streamListBox = new System.Windows.Forms.ListBox();
            this.streamRemoveButton = new System.Windows.Forms.Button();
            this.methodTextBox = new System.Windows.Forms.TextBox();
            this.streamAddBbutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.streamNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkListBox = new System.Windows.Forms.ListBox();
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.linkRemoveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.linkAddButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.linkStreamTextBox = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.initValueListBox = new System.Windows.Forms.ListBox();
            this.initValueRemoveButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.initValueAddButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.initValueTextBox = new System.Windows.Forms.TextBox();
            this.initValueNameTextBox = new System.Windows.Forms.TextBox();
            this.generateButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.blockRemoveButton);
            this.groupBox1.Controls.Add(this.blockAddButton);
            this.groupBox1.Controls.Add(this.blockListBox);
            this.groupBox1.Controls.Add(this.unitopTextBox);
            this.groupBox1.Controls.Add(this.blockNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "blocks";
            // 
            // blockRemoveButton
            // 
            this.blockRemoveButton.Location = new System.Drawing.Point(180, 44);
            this.blockRemoveButton.Name = "blockRemoveButton";
            this.blockRemoveButton.Size = new System.Drawing.Size(40, 23);
            this.blockRemoveButton.TabIndex = 6;
            this.blockRemoveButton.Text = "←";
            this.blockRemoveButton.UseVisualStyleBackColor = true;
            this.blockRemoveButton.Click += new System.EventHandler(this.OnBlockRemoveButtonClick);
            // 
            // blockAddButton
            // 
            this.blockAddButton.Location = new System.Drawing.Point(180, 14);
            this.blockAddButton.Name = "blockAddButton";
            this.blockAddButton.Size = new System.Drawing.Size(40, 23);
            this.blockAddButton.TabIndex = 5;
            this.blockAddButton.Text = "→";
            this.blockAddButton.UseVisualStyleBackColor = true;
            this.blockAddButton.Click += new System.EventHandler(this.OnBlockAddButtonClick);
            // 
            // blockListBox
            // 
            this.blockListBox.FormattingEnabled = true;
            this.blockListBox.ItemHeight = 12;
            this.blockListBox.Location = new System.Drawing.Point(226, 15);
            this.blockListBox.Name = "blockListBox";
            this.blockListBox.Size = new System.Drawing.Size(198, 76);
            this.blockListBox.TabIndex = 4;
            // 
            // unitopTextBox
            // 
            this.unitopTextBox.Location = new System.Drawing.Point(74, 44);
            this.unitopTextBox.Name = "unitopTextBox";
            this.unitopTextBox.Size = new System.Drawing.Size(100, 22);
            this.unitopTextBox.TabIndex = 3;
            // 
            // blockNameTextBox
            // 
            this.blockNameTextBox.Location = new System.Drawing.Point(74, 15);
            this.blockNameTextBox.Name = "blockNameTextBox";
            this.blockNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.blockNameTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "unitop :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "name :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.streamListBox);
            this.groupBox2.Controls.Add(this.streamRemoveButton);
            this.groupBox2.Controls.Add(this.methodTextBox);
            this.groupBox2.Controls.Add(this.streamAddBbutton);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.descriptionTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.streamNameTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(3, 109);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(430, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "streams";
            // 
            // streamListBox
            // 
            this.streamListBox.FormattingEnabled = true;
            this.streamListBox.ItemHeight = 12;
            this.streamListBox.Location = new System.Drawing.Point(226, 12);
            this.streamListBox.Name = "streamListBox";
            this.streamListBox.Size = new System.Drawing.Size(198, 76);
            this.streamListBox.TabIndex = 13;
            // 
            // streamRemoveButton
            // 
            this.streamRemoveButton.Location = new System.Drawing.Point(180, 55);
            this.streamRemoveButton.Name = "streamRemoveButton";
            this.streamRemoveButton.Size = new System.Drawing.Size(40, 23);
            this.streamRemoveButton.TabIndex = 8;
            this.streamRemoveButton.Text = "←";
            this.streamRemoveButton.UseVisualStyleBackColor = true;
            this.streamRemoveButton.Click += new System.EventHandler(this.OnStreamRemoveButtonClick);
            // 
            // methodTextBox
            // 
            this.methodTextBox.Location = new System.Drawing.Point(74, 71);
            this.methodTextBox.Name = "methodTextBox";
            this.methodTextBox.Size = new System.Drawing.Size(100, 22);
            this.methodTextBox.TabIndex = 12;
            // 
            // streamAddBbutton
            // 
            this.streamAddBbutton.Location = new System.Drawing.Point(180, 25);
            this.streamAddBbutton.Name = "streamAddBbutton";
            this.streamAddBbutton.Size = new System.Drawing.Size(40, 23);
            this.streamAddBbutton.TabIndex = 7;
            this.streamAddBbutton.Text = "→";
            this.streamAddBbutton.UseVisualStyleBackColor = true;
            this.streamAddBbutton.Click += new System.EventHandler(this.OnStreamAddBbuttonClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "method :";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(74, 43);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "name :";
            // 
            // streamNameTextBox
            // 
            this.streamNameTextBox.Location = new System.Drawing.Point(74, 15);
            this.streamNameTextBox.Name = "streamNameTextBox";
            this.streamNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.streamNameTextBox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "description :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkListBox);
            this.groupBox3.Controls.Add(this.toTextBox);
            this.groupBox3.Controls.Add(this.linkRemoveButton);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.linkAddButton);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.fromTextBox);
            this.groupBox3.Controls.Add(this.linkStreamTextBox);
            this.groupBox3.Location = new System.Drawing.Point(3, 215);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(430, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "links";
            // 
            // linkListBox
            // 
            this.linkListBox.FormattingEnabled = true;
            this.linkListBox.ItemHeight = 12;
            this.linkListBox.Location = new System.Drawing.Point(226, 15);
            this.linkListBox.Name = "linkListBox";
            this.linkListBox.Size = new System.Drawing.Size(198, 76);
            this.linkListBox.TabIndex = 16;
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(74, 71);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 22);
            this.toTextBox.TabIndex = 19;
            // 
            // linkRemoveButton
            // 
            this.linkRemoveButton.Location = new System.Drawing.Point(180, 55);
            this.linkRemoveButton.Name = "linkRemoveButton";
            this.linkRemoveButton.Size = new System.Drawing.Size(40, 23);
            this.linkRemoveButton.TabIndex = 15;
            this.linkRemoveButton.Text = "←";
            this.linkRemoveButton.UseVisualStyleBackColor = true;
            this.linkRemoveButton.Click += new System.EventHandler(this.OnLinkRemoveButtonClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "stream :";
            // 
            // linkAddButton
            // 
            this.linkAddButton.Location = new System.Drawing.Point(180, 25);
            this.linkAddButton.Name = "linkAddButton";
            this.linkAddButton.Size = new System.Drawing.Size(40, 23);
            this.linkAddButton.TabIndex = 14;
            this.linkAddButton.Text = "→";
            this.linkAddButton.UseVisualStyleBackColor = true;
            this.linkAddButton.Click += new System.EventHandler(this.OnLinkAddButtonClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "to :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 47);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 12);
            this.label8.TabIndex = 15;
            this.label8.Text = "from :";
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(74, 43);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 22);
            this.fromTextBox.TabIndex = 17;
            // 
            // linkStreamTextBox
            // 
            this.linkStreamTextBox.Location = new System.Drawing.Point(74, 15);
            this.linkStreamTextBox.Name = "linkStreamTextBox";
            this.linkStreamTextBox.Size = new System.Drawing.Size(100, 22);
            this.linkStreamTextBox.TabIndex = 16;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.initValueListBox);
            this.groupBox4.Controls.Add(this.initValueRemoveButton);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.initValueAddButton);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.initValueTextBox);
            this.groupBox4.Controls.Add(this.initValueNameTextBox);
            this.groupBox4.Location = new System.Drawing.Point(3, 321);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(430, 74);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "initValues";
            // 
            // initValueListBox
            // 
            this.initValueListBox.FormattingEnabled = true;
            this.initValueListBox.ItemHeight = 12;
            this.initValueListBox.Location = new System.Drawing.Point(226, 14);
            this.initValueListBox.Name = "initValueListBox";
            this.initValueListBox.Size = new System.Drawing.Size(198, 52);
            this.initValueListBox.TabIndex = 7;
            // 
            // initValueRemoveButton
            // 
            this.initValueRemoveButton.Location = new System.Drawing.Point(180, 44);
            this.initValueRemoveButton.Name = "initValueRemoveButton";
            this.initValueRemoveButton.Size = new System.Drawing.Size(40, 23);
            this.initValueRemoveButton.TabIndex = 12;
            this.initValueRemoveButton.Text = "←";
            this.initValueRemoveButton.UseVisualStyleBackColor = true;
            this.initValueRemoveButton.Click += new System.EventHandler(this.OnInitValueRemoveButtonClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 12);
            this.label10.TabIndex = 7;
            this.label10.Text = "name :";
            // 
            // initValueAddButton
            // 
            this.initValueAddButton.Location = new System.Drawing.Point(180, 14);
            this.initValueAddButton.Name = "initValueAddButton";
            this.initValueAddButton.Size = new System.Drawing.Size(40, 23);
            this.initValueAddButton.TabIndex = 11;
            this.initValueAddButton.Text = "→";
            this.initValueAddButton.UseVisualStyleBackColor = true;
            this.initValueAddButton.Click += new System.EventHandler(this.OnInitValueAddButtonClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "value :";
            // 
            // initValueTextBox
            // 
            this.initValueTextBox.Location = new System.Drawing.Point(74, 44);
            this.initValueTextBox.Name = "initValueTextBox";
            this.initValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.initValueTextBox.TabIndex = 10;
            // 
            // initValueNameTextBox
            // 
            this.initValueNameTextBox.Location = new System.Drawing.Point(74, 15);
            this.initValueNameTextBox.Name = "initValueNameTextBox";
            this.initValueNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.initValueNameTextBox.TabIndex = 9;
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(277, 401);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(75, 23);
            this.generateButton.TabIndex = 4;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.OnGenerateButtonClick);
            // 
            // CloseButton
            // 
            this.CloseButton.Location = new System.Drawing.Point(358, 401);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(75, 23);
            this.CloseButton.TabIndex = 5;
            this.CloseButton.Text = "Close";
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.OnCloseButtonClick);
            // 
            // FlowsheetConfigControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FlowsheetConfigControl";
            this.Size = new System.Drawing.Size(441, 440);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button blockRemoveButton;
        private System.Windows.Forms.Button blockAddButton;
        private System.Windows.Forms.ListBox blockListBox;
        private System.Windows.Forms.TextBox unitopTextBox;
        private System.Windows.Forms.TextBox blockNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox streamListBox;
        private System.Windows.Forms.Button streamRemoveButton;
        private System.Windows.Forms.TextBox methodTextBox;
        private System.Windows.Forms.Button streamAddBbutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox streamNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.TextBox linkStreamTextBox;
        private System.Windows.Forms.ListBox linkListBox;
        private System.Windows.Forms.Button linkRemoveButton;
        private System.Windows.Forms.Button linkAddButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox initValueListBox;
        private System.Windows.Forms.Button initValueRemoveButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button initValueAddButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox initValueTextBox;
        private System.Windows.Forms.TextBox initValueNameTextBox;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.Button CloseButton;
    }
}
