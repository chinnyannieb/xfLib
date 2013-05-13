using System.Drawing;
using System.Drawing.Imaging;

namespace xf
{
    //下面这两个函数还没有.NET中Bitmap类中的函数效率高，所以这个就没有存在的意义了
    /// <summary>
    ///操作图像的类
    /// </summary>
    public class ControlBitmap
    {
        public static Color GetPiexl(Bitmap image, int x, int y)
        {
            int r, g, b;
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* c = (byte*)data.Scan0 + x * 3 + y * data.Stride;
                r = *(c + 2);
                g = *(c + 1);
                b = *c;
            }
            image.UnlockBits(data);
            return Color.FromArgb(r, g, b);
        }

        public static void SetPiexl(Bitmap image, int x, int y, Color color)
        {
            BitmapData data = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
            unsafe
            {
                byte* c = (byte*)data.Scan0 + x * 3 + y * data.Stride;
                *(c + 2) = color.R;
                *(c + 1) = color.G;
                *c = color.B;
            }
            image.UnlockBits(data);
        }
    }
}