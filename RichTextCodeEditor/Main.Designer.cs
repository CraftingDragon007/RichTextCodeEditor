
namespace RichTextCodeEditor
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuBar = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteImageOutOfFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MarkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxDesigner = new System.Windows.Forms.RichTextBox();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schriftartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.farbeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hintergrundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBar.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Dock = System.Windows.Forms.DockStyle.None;
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.codeToolStripMenuItem});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.Size = new System.Drawing.Size(920, 24);
            this.MenuBar.TabIndex = 0;
            this.MenuBar.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.OpenToolStripMenuItem,
            this.SaveToolStripMenuItem,
            this.SaveAsToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.FileToolStripMenuItem.Text = "Datei";
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewToolStripMenuItem.Text = "Neu";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.neuToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Öffnen";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.öffnenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Speichern";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.speichernToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveAsToolStripMenuItem.Text = "Speichern als...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.speichernAlsToolStripMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem,
            this.ColorToolStripMenuItem,
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.CutToolStripMenuItem,
            this.SelectAllToolStripMenuItem,
            this.PasteImageOutOfFileToolStripMenuItem,
            this.MarkToolStripMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.EditToolStripMenuItem.Text = "Bearbeiten";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.FontToolStripMenuItem.Text = "Schriftart";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.schriftartToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.ColorToolStripMenuItem.Text = "Farbe";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.farbeToolStripMenuItem_Click);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.UndoToolStripMenuItem.Text = "Rückgängig";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.rückgängigToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.RedoToolStripMenuItem.Text = "Wiederholen";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.wiederholenToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.PasteToolStripMenuItem.Text = "Einfügen";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.einfügenToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.CopyToolStripMenuItem.Text = "Kopieren";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.kopierenToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.CutToolStripMenuItem.Text = "Ausschneiden";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.ausschneidenToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.SelectAllToolStripMenuItem.Text = "Alles Auswählen";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.allesAuswählenToolStripMenuItem_Click);
            // 
            // PasteImageOutOfFileToolStripMenuItem
            // 
            this.PasteImageOutOfFileToolStripMenuItem.Name = "PasteImageOutOfFileToolStripMenuItem";
            this.PasteImageOutOfFileToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.PasteImageOutOfFileToolStripMenuItem.Text = "Bild Einfügen aus Datei";
            this.PasteImageOutOfFileToolStripMenuItem.Click += new System.EventHandler(this.bildEinfügenAusDateiToolStripMenuItem_Click);
            // 
            // MarkToolStripMenuItem
            // 
            this.MarkToolStripMenuItem.Name = "MarkToolStripMenuItem";
            this.MarkToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.MarkToolStripMenuItem.Text = "Markieren";
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CodeBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.RichTextBoxDesigner);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(920, 571);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(920, 595);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.MenuBar);
            // 
            // CodeBox
            // 
            this.CodeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeBox.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CodeBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CodeBox.Location = new System.Drawing.Point(497, 3);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.CodeBox.Size = new System.Drawing.Size(420, 562);
            this.CodeBox.TabIndex = 1;
            this.CodeBox.Text = "";
            this.CodeBox.TextChanged += new System.EventHandler(this.codeBox_TextChanged);
            // 
            // RichTextBoxDesigner
            // 
            this.RichTextBoxDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RichTextBoxDesigner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RichTextBoxDesigner.Location = new System.Drawing.Point(3, 3);
            this.RichTextBoxDesigner.Name = "RichTextBoxDesigner";
            this.RichTextBoxDesigner.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.RichTextBoxDesigner.Size = new System.Drawing.Size(488, 562);
            this.RichTextBoxDesigner.TabIndex = 0;
            this.RichTextBoxDesigner.Text = "";
            this.RichTextBoxDesigner.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schriftartToolStripMenuItem,
            this.farbeToolStripMenuItem,
            this.hintergrundToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // schriftartToolStripMenuItem
            // 
            this.schriftartToolStripMenuItem.Name = "schriftartToolStripMenuItem";
            this.schriftartToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.schriftartToolStripMenuItem.Text = "Schriftart";
            this.schriftartToolStripMenuItem.Click += new System.EventHandler(this.schriftartToolStripMenuItem_Click_1);
            // 
            // farbeToolStripMenuItem
            // 
            this.farbeToolStripMenuItem.Name = "farbeToolStripMenuItem";
            this.farbeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.farbeToolStripMenuItem.Text = "Farbe";
            this.farbeToolStripMenuItem.Click += new System.EventHandler(this.farbeToolStripMenuItem_Click_1);
            // 
            // hintergrundToolStripMenuItem
            // 
            this.hintergrundToolStripMenuItem.Name = "hintergrundToolStripMenuItem";
            this.hintergrundToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hintergrundToolStripMenuItem.Text = "Hintergrund";
            this.hintergrundToolStripMenuItem.Click += new System.EventHandler(this.hintergrundToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 595);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Main";
            this.Text = "RichText Code Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuBar;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.RichTextBox RichTextBoxDesigner;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenToolStripMenuItem;
        private System.Windows.Forms.RichTextBox CodeBox;
        private System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteImageOutOfFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MarkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schriftartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem farbeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hintergrundToolStripMenuItem;
    }
}

