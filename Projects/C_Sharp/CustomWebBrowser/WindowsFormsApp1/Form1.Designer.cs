namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackBTN = new System.Windows.Forms.ToolStripButton();
            this.forwardBTN = new System.Windows.Forms.ToolStripButton();
            this.searchBX = new System.Windows.Forms.ToolStripComboBox();
            this.goBTN = new System.Windows.Forms.ToolStripButton();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackBTN,
            this.forwardBTN,
            this.searchBX,
            this.goBTN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1442, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BackBTN
            // 
            this.BackBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackBTN.Image = ((System.Drawing.Image)(resources.GetObject("BackBTN.Image")));
            this.BackBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackBTN.Name = "BackBTN";
            this.BackBTN.Size = new System.Drawing.Size(50, 25);
            this.BackBTN.Text = "BACK";
            this.BackBTN.Click += new System.EventHandler(this.BackBTN_Click);
            // 
            // forwardBTN
            // 
            this.forwardBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.forwardBTN.Image = ((System.Drawing.Image)(resources.GetObject("forwardBTN.Image")));
            this.forwardBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardBTN.Name = "forwardBTN";
            this.forwardBTN.Size = new System.Drawing.Size(83, 25);
            this.forwardBTN.Text = "FORWARD";
            this.forwardBTN.Click += new System.EventHandler(this.forwardBTN_Click);
            // 
            // searchBX
            // 
            this.searchBX.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllUrl;
            this.searchBX.Name = "searchBX";
            this.searchBX.Size = new System.Drawing.Size(121, 28);
            this.searchBX.Text = "SEARCH";
            this.searchBX.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBX_KeyDown);
            // 
            // goBTN
            // 
            this.goBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goBTN.Image = ((System.Drawing.Image)(resources.GetObject("goBTN.Image")));
            this.goBTN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBTN.Name = "goBTN";
            this.goBTN.Size = new System.Drawing.Size(34, 25);
            this.goBTN.Text = "GO";
            this.goBTN.Click += new System.EventHandler(this.goBTN_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.ContextMenuStrip = this.contextMenuStrip1;
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.IsWebBrowserContextMenuEnabled = false;
            this.webBrowser1.Location = new System.Drawing.Point(0, 28);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1442, 496);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1442, 524);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Custom Web Browser";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackBTN;
        private System.Windows.Forms.ToolStripButton forwardBTN;
        private System.Windows.Forms.ToolStripComboBox searchBX;
        private System.Windows.Forms.ToolStripButton goBTN;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
    }
}

