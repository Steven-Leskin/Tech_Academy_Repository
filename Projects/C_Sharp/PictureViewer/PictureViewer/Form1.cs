using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureViewer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (resizeBTN.Checked)
             pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; 
            else
             pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            ;
        }

        private void setBTN_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pictureBox1.BackColor = colorDialog1.Color;

        }

        private void selectBTN_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void clearBTN_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void closeBTN_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
