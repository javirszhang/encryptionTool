using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace encryptionTool
{
    public partial class Form1
    {
        private void btnDesEncrypt_Click(object sender, EventArgs e)
        {
            var cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbox_des_cipher_mode.SelectedItem.ToString());
            var paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), cbox_des_padding_mode.SelectedItem.ToString());
            Javirs.Common.Security.DesEncodeDecode des = new Javirs.Common.Security.DesEncodeDecode(
                txt_des_key.Text.Trim(),
                cipherMode,
                paddingMode,
                radio_des_key_format_hex.Checked);
            var buff = des.DesEncrypt(GetDesPlainEncoding().GetBytes(txt_des_plain.Text.Trim()));
            string cipher = GetDesCipherEncode().Encode(buff);
            txt_des_cipher.Text = cipher;
        }

        private void btnDesDecrypt_Click(object sender, EventArgs e)
        {
            CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbox_des_cipher_mode.SelectedItem.ToString());
            PaddingMode paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), cbox_des_padding_mode.SelectedItem.ToString());
            Javirs.Common.Security.DesEncodeDecode des = new Javirs.Common.Security.DesEncodeDecode(
                txt_des_key.Text.Trim(),
                cipherMode,
                paddingMode,
                radio_des_key_format_hex.Checked);
            var buff = des.DesDecrypt(GetDesCipherEncode().Decode(txt_des_cipher.Text.Trim()));
            string plain = GetDesPlainEncoding().GetString(buff);
            txt_des_plain.Text = plain;
        }
        private ICipherEncode GetDesCipherEncode()
        {
            string cipherMode = cbox_des_cipher_encode.SelectedItem.ToString().ToLower();
            ICipherEncode encode = null;
            switch (cipherMode)
            {
                case "base64":
                    encode = new Base64CipherEncode();
                    break;
                case "base58":
                    encode = new Base58CipherEncode();
                    break;
                case "hex":
                    encode = new HexCipherEncode();
                    break;
            }
            return encode;
        }
        private Encoding GetDesPlainEncoding()
        {
            return Encoding.GetEncoding(cbox_des_plain_encode.SelectedItem.ToString());
        }
    }
}
