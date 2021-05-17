using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;

namespace darkmodenotepad
{



    public partial class Form1 : Form
    {


        PrintDocument document = new PrintDocument();
        PrintDialog dialog = new PrintDialog();
        public Form1()
        {
            
            InitializeComponent();
            document.PrintPage += new PrintPageEventHandler(document_PrintPage);

        }
        void document_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 20, 20); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void RichTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                richTextBox1.Text += (string)Clipboard.GetData("Text");
                e.Handled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Text = File.ReadAllText(openFileDialog1.FileName);
            }
        }

        private void saveasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|All Files|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }


        private void wordWrapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //performing wordwrap operation         
            if (wordWrapToolStripMenuItem.Checked == false)
            {
                wordWrapToolStripMenuItem.Checked = true;
                richTextBox1.WordWrap = true;
            }
            else
            {
                wordWrapToolStripMenuItem.Checked = false;
                richTextBox1.WordWrap = false;
            }
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void richTextBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }



        private void toolStripSeparator1_Click_1(object sender, EventArgs e)
        {
            
        }



        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dialog.Document = document;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "Text File|*.txt|All Files|*.*";
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, richTextBox1.Text);
            }

        }

        private void newWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().Show();
        }

    }
}
