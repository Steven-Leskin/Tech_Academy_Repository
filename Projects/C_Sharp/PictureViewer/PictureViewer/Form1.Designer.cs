namespace PictureViewer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clearBTN = new System.Windows.Forms.Button();
            this.selectBTN = new System.Windows.Forms.Button();
            this.setBTN = new System.Windows.Forms.Button();
            this.closeBTN = new System.Windows.Forms.Button();
            this.resizeBTN = new System.Windows.Forms.RadioButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.clearBTN);
            this.panel1.Controls.Add(this.selectBTN);
            this.panel1.Controls.Add(this.setBTN);
            this.panel1.Controls.Add(this.closeBTN);
            this.panel1.Controls.Add(this.resizeBTN);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 423);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 354);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // clearBTN
            // 
            this.clearBTN.BackColor = System.Drawing.Color.OldLace;
            this.clearBTN.Location = new System.Drawing.Point(768, 375);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(139, 35);
            this.clearBTN.TabIndex = 4;
            this.clearBTN.Text = "CLEAR PICTURE";
            this.clearBTN.UseVisualStyleBackColor = false;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // selectBTN
            // 
            this.selectBTN.BackColor = System.Drawing.Color.OldLace;
            this.selectBTN.Location = new System.Drawing.Point(586, 377);
            this.selectBTN.Name = "selectBTN";
            this.selectBTN.Size = new System.Drawing.Size(139, 35);
            this.selectBTN.TabIndex = 3;
            this.selectBTN.Text = "SELECT PICTURE";
            this.selectBTN.UseVisualStyleBackColor = false;
            this.selectBTN.Click += new System.EventHandler(this.selectBTN_Click);
            // 
            // setBTN
            // 
            this.setBTN.BackColor = System.Drawing.Color.OldLace;
            this.setBTN.Location = new System.Drawing.Point(410, 377);
            this.setBTN.Name = "setBTN";
            this.setBTN.Size = new System.Drawing.Size(139, 35);
            this.setBTN.TabIndex = 2;
            this.setBTN.Text = "SET BACKGROUND";
            this.setBTN.UseVisualStyleBackColor = false;
            this.setBTN.Click += new System.EventHandler(this.setBTN_Click);
            // 
            // closeBTN
            // 
            this.closeBTN.BackColor = System.Drawing.Color.OldLace;
            this.closeBTN.Location = new System.Drawing.Point(233, 377);
            this.closeBTN.Name = "closeBTN";
            this.closeBTN.Size = new System.Drawing.Size(139, 35);
            this.closeBTN.TabIndex = 1;
            this.closeBTN.Text = "CLOSE";
            this.closeBTN.UseVisualStyleBackColor = false;
            this.closeBTN.Click += new System.EventHandler(this.closeBTN_Click);
            // 
            // resizeBTN
            // 
            this.resizeBTN.AutoSize = true;
            this.resizeBTN.Location = new System.Drawing.Point(63, 382);
            this.resizeBTN.Name = "resizeBTN";
            this.resizeBTN.Size = new System.Drawing.Size(79, 21);
            this.resizeBTN.TabIndex = 0;
            this.resizeBTN.Text = "RE-SIZE";
            this.resizeBTN.UseVisualStyleBackColor = true;
            this.resizeBTN.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.jpg|*.png";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(998, 448);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Picture Viewer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button closeBTN;
        private System.Windows.Forms.RadioButton resizeBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button selectBTN;
        private System.Windows.Forms.Button setBTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

