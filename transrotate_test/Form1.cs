using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transrotate_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            Bitmap b = new Bitmap(100, 100);
            pictureBox2.Image = b;
            Bitmap bmp = (Bitmap)imageList1.Images[trackBar1.Value];
            //Bitmap bmp = (Bitmap)pictureBox1.Image;
            Bitmap bmp2 = TransRotateBitmap.transrotate.makeTransparent_bmp(bmp, Color.FromArgb(255, 0, 255), 100);
            Bitmap bmp3 = (Bitmap)TransRotateBitmap.transrotate.RotateImage(bmp2, trackBar1.Value);

            pictureBox2.Image = bmp3;
        }
    }
}
