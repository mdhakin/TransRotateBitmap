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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //float AR = (float)pictureBox1.Width / (float)pictureBox1.Height;
            //float new_height = (float)pictureBox3.Height;

            //float fNew_width =AR*new_height;

            //int iNew_width = (int)fNew_width;

            pictureBox3.Width = TransRotateBitmap.transrotate.findNewWidthBasedOnNewHeight(pictureBox1.Width,pictureBox1.Height,pictureBox3.Height);

            Bitmap b = TransRotateBitmap.transrotate.makeTransparent_bmp((Bitmap)pictureBox1.Image, Color.FromArgb(255, 0, 255), 100);

            pictureBox3.Image = b;
        }

        private void propertyGrid1_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            listBox1.Items.Add(e.ChangedItem.ToString());
            listBox1.Items.Add(e.OldValue.ToString());
            listBox1.Items.Add(e.ChangedItem.Value.ToString());
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = pictureBox2;

            pictureBox3.Width = TransRotateBitmap.transrotate.findNewWidthBasedOnNewHeight(pictureBox1.Width, pictureBox1.Height, pictureBox3.Height);

            Bitmap b = TransRotateBitmap.transrotate.makeTransparent_bmp((Bitmap)pictureBox1.Image, Color.FromArgb(255, 0, 255), 100);

            pictureBox3.Image = b;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox2.Visible == false)
            {
                pictureBox2.Visible = true;
            }
            else
            {
                pictureBox2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }
           
        }
    }
}
