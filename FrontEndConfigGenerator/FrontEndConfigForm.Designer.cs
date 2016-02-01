namespace FrontEndConfigGenerator
{
    partial class FrontEndConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrontEndConfigForm));
            this.frontEndConfigControl1 = new FrontEndConfigGenerator.FrontEndConfigControl();
            this.SuspendLayout();
            // 
            // frontEndConfigControl1
            // 
            this.frontEndConfigControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.frontEndConfigControl1.Location = new System.Drawing.Point(0, 0);
            this.frontEndConfigControl1.Name = "frontEndConfigControl1";
            this.frontEndConfigControl1.Size = new System.Drawing.Size(470, 340);
            this.frontEndConfigControl1.TabIndex = 0;
            // 
            // FrontEndConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 340);
            this.Controls.Add(this.frontEndConfigControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrontEndConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config Generator";
            this.ResumeLayout(false);

        }

        #endregion

        private FrontEndConfigControl frontEndConfigControl1;
    }
}

