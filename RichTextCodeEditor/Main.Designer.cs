
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
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FontToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ColorToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.BackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.CodeBox = new System.Windows.Forms.RichTextBox();
            this.RichTextBoxDesigner = new System.Windows.Forms.RichTextBox();
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
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // OpenToolStripMenuItem
            // 
            this.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem";
            this.OpenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenToolStripMenuItem.Text = "Open";
            this.OpenToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // SaveToolStripMenuItem
            // 
            this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
            this.SaveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveToolStripMenuItem.Text = "Save";
            this.SaveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // SaveAsToolStripMenuItem
            // 
            this.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem";
            this.SaveAsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.SaveAsToolStripMenuItem.Text = "Save as...";
            this.SaveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
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
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "Edit";
            // 
            // FontToolStripMenuItem
            // 
            this.FontToolStripMenuItem.Name = "FontToolStripMenuItem";
            this.FontToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.FontToolStripMenuItem.Text = "Font";
            this.FontToolStripMenuItem.Click += new System.EventHandler(this.FontToolStripMenuItem_Click);
            // 
            // ColorToolStripMenuItem
            // 
            this.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem";
            this.ColorToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ColorToolStripMenuItem.Text = "Color";
            this.ColorToolStripMenuItem.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.UndoToolStripMenuItem.Text = "Undo";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.RedoToolStripMenuItem.Text = "Redo";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.CutToolStripMenuItem.Text = "Cut";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.SelectAllToolStripMenuItem.Text = "Select all";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // PasteImageOutOfFileToolStripMenuItem
            // 
            this.PasteImageOutOfFileToolStripMenuItem.Name = "PasteImageOutOfFileToolStripMenuItem";
            this.PasteImageOutOfFileToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.PasteImageOutOfFileToolStripMenuItem.Text = "Paste Image out of File";
            this.PasteImageOutOfFileToolStripMenuItem.Click += new System.EventHandler(this.PasteImageOutOfFileToolStripMenuItem_Click);
            // 
            // MarkToolStripMenuItem
            // 
            this.MarkToolStripMenuItem.Name = "MarkToolStripMenuItem";
            this.MarkToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.MarkToolStripMenuItem.Text = "Select";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FontToolStripMenuItem2,
            this.ColorToolStripMenuItem2,
            this.BackgroundToolStripMenuItem});
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.codeToolStripMenuItem.Text = "Code";
            // 
            // FontToolStripMenuItem2
            // 
            this.FontToolStripMenuItem2.Name = "FontToolStripMenuItem2";
            this.FontToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.FontToolStripMenuItem2.Text = "Font";
            this.FontToolStripMenuItem2.Click += new System.EventHandler(this.FontToolStripMenuItem_Click_1);
            // 
            // ColorToolStripMenuItem2
            // 
            this.ColorToolStripMenuItem2.Name = "ColorToolStripMenuItem2";
            this.ColorToolStripMenuItem2.Size = new System.Drawing.Size(138, 22);
            this.ColorToolStripMenuItem2.Text = "Color";
            this.ColorToolStripMenuItem2.Click += new System.EventHandler(this.ColorToolStripMenuItem_Click_1);
            // 
            // BackgroundToolStripMenuItem
            // 
            this.BackgroundToolStripMenuItem.Name = "BackgroundToolStripMenuItem";
            this.BackgroundToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.BackgroundToolStripMenuItem.Text = "Background";
            this.BackgroundToolStripMenuItem.Click += new System.EventHandler(this.BackgroundToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.CodeBox);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.RichTextBoxDesigner);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(920, 555);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(920, 579);
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
            this.CodeBox.Size = new System.Drawing.Size(420, 546);
            this.CodeBox.TabIndex = 1;
            this.CodeBox.Text = "";
            this.CodeBox.TextChanged += new System.EventHandler(this.CodeBox_TextChanged);
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
            this.RichTextBoxDesigner.Size = new System.Drawing.Size(488, 546);
            this.RichTextBoxDesigner.TabIndex = 0;
            this.RichTextBoxDesigner.Text = "";
            this.RichTextBoxDesigner.TextChanged += new System.EventHandler(this.RichTextBox1_TextChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 579);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.MenuBar;
            this.Name = "Main";
            this.Text = "RichText Code Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
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
        private System.Windows.Forms.ToolStripMenuItem FontToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ColorToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem BackgroundToolStripMenuItem;
    }
}

