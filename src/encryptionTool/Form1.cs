using encryptionTool.Common;
using Jareds.Common;
using Jareds.Common.Encrypt;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptionTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            IniFile iniFile = IniFile.Read(Path.Combine(AppContext.BaseDirectory, "setting.ini"));
            InitializeComponent();
            cbox_des_plain_encode.SelectedIndex = 0;
            cbox_des_cipher_encode.SelectedIndex = 0;
            cbox_aes_plain_encode.SelectedIndex = 0;
            cbox_des_padding_mode.SelectedIndex = 1;
            cbox_des_cipher_mode.SelectedIndex = 1;
            cb_aes_cipher_mode.SelectedIndex = 1;
            cb_aes_padding_mode.SelectedIndex = 1;
            txt_sign_key.Text = iniFile?.GetSection("signature")?.GetValue("key");
            txtJwtSeed.Text = iniFile?.GetSection("token")?.GetValue("seed");
            cb_passwd_length.SelectedIndex = 5;
        }
        #region aes
        private void btn_aes_encrypt_Click(object sender, EventArgs e)
        {
            byte[] keyBytes = getAesKeyBytes();
            string hexKeyString = keyBytes.ByteArray2HexString();
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
            string hexKeyString = keyBytes.ByteArray2HexString();
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
            var result = MD5Provider.Encode(buff);
            txt_md5_cipher.Text = result.ByteArray2HexString();
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
            string cipher = buff.ByteArray2HexString();
            txt_sha_cipher.Text = cipher;
        }

        private void btnSha256_Click(object sender, EventArgs e)
        {
            var athm = System.Security.Cryptography.SHA256.Create();
            var buff = athm.ComputeHash(GetSHAEncoding().GetBytes(txt_sha_plain.Text.Trim()));
            string cipher = buff.ByteArray2HexString();
            txt_sha_cipher.Text = cipher;
        }

        private void btnSha512_Click(object sender, EventArgs e)
        {
            var athm = System.Security.Cryptography.SHA512.Create();
            var buff = athm.ComputeHash(GetSHAEncoding().GetBytes(txt_sha_plain.Text.Trim()));
            string cipher = buff.ByteArray2HexString();
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
            var image = qrcode.QrImage(txt_qrcode_text.Text.Trim());

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
            string signature = MD5Provider.Encode(sourceData);
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

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            this.txtJwtDecodeJson.Text = null;
            this.txtJwtDecodeJson.Visible = false;
            if (e.TabPage.Name == "tabPage_timestamp")
            {
                cts = new CancellationTokenSource();
                txtCurTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                txtCurTimeStamp.Text = DateTimeOffset.Now.ToUnixTimeSeconds().ToString();
                this.btnStopTimeTicks.Text = "停止";
                _ = RefreshTimestamp(cts.Token);
            }
            else
            {
                cts?.Cancel();
            }
        }
        private async Task RefreshTimestamp(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                var now = DateTime.Now;
                this.Invoke((MethodInvoker)delegate
                {
                    this.lbl_current_time.Text = now.ToString();
                    this.lbl_current_timestamp.Text = new DateTimeOffset(now).ToUnixTimeSeconds().ToString();
                });
                await Task.Delay(1000);
            }
        }
        CancellationTokenSource cts = null;
        private void btnStopTimeTicks_Click(object sender, EventArgs e)
        {
            if (cts == null)
            {
                this.btnStopTimeTicks.Text = "停止";
                cts = new CancellationTokenSource();
                _ = RefreshTimestamp(cts.Token);
            }
            else
            {
                cts.Cancel();
                cts = null;
                this.btnStopTimeTicks.Text = "开始";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            cts?.Cancel();
            cts = null;
        }

        private void btnTicksToTime_Click(object sender, EventArgs e)
        {
            txtCurTimeStampTransform.Text = DateTimeOffset.FromUnixTimeSeconds(Convert.ToInt64(txtCurTimeStamp.Text)).LocalDateTime.ToString("yyyy-MM-dd HH:mm:ss");
        }

        private void btnTimeToTicks_Click(object sender, EventArgs e)
        {
            txtCurTimeTransform.Text = new DateTimeOffset(Convert.ToDateTime(txtCurTime.Text)).ToUnixTimeSeconds().ToString();
        }

        private void btnSensitiveDecode_Click(object sender, EventArgs e)
        {
            string token = txtJwtToken.Text;
            if (!string.IsNullOrEmpty(token))
            {
                if (token.StartsWith("Bearer "))
                {
                    token = token[7..];
                }
                JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
                var res = handler.ReadJwtToken(token);
                var dict = new Dictionary<string, string>();
                string[] encodedItemNames = { "id", "name", "sid", "stid" };
                foreach (var claim in res.Claims)
                {
                    if (claim.Type == "ticket")
                    {
                        txtJwtTickets.Text = claim.Value;
                        dict.Add(claim.Type, claim.Value);
                    }
                    else if (encodedItemNames.Contains(claim.Type))
                    {
                        dict.Add(claim.Type, Encoding.UTF8.GetString(Base58.Decode(claim.Value[1..])));
                    }
                    else
                    {
                        dict.Add(claim.Type, claim.Value);
                    }
                }
                this.txtJwtDecodeJson.Text = JsonConvert.SerializeObject(dict);
                this.txtJwtDecodeJson.Visible = true;
            }
            string cipher = txtJwtSensitiveCipher.Text;
            if (!string.IsNullOrEmpty(cipher))
            {
                string key = MD5Provider.Encode(txtJwtSeed.Text + txtJwtTickets.Text);
                if (cipher.StartsWith("ZYS_"))
                {
                    cipher = cipher[4..];
                }
                byte[] byteArray = Base58.Decode(cipher);
                DesEncodeDecode des = new DesEncodeDecode(key, CipherMode.ECB, PaddingMode.PKCS7, false);
                var buffer = des.DesDecrypt(byteArray);
                string str = Encoding.UTF8.GetString(buffer);
                txtSensitivePlainText.Text = str;
            }
        }

        private void btnGeneratePasswd_Click(object sender, EventArgs e)
        {
            string[] bigCase = new string[26];
            string[] smallCase = new string[26];
            string[] numbers = new string[10];
            string[] specialChars = { "!", "@", "#", "$", "%", "^", "&", "*", "(", ")" };
            for (int i = 0; i < 26; i++)
            {
                bigCase[i] = ((char)(i + 65)).ToString();
                smallCase[i] = ((char)(i + 97)).ToString();
                if (i < 10)
                {
                    numbers[i] = i.ToString();
                }
            }
            List<string> pool = new List<string>();
            if (cb_bigCase.Checked)
            {
                pool.AddRange(bigCase);
            }
            if (cb_smallCase.Checked)
            {
                pool.AddRange(smallCase);
            }
            if (cb_numbers.Checked)
            {
                pool.AddRange(numbers);
            }
            if (cb_special_char.Checked)
            {
                pool.AddRange(specialChars);
            }
            int length = int.Parse(cb_passwd_length.SelectedItem.ToString());
            StringBuilder sb = new StringBuilder();
            Random r = new Random();
            for (int i = 0; i < length; i++)
            {
                sb.Append(pool[r.Next(pool.Count)]);
            }
            txtPasswordOutput.Text = sb.ToString();
        }
    }
}
