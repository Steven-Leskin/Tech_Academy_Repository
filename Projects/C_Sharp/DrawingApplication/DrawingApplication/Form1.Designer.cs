namespace DrawingApplication
{
    partial class PaintCanvas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintCanvas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RedBTN = new System.Windows.Forms.ToolStripButton();
            this.greenBTN = new System.Windows.Forms.ToolStripButton();
            this.blueBTN = new System.Windows.Forms.ToolStripButton();
            this.purpleBTN = new System.Windows.Forms.ToolStripButton();
            this.LimeBTN = new System.Windows.Forms.ToolStripButton();
            this.WhiteBtn = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aTTACHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Controls.Add(this.menuStrip2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1366, 535);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1366, 456);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseClick);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RedBTN,
            this.greenBTN,
            this.blueBTN,
            this.purpleBTN,
            this.LimeBTN,
            this.WhiteBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 52);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1366, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // RedBTN
            // 
            this.RedBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RedBTN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RedBTN.ForeColor = System.Drawing.Color.Red;
            this.RedBTN.ImageTransparentColor = System.Drawing.Color.White;
            this.RedBTN.Name = "RedBTN";
            this.RedBTN.Size = new System.Drawing.Size(39, 24);
            this.RedBTN.Text = "Red";
            this.RedBTN.Click += new System.EventHandler(this.RedBTN_Click);
            // 
            // greenBTN
            // 
            this.greenBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.greenBTN.ForeColor = System.Drawing.Color.Green;
            this.greenBTN.Image = ((System.Drawing.Image)(resources.GetObject("greenBTN.Image")));
            this.greenBTN.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.greenBTN.Name = "greenBTN";
            this.greenBTN.Size = new System.Drawing.Size(52, 24);
            this.greenBTN.Text = "Green";
            this.greenBTN.Click += new System.EventHandler(this.greenBTN_Click);
            // 
            // blueBTN
            // 
            this.blueBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.blueBTN.ForeColor = System.Drawing.Color.Blue;
            this.blueBTN.Image = ((System.Drawing.Image)(resources.GetObject("blueBTN.Image")));
            this.blueBTN.ImageTransparentColor = System.Drawing.Color.White;
            this.blueBTN.Name = "blueBTN";
            this.blueBTN.Size = new System.Drawing.Size(42, 24);
            this.blueBTN.Text = "Blue";
            this.blueBTN.Click += new System.EventHandler(this.blueBTN_Click);
            // 
            // purpleBTN
            // 
            this.purpleBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.purpleBTN.ForeColor = System.Drawing.Color.BlueViolet;
            this.purpleBTN.Image = ((System.Drawing.Image)(resources.GetObject("purpleBTN.Image")));
            this.purpleBTN.ImageTransparentColor = System.Drawing.Color.Green;
            this.purpleBTN.Name = "purpleBTN";
            this.purpleBTN.Size = new System.Drawing.Size(55, 24);
            this.purpleBTN.Text = "Purple";
            this.purpleBTN.Click += new System.EventHandler(this.purpleBTN_Click);
            // 
            // LimeBTN
            // 
            this.LimeBTN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.LimeBTN.ForeColor = System.Drawing.Color.LimeGreen;
            this.LimeBTN.Image = ((System.Drawing.Image)(resources.GetObject("LimeBTN.Image")));
            this.LimeBTN.ImageTransparentColor = System.Drawing.Color.White;
            this.LimeBTN.Name = "LimeBTN";
            this.LimeBTN.Size = new System.Drawing.Size(45, 24);
            this.LimeBTN.Text = "Lime";
            this.LimeBTN.Click += new System.EventHandler(this.LimeBTN_Click);
            // 
            // WhiteBtn
            // 
            this.WhiteBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.WhiteBtn.ForeColor = System.Drawing.Color.White;
            this.WhiteBtn.Image = ((System.Drawing.Image)(resources.GetObject("WhiteBtn.Image")));
            this.WhiteBtn.ImageTransparentColor = System.Drawing.Color.White;
            this.WhiteBtn.Name = "WhiteBtn";
            this.WhiteBtn.Size = new System.Drawing.Size(52, 24);
            this.WhiteBtn.Text = "White";
            this.WhiteBtn.Click += new System.EventHandler(this.WhiteBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 28);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1366, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.aTTACHToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1366, 28);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(47, 24);
            this.fILEToolStripMenuItem.Text = "FILE";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.saveToolStripMenuItem.Text = "Save ";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // aTTACHToolStripMenuItem
            // 
            this.aTTACHToolStripMenuItem.Name = "aTTACHToolStripMenuItem";
            this.aTTACHToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.aTTACHToolStripMenuItem.Text = "ATTACH";
            // 
            // PaintCanvas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1391, 560);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PaintCanvas";
            this.Text = "Paint";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton RedBTN;
        private System.Windows.Forms.ToolStripButton greenBTN;
        private System.Windows.Forms.ToolStripButton blueBTN;
        private System.Windows.Forms.ToolStripButton purpleBTN;
        private System.Windows.Forms.ToolStripButton LimeBTN;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aTTACHToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton WhiteBtn;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
    }
}

