using System;
using System.Drawing;
using System.IO;
using ThoughtWorks.QRCode.Codec;

namespace encryptionTool
{
    public class QrCodeGeneration
    {
        public Bitmap QrImage(string text)
        {
            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 14;
            qrCodeEncoder.QRCodeVersion = 12;
            string qrCodeErrorCorrect = "H";
            switch (qrCodeErrorCorrect)
            {
                case "H":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.H;
                    break;
                case "L":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
                    break;
                case "M":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
                    break;
                case "Q":
                    qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.Q;
                    break;
            }
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            Bitmap bmPhoto = qrCodeEncoder.Encode(text, System.Text.Encoding.GetEncoding("UTF-8"));
            return bmPhoto;
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
