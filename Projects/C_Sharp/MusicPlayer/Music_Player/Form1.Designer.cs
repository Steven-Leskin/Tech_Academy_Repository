namespace Music_Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Browse = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // Browse
            // 
            this.Browse.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Browse.Font = new System.Drawing.Font("GrilledCheese BTN Wide Blk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Location = new System.Drawing.Point(53, 330);
            this.Browse.Name = "Browse";
            this.Browse.Size = new System.Drawing.Size(235, 52);
            this.Browse.TabIndex = 0;
            this.Browse.Text = "BROWSE";
            this.Browse.UseVisualStyleBackColor = false;
            this.Browse.Click += new System.EventHandler(this.Browse_Click);
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Play.Font = new System.Drawing.Font("GrilledCheese BTN Wide Blk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Play.Location = new System.Drawing.Point(313, 330);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(235, 52);
            this.Play.TabIndex = 1;
            this.Play.Text = "PLAY";
            this.Play.UseVisualStyleBackColor = false;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause.Font = new System.Drawing.Font("GrilledCheese BTN Wide Blk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(569, 330);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(235, 52);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "PAUSE";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Stop.Font = new System.Drawing.Font("GrilledCheese BTN Wide Blk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.Location = new System.Drawing.Point(829, 330);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(235, 52);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "STOP";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit.Font = new System.Drawing.Font("GrilledCheese BTN Wide Blk", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(1092, 330);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(235, 52);
            this.Exit.TabIndex = 4;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 269);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Now Playing:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 269);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1014, 22);
            this.textBox1.TabIndex = 6;
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(-10, -4);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(1388, 247);
            this.Player.TabIndex = 7;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1373, 427);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.Browse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Browse;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

