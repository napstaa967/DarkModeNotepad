
namespace darkmodenotepad



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
        /// </summary>p
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordWrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.formatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1467, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.newWindowToolStripMenuItem,
            this.opebToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.printToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click_1);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.newToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.newWindowToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.newWindowToolStripMenuItem.Text = "New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.newWindowToolStripMenuItem_Click);
            // 
            // opebToolStripMenuItem
            // 
            this.opebToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.opebToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.opebToolStripMenuItem.Name = "opebToolStripMenuItem";
            this.opebToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.opebToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.opebToolStripMenuItem.Text = "Open...";
            this.opebToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.saveToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveToolStripMenuItem.Text = "Save As...";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveasToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.exitToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(220, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.printToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem1,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6,
            this.toolStripMenuItem7,
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "Undo";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Redo";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.toolStripMenuItem4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem4.Text = "Cut";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.toolStripMenuItem5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripMenuItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem5.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem5.Text = "Copy";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripMenuItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.toolStripMenuItem6.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem6.Text = "Paste";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.toolStripMenuItem6_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripMenuItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripMenuItem7.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem7.Text = "Select All";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            // 
            // formatToolStripMenuItem
            // 
            this.formatToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fontToolStripMenuItem,
            this.wordWrapToolStripMenuItem});
            this.formatToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
            this.formatToolStripMenuItem.Size = new System.Drawing.Size(57, 19);
            this.formatToolStripMenuItem.Text = "Format";
            this.formatToolStripMenuItem.Click += new System.EventHandler(this.formatToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.fontToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.fontToolStripMenuItem.Text = "Font...";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // wordWrapToolStripMenuItem
            // 
            this.wordWrapToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.wordWrapToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.wordWrapToolStripMenuItem.Name = "wordWrapToolStripMenuItem";
            this.wordWrapToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.wordWrapToolStripMenuItem.Text = "Word Wrap";
            this.wordWrapToolStripMenuItem.Click += new System.EventHandler(this.wordWrapToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // fontDialog1
            // 
            this.fontDialog1.Apply += new System.EventHandler(this.fontDialog1_Apply);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Location = new System.Drawing.Point(0, 25);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1467, 737);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_2);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1467, 762);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(367, 338);
            this.Name = "Form1";
            this.Text = "Dark Mode Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem opebToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wordWrapToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
    }
}

