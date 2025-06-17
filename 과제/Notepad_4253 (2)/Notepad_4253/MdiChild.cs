using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_4253
{
    public partial class MdiChild : Form
    {
        public MdiChild()
        {
            InitializeComponent();
            this.Text = "이름없음-메모장";

            rTxtMain.Modified = false;
            rTxtMain.HideSelection = false;
        }
        

        public MdiChild(string filename, int filterIndex):this()
        {
            InitializeComponent();

            switch (filterIndex)
            {
                case 1:
                    rTxtMain.LoadFile(filename, RichTextBoxStreamType.RichText);
                    break;
                case 2:
                    rTxtMain.LoadFile(filename, RichTextBoxStreamType.PlainText);
                    break;
            }

            int iStart = filename.LastIndexOf("\\") + 1;
            int iEnd = filename.Length;
            this.Text = filename.Substring(iStart, iEnd - iStart) + "-메모장";

            rTxtMain.Modified = false;
            rTxtMain.HideSelection = false;
        }

        public void saveFile()
        {

            if(saveFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string filename = saveFileDialog1.FileName;

                if(filename.Length > 0)
                {
                    switch(saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            rTxtMain.SaveFile(filename, RichTextBoxStreamType.PlainText);
                            break;
                        case 2:
                            rTxtMain.SaveFile(filename, RichTextBoxStreamType.PlainText);
                            break;

                    }
                    rTxtMain.Modified = false;

                    int iStart = filename.LastIndexOf("\\") + 1;
                    int iEnd = filename.Length;
                    this.Text = filename.Substring(iStart, iEnd - iStart) + "-메모장";
                }
            }
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            saveFile();
        }

        private void mnuQuit_Click(object sender, EventArgs e)
        {
            if(rTxtMain.Modified)
            {
                DialogResult saveType = MessageBox.Show(this.Text + "를 저장하시겠습니까?", "알림", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                switch(saveType)
                {
                    case DialogResult.Yes:
                        saveFile();
                        if (rTxtMain.Modified == true) return;
                        break;
                    case DialogResult.No:
                        break;
                    case DialogResult.Cancel:
                        return;
                }
            }
            this.Close();
        }

        private void rTxtMain_TextChanged(object sender, EventArgs e)
        {
            mnuUndo.Enabled = true;
        }

        private void mnuRedo_Click(object sender, EventArgs e)
        {
            if(rTxtMain.CanRedo)
            {
                rTxtMain.Redo();
                mnuUndo.Enabled = true;
            }
        }

        private void mnuUndo_Click(object sender, EventArgs e)
        {
            if(rTxtMain.CanUndo)
            {
                rTxtMain.Undo();
                mnuRedo.Enabled = true;



            }

            if (rTxtMain.CanUndo) mnuUndo.Enabled = true;
            else mnuUndo.Enabled = false;

        }

        private void mnuCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }

        private void mnuCut_Click(object sender, EventArgs e)
        {
            Cut();
        }

        private void mnuPaste_Click(object sender, EventArgs e)
        {
            Paste();
        }

        public void Copy()
        {
            rTxtMain.Copy();
        }
        public void Cut()
        {
            rTxtMain.Cut();
        }

        public void Paste()
        {
            rTxtMain.Paste();
        }

        private void mnuAlignLeft_Click(object sender, EventArgs e)
        {
            rTxtMain.SelectionAlignment = HorizontalAlignment.Left;
            mnuAlignLeft.Checked = true;
            mnuAlignLeft.Checked = false;
            mnuAlignCenter.Checked = false;

        }

        private void mnuAlignRight_Click(object sender, EventArgs e)
        {
            rTxtMain.SelectionAlignment = HorizontalAlignment.Right;
            mnuAlignLeft.Checked = false;
            mnuAlignRight.Checked = true;
            mnuAlignCenter.Checked = false;

        }

        private void mnuAlignCenter_Click(object sender, EventArgs e)
        {
            rTxtMain.SelectionAlignment = HorizontalAlignment.Center;
            mnuAlignLeft.Checked = false;
            mnuAlignRight.Checked = false;
            mnuAlignCenter.Checked = true;
        }

        private void mnuFont_Click(object sender, EventArgs e)
        {
            fontDialog1.Color = rTxtMain.SelectionColor;
            fontDialog1.Font = rTxtMain.SelectionFont;

            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                rTxtMain.SelectionColor = fontDialog1.Color;
                rTxtMain.SelectionFont = fontDialog1.Font;
            }
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            FindForm myFinder = new FindForm();
            myFinder.Owner = this;

            myFinder.Show();
        }

        public void Search(string strKeyword, bool flagCase, bool flagDown)
        {
            RichTextBoxFinds myFindOption = new RichTextBoxFinds();

            myFindOption = 0;
            int startPositon =0;
            int finalPosition = rTxtMain.Text.Length;

            if (flagCase) myFindOption += 4;
            if (!flagDown) {
                myFindOption += 16;
                startPositon = 0;
                finalPosition = rTxtMain.SelectionStart + rTxtMain.SelectionLength;
            }else
            {
                startPositon = rTxtMain.SelectionStart + rTxtMain.SelectionLength;
                finalPosition = rTxtMain.Text.Length;
            }

            int keywordPostion = rTxtMain.Find(strKeyword, startPositon, myFindOption);


            if(keywordPostion >-1)
            {
                rTxtMain.Select(keywordPostion, strKeyword.Length);
            }else
            {
                MessageBox.Show("찾는 문자열이 없습니다.", "알림");
            }
        }
    }
}
