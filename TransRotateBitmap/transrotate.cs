using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TransRotateBitmap
{
    public static class transrotate
    {

        public static Bitmap makeTransparent_bmp(Bitmap bm, Color transcolor, int tolerance)
        {
            Bitmap bmp = bm.MakeTransparent(transcolor, tolerance);


            return bmp;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="wwidth"></param>
        /// <param name="hhight"></param>
        /// <param name="newHeight"></param>
        /// <returns></returns>
        public static int findNewWidthBasedOnNewHeight(int wwidth, int hhight, int newHeight)
        {
            float AR = (float)wwidth / (float)hhight;
            float new_height = (float)newHeight;

            float fNew_width = AR * newHeight;

            int iNew_width = (int)fNew_width;
            return iNew_width;
        }

        /// <summary>
        /// method to rotate an image either clockwise or counter-clockwise
        /// </summary>
        /// <param name="img">the image to be rotated</param>
        /// <param name="rotationAngle">the angle (in degrees).
        /// NOTE: 
        /// Positive values will rotate clockwise
        /// negative values will rotate counter-clockwise
        /// </param>
        /// <returns></returns>
        public static Image RotateImage(Image img, float rotationAngle)
        {
            //create an empty Bitmap image
            Bitmap bmp = new Bitmap(img.Width, img.Height);

            //turn the Bitmap into a Graphics object
            Graphics gfx = Graphics.FromImage(bmp);

            //now we set the rotation point to the center of our image
            gfx.TranslateTransform((float)bmp.Width / 2, (float)bmp.Height / 2);

            //now rotate the image
            gfx.RotateTransform(rotationAngle);

            gfx.TranslateTransform(-(float)bmp.Width / 2, -(float)bmp.Height / 2);

            //set the InterpolationMode to HighQualityBicubic so to ensure a high
            //quality image once it is transformed to the specified size
            gfx.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            //now draw our new image onto the graphics object
            gfx.DrawImage(img, new Point(0, 0));

            //dispose of our Graphics object
            gfx.Dispose();

            //return the image
            return bmp;
        }
    }

    public static class BitmapExtensions
    {
        public static Task<Bitmap> MakeTransparentAsync(this Bitmap image, Color transparentColor, int tolerance) => Task.Run(() => image.MakeTransparent(transparentColor, tolerance));
        public static Bitmap MakeTransparent(this Bitmap image, Color transparentColor, int tolerance)
        {
            var resultBitmap = new Bitmap(image);
            resultBitmap.ForEachPixel((i, j, pixelcolor) => {
                if (pixelcolor.IsCloseTo(transparentColor, tolerance))
                    resultBitmap.SetPixel(i, j, transparentColor);
            });
            resultBitmap.MakeTransparent(transparentColor);
            return resultBitmap;
        }

        public static void ForEachPixel(this Bitmap image, Action<int, int, Color> onPixel)
        {
            for (int i = image.Size.Width - 1; i >= 0; i--)
            {
                for (int j = image.Size.Height - 1; j >= 0; j--)
                {
                    onPixel(i, j, image.GetPixel(i, j));
                }
            }
        }

    }
}
