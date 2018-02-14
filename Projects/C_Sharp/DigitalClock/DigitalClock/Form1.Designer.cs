namespace DigitalClock
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
            this.dateLBL = new System.Windows.Forms.Label();
            this.dayLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timeLBL
            // 
            this.timeLBL.BackColor = System.Drawing.Color.Black;
            this.timeLBL.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLBL.ForeColor = System.Drawing.Color.White;
            this.timeLBL.Location = new System.Drawing.Point(99, 31);
            this.timeLBL.Name = "timeLBL";
            this.timeLBL.Size = new System.Drawing.Size(392, 60);
            this.timeLBL.TabIndex = 0;
            this.timeLBL.Text = "TIME";
            this.timeLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLBL
            // 
            this.dateLBL.BackColor = System.Drawing.Color.Black;
            this.dateLBL.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLBL.ForeColor = System.Drawing.Color.White;
            this.dateLBL.Location = new System.Drawing.Point(89, 112);
            this.dateLBL.Name = "dateLBL";
            this.dateLBL.Size = new System.Drawing.Size(402, 56);
            this.dateLBL.TabIndex = 1;
            this.dateLBL.Text = "DATE";
            this.dateLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dayLBL
            // 
            this.dayLBL.BackColor = System.Drawing.Color.Black;
            this.dayLBL.Font = new System.Drawing.Font("Candara", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayLBL.ForeColor = System.Drawing.Color.White;
            this.dayLBL.Location = new System.Drawing.Point(109, 206);
            this.dayLBL.Name = "dayLBL";
            this.dayLBL.Size = new System.Drawing.Size(382, 58);
            this.dayLBL.TabIndex = 2;
            this.dayLBL.Text = "DAY";
            this.dayLBL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dayLBL.Click += new System.EventHandler(this.dayLBL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(635, 304);
            this.Controls.Add(this.dayLBL);
            this.Controls.Add(this.dateLBL);
            this.Controls.Add(this.timeLBL);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label timeLBL;
        private System.Windows.Forms.Label dateLBL;
        private System.Windows.Forms.Label dayLBL;
    }
}

