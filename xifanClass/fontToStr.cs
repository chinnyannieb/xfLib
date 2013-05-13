using System;
using System.Drawing;
using System.Text;

namespace xf
{
    public static class fontTransfer
    {
        public static  int strLength = 28;       //字体对象转换成的字符串的总长度

        public static string fontToStr(Font f,System.Drawing.KnownColor color )
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(((int)f.Style).ToString());       //第一个字符表示FontStyle
            sb.Append((f.Size).ToString().PadRight(5, ' '));    //五个字符表示FontSize，字体可能是5.25之类的小数
            sb.Append(f.Name.PadRight(20,' '));         //20个字符表示字体名称
            sb.Append(((int)color).ToString().PadRight(2,' '));     //两位的颜色值
            return sb.ToString();
        }

        public static Font strToFont(string str,ref System.Drawing.KnownColor color)
        {
            FontStyle fs = (FontStyle)Int32.Parse(str.Substring(0, 1));
            float fontSize = float.Parse(str.Substring(1,5).Trim());        //字体可能是小数
            string fontName = str.Substring(6,20).Trim();
            color =(System.Drawing.KnownColor)Int32.Parse(str.Substring(26).Trim());
            return new Font(fontName,fontSize,fs);
        }
    }
}