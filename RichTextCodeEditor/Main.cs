using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace RichTextCodeEditor
{
    public partial class Main : Form
    {
        public static string openendFile = "";
        public static string tempText;
        public static DialogResult result;
        public static string text;
        public static bool blink;
        public static string[] startParameters;
        public static bool saved;
        public Main(string[] args)
        {
            InitializeComponent();
            startParameters = args;
        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (!CodeBox.Text.Equals(RichTextBoxDesigner.Rtf))
            {
                int i = CodeBox.SelectionStart;
                CodeBox.Text = RichTextBoxDesigner.Rtf;
                CodeBox.SelectionStart = i;
            }
            if (RichTextBoxDesigner.Rtf.Equals(tempText))
            {
                saved = true;
            }
            else
            {
                saved = false;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (startParameters.Length >= 1)
            {
                openendFile = startParameters[0];
                RichTextBoxDesigner.LoadFile(startParameters[0]);
                this.Text = "Rich Text Code Editor | " + openendFile;
            }
            Properties.Settings settings = Properties.Settings.Default;
            CodeBox.BackColor = settings.CodeBackgroundColor;
            CodeBox.ForeColor = settings.CodeColor;
            CodeBox.Font = settings.CodeFont;
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(Application.ExecutablePath);
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RichTextBoxDesigner.Text == "")
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Title = "Open File";
                dlg.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";
                if (dlg.ShowDialog().Equals(DialogResult.OK))
                {
                    openendFile = dlg.FileName;
                    RichTextBoxDesigner.LoadFile(dlg.FileName);
                    this.Text = "Rich Text Code Editor | " + openendFile;
                    tempText = RichTextBoxDesigner.Rtf;
                }
            }
            else
            {
                result = MessageBox.Show("Would you like to save the changes?", "Rich Text Code Editor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result.Equals(DialogResult.Yes))
                {
                    try
                    {
                        if (openendFile.Equals(""))
                        {
                            SaveFileDialog dlg1 = new SaveFileDialog();
                            dlg1.Title = "Save file as...";
                            dlg1.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";
                            if (dlg1.ShowDialog().Equals(DialogResult.OK))
                            {
                                openendFile = dlg1.FileName;
                                RichTextBoxDesigner.SaveFile(dlg1.Filter, RichTextBoxStreamType.RichText);
                                tempText = RichTextBoxDesigner.Rtf;
                                this.Text = "Rich Text Code Editor | " + openendFile;
                            }
                        }
                        else
                        {
                            RichTextBoxDesigner.SaveFile(openendFile, RichTextBoxStreamType.RichText);
                            tempText = RichTextBoxDesigner.Rtf;
                        }
                        OpenFileDialog dlg = new OpenFileDialog();
                        dlg.Title = "Open File";
                        dlg.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";
                        if (dlg.ShowDialog().Equals(DialogResult.OK))
                        {
                            openendFile = dlg.FileName;
                            RichTextBoxDesigner.LoadFile(dlg.FileName);
                            this.Text = "Rich Text Code Editor | " + openendFile;
                            tempText = RichTextBoxDesigner.Rtf;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Following Error occured: " + ex.Message, "Rich Text Code Editor | Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else if (result.Equals(DialogResult.No))
                {
                    OpenFileDialog dlg = new OpenFileDialog();
                    dlg.Title = "Open File";
                    dlg.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";
                    if (dlg.ShowDialog().Equals(DialogResult.OK))
                    {
                        openendFile = dlg.FileName;
                        RichTextBoxDesigner.LoadFile(dlg.FileName);
                        this.Text = "Rich Text Code Editor | " + openendFile;
                        tempText = RichTextBoxDesigner.Rtf;
                    }
                }
                else if (result.Equals(DialogResult.Cancel))
                {
                    return;
                }
            }
        }

        private void CodeBox_TextChanged(object sender, EventArgs e)
        {
            if (!CodeBox.Text.Equals(RichTextBoxDesigner.Rtf))
            {
                try
                {
                    int i = RichTextBoxDesigner.SelectionStart;
                    RichTextBoxDesigner.Rtf = CodeBox.Text;
                    RichTextBoxDesigner.SelectionStart = i;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openendFile.Equals(""))
            {
                SaveFileDialog dlg1 = new SaveFileDialog();
                dlg1.Title = "Save file as...";
                dlg1.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";
                if (dlg1.ShowDialog().Equals(DialogResult.OK))
                {
                    openendFile = dlg1.FileName;
                    RichTextBoxDesigner.SaveFile(dlg1.Filter, RichTextBoxStreamType.RichText);
                    tempText = RichTextBoxDesigner.Rtf;
                    this.Text = "Rich Text Code Editor | " + openendFile;
                }
            }
            else
            {
                RichTextBoxDesigner.SaveFile(openendFile, RichTextBoxStreamType.RichText);
                tempText = RichTextBoxDesigner.Rtf;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg1 = new SaveFileDialog();
            dlg1.Title = "Save file as...";
            dlg1.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";
            if (dlg1.ShowDialog().Equals(DialogResult.OK))
            {
                openendFile = dlg1.FileName;
                RichTextBoxDesigner.SaveFile(dlg1.Filter, RichTextBoxStreamType.RichText);
                tempText = RichTextBoxDesigner.Rtf;
                this.Text = "Rich Text Code Editor | " + openendFile;
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxDesigner.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxDesigner.Redo();
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxDesigner.Paste();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxDesigner.Copy();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxDesigner.Cut();
        }

        private void FontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = RichTextBoxDesigner.SelectionFont;
            if (dlg.ShowDialog().Equals(DialogResult.OK))
            {
                RichTextBoxDesigner.SelectionFont = dlg.Font;
            }
        }

        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBoxDesigner.SelectAll();
        }

        private void ColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = RichTextBoxDesigner.SelectionColor;
            if (dlg.ShowDialog().Equals(DialogResult.OK))
            {
                RichTextBoxDesigner.SelectionColor = dlg.Color;
            }
        }

        private void PasteImageOutOfFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select an Image to Paste";
            dlg.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.ICO;*.PNG)|*.BMP;*.JPG;*.GIF;*.ICO;*.PNG|Alle Dateien (*.*)|*.*";
            if (dlg.ShowDialog().Equals(DialogResult.OK))
            {
                Bitmap bmp = new Bitmap(dlg.FileName);
                Clipboard.SetImage(bmp);
                RichTextBoxDesigner.Paste();
            }
        }

        private void FontToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            dlg.Font = CodeBox.Font;
            if (dlg.ShowDialog().Equals(DialogResult.OK))
            {
                CodeBox.Font = dlg.Font;
            }
        }

        private void ColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = CodeBox.ForeColor;
            if (dlg.ShowDialog().Equals(DialogResult.OK))
            {
                CodeBox.ForeColor = dlg.Color;
            }
        }

        private void BackgroundToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            dlg.Color = CodeBox.BackColor;
            if (dlg.ShowDialog().Equals(DialogResult.OK))
            {
                CodeBox.BackColor = dlg.Color;
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if((e.CloseReason == CloseReason.UserClosing || e.CloseReason == CloseReason.WindowsShutDown) && !saved)
            {
                DialogResult result = MessageBox.Show("Do you want to save your RTF Document?", "RichTextCodeEditor", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (result)
                {
                    case DialogResult.Yes:
                        if (openendFile.Equals(""))
                        {
                            SaveFileDialog dlg1 = new SaveFileDialog();
                            dlg1.Title = "Save file as...";
                            dlg1.Filter = "Rich Text File (*.rtf)|*.rtf|All Files (*.*)|*.*";
                            if (dlg1.ShowDialog().Equals(DialogResult.OK))
                            {
                                openendFile = dlg1.FileName;
                                RichTextBoxDesigner.SaveFile(dlg1.FileName, RichTextBoxStreamType.RichText);
                                tempText = RichTextBoxDesigner.Rtf;
                                this.Text = "Rich Text Code Editor | " + openendFile;
                            }
                        }
                        else
                        {
                            RichTextBoxDesigner.SaveFile(openendFile, RichTextBoxStreamType.RichText);
                            tempText = RichTextBoxDesigner.Rtf;
                        }
                        e.Cancel = false;
                        break;
                    case DialogResult.No:
                        e.Cancel = false;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
            }
            Properties.Settings settings = Properties.Settings.Default;
            settings.CodeBackgroundColor = CodeBox.BackColor;
            settings.CodeColor = CodeBox.ForeColor;
            settings.CodeFont = CodeBox.Font;
            settings.Save();
        }
    }
}
