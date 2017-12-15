namespace Hexagram
{
    partial class HexWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HexWindow));
            this.hexMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitFileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectEditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutHelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexStatus = new System.Windows.Forms.StatusStrip();
            this.hexStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.hexOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.hexEditor = new Hexagram.UI.HexEditor();
            this.hexMenu.SuspendLayout();
            this.hexStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // hexMenu
            // 
            this.hexMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.hexMenu.Location = new System.Drawing.Point(0, 0);
            this.hexMenu.Name = "hexMenu";
            this.hexMenu.Size = new System.Drawing.Size(644, 24);
            this.hexMenu.TabIndex = 0;
            this.hexMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileMenuItem,
            this.toolStripSeparator,
            this.saveFileMenuItem,
            this.saveAsFileMenuItem,
            this.toolStripSeparator1,
            this.exitFileMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.openFileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openFileMenuItem.Image")));
            this.openFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openFileMenuItem.Name = "openFileMenuItem";
            this.openFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openFileMenuItem.Text = "&Open";
            this.openFileMenuItem.Click += new System.EventHandler(this.openFileMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.saveFileMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveFileMenuItem.Image")));
            this.saveFileMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveFileMenuItem.Name = "saveFileMenuItem";
            this.saveFileMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveFileMenuItem.Text = "&Save";
            // 
            // saveAsFileMenuItem
            // 
            this.saveAsFileMenuItem.Name = "saveAsFileMenuItem";
            this.saveAsFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.saveAsFileMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // exitFileMenuItem
            // 
            this.exitFileMenuItem.Name = "exitFileMenuItem";
            this.exitFileMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitFileMenuItem.Text = "E&xit";
            this.exitFileMenuItem.Click += new System.EventHandler(this.exitFileMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoEditMenuItem,
            this.redoEditMenuItem,
            this.toolStripSeparator3,
            this.cutEditMenuItem,
            this.copyEditMenuItem,
            this.pasteEditMenuItem,
            this.toolStripSeparator4,
            this.selectEditMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoEditMenuItem
            // 
            this.undoEditMenuItem.Name = "undoEditMenuItem";
            this.undoEditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoEditMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoEditMenuItem.Text = "&Undo";
            // 
            // redoEditMenuItem
            // 
            this.redoEditMenuItem.Name = "redoEditMenuItem";
            this.redoEditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoEditMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoEditMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutEditMenuItem
            // 
            this.cutEditMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cutEditMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutEditMenuItem.Image")));
            this.cutEditMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutEditMenuItem.Name = "cutEditMenuItem";
            this.cutEditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutEditMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutEditMenuItem.Text = "Cu&t";
            // 
            // copyEditMenuItem
            // 
            this.copyEditMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.copyEditMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyEditMenuItem.Image")));
            this.copyEditMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyEditMenuItem.Name = "copyEditMenuItem";
            this.copyEditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyEditMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyEditMenuItem.Text = "&Copy";
            // 
            // pasteEditMenuItem
            // 
            this.pasteEditMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.pasteEditMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteEditMenuItem.Image")));
            this.pasteEditMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteEditMenuItem.Name = "pasteEditMenuItem";
            this.pasteEditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteEditMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteEditMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectEditMenuItem
            // 
            this.selectEditMenuItem.Name = "selectEditMenuItem";
            this.selectEditMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectEditMenuItem.Text = "Select &All";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutHelpMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutHelpMenuItem
            // 
            this.aboutHelpMenuItem.Name = "aboutHelpMenuItem";
            this.aboutHelpMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutHelpMenuItem.Text = "&About...";
            this.aboutHelpMenuItem.Click += new System.EventHandler(this.aboutHelpMenuItem_Click);
            // 
            // hexStatus
            // 
            this.hexStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hexStatusLabel});
            this.hexStatus.Location = new System.Drawing.Point(0, 389);
            this.hexStatus.Name = "hexStatus";
            this.hexStatus.Size = new System.Drawing.Size(644, 22);
            this.hexStatus.TabIndex = 1;
            // 
            // hexStatusLabel
            // 
            this.hexStatusLabel.Name = "hexStatusLabel";
            this.hexStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // hexEditor
            // 
            this.hexEditor.BackColor = System.Drawing.Color.LightBlue;
            this.hexEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hexEditor.Font = new System.Drawing.Font("Courier New", 10F);
            this.hexEditor.Location = new System.Drawing.Point(0, 24);
            this.hexEditor.Multiline = true;
            this.hexEditor.Name = "hexEditor";
            this.hexEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.hexEditor.Size = new System.Drawing.Size(644, 365);
            this.hexEditor.TabIndex = 2;
            this.hexEditor.WordWrap = false;
            // 
            // HexWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 411);
            this.Controls.Add(this.hexEditor);
            this.Controls.Add(this.hexStatus);
            this.Controls.Add(this.hexMenu);
            this.MainMenuStrip = this.hexMenu;
            this.Name = "HexWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hexagram";
            this.hexMenu.ResumeLayout(false);
            this.hexMenu.PerformLayout();
            this.hexStatus.ResumeLayout(false);
            this.hexStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip hexMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveFileMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitFileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoEditMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteEditMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectEditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutHelpMenuItem;
        private System.Windows.Forms.StatusStrip hexStatus;
        private System.Windows.Forms.ToolStripMenuItem saveAsFileMenuItem;
        private System.Windows.Forms.OpenFileDialog hexOpenFileDialog;
        private System.Windows.Forms.ToolStripStatusLabel hexStatusLabel;
        private UI.HexEditor hexEditor;
    }
}

