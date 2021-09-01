using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GC_Panel
{
    public partial class SliderShow : UserControl
    {
        // Time to code
        private Bitmap image1 = GC_Panel.Properties.Resources._1;
        // image1 = image 1 in resources as sortcut of call
        // GC_Panel are my namespace user yours
        private Bitmap image2 = GC_Panel.Properties.Resources._2;
        // image2 = image 2 in resources as sortcut of call
        private Bitmap image3 = GC_Panel.Properties.Resources._3;
        // image3 = image 3 in resources as sortcut of call
        private Bitmap image4 = GC_Panel.Properties.Resources._4;
        // image4 = image 4 in resources as sortcut of call


        public SliderShow()
        {
            InitializeComponent();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            // call order now
            if (Wallpapers.Image == image1)
            {
                Wallpapers.Image = image2;
                // change image from image 1 into image2
            }
            else if (Wallpapers.Image == image2)
            {
                Wallpapers.Image = image3;
                // change image from image 2 into image3
            }
            else if (Wallpapers.Image == image3)
            {
                Wallpapers.Image = image4;
                // change image from image 3 into image4
            }
            else
            {
                Wallpapers.Image = image1;
                // back into first state image1
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // call order now
            if (Wallpapers.Image == image1)
            {
                Wallpapers.Image = image4;
                // change image from image 1 into image4
            }
            else if (Wallpapers.Image == image4)
            {
                Wallpapers.Image = image3;
                // change image from image 4 into image3
            }
            else if (Wallpapers.Image == image3)
            {
                Wallpapers.Image = image2;
                // change image from image 3 into image2
            }
            else
            {
                Wallpapers.Image = image1;
                // back into first state image1
            }
        }
    }
}
