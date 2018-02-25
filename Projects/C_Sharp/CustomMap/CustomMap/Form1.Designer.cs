namespace CustomMap
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.streetLBL = new System.Windows.Forms.Label();
            this.cityLBL = new System.Windows.Forms.Label();
            this.stateLBL = new System.Windows.Forms.Label();
            this.zipLBL = new System.Windows.Forms.Label();
            this.searchBTN = new System.Windows.Forms.Button();
            this.streetTB = new System.Windows.Forms.TextBox();
            this.cityTB = new System.Windows.Forms.TextBox();
            this.stateTB = new System.Windows.Forms.TextBox();
            this.zipTB = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.zipTB);
            this.groupBox1.Controls.Add(this.stateTB);
            this.groupBox1.Controls.Add(this.cityTB);
            this.groupBox1.Controls.Add(this.streetTB);
            this.groupBox1.Controls.Add(this.searchBTN);
            this.groupBox1.Controls.Add(this.zipLBL);
            this.groupBox1.Controls.Add(this.stateLBL);
            this.groupBox1.Controls.Add(this.cityLBL);
            this.groupBox1.Controls.Add(this.streetLBL);
            this.groupBox1.Font = new System.Drawing.Font("IMG Travel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(-1, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 563);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // streetLBL
            // 
            this.streetLBL.AutoSize = true;
            this.streetLBL.Location = new System.Drawing.Point(14, 50);
            this.streetLBL.Name = "streetLBL";
            this.streetLBL.Size = new System.Drawing.Size(94, 20);
            this.streetLBL.TabIndex = 0;
            this.streetLBL.Text = "STREET:";
            // 
            // cityLBL
            // 
            this.cityLBL.AutoSize = true;
            this.cityLBL.Location = new System.Drawing.Point(14, 96);
            this.cityLBL.Name = "cityLBL";
            this.cityLBL.Size = new System.Drawing.Size(60, 20);
            this.cityLBL.TabIndex = 1;
            this.cityLBL.Text = "CITY:";
            // 
            // stateLBL
            // 
            this.stateLBL.AutoSize = true;
            this.stateLBL.Location = new System.Drawing.Point(14, 149);
            this.stateLBL.Name = "stateLBL";
            this.stateLBL.Size = new System.Drawing.Size(80, 20);
            this.stateLBL.TabIndex = 2;
            this.stateLBL.Text = "STATE:";
            // 
            // zipLBL
            // 
            this.zipLBL.AutoSize = true;
            this.zipLBL.Location = new System.Drawing.Point(14, 198);
            this.zipLBL.Name = "zipLBL";
            this.zipLBL.Size = new System.Drawing.Size(114, 20);
            this.zipLBL.TabIndex = 3;
            this.zipLBL.Text = "ZIP CODE:";
            // 
            // searchBTN
            // 
            this.searchBTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.searchBTN.Location = new System.Drawing.Point(17, 247);
            this.searchBTN.Name = "searchBTN";
            this.searchBTN.Size = new System.Drawing.Size(305, 45);
            this.searchBTN.TabIndex = 4;
            this.searchBTN.Text = "SEARCH";
            this.searchBTN.UseVisualStyleBackColor = false;
            this.searchBTN.Click += new System.EventHandler(this.searchBTN_Click);
            // 
            // streetTB
            // 
            this.streetTB.Location = new System.Drawing.Point(177, 50);
            this.streetTB.Name = "streetTB";
            this.streetTB.Size = new System.Drawing.Size(145, 30);
            this.streetTB.TabIndex = 5;
            // 
            // cityTB
            // 
            this.cityTB.Location = new System.Drawing.Point(177, 96);
            this.cityTB.Name = "cityTB";
            this.cityTB.Size = new System.Drawing.Size(145, 30);
            this.cityTB.TabIndex = 6;
            // 
            // stateTB
            // 
            this.stateTB.Location = new System.Drawing.Point(177, 149);
            this.stateTB.Name = "stateTB";
            this.stateTB.Size = new System.Drawing.Size(145, 30);
            this.stateTB.TabIndex = 7;
            // 
            // zipTB
            // 
            this.zipTB.Location = new System.Drawing.Point(177, 198);
            this.zipTB.Name = "zipTB";
            this.zipTB.Size = new System.Drawing.Size(145, 30);
            this.zipTB.TabIndex = 8;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(374, -11);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(907, 574);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1293, 561);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom Map";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox zipTB;
        private System.Windows.Forms.TextBox stateTB;
        private System.Windows.Forms.TextBox cityTB;
        private System.Windows.Forms.TextBox streetTB;
        private System.Windows.Forms.Button searchBTN;
        private System.Windows.Forms.Label zipLBL;
        private System.Windows.Forms.Label stateLBL;
        private System.Windows.Forms.Label cityLBL;
        private System.Windows.Forms.Label streetLBL;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

