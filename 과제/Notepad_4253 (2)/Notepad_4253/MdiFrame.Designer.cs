namespace Notepad_4253
{
    partial class MdiFrame
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MdiFrame));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSp0 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTool = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbCut = new System.Windows.Forms.ToolStripButton();
            this.tsbPrint = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tstNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbFind = new System.Windows.Forms.ToolStripButton();
            this.tsbPaste = new System.Windows.Forms.ToolStripButton();
            this.tsbCopy = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssClock = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tssInform = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuTool,
            this.mnuWindow,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.mnuWindow;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNew,
            this.mnuOpen,
            this.mnuSp0,
            this.mnuExit});
            this.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(61, 20);
            this.mnuFile.Text = "파일 (&F)";
            // 
            // mnuNew
            // 
            this.mnuNew.MergeIndex = 0;
            this.mnuNew.Name = "mnuNew";
            this.mnuNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mnuNew.Size = new System.Drawing.Size(202, 22);
            this.mnuNew.Text = "새로 만들기 (&N)";
            this.mnuNew.Click += new System.EventHandler(this.mnuNew_Click);
            // 
            // mnuOpen
            // 
            this.mnuOpen.MergeIndex = 1;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(202, 22);
            this.mnuOpen.Text = "열기 (&O)";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSp0
            // 
            this.mnuSp0.MergeIndex = 5;
            this.mnuSp0.Name = "mnuSp0";
            this.mnuSp0.Size = new System.Drawing.Size(199, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.MergeIndex = 6;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mnuExit.Size = new System.Drawing.Size(202, 22);
            this.mnuExit.Text = "끝내기 (&X)";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuEdit
            // 
            this.mnuEdit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Size = new System.Drawing.Size(61, 20);
            this.mnuEdit.Text = "편집 (&E)";
            // 
            // mnuTool
            // 
            this.mnuTool.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
            this.mnuTool.Name = "mnuTool";
            this.mnuTool.Size = new System.Drawing.Size(61, 20);
            this.mnuTool.Text = "도구 (&T)";
            // 
            // mnuWindow
            // 
            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuHorizontal,
            this.mnuVertical,
            this.mnuIcon});
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(54, 20);
            this.mnuWindow.Text = "창 (&W)";
            // 
            // mnuCascade
            // 
            this.mnuCascade.Name = "mnuCascade";
            this.mnuCascade.Size = new System.Drawing.Size(155, 22);
            this.mnuCascade.Text = "계단 (&C)";
            this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
            // 
            // mnuHorizontal
            // 
            this.mnuHorizontal.Name = "mnuHorizontal";
            this.mnuHorizontal.Size = new System.Drawing.Size(155, 22);
            this.mnuHorizontal.Text = "가로바둑판 (&H)";
            this.mnuHorizontal.Click += new System.EventHandler(this.mnuHorizontal_Click);
            // 
            // mnuVertical
            // 
            this.mnuVertical.Name = "mnuVertical";
            this.mnuVertical.Size = new System.Drawing.Size(155, 22);
            this.mnuVertical.Text = "세로바둑판 (&V)";
            this.mnuVertical.Click += new System.EventHandler(this.mnuVertical_Click);
            // 
            // mnuIcon
            // 
            this.mnuIcon.Name = "mnuIcon";
            this.mnuIcon.Size = new System.Drawing.Size(155, 22);
            this.mnuIcon.Text = "아이콘 (&I)";
            this.mnuIcon.Click += new System.EventHandler(this.mnuIcon_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInformation});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(76, 20);
            this.mnuHelp.Text = "도움말 (&H)";
            // 
            // mnuInformation
            // 
            this.mnuInformation.Name = "mnuInformation";
            this.mnuInformation.Size = new System.Drawing.Size(180, 22);
            this.mnuInformation.Text = "메모장정보 (&A)";
            this.mnuInformation.Click += new System.EventHandler(this.mnuInformation_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstNew,
            this.tsbOpen,
            this.tsbSave,
            this.tsbPrint,
            this.toolStripSeparator1,
            this.tsbCut,
            this.tsbCopy,
            this.tsbPaste,
            this.toolStripSeparator2,
            this.tsbFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(861, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbCut
            // 
            this.tsbCut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCut.Image = ((System.Drawing.Image)(resources.GetObject("tsbCut.Image")));
            this.tsbCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCut.Name = "tsbCut";
            this.tsbCut.Size = new System.Drawing.Size(23, 22);
            this.tsbCut.Text = "toolStripButton1";
            this.tsbCut.ToolTipText = "자르기";
            this.tsbCut.Click += new System.EventHandler(this.tsbCut_Click);
            // 
            // tsbPrint
            // 
            this.tsbPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPrint.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrint.Image")));
            this.tsbPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrint.Name = "tsbPrint";
            this.tsbPrint.Size = new System.Drawing.Size(23, 22);
            this.tsbPrint.Text = "toolStripButton1";
            this.tsbPrint.ToolTipText = "인쇄";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 22);
            this.tsbSave.Text = "toolStripButton1";
            this.tsbSave.ToolTipText = "저장";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsbOpen.Image")));
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 22);
            this.tsbOpen.Text = "toolStripButton1";
            this.tsbOpen.ToolTipText = "열기";
            this.tsbOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // tstNew
            // 
            this.tstNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tstNew.Image = ((System.Drawing.Image)(resources.GetObject("tstNew.Image")));
            this.tstNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tstNew.Name = "tstNew";
            this.tstNew.Size = new System.Drawing.Size(23, 22);
            this.tstNew.Text = "toolStripButton1";
            this.tstNew.ToolTipText = "새로만들기";
            this.tstNew.Click += new System.EventHandler(this.tstNew_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbFind
            // 
            this.tsbFind.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbFind.Image = ((System.Drawing.Image)(resources.GetObject("tsbFind.Image")));
            this.tsbFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFind.Name = "tsbFind";
            this.tsbFind.Size = new System.Drawing.Size(23, 22);
            this.tsbFind.Text = "toolStripButton6";
            this.tsbFind.Click += new System.EventHandler(this.tsbFind_Click);
            // 
            // tsbPaste
            // 
            this.tsbPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPaste.Image = ((System.Drawing.Image)(resources.GetObject("tsbPaste.Image")));
            this.tsbPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPaste.Name = "tsbPaste";
            this.tsbPaste.Size = new System.Drawing.Size(23, 22);
            this.tsbPaste.Text = "toolStripButton6";
            this.tsbPaste.ToolTipText = "붙여넣기";
            this.tsbPaste.Click += new System.EventHandler(this.tsbPaste_Click);
            // 
            // tsbCopy
            // 
            this.tsbCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbCopy.Image = ((System.Drawing.Image)(resources.GetObject("tsbCopy.Image")));
            this.tsbCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCopy.Name = "tsbCopy";
            this.tsbCopy.Size = new System.Drawing.Size(23, 22);
            this.tsbCopy.Text = "toolStripButton6";
            this.tsbCopy.ToolTipText = "복사";
            this.tsbCopy.Click += new System.EventHandler(this.tsbCopy_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssInform,
            this.tssClock});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(861, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "동작정보를보여줍니다.";
            // 
            // tssClock
            // 
            this.tssClock.AutoSize = false;
            this.tssClock.Name = "tssClock";
            this.tssClock.Size = new System.Drawing.Size(694, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tssInform
            // 
            this.tssInform.Name = "tssInform";
            this.tssInform.Size = new System.Drawing.Size(121, 17);
            this.tssInform.Spring = true;
            this.tssInform.Text = "동작정보를 보여줍니다";
            this.tssInform.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MdiFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MdiFrame";
            this.Text = "메모장(두원공대 컴공과)";
            this.Load += new System.EventHandler(this.MdiFrame_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuNew;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripSeparator mnuSp0;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuEdit;
        private System.Windows.Forms.ToolStripMenuItem mnuTool;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuIcon;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuInformation;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tstNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbPrint;
        private System.Windows.Forms.ToolStripButton tsbCut;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbCopy;
        private System.Windows.Forms.ToolStripButton tsbPaste;
        private System.Windows.Forms.ToolStripButton tsbFind;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel tssClock;
        public System.Windows.Forms.ToolStripStatusLabel tssInform;
    }
}

