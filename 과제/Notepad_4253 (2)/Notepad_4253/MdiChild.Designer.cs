namespace Notepad_4253
{
    partial class MdiChild
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSp1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUndo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRedo = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSp2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSp3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlign = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignRight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlignCenter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFont = new System.Windows.Forms.ToolStripMenuItem();
            this.rTxtMain = new System.Windows.Forms.RichTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuTool});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            this.menuStrip2.Visible = false;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSave,
            this.mnuPrint,
            this.mnuQuit,
            this.mnuSp1});
            this.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(61, 20);
            this.mnuFile.Text = "파일 (&F)";
            // 
            // mnuSave
            // 
            this.mnuSave.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuSave.MergeIndex = 2;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(158, 22);
            this.mnuSave.Text = "저장 (&S)";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuPrint
            // 
            this.mnuPrint.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuPrint.MergeIndex = 3;
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Size = new System.Drawing.Size(158, 22);
            this.mnuPrint.Text = "인쇄 (&P)";
            // 
            // mnuQuit
            // 
            this.mnuQuit.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.mnuQuit.MergeIndex = 4;
            this.mnuQuit.Name = "mnuQuit";
            this.mnuQuit.Size = new System.Drawing.Size(158, 22);
            this.mnuQuit.Text = "닫기 (&Q)";
            this.mnuQuit.Click += new System.EventHandler(this.mnuQuit_Click);
            // 
            // mnuSp1
            // 
            this.mnuSp1.MergeAction = System.Windows.Forms.MergeAction.Replace;
            this.mnuSp1.MergeIndex = 5;
            this.mnuSp1.Name = "mnuSp1";
            this.mnuSp1.Size = new System.Drawing.Size(155, 6);
            // 
            // mnuEdit
            // 
            this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUndo,
            this.mnuRedo,
            this.mnuSp2,
            this.mnuCopy,
            this.mnuCut,
            this.mnuPaste,
            this.mnuSp3,
            this.mnuFind});
            this.mnuEdit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(61, 20);
            this.mnuEdit.Text = "편집 (&E)";
            // 
            // mnuUndo
            // 
            this.mnuUndo.Name = "mnuUndo";
            this.mnuUndo.Size = new System.Drawing.Size(171, 22);
            this.mnuUndo.Text = "취소 (&U)";
            this.mnuUndo.Click += new System.EventHandler(this.mnuUndo_Click);
            // 
            // mnuRedo
            // 
            this.mnuRedo.Name = "mnuRedo";
            this.mnuRedo.Size = new System.Drawing.Size(171, 22);
            this.mnuRedo.Text = "되돌리기 (&R)";
            this.mnuRedo.Click += new System.EventHandler(this.mnuRedo_Click);
            // 
            // mnuSp2
            // 
            this.mnuSp2.Name = "mnuSp2";
            this.mnuSp2.Size = new System.Drawing.Size(168, 6);
            // 
            // mnuCopy
            // 
            this.mnuCopy.Name = "mnuCopy";
            this.mnuCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mnuCopy.Size = new System.Drawing.Size(171, 22);
            this.mnuCopy.Text = "복사 (&C)";
            this.mnuCopy.Click += new System.EventHandler(this.mnuCopy_Click);
            // 
            // mnuCut
            // 
            this.mnuCut.Name = "mnuCut";
            this.mnuCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mnuCut.Size = new System.Drawing.Size(171, 22);
            this.mnuCut.Text = "자르기 (&T)";
            this.mnuCut.Click += new System.EventHandler(this.mnuCut_Click);
            // 
            // mnuPaste
            // 
            this.mnuPaste.Name = "mnuPaste";
            this.mnuPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mnuPaste.Size = new System.Drawing.Size(171, 22);
            this.mnuPaste.Text = "붙이기 (&P)";
            this.mnuPaste.Click += new System.EventHandler(this.mnuPaste_Click);
            // 
            // mnuSp3
            // 
            this.mnuSp3.Name = "mnuSp3";
            this.mnuSp3.Size = new System.Drawing.Size(168, 6);
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.mnuFind.Size = new System.Drawing.Size(180, 22);
            this.mnuFind.Text = "찾기 (&F)";
            this.mnuFind.Click += new System.EventHandler(this.mnuFind_Click);
            // 
            // mnuTool
            // 
            this.mnuTool.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlign,
            this.mnuFont});
            this.mnuTool.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuTool.Name = "mnuTool";
            this.mnuTool.Size = new System.Drawing.Size(61, 20);
            this.mnuTool.Text = "도구 (&T)";
            // 
            // mnuAlign
            // 
            this.mnuAlign.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAlignLeft,
            this.mnuAlignRight,
            this.mnuAlignCenter});
            this.mnuAlign.Name = "mnuAlign";
            this.mnuAlign.Size = new System.Drawing.Size(180, 22);
            this.mnuAlign.Text = "정렬 (&A)";
            // 
            // mnuAlignLeft
            // 
            this.mnuAlignLeft.Name = "mnuAlignLeft";
            this.mnuAlignLeft.Size = new System.Drawing.Size(180, 22);
            this.mnuAlignLeft.Text = "좌측정렬 (&L)";
            this.mnuAlignLeft.Click += new System.EventHandler(this.mnuAlignLeft_Click);
            // 
            // mnuAlignRight
            // 
            this.mnuAlignRight.Name = "mnuAlignRight";
            this.mnuAlignRight.Size = new System.Drawing.Size(180, 22);
            this.mnuAlignRight.Text = "우측정렬 (&R)";
            this.mnuAlignRight.Click += new System.EventHandler(this.mnuAlignRight_Click);
            // 
            // mnuAlignCenter
            // 
            this.mnuAlignCenter.Name = "mnuAlignCenter";
            this.mnuAlignCenter.Size = new System.Drawing.Size(180, 22);
            this.mnuAlignCenter.Text = "가운데정렬 (&C)";
            this.mnuAlignCenter.Click += new System.EventHandler(this.mnuAlignCenter_Click);
            // 
            // mnuFont
            // 
            this.mnuFont.Name = "mnuFont";
            this.mnuFont.Size = new System.Drawing.Size(180, 22);
            this.mnuFont.Text = "글꼴 (&F)";
            this.mnuFont.Click += new System.EventHandler(this.mnuFont_Click);
            // 
            // rTxtMain
            // 
            this.rTxtMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtMain.Location = new System.Drawing.Point(0, 24);
            this.rTxtMain.Name = "rTxtMain";
            this.rTxtMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rTxtMain.Size = new System.Drawing.Size(800, 426);
            this.rTxtMain.TabIndex = 1;
            this.rTxtMain.Text = "";
            this.rTxtMain.TextChanged += new System.EventHandler(this.rTxtMain_TextChanged);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "서식있는 텍스트 문서(*.rtf)|*.rtf|텍스트 문서(*.txt)|*.txt";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // MdiChild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtMain);
            this.Controls.Add(this.menuStrip2);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MdiChild";
            this.Text = "이름없음-메모장";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripMenuItem mnuPrint;
        private System.Windows.Forms.ToolStripMenuItem mnuQuit;
        private System.Windows.Forms.ToolStripSeparator mnuSp1;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuUndo;
        private System.Windows.Forms.ToolStripMenuItem mnuRedo;
        private System.Windows.Forms.ToolStripSeparator mnuSp2;
        private System.Windows.Forms.ToolStripMenuItem mnuCopy;
        private System.Windows.Forms.ToolStripMenuItem mnuCut;
        private System.Windows.Forms.ToolStripMenuItem mnuPaste;
        private System.Windows.Forms.ToolStripSeparator mnuSp3;
        private System.Windows.Forms.ToolStripMenuItem mnuFind;
        private System.Windows.Forms.ToolStripMenuItem mnuTool;
        private System.Windows.Forms.ToolStripMenuItem mnuAlign;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignLeft;
        private System.Windows.Forms.ToolStripMenuItem mnuFont;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignRight;
        private System.Windows.Forms.ToolStripMenuItem mnuAlignCenter;
        private System.Windows.Forms.RichTextBox rTxtMain;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}