namespace JsonVisualizerForVisualStudio
{
    partial class JsonVisualizerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JsonVisualizerForm));
            this.jsonWebBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // jsonWebBrowser
            // 
            this.jsonWebBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.jsonWebBrowser.IsWebBrowserContextMenuEnabled = false;
            this.jsonWebBrowser.Location = new System.Drawing.Point(0, 0);
            this.jsonWebBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.jsonWebBrowser.Name = "jsonWebBrowser";
            this.jsonWebBrowser.Size = new System.Drawing.Size(488, 263);
            this.jsonWebBrowser.TabIndex = 0;
            // 
            // JsonVisualizerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 263);
            this.Controls.Add(this.jsonWebBrowser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JsonVisualizerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json 可视化工具";
            this.Load += new System.EventHandler(this.JsonVisualizerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser jsonWebBrowser;
    }
}