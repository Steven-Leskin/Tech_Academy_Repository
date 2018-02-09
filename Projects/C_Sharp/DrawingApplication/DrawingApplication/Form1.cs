using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingApplication
{
    public partial class PaintCanvas : Form
    {
        Bitmap bmp = new Bitmap(1024,768);
        Pen p = new Pen(Color.Black,5);
        bool drawing = false;

        public PaintCanvas()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (drawing)
                drawing = false;
            else
                drawing = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (drawing)
            {
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(p, e.X, e.Y,3,1);
                pictureBox1.Image = bmp;
            }
        }

        private void RedBTN_Click(object sender, EventArgs e)
        {
            p.Color = Color.Red;
        }

        private void greenBTN_Click(object sender, EventArgs e)
        {
            p.Color = Color.Green;
        }

        private void blueBTN_Click(object sender, EventArgs e)
        {
            p.Color = Color.Blue;
        }

        private void purpleBTN_Click(object sender, EventArgs e)
        {
            p.Color = Color.Purple;
        }

        private void LimeBTN_Click(object sender, EventArgs e)
        {
            p.Color = Color.Lime;
        }
        private void WhiteBtn_Click(object sender, EventArgs e)
        {
            p.Color = Color.White; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpeg|Bitmap Image *.bmp|";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
        }
    }
}
