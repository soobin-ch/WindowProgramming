using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTest
{
    public partial class PaintForm: Form
    {

        private Bitmap imgBitmap = null;
        private Graphics g = null;
        private int width = 0, height = 0;

        private void PaintForm_Load(object sender, EventArgs e)
        {
            if (imgBitmap == null)
                imgBitmap = new Bitmap("..\\..\\..\\트와이스.jpg");
            this.width = (Width = imgBitmap.Width) + 18;
            this.height = (Height = imgBitmap.Height) + 40;

            g = this.CreateGraphics();
            g.Clear(Color.White);

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            g.DrawImage(imgBitmap, 0, 0, width, height);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.LightGray);
        }

        private void PaintForm_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(imgBitmap, 0, 0, width, height);
        }

        public PaintForm()
        {
            InitializeComponent();

        }
    }
}
