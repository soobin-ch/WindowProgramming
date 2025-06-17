using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawImage
{
    public partial class ImageForm: Form
    {
        public ImageForm()
        {
            InitializeComponent();
        }

        private void ImageForm_Load(object sender, EventArgs e)
        {
            Bitmap imgBitmap = new Bitmap("..\\..\\Images\\블랙핑크.jpg");
            Graphics g = this.CreateGraphics();
            g.DrawImage(imgBitmap, 0, 0);

        }

      

        private void ImageForm_Paint(object sender, PaintEventArgs e)
        {
        
            // 블랙핑크.jpg 파일로부터 Bitmap 객체 생성
            Bitmap imgBitmap = new Bitmap("..\\..\\..\\블랙핑크.jpg");

            // Graphics 객체를 생성
            Graphics g = this.CreateGraphics();

            // Bitmap 객체를 그림
            g.DrawImage(imgBitmap, 0, 0);
        

    }
}
}
