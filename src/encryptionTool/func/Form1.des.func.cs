using Jareds.Common;
using Jareds.Common.Encrypt;
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace encryptionTool
{
    public partial class Form1
    {
        private byte[] GetDesKeyBytes()
        {
            string keyString = txt_des_key.Text.Trim();
            byte[] key = null;
            if (radio_des_key_format_ascii.Checked)
            {
                key = Encoding.ASCII.GetBytes(keyString);
            }
            else if (radio_des_key_format_base64.Checked)
            {
                key = Convert.FromBase64String(keyString);
            }
            else
            {
                key = keyString.HexString2ByteArray();
            }
            return key;
        }
        private void btnDesEncrypt_Click(object sender, EventArgs e)
        {
            string plainText = txt_des_plain.Text.Trim();
            string cipher = string.Empty;
            byte[] key = GetDesKeyBytes();
            var cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbox_des_cipher_mode.SelectedItem.ToString());
            var paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), cbox_des_padding_mode.SelectedItem.ToString());
            if (radio_des_type_1des.Checked)
            {

                var des = new DesEncodeDecode(
                    Encoding.ASCII.GetString(key),
                    cipherMode,
                    paddingMode);
                var buff = des.DesEncrypt(GetDesPlainEncoding().GetBytes(plainText));
                cipher = GetDesCipherEncode().Encode(buff);
            }
            else if (radio_des_type_3des.Checked)
            {
                MemoryStream mStream = new MemoryStream();
                TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
                tripleDESCryptoServiceProvider.Key = key;
                tripleDESCryptoServiceProvider.Padding = paddingMode;//补位
                tripleDESCryptoServiceProvider.Mode = cipherMode;//CipherMode.CBC
                CryptoStream cStream = new CryptoStream(mStream,
                    tripleDESCryptoServiceProvider.CreateEncryptor(),
                    CryptoStreamMode.Write);

                byte[] toEncrypt = Encoding.UTF8.GetBytes(plainText);

                cStream.Write(toEncrypt, 0, toEncrypt.Length);
                cStream.FlushFinalBlock();

                byte[] ret = mStream.ToArray();

                cStream.Close();
                mStream.Close();
                cipher = GetDesCipherEncode().Encode(ret);
            }
            else
            {
                var base64Res = TripleDesEncodeDecode.TwiceDesEncrypt(key.ByteArray2HexString(), plainText);
                cipher = GetDesCipherEncode().Encode(Convert.FromBase64String(base64Res));
            }
            txt_des_cipher.Text = cipher;
        }

        private void btnDesDecrypt_Click(object sender, EventArgs e)
        {
            byte[] cipherBytes = GetDesCipherEncode().Decode(txt_des_cipher.Text.Trim());
            byte[] key = GetDesKeyBytes();
            CipherMode cipherMode = (CipherMode)Enum.Parse(typeof(CipherMode), cbox_des_cipher_mode.SelectedItem.ToString());
            PaddingMode paddingMode = (PaddingMode)Enum.Parse(typeof(PaddingMode), cbox_des_padding_mode.SelectedItem.ToString());
            if (radio_des_type_1des.Checked)
            {
                var des = new DesEncodeDecode(
                    txt_des_key.Text.Trim(),
                    cipherMode,
                    paddingMode,
                    radio_des_key_format_hex.Checked);
                cipherBytes = des.DesDecrypt(cipherBytes);
            }
            else if (radio_des_type_3des.Checked)
            {
                MemoryStream msDecrypt = new MemoryStream(cipherBytes);

                TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
                tripleDESCryptoServiceProvider.Key = key;
                tripleDESCryptoServiceProvider.Padding = paddingMode;//补位
                tripleDESCryptoServiceProvider.Mode = cipherMode;//CipherMode.CBC
                CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                    tripleDESCryptoServiceProvider.CreateDecryptor(),
                    CryptoStreamMode.Read);

                cipherBytes = new byte[cipherBytes.Length];

                csDecrypt.Read(cipherBytes, 0, cipherBytes.Length);
            }
            else
            {
                var base64Res = TripleDesEncodeDecode.TwiceDesDescrypt(key.ByteArray2HexString(), Convert.ToBase64String(cipherBytes));
                cipherBytes = Convert.FromBase64String(base64Res);
            }
            string plain = GetDesPlainEncoding().GetString(cipherBytes);
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
