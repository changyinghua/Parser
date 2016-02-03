namespace FlowsheetConfigGenerator
{
    partial class FlowsheetConfigForm
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

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlowsheetConfigForm));
            this.flowsheetConfigControl1 = new FlowsheetConfigGenerator.FlowsheetConfigControl();
            this.SuspendLayout();
            // 
            // flowsheetConfigControl1
            // 
            this.flowsheetConfigControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowsheetConfigControl1.Location = new System.Drawing.Point(0, 0);
            this.flowsheetConfigControl1.Name = "flowsheetConfigControl1";
            this.flowsheetConfigControl1.Size = new System.Drawing.Size(445, 437);
            this.flowsheetConfigControl1.TabIndex = 0;
            // 
            // FlowsheetConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 437);
            this.Controls.Add(this.flowsheetConfigControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FlowsheetConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FlowsheetConfig Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private FlowsheetConfigControl flowsheetConfigControl1;
    }
}

