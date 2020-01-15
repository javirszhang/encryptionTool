using Javirs.Common.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryptionTool
{
    public partial class Form1
    {
        //private string xmlPrivateKey;
        //private string xmlPublicKey;
        private Encoding GetRsaPlainEncoding()
        {
            return radio_plain_encode_ascii.Checked ? Encoding.ASCII : radio_plain_encode_utf8.Checked ? Encoding.UTF8 : Encoding.GetEncoding("GBK");
        }
        private ICipherEncode GetRsaCipherEncode() => radio_cipher_encode_hex.Checked ? new HexCipherEncode() : radio_cipher_encode_base58.Checked ? (ICipherEncode)new Base58CipherEncode() : new Base64CipherEncode();
        private void DisplayKeyPair()
        {
            string toFormat = "xml";
            if (radio_rsa_key_format_pem.Checked)
            {
                toFormat = "pkcs1";
            }
            else if (radio_rsa_key_format_pem_pkcs8.Checked)
            {
                toFormat = "pkcs8";
            }
            if (!string.IsNullOrEmpty(txt_public_key.Text.Trim()))
            {
                txt_public_key.Text = TransformKeyFormat(txt_public_key.Text.Trim(), false, toFormat);
            }
            if (!string.IsNullOrEmpty(txt_private_key.Text.Trim()))
            {
                txt_private_key.Text = TransformKeyFormat(txt_private_key.Text.Trim(), true, toFormat);
            }
        }
        /// <summary>
        /// 转换密钥格式
        /// </summary>
        /// <param name="keyString"></param>
        /// <param name="isPrivate"></param>
        /// <param name="toFormat"></param>
        /// <returns></returns>
        private static string TransformKeyFormat(string keyString, bool isPrivate, string toFormat)
        {
            string fromFormat = DetectKeyStringFormat(keyString, isPrivate);
            if (fromFormat == toFormat)
            {
                return keyString;
            }
            RsaKeyHelper helper = null;
            if (fromFormat == "xml")
            {
                helper = RsaKeyHelper.FromXmlKey(keyString);
            }
            else if (fromFormat == "pkcs1")
            {
                keyString = isPrivate ? RsaKeyHelper.FormatPrivateKey(keyString, RsaKeyHelper.KeyFormat.pkcs1) : RsaKeyHelper.FormatPublicKey(keyString);
                helper = RsaKeyHelper.FromPemKeyString(keyString);
            }
            else if (fromFormat == "pkcs8")
            {
                keyString = isPrivate ? RsaKeyHelper.FormatPrivateKey(keyString, RsaKeyHelper.KeyFormat.pkcs8) : RsaKeyHelper.FormatPublicKey(keyString);
                helper = RsaKeyHelper.FromPemKeyString(keyString);
            }
            if (helper == null)
            {
                return keyString;
            }
            string res = keyString;
            if (toFormat == "xml")
            {
                res = helper.ToXmlString(isPrivate);
            }
            else if (toFormat == "pkcs1")
            {
                helper.Format = RsaKeyHelper.KeyFormat.pkcs1;
                res = helper.GetKeyString(isPrivate);
            }
            else if (toFormat == "pkcs8")
            {
                helper.Format = RsaKeyHelper.KeyFormat.pkcs8;
                res = helper.GetKeyString(isPrivate);
            }
            return res;
        }

        /// <summary>
        /// 检测密钥格式
        /// </summary>
        /// <returns></returns>
        private static string DetectKeyStringFormat(string keyString, bool isPrivate)
        {
            if (keyString.StartsWith("<RSAKeyValue>"))
            {
                return "xml";
            }
            if (!isPrivate)//公钥不分pkcs1或pkcs8，只有私钥才有pkcs1和pkcs8区分
            {
                return "pkcs1";
            }
            if (keyString.StartsWith("-----"))
            {
                if (keyString.Contains("BEGIN RSA PRIVATE KEY"))
                {
                    return "pkcs1";
                }
                else if (keyString.Contains("BEGIN PRIVATE KEY"))
                {
                    return "pkcs8";
                }
                else
                {
                    return "unknown";
                }
            }
            byte[] keyBytes = Convert.FromBase64String(keyString);
            if (keyBytes[7] == 2)//第八个字节为【2】表示为pkcs1格式，【48】表示pkcs8格式
            {
                return "pkcs1";
            }
            else
            {
                return "pkcs8";
            }
        }
        private void btn_genrsa_Click(object sender, EventArgs e)
        {
            RsaCertificate.BuildRsaKey(out string privateKey, out string pubKey);
            txt_private_key.Text = privateKey;
            txt_public_key.Text = pubKey;
            DisplayKeyPair();
        }

        private void btn_rsa_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                txt_cert_folder.Text = dialog.SelectedPath;
            }
        }

        private void btn_read_pem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "pem密钥文件|*.pem";
            fileDialog.Multiselect = false;
            var dr = fileDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                var rsa = Javirs.Common.Security.PemCertificate.ReadFromPemFile(fileDialog.FileName);
                txt_private_key.Text = rsa.HasPrivateKey ? rsa.PrivateKey : null;
                txt_public_key.Text = rsa.PublicKey;
                DisplayKeyPair();
            }
        }

        private void btnReadX509_Click(object sender, EventArgs e)
        {
            try
            {
                string fullpath = Path.Combine(txt_cert_folder.Text.Trim(), txt_cert_name.Text.Trim());
                IRsa rsa;
                if (fullpath.ToLower().EndsWith(".pfx"))
                {
                    rsa = RsaCertificate.ReadFromPfx(fullpath, txt_cert_pwd.Text.Trim());
                }
                else
                {
                    rsa = RsaCertificate.ReadFromCert(fullpath);
                }
                txt_private_key.Text = rsa.HasPrivateKey ? rsa.PrivateKey : "";
                txt_public_key.Text = rsa.PublicKey;
                DisplayKeyPair();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRsaEncrypt_Click(object sender, EventArgs e)
        {
            string key = string.IsNullOrEmpty(txt_private_key.Text.Trim()) ? txt_public_key.Text.Trim() : txt_private_key.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("请设置密钥先");
                return;
            }
            try
            {
                IRsa rsa = GetRsaObject(false);
                var buffer = rsa.Encrypt(GetRsaPlainEncoding().GetBytes(txt_plain.Text.Trim()), false);

                string cipher = GetRsaCipherEncode().Encode(buffer);
                txt_cipher.Text = cipher;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRsaDecrypt_Click(object sender, EventArgs e)
        {
            string key = string.IsNullOrEmpty(txt_private_key.Text.Trim()) ? txt_public_key.Text.Trim() : txt_private_key.Text.Trim();
            if (string.IsNullOrEmpty(key))
            {
                MessageBox.Show("请设置密钥先");
                return;
            }
            if (string.IsNullOrEmpty(txt_cipher.Text.Trim()))
            {
                MessageBox.Show("请输入要解密的密文");
                return;
            }
            var buffer = GetRsaCipherEncode().Decode(txt_cipher.Text.Trim());
            try
            {
                IRsa rsa = GetRsaObject();
                var plain = rsa.Decrypt(buffer, false);
                txt_plain.Text = GetRsaPlainEncoding().GetString(plain);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRsaSign_Click(object sender, EventArgs e)
        {
            string althm = radio_sign_hash_md5.Checked ? "MD5" : radio_sign_hash_sha1.Checked ? "SHA1" : "SHA256";
            if (string.IsNullOrEmpty(txt_private_key.Text.Trim()))
            {
                MessageBox.Show("请设置私钥先");
                return;
            }
            if (string.IsNullOrEmpty(txt_plain.Text.Trim()))
            {
                MessageBox.Show("请设置明文");
                return;
            }
            try
            {
                IRsa rsa = GetRsaObject();
                string signature = rsa.SignData(Encoding.UTF8.GetBytes(txt_plain.Text.Trim()), althm);
                byte[] buffer = Convert.FromBase64String(signature);
                txt_signature.Text = GetRsaCipherEncode().Encode(buffer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private IRsa GetRsaObject(bool isPrivate = true)
        {
            string privateKey = txt_private_key.Text.Trim();
            string pubKey = txt_public_key.Text.Trim();
            string keyString = isPrivate ? privateKey : pubKey;
            if (isPrivate && string.IsNullOrEmpty(privateKey))
            {
                throw new Javirs.Common.Exceptions.InvalidKeyFormatException("请设置私钥先");
            }
            if (!isPrivate && string.IsNullOrEmpty(privateKey) && string.IsNullOrEmpty(pubKey))
            {
                throw new Javirs.Common.Exceptions.InvalidKeyFormatException("请设置密钥先");
            }
            if (radio_rsa_key_format_pem.Checked || radio_rsa_key_format_pem_pkcs8.Checked)
            {
                if (keyString.StartsWith("<"))
                {
                    throw new Javirs.Common.Exceptions.InvalidKeyFormatException("您设置的密钥可能是XML格式，请选择密钥格式");
                }
                return PemCertificate.ReadFromKeyString(keyString);
            }
            else
            {
                if (!keyString.StartsWith("<"))
                {
                    throw new Javirs.Common.Exceptions.InvalidKeyFormatException("您设置的密钥不是XML格式，请选择密钥格式");
                }
                return new RSAServiceProvider(keyString);
            }
        }
        private void btnRsaSignVerify_Click(object sender, EventArgs e)
        {
            string althm = radio_sign_hash_md5.Checked ? "MD5" : radio_sign_hash_sha1.Checked ? "SHA1" : "SHA256";
            if (string.IsNullOrEmpty(txt_public_key.Text.Trim()))
            {
                MessageBox.Show("请设置公钥先");
                return;
            }
            if (string.IsNullOrEmpty(txt_plain.Text.Trim()))
            {
                MessageBox.Show("请设置明文");
                return;
            }
            if (string.IsNullOrEmpty(txt_signature.Text.Trim()))
            {
                MessageBox.Show("请设置要验证的签名");
                return;
            }
            try
            {
                IRsa rsa = GetRsaObject(false);
                bool res = rsa.VerifyData(GetRsaPlainEncoding().GetBytes(txt_plain.Text.Trim()), GetRsaCipherEncode().Decode(txt_signature.Text.Trim()), althm);
                MessageBox.Show(res ? "签名验证OK" : "签名验证不正确");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBuildCert_Click(object sender, EventArgs e)
        {
            if (!File.Exists(txt_makecertpath.Text.Trim()))
            {
                MessageBox.Show($"无法创建证书，未能找到证书创建工具[{txt_makecertpath.Text}]");
                return;
            }
            if (string.IsNullOrEmpty(txt_cert_name.Text.Trim()) || string.IsNullOrEmpty(txt_cert_folder.Text.Trim()))
            {
                MessageBox.Show("请设置证书保存信息先");
                return;
            }
            bool res = RsaCertificate.CreateCertificate(txt_makecertpath.Text.Trim(), Path.GetFileNameWithoutExtension(txt_cert_name.Text.Trim()));
            MessageBox.Show(res ? "创建证书成功" : "创建证书失败");
        }

        private void btnExportPFX_Click(object sender, EventArgs e)
        {
            string name = txt_cert_name.Text.Trim();
            if (!name.Contains("."))
            {
                name += ".pfx";
            }
            string subject = Path.GetFileNameWithoutExtension(name);
            bool res = RsaCertificate.ExportPfxFile(subject, Path.Combine(txt_cert_folder.Text.Trim(), name), txt_cert_pwd.Text.Trim(), true);
            MessageBox.Show(res ? "导出证书成功" : "导出证书失败");
        }

        private void btnChooseCert_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "私钥证书文件|*.pfx|公钥证书文件|*.cer";
            dialog.Multiselect = false;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                string folder = Path.GetDirectoryName(fileName);
                string file = Path.GetFileName(fileName);
                txt_cert_folder.Text = folder;
                txt_cert_name.Text = file;
            }
        }

        private void btnExportCer_Click(object sender, EventArgs e)
        {
            string name = txt_cert_name.Text.Trim();
            if (!name.Contains("."))
            {
                name += ".cer";
            }
            string subject = Path.GetFileNameWithoutExtension(name);
            bool res = RsaCertificate.ExportCertFile(subject, Path.Combine(txt_cert_folder.Text.Trim(), name));
            MessageBox.Show(res ? "导出证书成功" : "导出证书失败");
        }

        private void OnKeyFormatChange(object sender, EventArgs e)
        {
            RadioButton btn = sender as RadioButton;
            if (btn == null || !btn.Checked)
            {
                return;
            }
            DisplayKeyPair();
        }
    }
}
