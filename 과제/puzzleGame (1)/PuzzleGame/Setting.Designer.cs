namespace PuzzleGame
{
    partial class Setting
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnImage = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoRight = new System.Windows.Forms.RadioButton();
            this.rdoCenter = new System.Windows.Forms.RadioButton();
            this.rdoLeft = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoBottom = new System.Windows.Forms.RadioButton();
            this.rdoMiddle = new System.Windows.Forms.RadioButton();
            this.rdoTop = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtImageSize = new System.Windows.Forms.TextBox();
            this.cboCol = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "퍼즐게임 설정";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "게임이미지 보기";
            // 
            // btnImage
            // 
            this.btnImage.Location = new System.Drawing.Point(62, 58);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(167, 23);
            this.btnImage.TabIndex = 2;
            this.btnImage.Text = "이미지파일 불러오기";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.Setting_Load);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoRight);
            this.groupBox1.Controls.Add(this.rdoCenter);
            this.groupBox1.Controls.Add(this.rdoLeft);
            this.groupBox1.Location = new System.Drawing.Point(62, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "가로방향 기준";
            // 
            // rdoRight
            // 
            this.rdoRight.AutoSize = true;
            this.rdoRight.Location = new System.Drawing.Point(164, 31);
            this.rdoRight.Name = "rdoRight";
            this.rdoRight.Size = new System.Drawing.Size(59, 16);
            this.rdoRight.TabIndex = 2;
            this.rdoRight.Text = "오른쪽";
            this.rdoRight.UseVisualStyleBackColor = true;
            // 
            // rdoCenter
            // 
            this.rdoCenter.AutoSize = true;
            this.rdoCenter.Checked = true;
            this.rdoCenter.Location = new System.Drawing.Point(88, 31);
            this.rdoCenter.Name = "rdoCenter";
            this.rdoCenter.Size = new System.Drawing.Size(59, 16);
            this.rdoCenter.TabIndex = 1;
            this.rdoCenter.TabStop = true;
            this.rdoCenter.Text = "가운데";
            this.rdoCenter.UseVisualStyleBackColor = true;
            // 
            // rdoLeft
            // 
            this.rdoLeft.AutoSize = true;
            this.rdoLeft.Location = new System.Drawing.Point(19, 31);
            this.rdoLeft.Name = "rdoLeft";
            this.rdoLeft.Size = new System.Drawing.Size(47, 16);
            this.rdoLeft.TabIndex = 0;
            this.rdoLeft.Text = "왼쪽";
            this.rdoLeft.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoBottom);
            this.groupBox2.Controls.Add(this.rdoMiddle);
            this.groupBox2.Controls.Add(this.rdoTop);
            this.groupBox2.Location = new System.Drawing.Point(62, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "세로방향 기준";
            // 
            // rdoBottom
            // 
            this.rdoBottom.AutoSize = true;
            this.rdoBottom.Location = new System.Drawing.Point(164, 31);
            this.rdoBottom.Name = "rdoBottom";
            this.rdoBottom.Size = new System.Drawing.Size(47, 16);
            this.rdoBottom.TabIndex = 2;
            this.rdoBottom.Text = "아래";
            this.rdoBottom.UseVisualStyleBackColor = true;
            // 
            // rdoMiddle
            // 
            this.rdoMiddle.AutoSize = true;
            this.rdoMiddle.Checked = true;
            this.rdoMiddle.Location = new System.Drawing.Point(88, 31);
            this.rdoMiddle.Name = "rdoMiddle";
            this.rdoMiddle.Size = new System.Drawing.Size(59, 16);
            this.rdoMiddle.TabIndex = 1;
            this.rdoMiddle.TabStop = true;
            this.rdoMiddle.Text = "가운데";
            this.rdoMiddle.UseVisualStyleBackColor = true;
            // 
            // rdoTop
            // 
            this.rdoTop.AutoSize = true;
            this.rdoTop.Location = new System.Drawing.Point(19, 31);
            this.rdoTop.Name = "rdoTop";
            this.rdoTop.Size = new System.Drawing.Size(35, 16);
            this.rdoTop.TabIndex = 0;
            this.rdoTop.Text = "위";
            this.rdoTop.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtImageSize);
            this.groupBox3.Controls.Add(this.cboCol);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(62, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 104);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "게임설정";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(173, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "픽셀";
            // 
            // txtImageSize
            // 
            this.txtImageSize.Location = new System.Drawing.Point(116, 63);
            this.txtImageSize.Name = "txtImageSize";
            this.txtImageSize.Size = new System.Drawing.Size(51, 21);
            this.txtImageSize.TabIndex = 3;
            this.txtImageSize.Text = "100";
            this.txtImageSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cboCol
            // 
            this.cboCol.FormattingEnabled = true;
            this.cboCol.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.cboCol.Location = new System.Drawing.Point(116, 24);
            this.cboCol.Name = "cboCol";
            this.cboCol.Size = new System.Drawing.Size(45, 20);
            this.cboCol.TabIndex = 2;
            this.cboCol.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "이미지크기:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "퍼즐 컬럼수 :";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(73, 398);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 6;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(189, 398);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "취소";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(360, 58);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(419, 363);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picImage.TabIndex = 8;
            this.picImage.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Setting";
            this.Text = "퍼즐게임 설정";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoRight;
        private System.Windows.Forms.RadioButton rdoCenter;
        private System.Windows.Forms.RadioButton rdoLeft;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdoBottom;
        private System.Windows.Forms.RadioButton rdoMiddle;
        private System.Windows.Forms.RadioButton rdoTop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtImageSize;
        private System.Windows.Forms.ComboBox cboCol;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}