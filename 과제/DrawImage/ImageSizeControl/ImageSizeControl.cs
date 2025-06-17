using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageSizeControl
{
    public partial class ImageSizeControl: Form
    {

        int scale = 100;
        string filename = null;

        public ImageSizeControl()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            scale = int.Parse(cboScale.Text);

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                filename = openFileDialog1.FileName;
                if (filename == null) return;
            }

            DrawImage(scale, filename);
        }

        private void DrawImage(int scale, string filename)
        {
            Bitmap imgBitmap = new Bitmap(filename);
            this.Width = (int)((double)imgBitmap.Width * scale / 100) + 18;
            this.Height = (int)((double)imgBitmap.Height * scale / 100) + 40;

            Graphics g = this.CreateGraphics();
            g.Clear(Color.White);

            g.DrawImage( ImgByScale(scale, imgBitmap), 0, 0);
        }

        private Image ImgByScale(int scale, Image image)
        {
            int oWidth = image.Width;
            int oHeight = image.Height;

            int width = (int)((double)oWidth * scale / 100);
            int height = (int)((double)oHeight * scale / 100);

            Bitmap imgReturn = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            Graphics gr = Graphics.FromImage(imgReturn);

            gr.DrawImage(image, new Rectangle(0, 0, width, height), new Rectangle(0, 0, oWidth, oHeight), GraphicsUnit.Pixel);
            gr.Dispose();
            return imgReturn;
        }

        private void cboScale_SelectedIndexChanged(object sender, EventArgs e)
        {
            int scale = int.Parse(cboScale.Text);
            DrawImage(scale, filename);
        }
    }
}
