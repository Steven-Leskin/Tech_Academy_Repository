namespace LoginForm
{
    partial class loginFRM
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
            this.userNameLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameTB = new System.Windows.Forms.TextBox();
            this.passWordTB = new System.Windows.Forms.TextBox();
            this.longOutBTN = new System.Windows.Forms.Button();
            this.logInBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userNameLBL
            // 
            this.userNameLBL.AutoSize = true;
            this.userNameLBL.BackColor = System.Drawing.Color.Firebrick;
            this.userNameLBL.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLBL.Location = new System.Drawing.Point(48, 41);
            this.userNameLBL.Name = "userNameLBL";
            this.userNameLBL.Size = new System.Drawing.Size(201, 40);
            this.userNameLBL.TabIndex = 0;
            this.userNameLBL.Text = "USERNAME:";
            this.userNameLBL.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Firebrick;
            this.label1.Font = new System.Drawing.Font("Corbel", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "PASSWORD:";
            // 
            // userNameTB
            // 
            this.userNameTB.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTB.Location = new System.Drawing.Point(283, 41);
            this.userNameTB.Name = "userNameTB";
            this.userNameTB.Size = new System.Drawing.Size(299, 40);
            this.userNameTB.TabIndex = 2;
            this.userNameTB.Tag = "";
            // 
            // passWordTB
            // 
            this.passWordTB.Font = new System.Drawing.Font("Corbel", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passWordTB.Location = new System.Drawing.Point(283, 94);
            this.passWordTB.Name = "passWordTB";
            this.passWordTB.PasswordChar = '*';
            this.passWordTB.Size = new System.Drawing.Size(299, 40);
            this.passWordTB.TabIndex = 3;
            this.passWordTB.Tag = "";
            this.passWordTB.TextChanged += new System.EventHandler(this.passWordTB_TextChanged);
            // 
            // longOutBTN
            // 
            this.longOutBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.longOutBTN.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longOutBTN.ForeColor = System.Drawing.Color.White;
            this.longOutBTN.Location = new System.Drawing.Point(331, 153);
            this.longOutBTN.Name = "longOutBTN";
            this.longOutBTN.Size = new System.Drawing.Size(123, 38);
            this.longOutBTN.TabIndex = 4;
            this.longOutBTN.Text = "Log Out";
            this.longOutBTN.UseVisualStyleBackColor = true;
            this.longOutBTN.Click += new System.EventHandler(this.longOutBTN_Click);
            // 
            // logInBTN
            // 
            this.logInBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logInBTN.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInBTN.ForeColor = System.Drawing.Color.White;
            this.logInBTN.Location = new System.Drawing.Point(460, 153);
            this.logInBTN.Name = "logInBTN";
            this.logInBTN.Size = new System.Drawing.Size(122, 38);
            this.logInBTN.TabIndex = 5;
            this.logInBTN.Text = "Log In";
            this.logInBTN.UseVisualStyleBackColor = true;
            this.logInBTN.Click += new System.EventHandler(this.logInBTN_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(198, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 38);
            this.button1.TabIndex = 6;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(55, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 38);
            this.button2.TabIndex = 7;
            this.button2.Text = "Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // loginFRM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(637, 229);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logInBTN);
            this.Controls.Add(this.longOutBTN);
            this.Controls.Add(this.passWordTB);
            this.Controls.Add(this.userNameTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userNameLBL);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginFRM";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userNameLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameTB;
        private System.Windows.Forms.TextBox passWordTB;
        private System.Windows.Forms.Button longOutBTN;
        private System.Windows.Forms.Button logInBTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

