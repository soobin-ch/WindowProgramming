namespace ImageCut
{
    partial class ImageCutForm
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.cboX = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboY = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnOriginal = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(9, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(105, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "이미지선택";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // cboX
            // 
            this.cboX.FormattingEnabled = true;
            this.cboX.Location = new System.Drawing.Point(135, 6);
            this.cboX.Name = "cboX";
            this.cboX.Size = new System.Drawing.Size(59, 23);
            this.cboX.TabIndex = 1;
            this.cboX.Text = "3";
            this.cboX.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // cboY
            // 
            this.cboY.FormattingEnabled = true;
            this.cboY.Location = new System.Drawing.Point(222, 5);
            this.cboY.Name = "cboY";
            this.cboY.Size = new System.Drawing.Size(80, 23);
            this.cboY.TabIndex = 3;
            this.cboY.Text = "3";
            this.cboY.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(338, 9);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "자르기";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnOriginal
            // 
            this.btnOriginal.Location = new System.Drawing.Point(442, 12);
            this.btnOriginal.Name = "btnOriginal";
            this.btnOriginal.Size = new System.Drawing.Size(75, 23);
            this.btnOriginal.TabIndex = 5;
            this.btnOriginal.Text = "원본보기";
            this.btnOriginal.UseVisualStyleBackColor = true;
            this.btnOriginal.Click += new System.EventHandler(this.btnOriginal_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ImageCutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOriginal);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboX);
            this.Controls.Add(this.btnOpen);
            this.Name = "ImageCutForm";
            this.Text = "이미지 자르기";
            this.Load += new System.EventHandler(this.ImageCutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.ComboBox cboX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboY;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnOriginal;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

