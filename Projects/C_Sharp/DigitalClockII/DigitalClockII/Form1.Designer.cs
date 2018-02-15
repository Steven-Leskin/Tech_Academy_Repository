namespace DigitalClockII
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
            this.timeLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLBL
            // 
            this.timeLBL.BackColor = System.Drawing.Color.Transparent;
            this.timeLBL.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.timeLBL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timeLBL.Font = new System.Drawing.Font("Agency FB", 120F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL.ForeColor = System.Drawing.Color.White;
            this.timeLBL.Location = new System.Drawing.Point(13, 13);
            this.timeLBL.Margin = new System.Windows.Forms.Padding(3);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(1542, 431);
            this.timeLBL.TabIndex = 0;
            this.timeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timeLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1567, 453);
            this.Controls.Add(this.timeLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Digital Clock";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLBL;
    }
}

