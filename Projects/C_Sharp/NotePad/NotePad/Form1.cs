using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class Form1 : Form
    {
        string OurfileName;
        string LastFindWord;
        bool LastFindDown;
        bool LastFindMatchCase;

        void DoSave(string fileName)
        {
            OurfileName = fileName;
            richTextBox1.SaveFile(fileName);
        }

        void DoSaveAs()

        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DoSave(saveFileDialog1.FileName);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(OurfileName))
            {
                DoSaveAs();
            }
            else
            {
                DoSave(OurfileName);
            }
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void tIMEDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            findFRM find = new findFRM();
            find.Show(this);
        }

        public void DoFind(string search, bool down, bool match_case)

        { 
            LastFindWord = search;
            LastFindDown = down;
            LastFindMatchCase = match_case;

            if (down)

            {
                richTextBox1.Find(search, richTextBox1.SelectionStart + 1, RichTextBoxFinds.MatchCase);
            }
            else
            {
                richTextBox1.Find(search, richTextBox1.SelectionStart + 1, RichTextBoxFinds.None);

            }
        }

        private void findAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 parent_form = (Form1)Owner;
           // parent_form.DoFind(textFindWhat.Text, downRDO.checked, checkMatchCase.checked);
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        bool checkChanges()
        {
            return true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(checkChanges())
            {
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Drawing.Printing.PrintDocument prntDoc = new System.Drawing.Printing.PrintDocument();
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void fILEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();

            if (print.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
         }        
    }
}
