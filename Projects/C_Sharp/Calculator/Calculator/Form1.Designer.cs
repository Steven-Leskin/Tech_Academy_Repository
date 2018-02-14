namespace Calculator
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
            this.resultValueTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.plusBTN = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.minusBTN = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.multiplicationBTN = new System.Windows.Forms.Button();
            this.clearBTN = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.equalBTN = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultValueTB
            // 
            this.resultValueTB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultValueTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultValueTB.Location = new System.Drawing.Point(13, 12);
            this.resultValueTB.Multiline = true;
            this.resultValueTB.Name = "resultValueTB";
            this.resultValueTB.Size = new System.Drawing.Size(238, 35);
            this.resultValueTB.TabIndex = 0;
            this.resultValueTB.Text = "0";
            this.resultValueTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(55, 51);
            this.button1.TabIndex = 1;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.click_button);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(74, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(55, 51);
            this.button2.TabIndex = 2;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.click_button);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(135, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(55, 51);
            this.button3.TabIndex = 3;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.click_button);
            // 
            // plusBTN
            // 
            this.plusBTN.Location = new System.Drawing.Point(196, 53);
            this.plusBTN.Name = "plusBTN";
            this.plusBTN.Size = new System.Drawing.Size(55, 51);
            this.plusBTN.TabIndex = 4;
            this.plusBTN.Text = "+";
            this.plusBTN.UseVisualStyleBackColor = true;
            this.plusBTN.Click += new System.EventHandler(this.click_operator);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(13, 110);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 51);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.click_button);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(74, 110);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 51);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.click_button);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(135, 110);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 51);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.click_button);
            // 
            // minusBTN
            // 
            this.minusBTN.Location = new System.Drawing.Point(196, 110);
            this.minusBTN.Name = "minusBTN";
            this.minusBTN.Size = new System.Drawing.Size(55, 51);
            this.minusBTN.TabIndex = 8;
            this.minusBTN.Text = "-";
            this.minusBTN.UseVisualStyleBackColor = true;
            this.minusBTN.Click += new System.EventHandler(this.click_operator);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(13, 167);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(55, 51);
            this.button7.TabIndex = 9;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.click_button);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(74, 167);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(55, 51);
            this.button8.TabIndex = 10;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.click_button);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(135, 167);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(55, 51);
            this.button9.TabIndex = 11;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.click_button);
            // 
            // multiplicationBTN
            // 
            this.multiplicationBTN.Location = new System.Drawing.Point(196, 167);
            this.multiplicationBTN.Name = "multiplicationBTN";
            this.multiplicationBTN.Size = new System.Drawing.Size(55, 51);
            this.multiplicationBTN.TabIndex = 12;
            this.multiplicationBTN.Text = "*";
            this.multiplicationBTN.UseVisualStyleBackColor = true;
            this.multiplicationBTN.Click += new System.EventHandler(this.click_operator);
            // 
            // clearBTN
            // 
            this.clearBTN.Location = new System.Drawing.Point(13, 224);
            this.clearBTN.Name = "clearBTN";
            this.clearBTN.Size = new System.Drawing.Size(55, 51);
            this.clearBTN.TabIndex = 13;
            this.clearBTN.Text = "C";
            this.clearBTN.UseVisualStyleBackColor = true;
            this.clearBTN.Click += new System.EventHandler(this.clearBTN_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(74, 224);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(55, 51);
            this.button11.TabIndex = 14;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.click_button);
            // 
            // equalBTN
            // 
            this.equalBTN.Location = new System.Drawing.Point(135, 224);
            this.equalBTN.Name = "equalBTN";
            this.equalBTN.Size = new System.Drawing.Size(55, 51);
            this.equalBTN.TabIndex = 15;
            this.equalBTN.Text = "=";
            this.equalBTN.UseVisualStyleBackColor = true;
            this.equalBTN.Click += new System.EventHandler(this.equalBTN_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(196, 224);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(55, 51);
            this.button13.TabIndex = 16;
            this.button13.Text = "/";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.click_operator);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(267, 287);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.equalBTN);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.clearBTN);
            this.Controls.Add(this.multiplicationBTN);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.minusBTN);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.plusBTN);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.resultValueTB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultValueTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button plusBTN;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button minusBTN;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button multiplicationBTN;
        private System.Windows.Forms.Button clearBTN;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button equalBTN;
        private System.Windows.Forms.Button button13;
    }
}

