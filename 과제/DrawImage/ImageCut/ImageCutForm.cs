using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCut
{
    public partial class ImageCutForm : Form
    {
        // ✅ 멤버 변수
        Bitmap imgBitmap;
        int imgCount = -1;
        int imgTot = 1;
        string filename = null;

        public ImageCutForm()
        {
            InitializeComponent();
        }

        private void ImageCutForm_Load(object sender, EventArgs e)
        {
            imgTot = int.Parse(cboX.Text) * int.Parse(cboY.Text);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (filename == null) return;

                imgBitmap = new Bitmap(filename);
                this.Width = imgBitmap.Width + 18;
                this.Height = imgBitmap.Height + 40;

                imgCount = -1;
                DrawImage(imgCount);
            }
        }

        private void DrawImage(int icnt)
        {
            if (imgBitmap == null) return;

            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            if (icnt == -1)
            {
                g.DrawImage(imgBitmap, 0, 0);
            }
            else
            {
                Image croppedImage = ImgCrop(icnt);
                if (croppedImage == null)
                {
                    MessageBox.Show("이미지 자르기 중 오류가 발생했습니다.");
                    return;
                }

                // 자른 이미지를 화면에 꽉 채우기
                int width = croppedImage.Width;
                int height = croppedImage.Height;
                float ratio = Math.Min((float)this.ClientSize.Width / width, (float)this.ClientSize.Height / height);
                int newWidth = (int)(width * ratio);
                int newHeight = (int)(height * ratio);

                g.DrawImage(croppedImage, 0, 0, newWidth, newHeight);
            }

            g.Dispose();
        }

        // ✅ 제시된 번호에 해당하는 영역의 이미지를 자름
        private Image ImgCrop(int icnt)
        {
            // 원본이면 그냥 return
            if (icnt < 0)
            {
                this.Text = "이미지 자르기:" + filename + " (원본)";
                return imgBitmap;
            }

            // ✅ 이미지의 크기를 구함
            int oWidth = imgBitmap.Width;
            int oHeight = imgBitmap.Height;

            //

            int width = oWidth / int.Parse(cboX.Text);
            int height = oHeight / int.Parse(cboY.Text);

            // ✅ 이미지 시작 위치 계산 (열, 행)
         
            int x = (icnt % int.Parse(cboX.Text))* width;
            int y = (icnt / int.Parse(cboY.Text)) * height;

            // ✅ Form의 Text 변경 (현재 자른 이미지 위치 표시)
            this.Text = "이미지 자르기 " + filename +
                        " (" + (icnt / int.Parse(cboY.Text)).ToString() + "," +(icnt % int.Parse(cboX.Text)).ToString() + ")";

            // ✅ 빈 비트맵 이미지를 만들고
            Bitmap imgReturn = new Bitmap(width, height, PixelFormat.Format24bppRgb);

            // ✅ 그래픽 객체 생성 후 선택된 영역 복사
            Graphics gr = Graphics.FromImage(imgReturn);
            gr.DrawImage(imgBitmap,
                new Rectangle(0, 0, width, height),   // 대상 위치 (새 이미지 전체)
                new Rectangle(x, y, width, height),   // 원본에서 잘라낼 위치
                GraphicsUnit.Pixel);
            gr.Dispose();

            return imgReturn;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // ✅ 그림 번호를 하나씩 증가시킴. 최종 그림에 도달하면 0번으로
            imgCount = (imgCount + 1) % imgTot;

            // ✅ 그림을 그림
            DrawImage(imgCount);

            btnOk.Text = "다음";
        }

        private void btnOriginal_Click(object sender, EventArgs e)
        {
            // ✅ 그림 번호를 -1로 지정하면 원본 그림 보기
            imgCount = -1;

            // 그림이 없으면 그냥 return
            if (imgBitmap == null) return;

            // 그림을 그림
            DrawImage(imgCount);

            btnOk.Text = "자르기";
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            // 잘린 이미지의 총 수 수정
            imgTot = int.Parse(cboX.Text) * int.Parse(cboY.Text);

            // 원본 이미지 보기
            imgCount = -1;

            // 그림이 없으면 그냥 return
            if (imgBitmap == null) return;

            // 그림 보기
            DrawImage(imgCount);

            btnOk.Text = "자르기";
        }

    }

}

