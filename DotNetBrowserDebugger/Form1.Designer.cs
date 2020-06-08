namespace ESRI.ArcGIS.Mapping.OfficeIntegration.Core
{
    partial class Form1
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
			this.textBoxPort = new System.Windows.Forms.TextBox();
			this.browserView1 = new DotNetBrowser.WinForms.BrowserView();
			this.labelPort = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// textBoxPort
			// 
			this.textBoxPort.AcceptsReturn = true;
			this.textBoxPort.Location = new System.Drawing.Point(100, 1);
			this.textBoxPort.Margin = new System.Windows.Forms.Padding(2);
			this.textBoxPort.Name = "textBoxPort";
			this.textBoxPort.Size = new System.Drawing.Size(100, 20);
			this.textBoxPort.TabIndex = 0;
			// 
			// browserView1
			// 
			this.browserView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.browserView1.Location = new System.Drawing.Point(0, 24);
			this.browserView1.Margin = new System.Windows.Forms.Padding(2);
			this.browserView1.Name = "browserView1";
			this.browserView1.Size = new System.Drawing.Size(786, 537);
			this.browserView1.TabIndex = 1;
			// 
			// labelPort
			// 
			this.labelPort.AutoSize = true;
			this.labelPort.Location = new System.Drawing.Point(5, 4);
			this.labelPort.Name = "labelPort";
			this.labelPort.Size = new System.Drawing.Size(91, 13);
			this.labelPort.TabIndex = 0;
			this.labelPort.Text = "Enter port number";
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(206, 0);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 23);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Start";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.labelPort);
			this.Controls.Add(this.browserView1);
			this.Controls.Add(this.textBoxPort);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "DotNetBrowser Debugger";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPort;
        private DotNetBrowser.WinForms.BrowserView browserView1;
		private System.Windows.Forms.Label labelPort;
		private System.Windows.Forms.Button buttonStart;
	}
}

