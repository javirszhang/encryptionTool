using Javirs.Common;
using Javirs.Common.Security;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbox_des_plain_encode.SelectedIndex = 0;
            cbox_des_cipher_encode.SelectedIndex = 0;
            cbox_aes_plain_encode.SelectedIndex = 0;
            cbox_des_padding_mode.SelectedIndex = 1;
            cbox_des_cipher_mode.SelectedIndex = 1;
            cb_aes_cipher_mode.SelectedIndex = 1;
            cb_aes_padding_mode.SelectedIndex = 1;
            txt_sign_key.Text = ConfigurationManager.AppSettings["api_sign_key"];
        }
        #region aes
        private void btn_aes_encrypt_Click(object sender, EventArgs e)
        {
            byte[] keyBytes = getAesKeyBytes();
            string hexKeyString = keyBytes.Byte2HexString();
            AesCryptoProvider aes = new AesCryptoProvider(hexKeyString, check_aes_random.Checked);
            aes.CipherMode = GetAesCipherMode();
            aes.PaddingMode = GetAesPaddingMode();
            var buff = aes.Encrypt(GetAesPlainEncoding().GetBytes(txt_aes_plain.Text.Trim()));
            string cihper = GetAesCipherEncode().Encode(buff);
            txt_aes_cipher.Text = cihper;
        }
        private CipherMode GetAesCipherMode()
        {
            string text = cb_aes_cipher_mode.SelectedItem.ToString();
            return (CipherMode)Enum.Parse(typeof(CipherMode), text, true);
        }
        private PaddingMode GetAesPaddingMode()
        {
            string text = cb_aes_padding_mode.SelectedItem.ToString();
            return (PaddingMode)Enum.Parse(typeof(PaddingMode), text, true);
        }
        private byte[] getAesKeyBytes()
        {
            string keyString = txt_aes_key.Text.Trim();
            byte[] buffer;
            if (radio_aes_key_format_ascii.Checked)
            {
                buffer = Encoding.ASCII.GetBytes(keyString);
            }
            else if (radio_aes_key_format_base64.Checked)
            {
                buffer = Convert.FromBase64String(keyString);
            }
            else if (radio_aes_key_format_hex.Checked)
            {
                buffer = keyString.HexString2ByteArray();
            }
            else
            {
                buffer = Convert.FromBase64String(keyString);
            }
            return buffer;
        }
        private ICipherEncode GetAesCipherEncode()
        {
            ICipherEncode encode = null;
            if (radio_aes_cipher_encode_base58.Checked)
            {
                encode = new Base58CipherEncode();
            }
            if (radio_aes_cipher_encode_base64.Checked)
            {
                encode = new Base64CipherEncode();
            }
            if (radio_aes_cipher_encode_hex.Checked)
            {
                encode = new HexCipherEncode();
            }
            return encode;
        }
        private Encoding GetAesPlainEncoding()
        {
            return Encoding.GetEncoding(cbox_aes_plain_encode.SelectedItem.ToString());
        }
        private void btn_aes_decrypt_Click(object sender, EventArgs e)
        {
            byte[] keyBytes = getAesKeyBytes();
            string hexKeyString = keyBytes.Byte2HexString();
            AesCryptoProvider aes = new AesCryptoProvider(hexKeyString, check_aes_random.Checked);
            aes.CipherMode = GetAesCipherMode();
            aes.PaddingMode = GetAesPaddingMode();
            var buff = aes.Decrypt(GetAesCipherEncode().Decode(txt_aes_cipher.Text.Trim()));
            string plain = GetAesPlainEncoding().GetString(buff);
            txt_aes_plain.Text = plain;
        }
        #endregion
        #region base58
        private void btnBase58Encode_Click(object sender, EventArgs e)
        {
            var buff = GetBase58PlainEncoding().GetBytes(txt_base58_plain.Text.Trim());
            string cipher = Base58.Encode(buff);
            txt_base58_cipher.Text = cipher;
        }
        private Encoding GetBase58PlainEncoding()
        {
            return radio_base58_ascii.Checked ? Encoding.ASCII : radio_base58_gbk.Checked ? Encoding.GetEncoding("GBK") : Encoding.UTF8;
        }
        private void btnBase58Decode_Click(object sender, EventArgs e)
        {
            var buff = Base58.Decode(txt_base58_cipher.Text.Trim());
            string plain = GetBase58PlainEncoding().GetString(buff);
            txt_base58_plain.Text = plain;
        }
        #endregion
        #region base64
        private void btnBase64Encode_Click(object sender, EventArgs e)
        {
            var buff = GetBase64PlainEncoding().GetBytes(txt_base64_plain.Text.Trim());
            string cipher = Convert.ToBase64String(buff);
            txt_base64_cipher.Text = cipher;
        }
        private Encoding GetBase64PlainEncoding()
        {
            return radio_base64_ascii.Checked ? Encoding.ASCII : radio_base64_gbk.Checked ? Encoding.GetEncoding("GBK") : Encoding.UTF8;
        }
        private void btnBase64Decode_Click(object sender, EventArgs e)
        {
            var buff = Convert.FromBase64String(txt_base64_cipher.Text.Trim());
            string plain = GetBase64PlainEncoding().GetString(buff);
            txt_base64_plain.Text = plain;
        }
        #endregion
        #region md5
        private void btnMd5Encode_Click(object sender, EventArgs e)
        {
            var buff = GetMD5Encoding().GetBytes(txt_md5_plain.Text.Trim());
            var result = Javirs.Common.Security.MD5.Encode(buff);
            txt_md5_cipher.Text = result.Byte2HexString();
        }
        private Encoding GetMD5Encoding()
        {
            return radio_md5_ascii.Checked ? Encoding.ASCII : radio_md5_utf8.Checked ? Encoding.UTF8 : Encoding.GetEncoding("GBK");
        }
        #endregion
        #region sha
        private void btnSha1_Click(object sender, EventArgs e)
        {
            var athm = System.Security.Cryptography.SHA1.Create();
            var buff = athm.ComputeHash(GetSHAEncoding().GetBytes(txt_sha_plain.Text.Trim()));
            string cipher = buff.Byte2HexString();
            txt_sha_cipher.Text = cipher;
        }

        private void btnSha256_Click(object sender, EventArgs e)
        {
            var athm = System.Security.Cryptography.SHA256.Create();
            var buff = athm.ComputeHash(GetSHAEncoding().GetBytes(txt_sha_plain.Text.Trim()));
            string cipher = buff.Byte2HexString();
            txt_sha_cipher.Text = cipher;
        }

        private void btnSha512_Click(object sender, EventArgs e)
        {
            var athm = System.Security.Cryptography.SHA512.Create();
            var buff = athm.ComputeHash(GetSHAEncoding().GetBytes(txt_sha_plain.Text.Trim()));
            string cipher = buff.Byte2HexString();
            txt_sha_cipher.Text = cipher;
        }
        private Encoding GetSHAEncoding()
        {
            return radio_sha_ascii.Checked ? Encoding.ASCII : radio_sha_utf8.Checked ? Encoding.UTF8 : Encoding.GetEncoding("GBK");
        }
        #endregion
        #region urlencode
        private void btnUrlEncode_Click(object sender, EventArgs e)
        {
            string cipher = System.Web.HttpUtility.UrlEncode(txt_urlencode_plain.Text.Trim(), GetUrlEncoding());
            txt_urlencode_cipher.Text = cipher;
        }

        private void btnUrlDecode_Click(object sender, EventArgs e)
        {
            string plain = System.Web.HttpUtility.UrlDecode(txt_urlencode_cipher.Text.Trim(), GetUrlEncoding());
            txt_urlencode_plain.Text = plain;
        }
        private Encoding GetUrlEncoding()
        {
            return radio_urlencode_ascii.Checked ? Encoding.ASCII : radio_urlencode_utf8.Checked ? Encoding.UTF8 : Encoding.GetEncoding("GBK");
        }
        #endregion

        private void btnQrCodeGenerate_Click(object sender, EventArgs e)
        {
            QrCodeGeneration qrcode = new QrCodeGeneration();
            Stream stream = qrcode.QrImage(txt_qrcode_text.Text.Trim());
            Bitmap image = new Bitmap(stream);

            picQrCode.Image = image;
            picQrCode.Width = image.Width > 469 ? 469 : image.Width;
            picQrCode.Height = image.Height > 469 ? 469 : image.Height;
            picQrCode.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_sign_calculate_Click(object sender, EventArgs e)
        {
            string sourceData = "";
            if (!string.IsNullOrEmpty(txt_sign_service.Text.Trim()))
            {
                sourceData += "service=" + txt_sign_service.Text.Trim() + "&";
            }
            sourceData += "path=" + txt_sign_path.Text.Trim() + "&";
            sourceData += "timestamp=" + txt_sign_timestamp.Text.Trim() + "&";
            if (!string.IsNullOrEmpty(txt_sign_token.Text.Trim()))
            {
                sourceData += "token=" + txt_sign_token.Text.Trim() + "&";
            }
            if (!string.IsNullOrEmpty(txt_sign_body.Text.Trim()))
            {
                sourceData += "body=" + txt_sign_body.Text.Trim() + "&";
            }
            sourceData += "key=" + txt_sign_key.Text.Trim();
            txt_sign_sourcedata.Text = sourceData;
            string signature = Javirs.Common.Security.MD5.Encode(sourceData);
            txt_sign_sign.Text = signature;
        }

        private void btn_gen_guid_Click(object sender, EventArgs e)
        {
            int count = int.Parse(txt_guid_count.Text.Trim());
            bool upperCase = cb_guid_case.Checked;
            bool split = cb_guid_nosplit.Checked;
            bool arround = cb_guid_suffix.Checked;
            StringBuilder builder = new StringBuilder();
            for (var i = 1; i <= count; i++)
            {
                string format = split ? "N" : null;
                var g = Guid.NewGuid().ToString(format);
                if (upperCase)
                {
                    g = g.ToUpper();
                }
                if (arround)
                {
                    g = string.Concat("{", g, "}");
                }
                builder.AppendLine(g);
            }
            txt_guid.Text = builder.ToString();
        }
    }
}
