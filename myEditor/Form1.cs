﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.NewToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_CLick);
            this.OpenToolStripMenuItem.Click += new EventHandler(OpenToolStripMenuItem_Click);
            this.SaveToolStripMenuItem.Click += new EventHandler(SaveToolStripMenuItem_Click);
            this.ExitToolStripMenuItem.Click += new EventHandler(ExitToolStripMenuItem_Click);

            this.copyToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_CLick);
            this.cutToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_CLick);
            this.pasteToolStripMenuItem.Click += new EventHandler(NewToolStripMenuItem_CLick);

            this.boldToolStripMenuItem.Click += new EventHandler(BoldToolStripMenuItem__Click);
            this.italicsToolStripMenuItem.Click += new EventHandler(ItalicsToolStripMenuItem__Click);
            this.underlineToolStripMenuItem.Click += new EventHandler(UnderlineToolStripMenuItem__Click);

            this.mSSansSerifToolStripMenuItem.Click += new EventHandler(MSSansSerifToolStripMenuItem__Click);
            this.timesNewRomanToolStripMenuItem.Click += new EventHandler(TimesNewRomanToolStripMenuItem__Click);

            this.toolStrip.ItemClicked += new ToolStripItemClickedEventHandler(ToolStrip_ItemClicked);

            this.richTextBox.SelectionChanged += new EventHandler(RichTextBox__SelectionChanged);

            this.Text = "MyEditor";
        }
        private void NewToolStripMenuItem_CLick(object sender, EventArgs e)
        {
            richTextBox.Clear();
            this.Text = "MyEditor";
        }

        private void BoldToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Bold;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if(selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Bold);

        }

        private void ItalicsToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Italic;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Italic);

        }

        private void UnderlineToolStripMenuItem__Click(object sender, EventArgs e)
        {
            FontStyle fontStyle = FontStyle.Underline;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if (selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }
            SetSelectionFont(fontStyle, !selectionFont.Underline);

        }
        private void MSSansSerifToolStripMenuItem__Click(Object sender, EventArgs e)
        {
            Font newFont = new Font("MS Sans Serif", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }

        private void TimesNewRomanToolStripMenuItem__Click(Object sender, EventArgs e)
        {
            Font newFont = new Font("Times New Roman", richTextBox.SelectionFont.Size, richTextBox.SelectionFont.Style);
            richTextBox.SelectionFont = newFont;
        }

        private void RichTextBox__SelectionChanged(object sender, EventArgs e)
        {
            if(this.richTextBox.SelectionFont != null)
            {
                this.boldToolStripButton.Checked = richTextBox.SelectionFont.Bold;
                this.italicsToolStripButton.Checked = richTextBox.SelectionFont.Italic;
                this.underlineToolStripButton.Checked = richTextBox.SelectionFont.Underline;
            }
            this.colorToolStripButton.BackColor = richTextBox.SelectionColor;
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (openFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.LoadFile(openFileDialog.FileName, richTextBoxStreamType);
                this.Text = "MyEditor (" + openFileDialog.FileName + ")";
            }

        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = openFileDialog.FileName;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RichTextBoxStreamType richTextBoxStreamType = RichTextBoxStreamType.RichText;

                if (saveFileDialog.FileName.ToLower().Contains(".txt"))
                {
                    richTextBoxStreamType = RichTextBoxStreamType.PlainText;
                }
                richTextBox.SaveFile(saveFileDialog.FileName, richTextBoxStreamType);
                this.Text = "MyEditor (" + saveFileDialog.FileName + ")";
            }
        }

        
        private void ExitToolStripMenuItem_Click(Object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Paste();
        }

        private void ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            FontStyle fontStyle = FontStyle.Regular;
            ToolStripButton toolStripButton = null;

            if(e.ClickedItem == this.boldToolStripButton)
            {
                fontStyle = FontStyle.Bold;
                toolStripButton = this.boldToolStripButton;
            }
            else if (e.ClickedItem == this.italicsToolStripButton)
            {
                fontStyle = FontStyle.Italic;
                toolStripButton = this.italicsToolStripButton;
            }
            else if (e.ClickedItem == this.underlineToolStripButton)
            {
                fontStyle = FontStyle.Underline;
                toolStripButton = this.underlineToolStripButton;
            }
            else if (e.ClickedItem == this.colorToolStripButton)
            {
                if(colorDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox.SelectionColor = colorDialog.Color;
                    colorToolStripButton.BackColor = colorDialog.Color;
                }
            }
            if(fontStyle != FontStyle.Regular)
            {
                toolStripButton.Checked = !toolStripButton.Checked;

                SetSelectionFont(fontStyle, toolStripButton.Checked);
            }
        }

        private void SetSelectionFont(FontStyle fontStyle, bool bSet)
        {
            Font newFont = null;
            Font selectionFont = null;

            selectionFont = richTextBox.SelectionFont;
            if(selectionFont == null)
            {
                selectionFont = richTextBox.Font;
            }

            if (bSet)
            {
                newFont = new Font(selectionFont, selectionFont.Style | fontStyle);
            }
            else
            {
                newFont = new Font(selectionFont, selectionFont.Style & ~fontStyle);
            }
            this.richTextBox.SelectionFont = newFont;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {

        }
    }
}
