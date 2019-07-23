using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encryptionTool
{
    public class QrCodeGeneration
    {
        public Stream QrImage(string text)
        {
            var ms = new MemoryStream();
            ErrorCorrectionLevel Ecl = ErrorCorrectionLevel.M; //误差校正水平   
            string Content = text;//待编码内容  
            QuietZoneModules QuietZones = QuietZoneModules.Two;  //空白区域   
            int ModuleSize = 12;//大小  
            var encoder = new QrEncoder(Ecl);
            QrCode qr;
            if (encoder.TryEncode(Content, out qr))//对内容进行编码，并保存生成的矩阵  
            {
                FixedModuleSize fms = new FixedModuleSize(ModuleSize, QuietZones);//Color.FromArgb(1, 127, 38, 0)
                Brush darkBrush = new SolidBrush(TranslateHexToRGBColor("C8000000"));//(Color.FromArgb(127, 38, 0));
                Brush lightBrush = new SolidBrush(TranslateHexToRGBColor("00ffffff")); //Brushes.Transparent;
                var render = new GraphicsRenderer(fms, darkBrush, lightBrush);
                render.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
                return ms;
            }
            else
            {
                
                return null;
            }
        }

        /// <summary>
        /// 16进制字符串转换为颜色对象
        /// </summary>
        /// <param name="hexColor"></param>
        /// <returns></returns>
        public static System.Drawing.Color TranslateHexToRGBColor(string hexColor)
        {
            if (string.IsNullOrEmpty(hexColor))
            {
                return System.Drawing.Color.FromArgb(255, 0, 0, 0);
            }
            StringReader reader = new StringReader(hexColor);
            string a = "ff", r = "0", g = "0", b = "0";
            if (hexColor.Length == 6)
            {
                r = hexColor.Substring(0, 2);
                g = hexColor.Substring(2, 2);
                b = hexColor.Substring(4, 2);
            }
            else if (hexColor.Length == 3)
            {
                r = hexColor.Substring(0, 1);
                r = r.PadLeft(2, r[0]);
                g = hexColor.Substring(1, 1);
                g = r.PadLeft(2, g[0]);
                b = hexColor.Substring(2, 1);
                b = b.PadLeft(2, b[0]);
            }
            else if (hexColor.Length == 4)
            {
                a = hexColor.Substring(0, 1);
                a = a.PadLeft(2, a[0]);
                r = hexColor.Substring(1, 1);
                r = r.PadLeft(2, r[0]);
                g = hexColor.Substring(2, 1);
                g = g.PadLeft(2, g[0]);
                b = hexColor.Substring(3, 1);
                b = b.PadLeft(2, b[0]);
            }
            else if (hexColor.Length == 8)
            {
                a = hexColor.Substring(0, 2);
                r = hexColor.Substring(2, 2);
                g = hexColor.Substring(4, 2);
                b = hexColor.Substring(6, 2);
            }
            else
            {
                throw new ApplicationException("无效的颜色值");
            }
            return System.Drawing.Color.FromArgb(Convert.ToInt32(a, 16), Convert.ToInt32(r, 16), Convert.ToInt32(g, 16), Convert.ToInt32(b, 16));//argb
        }
    }
}
