namespace encryptionTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage_rsa = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radio_cipher_encode_hex = new System.Windows.Forms.RadioButton();
            this.radio_cipher_encode_base58 = new System.Windows.Forms.RadioButton();
            this.radio_cipher_encode_base64 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radio_plain_encode_gbk = new System.Windows.Forms.RadioButton();
            this.radio_plain_encode_ascii = new System.Windows.Forms.RadioButton();
            this.radio_plain_encode_utf8 = new System.Windows.Forms.RadioButton();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radio_sign_hash_md5 = new System.Windows.Forms.RadioButton();
            this.radio_sign_hash_sha1 = new System.Windows.Forms.RadioButton();
            this.radio_sign_hash_sha256 = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReadX509 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radio_key_format_pem = new System.Windows.Forms.RadioButton();
            this.radio_key_format_xml = new System.Windows.Forms.RadioButton();
            this.btnRsaSignVerify = new System.Windows.Forms.Button();
            this.btnExportCer = new System.Windows.Forms.Button();
            this.btnExportPFX = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.btnBuildCert = new System.Windows.Forms.Button();
            this.btnRsaSign = new System.Windows.Forms.Button();
            this.btnRsaDecrypt = new System.Windows.Forms.Button();
            this.btnRsaEncrypt = new System.Windows.Forms.Button();
            this.btnChooseCert = new System.Windows.Forms.Button();
            this.btn_read_pem = new System.Windows.Forms.Button();
            this.btn_rsa_folder = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_makecertpath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cert_pwd = new System.Windows.Forms.TextBox();
            this.txt_cert_folder = new System.Windows.Forms.TextBox();
            this.txt_cert_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_signature = new System.Windows.Forms.TextBox();
            this.txt_cipher = new System.Windows.Forms.TextBox();
            this.txt_plain = new System.Windows.Forms.TextBox();
            this.txt_public_key = new System.Windows.Forms.TextBox();
            this.txt_private_key = new System.Windows.Forms.TextBox();
            this.btn_genrsa = new System.Windows.Forms.Button();
            this.tabPage_des = new System.Windows.Forms.TabPage();
            this.cbox_des_cipher_mode = new System.Windows.Forms.ComboBox();
            this.cbox_des_padding_mode = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.btnDesDecrypt = new System.Windows.Forms.Button();
            this.btnDesEncrypt = new System.Windows.Forms.Button();
            this.cbox_des_cipher_encode = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.radio_des_type_twicedes = new System.Windows.Forms.RadioButton();
            this.radio_des_type_1des = new System.Windows.Forms.RadioButton();
            this.radio_des_type_3des = new System.Windows.Forms.RadioButton();
            this.label19 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radio_des_key_format_base64 = new System.Windows.Forms.RadioButton();
            this.radio_des_key_format_hex = new System.Windows.Forms.RadioButton();
            this.radio_des_key_format_ascii = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.cbox_des_plain_encode = new System.Windows.Forms.ComboBox();
            this.txt_des_cipher = new System.Windows.Forms.TextBox();
            this.txt_des_plain = new System.Windows.Forms.TextBox();
            this.txt_des_key = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tabPage_aes = new System.Windows.Forms.TabPage();
            this.radio_aes_cipher_encode_base58 = new System.Windows.Forms.RadioButton();
            this.radio_aes_cipher_encode_hex = new System.Windows.Forms.RadioButton();
            this.radio_aes_cipher_encode_base64 = new System.Windows.Forms.RadioButton();
            this.cbox_aes_plain_encode = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btn_aes_decrypt = new System.Windows.Forms.Button();
            this.btn_aes_encrypt = new System.Windows.Forms.Button();
            this.txt_aes_cipher = new System.Windows.Forms.TextBox();
            this.txt_aes_plain = new System.Windows.Forms.TextBox();
            this.txt_aes_key = new System.Windows.Forms.TextBox();
            this.check_aes_random = new System.Windows.Forms.CheckBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.tabPage_base58 = new System.Windows.Forms.TabPage();
            this.radio_base58_gbk = new System.Windows.Forms.RadioButton();
            this.radio_base58_ascii = new System.Windows.Forms.RadioButton();
            this.radio_base58_utf8 = new System.Windows.Forms.RadioButton();
            this.txt_base58_cipher = new System.Windows.Forms.TextBox();
            this.btnBase58Decode = new System.Windows.Forms.Button();
            this.btnBase58Encode = new System.Windows.Forms.Button();
            this.txt_base58_plain = new System.Windows.Forms.TextBox();
            this.tabPage_base64 = new System.Windows.Forms.TabPage();
            this.btnBase64Decode = new System.Windows.Forms.Button();
            this.btnBase64Encode = new System.Windows.Forms.Button();
            this.txt_base64_cipher = new System.Windows.Forms.TextBox();
            this.txt_base64_plain = new System.Windows.Forms.TextBox();
            this.radio_base64_gbk = new System.Windows.Forms.RadioButton();
            this.radio_base64_ascii = new System.Windows.Forms.RadioButton();
            this.radio_base64_utf8 = new System.Windows.Forms.RadioButton();
            this.tabPage_md5 = new System.Windows.Forms.TabPage();
            this.btnMd5Encode = new System.Windows.Forms.Button();
            this.txt_md5_cipher = new System.Windows.Forms.TextBox();
            this.txt_md5_plain = new System.Windows.Forms.TextBox();
            this.radio_md5_gbk = new System.Windows.Forms.RadioButton();
            this.radio_md5_ascii = new System.Windows.Forms.RadioButton();
            this.radio_md5_utf8 = new System.Windows.Forms.RadioButton();
            this.tabPage_sha = new System.Windows.Forms.TabPage();
            this.btnSha256 = new System.Windows.Forms.Button();
            this.btnSha512 = new System.Windows.Forms.Button();
            this.btnSha1 = new System.Windows.Forms.Button();
            this.txt_sha_cipher = new System.Windows.Forms.TextBox();
            this.txt_sha_plain = new System.Windows.Forms.TextBox();
            this.radio_sha_gbk = new System.Windows.Forms.RadioButton();
            this.radio_sha_ascii = new System.Windows.Forms.RadioButton();
            this.radio_sha_utf8 = new System.Windows.Forms.RadioButton();
            this.tabPage_urlencode = new System.Windows.Forms.TabPage();
            this.btnUrlDecode = new System.Windows.Forms.Button();
            this.btnUrlEncode = new System.Windows.Forms.Button();
            this.txt_urlencode_cipher = new System.Windows.Forms.TextBox();
            this.txt_urlencode_plain = new System.Windows.Forms.TextBox();
            this.radio_urlencode_gbk = new System.Windows.Forms.RadioButton();
            this.radio_urlencode_ascii = new System.Windows.Forms.RadioButton();
            this.radio_urlencode_utf8 = new System.Windows.Forms.RadioButton();
            this.tabControl.SuspendLayout();
            this.tabPage_rsa.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage_des.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabPage_aes.SuspendLayout();
            this.tabPage_base58.SuspendLayout();
            this.tabPage_base64.SuspendLayout();
            this.tabPage_md5.SuspendLayout();
            this.tabPage_sha.SuspendLayout();
            this.tabPage_urlencode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage_rsa);
            this.tabControl.Controls.Add(this.tabPage_des);
            this.tabControl.Controls.Add(this.tabPage_aes);
            this.tabControl.Controls.Add(this.tabPage_base58);
            this.tabControl.Controls.Add(this.tabPage_base64);
            this.tabControl.Controls.Add(this.tabPage_md5);
            this.tabControl.Controls.Add(this.tabPage_sha);
            this.tabControl.Controls.Add(this.tabPage_urlencode);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl.ItemSize = new System.Drawing.Size(80, 35);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(915, 667);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage_rsa
            // 
            this.tabPage_rsa.Controls.Add(this.panel4);
            this.tabPage_rsa.Controls.Add(this.panel3);
            this.tabPage_rsa.Controls.Add(this.label13);
            this.tabPage_rsa.Controls.Add(this.label12);
            this.tabPage_rsa.Controls.Add(this.panel2);
            this.tabPage_rsa.Controls.Add(this.label11);
            this.tabPage_rsa.Controls.Add(this.btnReadX509);
            this.tabPage_rsa.Controls.Add(this.panel1);
            this.tabPage_rsa.Controls.Add(this.btnRsaSignVerify);
            this.tabPage_rsa.Controls.Add(this.btnExportCer);
            this.tabPage_rsa.Controls.Add(this.btnExportPFX);
            this.tabPage_rsa.Controls.Add(this.label10);
            this.tabPage_rsa.Controls.Add(this.btnBuildCert);
            this.tabPage_rsa.Controls.Add(this.btnRsaSign);
            this.tabPage_rsa.Controls.Add(this.btnRsaDecrypt);
            this.tabPage_rsa.Controls.Add(this.btnRsaEncrypt);
            this.tabPage_rsa.Controls.Add(this.btnChooseCert);
            this.tabPage_rsa.Controls.Add(this.btn_read_pem);
            this.tabPage_rsa.Controls.Add(this.btn_rsa_folder);
            this.tabPage_rsa.Controls.Add(this.label9);
            this.tabPage_rsa.Controls.Add(this.txt_makecertpath);
            this.tabPage_rsa.Controls.Add(this.label8);
            this.tabPage_rsa.Controls.Add(this.label7);
            this.tabPage_rsa.Controls.Add(this.label6);
            this.tabPage_rsa.Controls.Add(this.txt_cert_pwd);
            this.tabPage_rsa.Controls.Add(this.txt_cert_folder);
            this.tabPage_rsa.Controls.Add(this.txt_cert_name);
            this.tabPage_rsa.Controls.Add(this.label5);
            this.tabPage_rsa.Controls.Add(this.label4);
            this.tabPage_rsa.Controls.Add(this.label3);
            this.tabPage_rsa.Controls.Add(this.label2);
            this.tabPage_rsa.Controls.Add(this.label1);
            this.tabPage_rsa.Controls.Add(this.txt_signature);
            this.tabPage_rsa.Controls.Add(this.txt_cipher);
            this.tabPage_rsa.Controls.Add(this.txt_plain);
            this.tabPage_rsa.Controls.Add(this.txt_public_key);
            this.tabPage_rsa.Controls.Add(this.txt_private_key);
            this.tabPage_rsa.Controls.Add(this.btn_genrsa);
            this.tabPage_rsa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_rsa.Location = new System.Drawing.Point(4, 39);
            this.tabPage_rsa.Name = "tabPage_rsa";
            this.tabPage_rsa.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_rsa.Size = new System.Drawing.Size(907, 624);
            this.tabPage_rsa.TabIndex = 0;
            this.tabPage_rsa.Text = "RSA";
            this.tabPage_rsa.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radio_cipher_encode_hex);
            this.panel4.Controls.Add(this.radio_cipher_encode_base58);
            this.panel4.Controls.Add(this.radio_cipher_encode_base64);
            this.panel4.Location = new System.Drawing.Point(86, 287);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 20);
            this.panel4.TabIndex = 41;
            // 
            // radio_cipher_encode_hex
            // 
            this.radio_cipher_encode_hex.AutoSize = true;
            this.radio_cipher_encode_hex.Location = new System.Drawing.Point(143, 2);
            this.radio_cipher_encode_hex.Name = "radio_cipher_encode_hex";
            this.radio_cipher_encode_hex.Size = new System.Drawing.Size(41, 16);
            this.radio_cipher_encode_hex.TabIndex = 2;
            this.radio_cipher_encode_hex.Text = "HEX";
            this.radio_cipher_encode_hex.UseVisualStyleBackColor = true;
            // 
            // radio_cipher_encode_base58
            // 
            this.radio_cipher_encode_base58.AutoSize = true;
            this.radio_cipher_encode_base58.Location = new System.Drawing.Point(73, 2);
            this.radio_cipher_encode_base58.Name = "radio_cipher_encode_base58";
            this.radio_cipher_encode_base58.Size = new System.Drawing.Size(59, 16);
            this.radio_cipher_encode_base58.TabIndex = 1;
            this.radio_cipher_encode_base58.Text = "BASE58";
            this.radio_cipher_encode_base58.UseVisualStyleBackColor = true;
            // 
            // radio_cipher_encode_base64
            // 
            this.radio_cipher_encode_base64.AutoSize = true;
            this.radio_cipher_encode_base64.Checked = true;
            this.radio_cipher_encode_base64.Location = new System.Drawing.Point(3, 2);
            this.radio_cipher_encode_base64.Name = "radio_cipher_encode_base64";
            this.radio_cipher_encode_base64.Size = new System.Drawing.Size(59, 16);
            this.radio_cipher_encode_base64.TabIndex = 0;
            this.radio_cipher_encode_base64.TabStop = true;
            this.radio_cipher_encode_base64.Text = "BASE64";
            this.radio_cipher_encode_base64.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radio_plain_encode_gbk);
            this.panel3.Controls.Add(this.radio_plain_encode_ascii);
            this.panel3.Controls.Add(this.radio_plain_encode_utf8);
            this.panel3.Location = new System.Drawing.Point(86, 253);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 20);
            this.panel3.TabIndex = 40;
            // 
            // radio_plain_encode_gbk
            // 
            this.radio_plain_encode_gbk.AutoSize = true;
            this.radio_plain_encode_gbk.Location = new System.Drawing.Point(143, 2);
            this.radio_plain_encode_gbk.Name = "radio_plain_encode_gbk";
            this.radio_plain_encode_gbk.Size = new System.Drawing.Size(41, 16);
            this.radio_plain_encode_gbk.TabIndex = 2;
            this.radio_plain_encode_gbk.Text = "GBK";
            this.radio_plain_encode_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_plain_encode_ascii
            // 
            this.radio_plain_encode_ascii.AutoSize = true;
            this.radio_plain_encode_ascii.Location = new System.Drawing.Point(70, 2);
            this.radio_plain_encode_ascii.Name = "radio_plain_encode_ascii";
            this.radio_plain_encode_ascii.Size = new System.Drawing.Size(53, 16);
            this.radio_plain_encode_ascii.TabIndex = 1;
            this.radio_plain_encode_ascii.Text = "ASCII";
            this.radio_plain_encode_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_plain_encode_utf8
            // 
            this.radio_plain_encode_utf8.AutoSize = true;
            this.radio_plain_encode_utf8.Checked = true;
            this.radio_plain_encode_utf8.Location = new System.Drawing.Point(3, 2);
            this.radio_plain_encode_utf8.Name = "radio_plain_encode_utf8";
            this.radio_plain_encode_utf8.Size = new System.Drawing.Size(47, 16);
            this.radio_plain_encode_utf8.TabIndex = 0;
            this.radio_plain_encode_utf8.TabStop = true;
            this.radio_plain_encode_utf8.Text = "UTF8";
            this.radio_plain_encode_utf8.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 291);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 39;
            this.label13.Text = "密文编码";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 12);
            this.label12.TabIndex = 38;
            this.label12.Text = "明文编码";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio_sign_hash_md5);
            this.panel2.Controls.Add(this.radio_sign_hash_sha1);
            this.panel2.Controls.Add(this.radio_sign_hash_sha256);
            this.panel2.Location = new System.Drawing.Point(86, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 20);
            this.panel2.TabIndex = 37;
            // 
            // radio_sign_hash_md5
            // 
            this.radio_sign_hash_md5.AutoSize = true;
            this.radio_sign_hash_md5.Location = new System.Drawing.Point(3, 3);
            this.radio_sign_hash_md5.Name = "radio_sign_hash_md5";
            this.radio_sign_hash_md5.Size = new System.Drawing.Size(41, 16);
            this.radio_sign_hash_md5.TabIndex = 27;
            this.radio_sign_hash_md5.Text = "MD5";
            this.radio_sign_hash_md5.UseVisualStyleBackColor = true;
            // 
            // radio_sign_hash_sha1
            // 
            this.radio_sign_hash_sha1.AutoSize = true;
            this.radio_sign_hash_sha1.Checked = true;
            this.radio_sign_hash_sha1.Location = new System.Drawing.Point(61, 3);
            this.radio_sign_hash_sha1.Name = "radio_sign_hash_sha1";
            this.radio_sign_hash_sha1.Size = new System.Drawing.Size(47, 16);
            this.radio_sign_hash_sha1.TabIndex = 27;
            this.radio_sign_hash_sha1.TabStop = true;
            this.radio_sign_hash_sha1.Text = "SHA1";
            this.radio_sign_hash_sha1.UseVisualStyleBackColor = true;
            // 
            // radio_sign_hash_sha256
            // 
            this.radio_sign_hash_sha256.AutoSize = true;
            this.radio_sign_hash_sha256.Location = new System.Drawing.Point(125, 2);
            this.radio_sign_hash_sha256.Name = "radio_sign_hash_sha256";
            this.radio_sign_hash_sha256.Size = new System.Drawing.Size(59, 16);
            this.radio_sign_hash_sha256.TabIndex = 27;
            this.radio_sign_hash_sha256.Text = "SHA256";
            this.radio_sign_hash_sha256.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 342);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 12);
            this.label11.TabIndex = 36;
            this.label11.Text = "选择密钥格式";
            // 
            // btnReadX509
            // 
            this.btnReadX509.Location = new System.Drawing.Point(3, 203);
            this.btnReadX509.Name = "btnReadX509";
            this.btnReadX509.Size = new System.Drawing.Size(86, 33);
            this.btnReadX509.TabIndex = 35;
            this.btnReadX509.Text = "读取X509证书";
            this.btnReadX509.UseVisualStyleBackColor = true;
            this.btnReadX509.Click += new System.EventHandler(this.btnReadX509_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_key_format_pem);
            this.panel1.Controls.Add(this.radio_key_format_xml);
            this.panel1.Location = new System.Drawing.Point(86, 338);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 20);
            this.panel1.TabIndex = 34;
            // 
            // radio_key_format_pem
            // 
            this.radio_key_format_pem.AutoSize = true;
            this.radio_key_format_pem.Location = new System.Drawing.Point(95, 3);
            this.radio_key_format_pem.Name = "radio_key_format_pem";
            this.radio_key_format_pem.Size = new System.Drawing.Size(89, 16);
            this.radio_key_format_pem.TabIndex = 32;
            this.radio_key_format_pem.Text = "PEM格式密钥";
            this.radio_key_format_pem.UseVisualStyleBackColor = true;
            // 
            // radio_key_format_xml
            // 
            this.radio_key_format_xml.AutoSize = true;
            this.radio_key_format_xml.Checked = true;
            this.radio_key_format_xml.Location = new System.Drawing.Point(3, 3);
            this.radio_key_format_xml.Name = "radio_key_format_xml";
            this.radio_key_format_xml.Size = new System.Drawing.Size(65, 16);
            this.radio_key_format_xml.TabIndex = 31;
            this.radio_key_format_xml.TabStop = true;
            this.radio_key_format_xml.Text = "XML密钥";
            this.radio_key_format_xml.UseVisualStyleBackColor = true;
            // 
            // btnRsaSignVerify
            // 
            this.btnRsaSignVerify.Location = new System.Drawing.Point(806, 6);
            this.btnRsaSignVerify.Name = "btnRsaSignVerify";
            this.btnRsaSignVerify.Size = new System.Drawing.Size(86, 33);
            this.btnRsaSignVerify.TabIndex = 30;
            this.btnRsaSignVerify.Text = "验签";
            this.btnRsaSignVerify.UseVisualStyleBackColor = true;
            this.btnRsaSignVerify.Click += new System.EventHandler(this.btnRsaSignVerify_Click);
            // 
            // btnExportCer
            // 
            this.btnExportCer.Location = new System.Drawing.Point(187, 203);
            this.btnExportCer.Name = "btnExportCer";
            this.btnExportCer.Size = new System.Drawing.Size(86, 33);
            this.btnExportCer.TabIndex = 29;
            this.btnExportCer.Text = "导出公钥证书";
            this.btnExportCer.UseVisualStyleBackColor = true;
            this.btnExportCer.Click += new System.EventHandler(this.btnExportCer_Click);
            // 
            // btnExportPFX
            // 
            this.btnExportPFX.Location = new System.Drawing.Point(95, 203);
            this.btnExportPFX.Name = "btnExportPFX";
            this.btnExportPFX.Size = new System.Drawing.Size(86, 33);
            this.btnExportPFX.TabIndex = 28;
            this.btnExportPFX.Text = "导出私钥证书";
            this.btnExportPFX.UseVisualStyleBackColor = true;
            this.btnExportPFX.Click += new System.EventHandler(this.btnExportPFX_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 373);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "签名摘要算法";
            // 
            // btnBuildCert
            // 
            this.btnBuildCert.Location = new System.Drawing.Point(109, 52);
            this.btnBuildCert.Name = "btnBuildCert";
            this.btnBuildCert.Size = new System.Drawing.Size(77, 33);
            this.btnBuildCert.TabIndex = 25;
            this.btnBuildCert.Text = "创建新证书";
            this.btnBuildCert.UseVisualStyleBackColor = true;
            this.btnBuildCert.Click += new System.EventHandler(this.btnBuildCert_Click);
            // 
            // btnRsaSign
            // 
            this.btnRsaSign.Location = new System.Drawing.Point(679, 6);
            this.btnRsaSign.Name = "btnRsaSign";
            this.btnRsaSign.Size = new System.Drawing.Size(86, 33);
            this.btnRsaSign.TabIndex = 24;
            this.btnRsaSign.Text = "签名";
            this.btnRsaSign.UseVisualStyleBackColor = true;
            this.btnRsaSign.Click += new System.EventHandler(this.btnRsaSign_Click);
            // 
            // btnRsaDecrypt
            // 
            this.btnRsaDecrypt.Location = new System.Drawing.Point(552, 6);
            this.btnRsaDecrypt.Name = "btnRsaDecrypt";
            this.btnRsaDecrypt.Size = new System.Drawing.Size(86, 33);
            this.btnRsaDecrypt.TabIndex = 23;
            this.btnRsaDecrypt.Text = "解密";
            this.btnRsaDecrypt.UseVisualStyleBackColor = true;
            this.btnRsaDecrypt.Click += new System.EventHandler(this.btnRsaDecrypt_Click);
            // 
            // btnRsaEncrypt
            // 
            this.btnRsaEncrypt.Location = new System.Drawing.Point(425, 6);
            this.btnRsaEncrypt.Name = "btnRsaEncrypt";
            this.btnRsaEncrypt.Size = new System.Drawing.Size(86, 33);
            this.btnRsaEncrypt.TabIndex = 22;
            this.btnRsaEncrypt.Text = "加密";
            this.btnRsaEncrypt.UseVisualStyleBackColor = true;
            this.btnRsaEncrypt.Click += new System.EventHandler(this.btnRsaEncrypt_Click);
            // 
            // btnChooseCert
            // 
            this.btnChooseCert.Location = new System.Drawing.Point(8, 52);
            this.btnChooseCert.Name = "btnChooseCert";
            this.btnChooseCert.Size = new System.Drawing.Size(86, 33);
            this.btnChooseCert.TabIndex = 21;
            this.btnChooseCert.Text = "选择X509证书";
            this.btnChooseCert.UseVisualStyleBackColor = true;
            this.btnChooseCert.Click += new System.EventHandler(this.btnChooseCert_Click);
            // 
            // btn_read_pem
            // 
            this.btn_read_pem.Location = new System.Drawing.Point(298, 6);
            this.btn_read_pem.Name = "btn_read_pem";
            this.btn_read_pem.Size = new System.Drawing.Size(86, 33);
            this.btn_read_pem.TabIndex = 20;
            this.btn_read_pem.Text = "读取PEM证书";
            this.btn_read_pem.UseVisualStyleBackColor = true;
            this.btn_read_pem.Click += new System.EventHandler(this.btn_read_pem_Click);
            // 
            // btn_rsa_folder
            // 
            this.btn_rsa_folder.Location = new System.Drawing.Point(139, 6);
            this.btn_rsa_folder.Name = "btn_rsa_folder";
            this.btn_rsa_folder.Size = new System.Drawing.Size(118, 33);
            this.btn_rsa_folder.TabIndex = 19;
            this.btn_rsa_folder.Text = "选择证书存储目录";
            this.btn_rsa_folder.UseVisualStyleBackColor = true;
            this.btn_rsa_folder.Click += new System.EventHandler(this.btn_rsa_folder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 417);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "证书工具";
            // 
            // txt_makecertpath
            // 
            this.txt_makecertpath.Location = new System.Drawing.Point(62, 414);
            this.txt_makecertpath.Name = "txt_makecertpath";
            this.txt_makecertpath.Size = new System.Drawing.Size(209, 22);
            this.txt_makecertpath.TabIndex = 17;
            this.txt_makecertpath.Text = "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v7.1A\\Bin\\makecert.exe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 16;
            this.label8.Text = "证书密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "保存目录";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "证书名称";
            // 
            // txt_cert_pwd
            // 
            this.txt_cert_pwd.Location = new System.Drawing.Point(65, 165);
            this.txt_cert_pwd.Name = "txt_cert_pwd";
            this.txt_cert_pwd.Size = new System.Drawing.Size(209, 22);
            this.txt_cert_pwd.TabIndex = 13;
            // 
            // txt_cert_folder
            // 
            this.txt_cert_folder.Location = new System.Drawing.Point(65, 133);
            this.txt_cert_folder.Name = "txt_cert_folder";
            this.txt_cert_folder.Size = new System.Drawing.Size(209, 22);
            this.txt_cert_folder.TabIndex = 12;
            // 
            // txt_cert_name
            // 
            this.txt_cert_name.Location = new System.Drawing.Point(65, 102);
            this.txt_cert_name.Name = "txt_cert_name";
            this.txt_cert_name.Size = new System.Drawing.Size(209, 22);
            this.txt_cert_name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 519);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "签名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 411);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "密文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 323);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "明文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(290, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "公钥";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "私钥";
            // 
            // txt_signature
            // 
            this.txt_signature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_signature.Location = new System.Drawing.Point(290, 536);
            this.txt_signature.Multiline = true;
            this.txt_signature.Name = "txt_signature";
            this.txt_signature.Size = new System.Drawing.Size(608, 81);
            this.txt_signature.TabIndex = 5;
            // 
            // txt_cipher
            // 
            this.txt_cipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cipher.Location = new System.Drawing.Point(291, 430);
            this.txt_cipher.Multiline = true;
            this.txt_cipher.Name = "txt_cipher";
            this.txt_cipher.Size = new System.Drawing.Size(608, 83);
            this.txt_cipher.TabIndex = 4;
            // 
            // txt_plain
            // 
            this.txt_plain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_plain.Location = new System.Drawing.Point(293, 342);
            this.txt_plain.Multiline = true;
            this.txt_plain.Name = "txt_plain";
            this.txt_plain.Size = new System.Drawing.Size(608, 66);
            this.txt_plain.TabIndex = 3;
            // 
            // txt_public_key
            // 
            this.txt_public_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_public_key.Location = new System.Drawing.Point(293, 202);
            this.txt_public_key.Multiline = true;
            this.txt_public_key.Name = "txt_public_key";
            this.txt_public_key.Size = new System.Drawing.Size(608, 118);
            this.txt_public_key.TabIndex = 2;
            // 
            // txt_private_key
            // 
            this.txt_private_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_private_key.Location = new System.Drawing.Point(293, 73);
            this.txt_private_key.Multiline = true;
            this.txt_private_key.Name = "txt_private_key";
            this.txt_private_key.Size = new System.Drawing.Size(608, 107);
            this.txt_private_key.TabIndex = 1;
            // 
            // btn_genrsa
            // 
            this.btn_genrsa.Location = new System.Drawing.Point(8, 6);
            this.btn_genrsa.Name = "btn_genrsa";
            this.btn_genrsa.Size = new System.Drawing.Size(90, 33);
            this.btn_genrsa.TabIndex = 0;
            this.btn_genrsa.Text = "创建密钥";
            this.btn_genrsa.UseVisualStyleBackColor = true;
            this.btn_genrsa.Click += new System.EventHandler(this.btn_genrsa_Click);
            // 
            // tabPage_des
            // 
            this.tabPage_des.Controls.Add(this.cbox_des_cipher_mode);
            this.tabPage_des.Controls.Add(this.cbox_des_padding_mode);
            this.tabPage_des.Controls.Add(this.label28);
            this.tabPage_des.Controls.Add(this.label27);
            this.tabPage_des.Controls.Add(this.label26);
            this.tabPage_des.Controls.Add(this.btnDesDecrypt);
            this.tabPage_des.Controls.Add(this.btnDesEncrypt);
            this.tabPage_des.Controls.Add(this.cbox_des_cipher_encode);
            this.tabPage_des.Controls.Add(this.label20);
            this.tabPage_des.Controls.Add(this.panel6);
            this.tabPage_des.Controls.Add(this.label19);
            this.tabPage_des.Controls.Add(this.panel5);
            this.tabPage_des.Controls.Add(this.label18);
            this.tabPage_des.Controls.Add(this.cbox_des_plain_encode);
            this.tabPage_des.Controls.Add(this.txt_des_cipher);
            this.tabPage_des.Controls.Add(this.txt_des_plain);
            this.tabPage_des.Controls.Add(this.txt_des_key);
            this.tabPage_des.Controls.Add(this.label17);
            this.tabPage_des.Controls.Add(this.label16);
            this.tabPage_des.Controls.Add(this.label15);
            this.tabPage_des.Controls.Add(this.label14);
            this.tabPage_des.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_des.Location = new System.Drawing.Point(4, 39);
            this.tabPage_des.Name = "tabPage_des";
            this.tabPage_des.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_des.Size = new System.Drawing.Size(907, 624);
            this.tabPage_des.TabIndex = 1;
            this.tabPage_des.Text = "DES";
            this.tabPage_des.UseVisualStyleBackColor = true;
            // 
            // cbox_des_cipher_mode
            // 
            this.cbox_des_cipher_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_des_cipher_mode.FormattingEnabled = true;
            this.cbox_des_cipher_mode.Items.AddRange(new object[] {
            "None",
            "PKCS7",
            "Zeros",
            "ANSIX923",
            "ISO10126"});
            this.cbox_des_cipher_mode.Location = new System.Drawing.Point(516, 144);
            this.cbox_des_cipher_mode.Name = "cbox_des_cipher_mode";
            this.cbox_des_cipher_mode.Size = new System.Drawing.Size(129, 20);
            this.cbox_des_cipher_mode.TabIndex = 20;
            // 
            // cbox_des_padding_mode
            // 
            this.cbox_des_padding_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_des_padding_mode.FormattingEnabled = true;
            this.cbox_des_padding_mode.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.cbox_des_padding_mode.Location = new System.Drawing.Point(242, 144);
            this.cbox_des_padding_mode.Name = "cbox_des_padding_mode";
            this.cbox_des_padding_mode.Size = new System.Drawing.Size(121, 20);
            this.cbox_des_padding_mode.TabIndex = 19;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(457, 147);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(53, 12);
            this.label28.TabIndex = 18;
            this.label28.Text = "加密模式";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(183, 147);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(53, 12);
            this.label27.TabIndex = 17;
            this.label27.Text = "填充方式";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(61, 147);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(53, 12);
            this.label26.TabIndex = 16;
            this.label26.Text = "加密参数";
            // 
            // btnDesDecrypt
            // 
            this.btnDesDecrypt.Location = new System.Drawing.Point(486, 467);
            this.btnDesDecrypt.Name = "btnDesDecrypt";
            this.btnDesDecrypt.Size = new System.Drawing.Size(88, 33);
            this.btnDesDecrypt.TabIndex = 15;
            this.btnDesDecrypt.Text = "解密";
            this.btnDesDecrypt.UseVisualStyleBackColor = true;
            this.btnDesDecrypt.Click += new System.EventHandler(this.btnDesDecrypt_Click);
            // 
            // btnDesEncrypt
            // 
            this.btnDesEncrypt.Location = new System.Drawing.Point(351, 467);
            this.btnDesEncrypt.Name = "btnDesEncrypt";
            this.btnDesEncrypt.Size = new System.Drawing.Size(86, 33);
            this.btnDesEncrypt.TabIndex = 14;
            this.btnDesEncrypt.Text = "加密";
            this.btnDesEncrypt.UseVisualStyleBackColor = true;
            this.btnDesEncrypt.Click += new System.EventHandler(this.btnDesEncrypt_Click);
            // 
            // cbox_des_cipher_encode
            // 
            this.cbox_des_cipher_encode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_des_cipher_encode.FormattingEnabled = true;
            this.cbox_des_cipher_encode.Items.AddRange(new object[] {
            "BASE64",
            "HEX",
            "BASE58"});
            this.cbox_des_cipher_encode.Location = new System.Drawing.Point(182, 252);
            this.cbox_des_cipher_encode.Name = "cbox_des_cipher_encode";
            this.cbox_des_cipher_encode.Size = new System.Drawing.Size(644, 20);
            this.cbox_des_cipher_encode.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(61, 255);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(53, 12);
            this.label20.TabIndex = 12;
            this.label20.Text = "密文编码";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radio_des_type_twicedes);
            this.panel6.Controls.Add(this.radio_des_type_1des);
            this.panel6.Controls.Add(this.radio_des_type_3des);
            this.panel6.Location = new System.Drawing.Point(182, 112);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(644, 20);
            this.panel6.TabIndex = 11;
            // 
            // radio_des_type_twicedes
            // 
            this.radio_des_type_twicedes.AutoSize = true;
            this.radio_des_type_twicedes.Location = new System.Drawing.Point(304, 2);
            this.radio_des_type_twicedes.Name = "radio_des_type_twicedes";
            this.radio_des_type_twicedes.Size = new System.Drawing.Size(83, 16);
            this.radio_des_type_twicedes.TabIndex = 14;
            this.radio_des_type_twicedes.Text = "双倍长3DES";
            this.radio_des_type_twicedes.UseVisualStyleBackColor = true;
            // 
            // radio_des_type_1des
            // 
            this.radio_des_type_1des.AutoSize = true;
            this.radio_des_type_1des.Checked = true;
            this.radio_des_type_1des.Location = new System.Drawing.Point(3, 2);
            this.radio_des_type_1des.Name = "radio_des_type_1des";
            this.radio_des_type_1des.Size = new System.Drawing.Size(65, 16);
            this.radio_des_type_1des.TabIndex = 12;
            this.radio_des_type_1des.TabStop = true;
            this.radio_des_type_1des.Text = "单倍DES";
            this.radio_des_type_1des.UseVisualStyleBackColor = true;
            // 
            // radio_des_type_3des
            // 
            this.radio_des_type_3des.AutoSize = true;
            this.radio_des_type_3des.Location = new System.Drawing.Point(154, 2);
            this.radio_des_type_3des.Name = "radio_des_type_3des";
            this.radio_des_type_3des.Size = new System.Drawing.Size(47, 16);
            this.radio_des_type_3des.TabIndex = 13;
            this.radio_des_type_3des.Text = "3DES";
            this.radio_des_type_3des.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(61, 116);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 10;
            this.label19.Text = "加密方式";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radio_des_key_format_base64);
            this.panel5.Controls.Add(this.radio_des_key_format_hex);
            this.panel5.Controls.Add(this.radio_des_key_format_ascii);
            this.panel5.Location = new System.Drawing.Point(182, 84);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(644, 20);
            this.panel5.TabIndex = 9;
            // 
            // radio_des_key_format_base64
            // 
            this.radio_des_key_format_base64.AutoSize = true;
            this.radio_des_key_format_base64.Location = new System.Drawing.Point(217, 2);
            this.radio_des_key_format_base64.Name = "radio_des_key_format_base64";
            this.radio_des_key_format_base64.Size = new System.Drawing.Size(59, 16);
            this.radio_des_key_format_base64.TabIndex = 12;
            this.radio_des_key_format_base64.Text = "BASE64";
            this.radio_des_key_format_base64.UseVisualStyleBackColor = true;
            // 
            // radio_des_key_format_hex
            // 
            this.radio_des_key_format_hex.AutoSize = true;
            this.radio_des_key_format_hex.Checked = true;
            this.radio_des_key_format_hex.Location = new System.Drawing.Point(3, 2);
            this.radio_des_key_format_hex.Name = "radio_des_key_format_hex";
            this.radio_des_key_format_hex.Size = new System.Drawing.Size(41, 16);
            this.radio_des_key_format_hex.TabIndex = 10;
            this.radio_des_key_format_hex.TabStop = true;
            this.radio_des_key_format_hex.Text = "HEX";
            this.radio_des_key_format_hex.UseVisualStyleBackColor = true;
            // 
            // radio_des_key_format_ascii
            // 
            this.radio_des_key_format_ascii.AutoSize = true;
            this.radio_des_key_format_ascii.Location = new System.Drawing.Point(104, 2);
            this.radio_des_key_format_ascii.Name = "radio_des_key_format_ascii";
            this.radio_des_key_format_ascii.Size = new System.Drawing.Size(53, 16);
            this.radio_des_key_format_ascii.TabIndex = 11;
            this.radio_des_key_format_ascii.Text = "ASCII";
            this.radio_des_key_format_ascii.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(61, 88);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(53, 12);
            this.label18.TabIndex = 8;
            this.label18.Text = "密钥格式";
            // 
            // cbox_des_plain_encode
            // 
            this.cbox_des_plain_encode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_des_plain_encode.FormattingEnabled = true;
            this.cbox_des_plain_encode.Items.AddRange(new object[] {
            "UTF-8",
            "ASCII",
            "GBK"});
            this.cbox_des_plain_encode.Location = new System.Drawing.Point(182, 216);
            this.cbox_des_plain_encode.Name = "cbox_des_plain_encode";
            this.cbox_des_plain_encode.Size = new System.Drawing.Size(644, 20);
            this.cbox_des_plain_encode.TabIndex = 7;
            // 
            // txt_des_cipher
            // 
            this.txt_des_cipher.Location = new System.Drawing.Point(182, 294);
            this.txt_des_cipher.Multiline = true;
            this.txt_des_cipher.Name = "txt_des_cipher";
            this.txt_des_cipher.Size = new System.Drawing.Size(644, 126);
            this.txt_des_cipher.TabIndex = 6;
            // 
            // txt_des_plain
            // 
            this.txt_des_plain.Location = new System.Drawing.Point(182, 176);
            this.txt_des_plain.Name = "txt_des_plain";
            this.txt_des_plain.Size = new System.Drawing.Size(644, 22);
            this.txt_des_plain.TabIndex = 5;
            // 
            // txt_des_key
            // 
            this.txt_des_key.Location = new System.Drawing.Point(182, 49);
            this.txt_des_key.Name = "txt_des_key";
            this.txt_des_key.Size = new System.Drawing.Size(644, 22);
            this.txt_des_key.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 297);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "密文";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(61, 219);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 12);
            this.label16.TabIndex = 2;
            this.label16.Text = "明文编码";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(85, 179);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 1;
            this.label15.Text = "明文";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "密钥";
            // 
            // tabPage_aes
            // 
            this.tabPage_aes.Controls.Add(this.radio_aes_cipher_encode_base58);
            this.tabPage_aes.Controls.Add(this.radio_aes_cipher_encode_hex);
            this.tabPage_aes.Controls.Add(this.radio_aes_cipher_encode_base64);
            this.tabPage_aes.Controls.Add(this.cbox_aes_plain_encode);
            this.tabPage_aes.Controls.Add(this.label25);
            this.tabPage_aes.Controls.Add(this.label24);
            this.tabPage_aes.Controls.Add(this.btn_aes_decrypt);
            this.tabPage_aes.Controls.Add(this.btn_aes_encrypt);
            this.tabPage_aes.Controls.Add(this.txt_aes_cipher);
            this.tabPage_aes.Controls.Add(this.txt_aes_plain);
            this.tabPage_aes.Controls.Add(this.txt_aes_key);
            this.tabPage_aes.Controls.Add(this.check_aes_random);
            this.tabPage_aes.Controls.Add(this.label23);
            this.tabPage_aes.Controls.Add(this.label22);
            this.tabPage_aes.Controls.Add(this.label21);
            this.tabPage_aes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_aes.Location = new System.Drawing.Point(4, 39);
            this.tabPage_aes.Name = "tabPage_aes";
            this.tabPage_aes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_aes.Size = new System.Drawing.Size(907, 624);
            this.tabPage_aes.TabIndex = 2;
            this.tabPage_aes.Text = "AES";
            this.tabPage_aes.UseVisualStyleBackColor = true;
            // 
            // radio_aes_cipher_encode_base58
            // 
            this.radio_aes_cipher_encode_base58.AutoSize = true;
            this.radio_aes_cipher_encode_base58.Location = new System.Drawing.Point(377, 429);
            this.radio_aes_cipher_encode_base58.Name = "radio_aes_cipher_encode_base58";
            this.radio_aes_cipher_encode_base58.Size = new System.Drawing.Size(59, 16);
            this.radio_aes_cipher_encode_base58.TabIndex = 14;
            this.radio_aes_cipher_encode_base58.Text = "BASE58";
            this.radio_aes_cipher_encode_base58.UseVisualStyleBackColor = true;
            // 
            // radio_aes_cipher_encode_hex
            // 
            this.radio_aes_cipher_encode_hex.AutoSize = true;
            this.radio_aes_cipher_encode_hex.Location = new System.Drawing.Point(257, 429);
            this.radio_aes_cipher_encode_hex.Name = "radio_aes_cipher_encode_hex";
            this.radio_aes_cipher_encode_hex.Size = new System.Drawing.Size(41, 16);
            this.radio_aes_cipher_encode_hex.TabIndex = 13;
            this.radio_aes_cipher_encode_hex.Text = "HEX";
            this.radio_aes_cipher_encode_hex.UseVisualStyleBackColor = true;
            // 
            // radio_aes_cipher_encode_base64
            // 
            this.radio_aes_cipher_encode_base64.AutoSize = true;
            this.radio_aes_cipher_encode_base64.Checked = true;
            this.radio_aes_cipher_encode_base64.Location = new System.Drawing.Point(106, 429);
            this.radio_aes_cipher_encode_base64.Name = "radio_aes_cipher_encode_base64";
            this.radio_aes_cipher_encode_base64.Size = new System.Drawing.Size(59, 16);
            this.radio_aes_cipher_encode_base64.TabIndex = 12;
            this.radio_aes_cipher_encode_base64.TabStop = true;
            this.radio_aes_cipher_encode_base64.Text = "BASE64";
            this.radio_aes_cipher_encode_base64.UseVisualStyleBackColor = true;
            // 
            // cbox_aes_plain_encode
            // 
            this.cbox_aes_plain_encode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_aes_plain_encode.FormattingEnabled = true;
            this.cbox_aes_plain_encode.Items.AddRange(new object[] {
            "UTF-8",
            "ASCII",
            "GBK"});
            this.cbox_aes_plain_encode.Location = new System.Drawing.Point(106, 237);
            this.cbox_aes_plain_encode.Name = "cbox_aes_plain_encode";
            this.cbox_aes_plain_encode.Size = new System.Drawing.Size(722, 20);
            this.cbox_aes_plain_encode.TabIndex = 11;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(38, 240);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(53, 12);
            this.label25.TabIndex = 10;
            this.label25.Text = "明文编码";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(38, 431);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(53, 12);
            this.label24.TabIndex = 9;
            this.label24.Text = "密文编码";
            // 
            // btn_aes_decrypt
            // 
            this.btn_aes_decrypt.Location = new System.Drawing.Point(460, 471);
            this.btn_aes_decrypt.Name = "btn_aes_decrypt";
            this.btn_aes_decrypt.Size = new System.Drawing.Size(88, 33);
            this.btn_aes_decrypt.TabIndex = 8;
            this.btn_aes_decrypt.Text = "解密";
            this.btn_aes_decrypt.UseVisualStyleBackColor = true;
            this.btn_aes_decrypt.Click += new System.EventHandler(this.btn_aes_decrypt_Click);
            // 
            // btn_aes_encrypt
            // 
            this.btn_aes_encrypt.Location = new System.Drawing.Point(282, 471);
            this.btn_aes_encrypt.Name = "btn_aes_encrypt";
            this.btn_aes_encrypt.Size = new System.Drawing.Size(88, 33);
            this.btn_aes_encrypt.TabIndex = 7;
            this.btn_aes_encrypt.Text = "加密";
            this.btn_aes_encrypt.UseVisualStyleBackColor = true;
            this.btn_aes_encrypt.Click += new System.EventHandler(this.btn_aes_encrypt_Click);
            // 
            // txt_aes_cipher
            // 
            this.txt_aes_cipher.Location = new System.Drawing.Point(106, 276);
            this.txt_aes_cipher.Multiline = true;
            this.txt_aes_cipher.Name = "txt_aes_cipher";
            this.txt_aes_cipher.Size = new System.Drawing.Size(722, 119);
            this.txt_aes_cipher.TabIndex = 6;
            // 
            // txt_aes_plain
            // 
            this.txt_aes_plain.Location = new System.Drawing.Point(106, 107);
            this.txt_aes_plain.Multiline = true;
            this.txt_aes_plain.Name = "txt_aes_plain";
            this.txt_aes_plain.Size = new System.Drawing.Size(722, 107);
            this.txt_aes_plain.TabIndex = 5;
            // 
            // txt_aes_key
            // 
            this.txt_aes_key.Location = new System.Drawing.Point(106, 49);
            this.txt_aes_key.Name = "txt_aes_key";
            this.txt_aes_key.Size = new System.Drawing.Size(470, 22);
            this.txt_aes_key.TabIndex = 4;
            // 
            // check_aes_random
            // 
            this.check_aes_random.AutoSize = true;
            this.check_aes_random.Location = new System.Drawing.Point(582, 51);
            this.check_aes_random.Name = "check_aes_random";
            this.check_aes_random.Size = new System.Drawing.Size(246, 16);
            this.check_aes_random.TabIndex = 3;
            this.check_aes_random.Text = "使用JAVA随机安全密钥(SecureRandomKey)";
            this.check_aes_random.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(62, 279);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 2;
            this.label23.Text = "密文";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(62, 110);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 1;
            this.label22.Text = "明文";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(62, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "密钥";
            // 
            // tabPage_base58
            // 
            this.tabPage_base58.Controls.Add(this.radio_base58_gbk);
            this.tabPage_base58.Controls.Add(this.radio_base58_ascii);
            this.tabPage_base58.Controls.Add(this.radio_base58_utf8);
            this.tabPage_base58.Controls.Add(this.txt_base58_cipher);
            this.tabPage_base58.Controls.Add(this.btnBase58Decode);
            this.tabPage_base58.Controls.Add(this.btnBase58Encode);
            this.tabPage_base58.Controls.Add(this.txt_base58_plain);
            this.tabPage_base58.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_base58.Location = new System.Drawing.Point(4, 39);
            this.tabPage_base58.Name = "tabPage_base58";
            this.tabPage_base58.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_base58.Size = new System.Drawing.Size(907, 624);
            this.tabPage_base58.TabIndex = 3;
            this.tabPage_base58.Text = "BASE58";
            this.tabPage_base58.UseVisualStyleBackColor = true;
            // 
            // radio_base58_gbk
            // 
            this.radio_base58_gbk.AutoSize = true;
            this.radio_base58_gbk.Location = new System.Drawing.Point(375, 34);
            this.radio_base58_gbk.Name = "radio_base58_gbk";
            this.radio_base58_gbk.Size = new System.Drawing.Size(41, 16);
            this.radio_base58_gbk.TabIndex = 6;
            this.radio_base58_gbk.Text = "GBK";
            this.radio_base58_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_base58_ascii
            // 
            this.radio_base58_ascii.AutoSize = true;
            this.radio_base58_ascii.Location = new System.Drawing.Point(219, 34);
            this.radio_base58_ascii.Name = "radio_base58_ascii";
            this.radio_base58_ascii.Size = new System.Drawing.Size(53, 16);
            this.radio_base58_ascii.TabIndex = 5;
            this.radio_base58_ascii.Text = "ASCII";
            this.radio_base58_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_base58_utf8
            // 
            this.radio_base58_utf8.AutoSize = true;
            this.radio_base58_utf8.Checked = true;
            this.radio_base58_utf8.Location = new System.Drawing.Point(63, 34);
            this.radio_base58_utf8.Name = "radio_base58_utf8";
            this.radio_base58_utf8.Size = new System.Drawing.Size(53, 16);
            this.radio_base58_utf8.TabIndex = 4;
            this.radio_base58_utf8.TabStop = true;
            this.radio_base58_utf8.Text = "UTF-8";
            this.radio_base58_utf8.UseVisualStyleBackColor = true;
            // 
            // txt_base58_cipher
            // 
            this.txt_base58_cipher.Location = new System.Drawing.Point(63, 358);
            this.txt_base58_cipher.Multiline = true;
            this.txt_base58_cipher.Name = "txt_base58_cipher";
            this.txt_base58_cipher.Size = new System.Drawing.Size(764, 205);
            this.txt_base58_cipher.TabIndex = 3;
            // 
            // btnBase58Decode
            // 
            this.btnBase58Decode.Location = new System.Drawing.Point(497, 290);
            this.btnBase58Decode.Name = "btnBase58Decode";
            this.btnBase58Decode.Size = new System.Drawing.Size(330, 33);
            this.btnBase58Decode.TabIndex = 2;
            this.btnBase58Decode.Text = "解码↑";
            this.btnBase58Decode.UseVisualStyleBackColor = true;
            this.btnBase58Decode.Click += new System.EventHandler(this.btnBase58Decode_Click);
            // 
            // btnBase58Encode
            // 
            this.btnBase58Encode.Location = new System.Drawing.Point(63, 290);
            this.btnBase58Encode.Name = "btnBase58Encode";
            this.btnBase58Encode.Size = new System.Drawing.Size(330, 33);
            this.btnBase58Encode.TabIndex = 1;
            this.btnBase58Encode.Text = "编码↓";
            this.btnBase58Encode.UseVisualStyleBackColor = true;
            this.btnBase58Encode.Click += new System.EventHandler(this.btnBase58Encode_Click);
            // 
            // txt_base58_plain
            // 
            this.txt_base58_plain.Location = new System.Drawing.Point(63, 81);
            this.txt_base58_plain.Multiline = true;
            this.txt_base58_plain.Name = "txt_base58_plain";
            this.txt_base58_plain.Size = new System.Drawing.Size(764, 174);
            this.txt_base58_plain.TabIndex = 0;
            // 
            // tabPage_base64
            // 
            this.tabPage_base64.Controls.Add(this.btnBase64Decode);
            this.tabPage_base64.Controls.Add(this.btnBase64Encode);
            this.tabPage_base64.Controls.Add(this.txt_base64_cipher);
            this.tabPage_base64.Controls.Add(this.txt_base64_plain);
            this.tabPage_base64.Controls.Add(this.radio_base64_gbk);
            this.tabPage_base64.Controls.Add(this.radio_base64_ascii);
            this.tabPage_base64.Controls.Add(this.radio_base64_utf8);
            this.tabPage_base64.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_base64.Location = new System.Drawing.Point(4, 39);
            this.tabPage_base64.Name = "tabPage_base64";
            this.tabPage_base64.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_base64.Size = new System.Drawing.Size(907, 624);
            this.tabPage_base64.TabIndex = 4;
            this.tabPage_base64.Text = "BASE64";
            this.tabPage_base64.UseVisualStyleBackColor = true;
            // 
            // btnBase64Decode
            // 
            this.btnBase64Decode.Location = new System.Drawing.Point(497, 290);
            this.btnBase64Decode.Name = "btnBase64Decode";
            this.btnBase64Decode.Size = new System.Drawing.Size(330, 33);
            this.btnBase64Decode.TabIndex = 6;
            this.btnBase64Decode.Text = "解码↑";
            this.btnBase64Decode.UseVisualStyleBackColor = true;
            this.btnBase64Decode.Click += new System.EventHandler(this.btnBase64Decode_Click);
            // 
            // btnBase64Encode
            // 
            this.btnBase64Encode.Location = new System.Drawing.Point(63, 290);
            this.btnBase64Encode.Name = "btnBase64Encode";
            this.btnBase64Encode.Size = new System.Drawing.Size(330, 33);
            this.btnBase64Encode.TabIndex = 5;
            this.btnBase64Encode.Text = "编码↓";
            this.btnBase64Encode.UseVisualStyleBackColor = true;
            this.btnBase64Encode.Click += new System.EventHandler(this.btnBase64Encode_Click);
            // 
            // txt_base64_cipher
            // 
            this.txt_base64_cipher.Location = new System.Drawing.Point(63, 358);
            this.txt_base64_cipher.Multiline = true;
            this.txt_base64_cipher.Name = "txt_base64_cipher";
            this.txt_base64_cipher.Size = new System.Drawing.Size(764, 205);
            this.txt_base64_cipher.TabIndex = 4;
            // 
            // txt_base64_plain
            // 
            this.txt_base64_plain.Location = new System.Drawing.Point(63, 81);
            this.txt_base64_plain.Multiline = true;
            this.txt_base64_plain.Name = "txt_base64_plain";
            this.txt_base64_plain.Size = new System.Drawing.Size(764, 174);
            this.txt_base64_plain.TabIndex = 3;
            // 
            // radio_base64_gbk
            // 
            this.radio_base64_gbk.AutoSize = true;
            this.radio_base64_gbk.Location = new System.Drawing.Point(375, 34);
            this.radio_base64_gbk.Name = "radio_base64_gbk";
            this.radio_base64_gbk.Size = new System.Drawing.Size(41, 16);
            this.radio_base64_gbk.TabIndex = 2;
            this.radio_base64_gbk.Text = "GBK";
            this.radio_base64_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_base64_ascii
            // 
            this.radio_base64_ascii.AutoSize = true;
            this.radio_base64_ascii.Location = new System.Drawing.Point(219, 34);
            this.radio_base64_ascii.Name = "radio_base64_ascii";
            this.radio_base64_ascii.Size = new System.Drawing.Size(53, 16);
            this.radio_base64_ascii.TabIndex = 1;
            this.radio_base64_ascii.Text = "ASCII";
            this.radio_base64_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_base64_utf8
            // 
            this.radio_base64_utf8.AutoSize = true;
            this.radio_base64_utf8.Checked = true;
            this.radio_base64_utf8.Location = new System.Drawing.Point(63, 34);
            this.radio_base64_utf8.Name = "radio_base64_utf8";
            this.radio_base64_utf8.Size = new System.Drawing.Size(53, 16);
            this.radio_base64_utf8.TabIndex = 0;
            this.radio_base64_utf8.TabStop = true;
            this.radio_base64_utf8.Text = "UTF-8";
            this.radio_base64_utf8.UseVisualStyleBackColor = true;
            // 
            // tabPage_md5
            // 
            this.tabPage_md5.Controls.Add(this.btnMd5Encode);
            this.tabPage_md5.Controls.Add(this.txt_md5_cipher);
            this.tabPage_md5.Controls.Add(this.txt_md5_plain);
            this.tabPage_md5.Controls.Add(this.radio_md5_gbk);
            this.tabPage_md5.Controls.Add(this.radio_md5_ascii);
            this.tabPage_md5.Controls.Add(this.radio_md5_utf8);
            this.tabPage_md5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_md5.Location = new System.Drawing.Point(4, 39);
            this.tabPage_md5.Name = "tabPage_md5";
            this.tabPage_md5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_md5.Size = new System.Drawing.Size(907, 624);
            this.tabPage_md5.TabIndex = 5;
            this.tabPage_md5.Text = "MD5";
            this.tabPage_md5.UseVisualStyleBackColor = true;
            // 
            // btnMd5Encode
            // 
            this.btnMd5Encode.Location = new System.Drawing.Point(65, 289);
            this.btnMd5Encode.Name = "btnMd5Encode";
            this.btnMd5Encode.Size = new System.Drawing.Size(764, 33);
            this.btnMd5Encode.TabIndex = 12;
            this.btnMd5Encode.Text = "编码↓";
            this.btnMd5Encode.UseVisualStyleBackColor = true;
            this.btnMd5Encode.Click += new System.EventHandler(this.btnMd5Encode_Click);
            // 
            // txt_md5_cipher
            // 
            this.txt_md5_cipher.Location = new System.Drawing.Point(65, 357);
            this.txt_md5_cipher.Multiline = true;
            this.txt_md5_cipher.Name = "txt_md5_cipher";
            this.txt_md5_cipher.Size = new System.Drawing.Size(764, 205);
            this.txt_md5_cipher.TabIndex = 11;
            // 
            // txt_md5_plain
            // 
            this.txt_md5_plain.Location = new System.Drawing.Point(65, 80);
            this.txt_md5_plain.Multiline = true;
            this.txt_md5_plain.Name = "txt_md5_plain";
            this.txt_md5_plain.Size = new System.Drawing.Size(764, 174);
            this.txt_md5_plain.TabIndex = 10;
            // 
            // radio_md5_gbk
            // 
            this.radio_md5_gbk.AutoSize = true;
            this.radio_md5_gbk.Location = new System.Drawing.Point(378, 34);
            this.radio_md5_gbk.Name = "radio_md5_gbk";
            this.radio_md5_gbk.Size = new System.Drawing.Size(41, 16);
            this.radio_md5_gbk.TabIndex = 9;
            this.radio_md5_gbk.Text = "GBK";
            this.radio_md5_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_md5_ascii
            // 
            this.radio_md5_ascii.AutoSize = true;
            this.radio_md5_ascii.Location = new System.Drawing.Point(221, 34);
            this.radio_md5_ascii.Name = "radio_md5_ascii";
            this.radio_md5_ascii.Size = new System.Drawing.Size(53, 16);
            this.radio_md5_ascii.TabIndex = 8;
            this.radio_md5_ascii.Text = "ASCII";
            this.radio_md5_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_md5_utf8
            // 
            this.radio_md5_utf8.AutoSize = true;
            this.radio_md5_utf8.Checked = true;
            this.radio_md5_utf8.Location = new System.Drawing.Point(63, 34);
            this.radio_md5_utf8.Name = "radio_md5_utf8";
            this.radio_md5_utf8.Size = new System.Drawing.Size(53, 16);
            this.radio_md5_utf8.TabIndex = 7;
            this.radio_md5_utf8.TabStop = true;
            this.radio_md5_utf8.Text = "UTF-8";
            this.radio_md5_utf8.UseVisualStyleBackColor = true;
            // 
            // tabPage_sha
            // 
            this.tabPage_sha.Controls.Add(this.btnSha256);
            this.tabPage_sha.Controls.Add(this.btnSha512);
            this.tabPage_sha.Controls.Add(this.btnSha1);
            this.tabPage_sha.Controls.Add(this.txt_sha_cipher);
            this.tabPage_sha.Controls.Add(this.txt_sha_plain);
            this.tabPage_sha.Controls.Add(this.radio_sha_gbk);
            this.tabPage_sha.Controls.Add(this.radio_sha_ascii);
            this.tabPage_sha.Controls.Add(this.radio_sha_utf8);
            this.tabPage_sha.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_sha.Location = new System.Drawing.Point(4, 39);
            this.tabPage_sha.Name = "tabPage_sha";
            this.tabPage_sha.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_sha.Size = new System.Drawing.Size(907, 624);
            this.tabPage_sha.TabIndex = 6;
            this.tabPage_sha.Text = "SHA";
            this.tabPage_sha.UseVisualStyleBackColor = true;
            // 
            // btnSha256
            // 
            this.btnSha256.Location = new System.Drawing.Point(335, 290);
            this.btnSha256.Name = "btnSha256";
            this.btnSha256.Size = new System.Drawing.Size(220, 33);
            this.btnSha256.TabIndex = 14;
            this.btnSha256.Text = "SHA256↓";
            this.btnSha256.UseVisualStyleBackColor = true;
            this.btnSha256.Click += new System.EventHandler(this.btnSha256_Click);
            // 
            // btnSha512
            // 
            this.btnSha512.Location = new System.Drawing.Point(607, 290);
            this.btnSha512.Name = "btnSha512";
            this.btnSha512.Size = new System.Drawing.Size(220, 33);
            this.btnSha512.TabIndex = 13;
            this.btnSha512.Text = "SHA512↓";
            this.btnSha512.UseVisualStyleBackColor = true;
            this.btnSha512.Click += new System.EventHandler(this.btnSha512_Click);
            // 
            // btnSha1
            // 
            this.btnSha1.Location = new System.Drawing.Point(63, 290);
            this.btnSha1.Name = "btnSha1";
            this.btnSha1.Size = new System.Drawing.Size(220, 33);
            this.btnSha1.TabIndex = 12;
            this.btnSha1.Text = "SHA1↓";
            this.btnSha1.UseVisualStyleBackColor = true;
            this.btnSha1.Click += new System.EventHandler(this.btnSha1_Click);
            // 
            // txt_sha_cipher
            // 
            this.txt_sha_cipher.Location = new System.Drawing.Point(63, 358);
            this.txt_sha_cipher.Multiline = true;
            this.txt_sha_cipher.Name = "txt_sha_cipher";
            this.txt_sha_cipher.Size = new System.Drawing.Size(764, 205);
            this.txt_sha_cipher.TabIndex = 11;
            // 
            // txt_sha_plain
            // 
            this.txt_sha_plain.Location = new System.Drawing.Point(63, 81);
            this.txt_sha_plain.Multiline = true;
            this.txt_sha_plain.Name = "txt_sha_plain";
            this.txt_sha_plain.Size = new System.Drawing.Size(764, 174);
            this.txt_sha_plain.TabIndex = 10;
            // 
            // radio_sha_gbk
            // 
            this.radio_sha_gbk.AutoSize = true;
            this.radio_sha_gbk.Location = new System.Drawing.Point(375, 34);
            this.radio_sha_gbk.Name = "radio_sha_gbk";
            this.radio_sha_gbk.Size = new System.Drawing.Size(41, 16);
            this.radio_sha_gbk.TabIndex = 9;
            this.radio_sha_gbk.Text = "GBK";
            this.radio_sha_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_sha_ascii
            // 
            this.radio_sha_ascii.AutoSize = true;
            this.radio_sha_ascii.Location = new System.Drawing.Point(219, 34);
            this.radio_sha_ascii.Name = "radio_sha_ascii";
            this.radio_sha_ascii.Size = new System.Drawing.Size(53, 16);
            this.radio_sha_ascii.TabIndex = 8;
            this.radio_sha_ascii.Text = "ASCII";
            this.radio_sha_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_sha_utf8
            // 
            this.radio_sha_utf8.AutoSize = true;
            this.radio_sha_utf8.Checked = true;
            this.radio_sha_utf8.Location = new System.Drawing.Point(63, 34);
            this.radio_sha_utf8.Name = "radio_sha_utf8";
            this.radio_sha_utf8.Size = new System.Drawing.Size(53, 16);
            this.radio_sha_utf8.TabIndex = 7;
            this.radio_sha_utf8.TabStop = true;
            this.radio_sha_utf8.Text = "UTF-8";
            this.radio_sha_utf8.UseVisualStyleBackColor = true;
            // 
            // tabPage_urlencode
            // 
            this.tabPage_urlencode.Controls.Add(this.btnUrlDecode);
            this.tabPage_urlencode.Controls.Add(this.btnUrlEncode);
            this.tabPage_urlencode.Controls.Add(this.txt_urlencode_cipher);
            this.tabPage_urlencode.Controls.Add(this.txt_urlencode_plain);
            this.tabPage_urlencode.Controls.Add(this.radio_urlencode_gbk);
            this.tabPage_urlencode.Controls.Add(this.radio_urlencode_ascii);
            this.tabPage_urlencode.Controls.Add(this.radio_urlencode_utf8);
            this.tabPage_urlencode.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabPage_urlencode.Location = new System.Drawing.Point(4, 39);
            this.tabPage_urlencode.Name = "tabPage_urlencode";
            this.tabPage_urlencode.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_urlencode.Size = new System.Drawing.Size(907, 624);
            this.tabPage_urlencode.TabIndex = 7;
            this.tabPage_urlencode.Text = "URL ENCODE";
            this.tabPage_urlencode.UseVisualStyleBackColor = true;
            // 
            // btnUrlDecode
            // 
            this.btnUrlDecode.Location = new System.Drawing.Point(497, 290);
            this.btnUrlDecode.Name = "btnUrlDecode";
            this.btnUrlDecode.Size = new System.Drawing.Size(330, 33);
            this.btnUrlDecode.TabIndex = 13;
            this.btnUrlDecode.Text = "解码↑";
            this.btnUrlDecode.UseVisualStyleBackColor = true;
            this.btnUrlDecode.Click += new System.EventHandler(this.btnUrlDecode_Click);
            // 
            // btnUrlEncode
            // 
            this.btnUrlEncode.Location = new System.Drawing.Point(63, 290);
            this.btnUrlEncode.Name = "btnUrlEncode";
            this.btnUrlEncode.Size = new System.Drawing.Size(330, 33);
            this.btnUrlEncode.TabIndex = 12;
            this.btnUrlEncode.Text = "编码↓";
            this.btnUrlEncode.UseVisualStyleBackColor = true;
            this.btnUrlEncode.Click += new System.EventHandler(this.btnUrlEncode_Click);
            // 
            // txt_urlencode_cipher
            // 
            this.txt_urlencode_cipher.Location = new System.Drawing.Point(63, 358);
            this.txt_urlencode_cipher.Multiline = true;
            this.txt_urlencode_cipher.Name = "txt_urlencode_cipher";
            this.txt_urlencode_cipher.Size = new System.Drawing.Size(764, 205);
            this.txt_urlencode_cipher.TabIndex = 11;
            // 
            // txt_urlencode_plain
            // 
            this.txt_urlencode_plain.Location = new System.Drawing.Point(63, 81);
            this.txt_urlencode_plain.Multiline = true;
            this.txt_urlencode_plain.Name = "txt_urlencode_plain";
            this.txt_urlencode_plain.Size = new System.Drawing.Size(764, 174);
            this.txt_urlencode_plain.TabIndex = 10;
            // 
            // radio_urlencode_gbk
            // 
            this.radio_urlencode_gbk.AutoSize = true;
            this.radio_urlencode_gbk.Location = new System.Drawing.Point(375, 34);
            this.radio_urlencode_gbk.Name = "radio_urlencode_gbk";
            this.radio_urlencode_gbk.Size = new System.Drawing.Size(41, 16);
            this.radio_urlencode_gbk.TabIndex = 9;
            this.radio_urlencode_gbk.Text = "GBK";
            this.radio_urlencode_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_urlencode_ascii
            // 
            this.radio_urlencode_ascii.AutoSize = true;
            this.radio_urlencode_ascii.Location = new System.Drawing.Point(219, 34);
            this.radio_urlencode_ascii.Name = "radio_urlencode_ascii";
            this.radio_urlencode_ascii.Size = new System.Drawing.Size(53, 16);
            this.radio_urlencode_ascii.TabIndex = 8;
            this.radio_urlencode_ascii.Text = "ASCII";
            this.radio_urlencode_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_urlencode_utf8
            // 
            this.radio_urlencode_utf8.AutoSize = true;
            this.radio_urlencode_utf8.Checked = true;
            this.radio_urlencode_utf8.Location = new System.Drawing.Point(63, 34);
            this.radio_urlencode_utf8.Name = "radio_urlencode_utf8";
            this.radio_urlencode_utf8.Size = new System.Drawing.Size(53, 16);
            this.radio_urlencode_utf8.TabIndex = 7;
            this.radio_urlencode_utf8.TabStop = true;
            this.radio_urlencode_utf8.Text = "UTF-8";
            this.radio_urlencode_utf8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 667);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加解密工具";
            this.tabControl.ResumeLayout(false);
            this.tabPage_rsa.ResumeLayout(false);
            this.tabPage_rsa.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage_des.ResumeLayout(false);
            this.tabPage_des.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage_aes.ResumeLayout(false);
            this.tabPage_aes.PerformLayout();
            this.tabPage_base58.ResumeLayout(false);
            this.tabPage_base58.PerformLayout();
            this.tabPage_base64.ResumeLayout(false);
            this.tabPage_base64.PerformLayout();
            this.tabPage_md5.ResumeLayout(false);
            this.tabPage_md5.PerformLayout();
            this.tabPage_sha.ResumeLayout(false);
            this.tabPage_sha.PerformLayout();
            this.tabPage_urlencode.ResumeLayout(false);
            this.tabPage_urlencode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage_rsa;
        private System.Windows.Forms.TabPage tabPage_des;
        private System.Windows.Forms.TabPage tabPage_aes;
        private System.Windows.Forms.TabPage tabPage_base58;
        private System.Windows.Forms.TabPage tabPage_base64;
        private System.Windows.Forms.TabPage tabPage_md5;
        private System.Windows.Forms.TabPage tabPage_sha;
        private System.Windows.Forms.TabPage tabPage_urlencode;
        private System.Windows.Forms.TextBox txt_public_key;
        private System.Windows.Forms.TextBox txt_private_key;
        private System.Windows.Forms.Button btn_genrsa;
        private System.Windows.Forms.TextBox txt_signature;
        private System.Windows.Forms.TextBox txt_cipher;
        private System.Windows.Forms.TextBox txt_plain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_cert_pwd;
        private System.Windows.Forms.TextBox txt_cert_folder;
        private System.Windows.Forms.TextBox txt_cert_name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_makecertpath;
        private System.Windows.Forms.Button btnBuildCert;
        private System.Windows.Forms.Button btnRsaSign;
        private System.Windows.Forms.Button btnRsaDecrypt;
        private System.Windows.Forms.Button btnRsaEncrypt;
        private System.Windows.Forms.Button btnChooseCert;
        private System.Windows.Forms.Button btn_read_pem;
        private System.Windows.Forms.Button btn_rsa_folder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radio_sign_hash_sha256;
        private System.Windows.Forms.RadioButton radio_sign_hash_sha1;
        private System.Windows.Forms.RadioButton radio_sign_hash_md5;
        private System.Windows.Forms.Button btnExportCer;
        private System.Windows.Forms.Button btnExportPFX;
        private System.Windows.Forms.Button btnRsaSignVerify;
        private System.Windows.Forms.RadioButton radio_key_format_pem;
        private System.Windows.Forms.RadioButton radio_key_format_xml;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReadX509;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radio_cipher_encode_hex;
        private System.Windows.Forms.RadioButton radio_cipher_encode_base58;
        private System.Windows.Forms.RadioButton radio_cipher_encode_base64;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radio_plain_encode_gbk;
        private System.Windows.Forms.RadioButton radio_plain_encode_ascii;
        private System.Windows.Forms.RadioButton radio_plain_encode_utf8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbox_des_plain_encode;
        private System.Windows.Forms.TextBox txt_des_cipher;
        private System.Windows.Forms.TextBox txt_des_plain;
        private System.Windows.Forms.TextBox txt_des_key;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RadioButton radio_des_key_format_base64;
        private System.Windows.Forms.RadioButton radio_des_key_format_ascii;
        private System.Windows.Forms.RadioButton radio_des_key_format_hex;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radio_des_type_twicedes;
        private System.Windows.Forms.RadioButton radio_des_type_3des;
        private System.Windows.Forms.RadioButton radio_des_type_1des;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cbox_des_cipher_encode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnDesDecrypt;
        private System.Windows.Forms.Button btnDesEncrypt;
        private System.Windows.Forms.Button btn_aes_decrypt;
        private System.Windows.Forms.Button btn_aes_encrypt;
        private System.Windows.Forms.TextBox txt_aes_cipher;
        private System.Windows.Forms.TextBox txt_aes_plain;
        private System.Windows.Forms.TextBox txt_aes_key;
        private System.Windows.Forms.CheckBox check_aes_random;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cbox_aes_plain_encode;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.RadioButton radio_aes_cipher_encode_base58;
        private System.Windows.Forms.RadioButton radio_aes_cipher_encode_hex;
        private System.Windows.Forms.RadioButton radio_aes_cipher_encode_base64;
        private System.Windows.Forms.RadioButton radio_base58_gbk;
        private System.Windows.Forms.RadioButton radio_base58_ascii;
        private System.Windows.Forms.RadioButton radio_base58_utf8;
        private System.Windows.Forms.TextBox txt_base58_cipher;
        private System.Windows.Forms.Button btnBase58Decode;
        private System.Windows.Forms.Button btnBase58Encode;
        private System.Windows.Forms.TextBox txt_base58_plain;
        private System.Windows.Forms.Button btnBase64Decode;
        private System.Windows.Forms.Button btnBase64Encode;
        private System.Windows.Forms.TextBox txt_base64_cipher;
        private System.Windows.Forms.TextBox txt_base64_plain;
        private System.Windows.Forms.RadioButton radio_base64_gbk;
        private System.Windows.Forms.RadioButton radio_base64_ascii;
        private System.Windows.Forms.RadioButton radio_base64_utf8;
        private System.Windows.Forms.Button btnMd5Encode;
        private System.Windows.Forms.TextBox txt_md5_cipher;
        private System.Windows.Forms.TextBox txt_md5_plain;
        private System.Windows.Forms.RadioButton radio_md5_gbk;
        private System.Windows.Forms.RadioButton radio_md5_ascii;
        private System.Windows.Forms.RadioButton radio_md5_utf8;
        private System.Windows.Forms.Button btnSha512;
        private System.Windows.Forms.Button btnSha1;
        private System.Windows.Forms.TextBox txt_sha_cipher;
        private System.Windows.Forms.TextBox txt_sha_plain;
        private System.Windows.Forms.RadioButton radio_sha_gbk;
        private System.Windows.Forms.RadioButton radio_sha_ascii;
        private System.Windows.Forms.RadioButton radio_sha_utf8;
        private System.Windows.Forms.Button btnUrlDecode;
        private System.Windows.Forms.Button btnUrlEncode;
        private System.Windows.Forms.TextBox txt_urlencode_cipher;
        private System.Windows.Forms.TextBox txt_urlencode_plain;
        private System.Windows.Forms.RadioButton radio_urlencode_gbk;
        private System.Windows.Forms.RadioButton radio_urlencode_ascii;
        private System.Windows.Forms.RadioButton radio_urlencode_utf8;
        private System.Windows.Forms.Button btnSha256;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cbox_des_cipher_mode;
        private System.Windows.Forms.ComboBox cbox_des_padding_mode;
    }
}

