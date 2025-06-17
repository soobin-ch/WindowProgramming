using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzleGame
{
    public partial class Setting: Form
    {


        // 멤버변수 선언
        public int colNum = 0;
        public int imgSize = 0;
        public string filename = null;
        public int criteriaHorizontal = 1;
        public int criteriaVertical = 1;

        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;

                // 파일 이름이 없으면 리턴
                if (filename == null)
                    return;

                // 사진을 pictureBox에 그려줌
                picImage.Image = new Bitmap(filename);
                // DrawImage(filename);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboCol.Text = "3";
            txtImageSize.Text = "100";
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            colNum = int.Parse(cboCol.Text);
            imgSize = int.Parse(txtImageSize.Text);

            // 가로방향 자르기 기준
            if (rdoLeft.Checked)
                criteriaHorizontal = 0;
            if (rdoCenter.Checked)
                criteriaHorizontal = 1;
            if (rdoRight.Checked)
                criteriaHorizontal = 2;

            // 세로방향 자르기 기준
            if (rdoTop.Checked)
                criteriaVertical = 0;
            if (rdoMiddle.Checked)
                criteriaVertical = 1;
            if (rdoBottom.Checked)
                criteriaVertical = 2;

            // 확인 버튼을 눌렀음을 지정
            DialogResult = DialogResult.OK;
            return;
        }
    }
}
