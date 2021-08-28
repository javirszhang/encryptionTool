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
            this.radio_rsa_key_format_pem_pkcs8 = new System.Windows.Forms.RadioButton();
            this.radio_rsa_key_format_pem = new System.Windows.Forms.RadioButton();
            this.radio_rsa_key_format_xml = new System.Windows.Forms.RadioButton();
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
            this.cbox_des_padding_mode = new System.Windows.Forms.ComboBox();
            this.cbox_des_cipher_mode = new System.Windows.Forms.ComboBox();
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
            this.cb_aes_cipher_mode = new System.Windows.Forms.ComboBox();
            this.cb_aes_padding_mode = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.radio_aes_key_format_hex = new System.Windows.Forms.RadioButton();
            this.radio_aes_key_format_base64 = new System.Windows.Forms.RadioButton();
            this.radio_aes_key_format_ascii = new System.Windows.Forms.RadioButton();
            this.label38 = new System.Windows.Forms.Label();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnQrCodeGenerate = new System.Windows.Forms.Button();
            this.picQrCode = new System.Windows.Forms.PictureBox();
            this.txt_qrcode_text = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txt_sign_sourcedata = new System.Windows.Forms.TextBox();
            this.txt_sign_sign = new System.Windows.Forms.TextBox();
            this.btn_sign_calculate = new System.Windows.Forms.Button();
            this.txt_sign_service = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txt_sign_key = new System.Windows.Forms.TextBox();
            this.txt_sign_body = new System.Windows.Forms.TextBox();
            this.txt_sign_token = new System.Windows.Forms.TextBox();
            this.txt_sign_timestamp = new System.Windows.Forms.TextBox();
            this.txt_sign_path = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cb_guid_suffix = new System.Windows.Forms.CheckBox();
            this.cb_guid_nosplit = new System.Windows.Forms.CheckBox();
            this.cb_guid_case = new System.Windows.Forms.CheckBox();
            this.txt_guid_count = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.btn_gen_guid = new System.Windows.Forms.Button();
            this.txt_guid = new System.Windows.Forms.TextBox();
            this.tabPage_timestamp = new System.Windows.Forms.TabPage();
            this.btnTimeToTicks = new System.Windows.Forms.Button();
            this.btnTicksToTime = new System.Windows.Forms.Button();
            this.txtCurTimeTransform = new System.Windows.Forms.TextBox();
            this.txtCurTimeStampTransform = new System.Windows.Forms.TextBox();
            this.txtCurTime = new System.Windows.Forms.TextBox();
            this.txtCurTimeStamp = new System.Windows.Forms.TextBox();
            this.lbl_current_timestamp = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.btnStopTimeTicks = new System.Windows.Forms.Button();
            this.label45 = new System.Windows.Forms.Label();
            this.lbl_current_time = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.tabPage_jwt = new System.Windows.Forms.TabPage();
            this.txtJwtDecodeJson = new System.Windows.Forms.TextBox();
            this.btnSensitiveDecode = new System.Windows.Forms.Button();
            this.txtSensitivePlainText = new System.Windows.Forms.TextBox();
            this.txtJwtSensitiveCipher = new System.Windows.Forms.TextBox();
            this.txtJwtTickets = new System.Windows.Forms.TextBox();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.txtJwtSeed = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.txtJwtToken = new System.Windows.Forms.TextBox();
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
            this.panel7.SuspendLayout();
            this.tabPage_base58.SuspendLayout();
            this.tabPage_base64.SuspendLayout();
            this.tabPage_md5.SuspendLayout();
            this.tabPage_sha.SuspendLayout();
            this.tabPage_urlencode.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage_timestamp.SuspendLayout();
            this.tabPage_jwt.SuspendLayout();
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
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage_timestamp);
            this.tabControl.Controls.Add(this.tabPage_jwt);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl.ItemSize = new System.Drawing.Size(80, 35);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1062, 830);
            this.tabControl.TabIndex = 0;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl_Selected);
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
            this.tabPage_rsa.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_rsa.Location = new System.Drawing.Point(4, 39);
            this.tabPage_rsa.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_rsa.Name = "tabPage_rsa";
            this.tabPage_rsa.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_rsa.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_rsa.TabIndex = 0;
            this.tabPage_rsa.Text = "RSA";
            this.tabPage_rsa.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.radio_cipher_encode_hex);
            this.panel4.Controls.Add(this.radio_cipher_encode_base58);
            this.panel4.Controls.Add(this.radio_cipher_encode_base64);
            this.panel4.Location = new System.Drawing.Point(100, 407);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(218, 28);
            this.panel4.TabIndex = 41;
            // 
            // radio_cipher_encode_hex
            // 
            this.radio_cipher_encode_hex.AutoSize = true;
            this.radio_cipher_encode_hex.Location = new System.Drawing.Point(167, 3);
            this.radio_cipher_encode_hex.Margin = new System.Windows.Forms.Padding(4);
            this.radio_cipher_encode_hex.Name = "radio_cipher_encode_hex";
            this.radio_cipher_encode_hex.Size = new System.Drawing.Size(46, 18);
            this.radio_cipher_encode_hex.TabIndex = 2;
            this.radio_cipher_encode_hex.Text = "HEX";
            this.radio_cipher_encode_hex.UseVisualStyleBackColor = true;
            // 
            // radio_cipher_encode_base58
            // 
            this.radio_cipher_encode_base58.AutoSize = true;
            this.radio_cipher_encode_base58.Location = new System.Drawing.Point(85, 3);
            this.radio_cipher_encode_base58.Margin = new System.Windows.Forms.Padding(4);
            this.radio_cipher_encode_base58.Name = "radio_cipher_encode_base58";
            this.radio_cipher_encode_base58.Size = new System.Drawing.Size(67, 18);
            this.radio_cipher_encode_base58.TabIndex = 1;
            this.radio_cipher_encode_base58.Text = "BASE58";
            this.radio_cipher_encode_base58.UseVisualStyleBackColor = true;
            // 
            // radio_cipher_encode_base64
            // 
            this.radio_cipher_encode_base64.AutoSize = true;
            this.radio_cipher_encode_base64.Checked = true;
            this.radio_cipher_encode_base64.Location = new System.Drawing.Point(4, 3);
            this.radio_cipher_encode_base64.Margin = new System.Windows.Forms.Padding(4);
            this.radio_cipher_encode_base64.Name = "radio_cipher_encode_base64";
            this.radio_cipher_encode_base64.Size = new System.Drawing.Size(67, 18);
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
            this.panel3.Location = new System.Drawing.Point(100, 358);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 28);
            this.panel3.TabIndex = 40;
            // 
            // radio_plain_encode_gbk
            // 
            this.radio_plain_encode_gbk.AutoSize = true;
            this.radio_plain_encode_gbk.Location = new System.Drawing.Point(167, 3);
            this.radio_plain_encode_gbk.Margin = new System.Windows.Forms.Padding(4);
            this.radio_plain_encode_gbk.Name = "radio_plain_encode_gbk";
            this.radio_plain_encode_gbk.Size = new System.Drawing.Size(46, 18);
            this.radio_plain_encode_gbk.TabIndex = 2;
            this.radio_plain_encode_gbk.Text = "GBK";
            this.radio_plain_encode_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_plain_encode_ascii
            // 
            this.radio_plain_encode_ascii.AutoSize = true;
            this.radio_plain_encode_ascii.Location = new System.Drawing.Point(82, 3);
            this.radio_plain_encode_ascii.Margin = new System.Windows.Forms.Padding(4);
            this.radio_plain_encode_ascii.Name = "radio_plain_encode_ascii";
            this.radio_plain_encode_ascii.Size = new System.Drawing.Size(60, 18);
            this.radio_plain_encode_ascii.TabIndex = 1;
            this.radio_plain_encode_ascii.Text = "ASCII";
            this.radio_plain_encode_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_plain_encode_utf8
            // 
            this.radio_plain_encode_utf8.AutoSize = true;
            this.radio_plain_encode_utf8.Checked = true;
            this.radio_plain_encode_utf8.Location = new System.Drawing.Point(4, 3);
            this.radio_plain_encode_utf8.Margin = new System.Windows.Forms.Padding(4);
            this.radio_plain_encode_utf8.Name = "radio_plain_encode_utf8";
            this.radio_plain_encode_utf8.Size = new System.Drawing.Size(53, 18);
            this.radio_plain_encode_utf8.TabIndex = 0;
            this.radio_plain_encode_utf8.TabStop = true;
            this.radio_plain_encode_utf8.Text = "UTF8";
            this.radio_plain_encode_utf8.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 412);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 14);
            this.label13.TabIndex = 39;
            this.label13.Text = "密文编码";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 364);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 14);
            this.label12.TabIndex = 38;
            this.label12.Text = "明文编码";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radio_sign_hash_md5);
            this.panel2.Controls.Add(this.radio_sign_hash_sha1);
            this.panel2.Controls.Add(this.radio_sign_hash_sha256);
            this.panel2.Location = new System.Drawing.Point(100, 523);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 28);
            this.panel2.TabIndex = 37;
            // 
            // radio_sign_hash_md5
            // 
            this.radio_sign_hash_md5.AutoSize = true;
            this.radio_sign_hash_md5.Location = new System.Drawing.Point(4, 4);
            this.radio_sign_hash_md5.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sign_hash_md5.Name = "radio_sign_hash_md5";
            this.radio_sign_hash_md5.Size = new System.Drawing.Size(46, 18);
            this.radio_sign_hash_md5.TabIndex = 27;
            this.radio_sign_hash_md5.Text = "MD5";
            this.radio_sign_hash_md5.UseVisualStyleBackColor = true;
            // 
            // radio_sign_hash_sha1
            // 
            this.radio_sign_hash_sha1.AutoSize = true;
            this.radio_sign_hash_sha1.Checked = true;
            this.radio_sign_hash_sha1.Location = new System.Drawing.Point(71, 4);
            this.radio_sign_hash_sha1.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sign_hash_sha1.Name = "radio_sign_hash_sha1";
            this.radio_sign_hash_sha1.Size = new System.Drawing.Size(53, 18);
            this.radio_sign_hash_sha1.TabIndex = 27;
            this.radio_sign_hash_sha1.TabStop = true;
            this.radio_sign_hash_sha1.Text = "SHA1";
            this.radio_sign_hash_sha1.UseVisualStyleBackColor = true;
            // 
            // radio_sign_hash_sha256
            // 
            this.radio_sign_hash_sha256.AutoSize = true;
            this.radio_sign_hash_sha256.Location = new System.Drawing.Point(146, 3);
            this.radio_sign_hash_sha256.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sign_hash_sha256.Name = "radio_sign_hash_sha256";
            this.radio_sign_hash_sha256.Size = new System.Drawing.Size(67, 18);
            this.radio_sign_hash_sha256.TabIndex = 27;
            this.radio_sign_hash_sha256.Text = "SHA256";
            this.radio_sign_hash_sha256.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 484);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 14);
            this.label11.TabIndex = 36;
            this.label11.Text = "密钥格式";
            // 
            // btnReadX509
            // 
            this.btnReadX509.Location = new System.Drawing.Point(4, 288);
            this.btnReadX509.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadX509.Name = "btnReadX509";
            this.btnReadX509.Size = new System.Drawing.Size(100, 47);
            this.btnReadX509.TabIndex = 35;
            this.btnReadX509.Text = "读取X509证书";
            this.btnReadX509.UseVisualStyleBackColor = true;
            this.btnReadX509.Click += new System.EventHandler(this.btnReadX509_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radio_rsa_key_format_pem_pkcs8);
            this.panel1.Controls.Add(this.radio_rsa_key_format_pem);
            this.panel1.Controls.Add(this.radio_rsa_key_format_xml);
            this.panel1.Location = new System.Drawing.Point(72, 479);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 28);
            this.panel1.TabIndex = 34;
            // 
            // radio_rsa_key_format_pem_pkcs8
            // 
            this.radio_rsa_key_format_pem_pkcs8.AutoSize = true;
            this.radio_rsa_key_format_pem_pkcs8.Location = new System.Drawing.Point(146, 4);
            this.radio_rsa_key_format_pem_pkcs8.Margin = new System.Windows.Forms.Padding(4);
            this.radio_rsa_key_format_pem_pkcs8.Name = "radio_rsa_key_format_pem_pkcs8";
            this.radio_rsa_key_format_pem_pkcs8.Size = new System.Drawing.Size(88, 18);
            this.radio_rsa_key_format_pem_pkcs8.TabIndex = 33;
            this.radio_rsa_key_format_pem_pkcs8.TabStop = true;
            this.radio_rsa_key_format_pem_pkcs8.Text = "PEM-pkcs8";
            this.radio_rsa_key_format_pem_pkcs8.UseVisualStyleBackColor = true;
            this.radio_rsa_key_format_pem_pkcs8.CheckedChanged += new System.EventHandler(this.OnKeyFormatChange);
            // 
            // radio_rsa_key_format_pem
            // 
            this.radio_rsa_key_format_pem.AutoSize = true;
            this.radio_rsa_key_format_pem.Location = new System.Drawing.Point(55, 4);
            this.radio_rsa_key_format_pem.Margin = new System.Windows.Forms.Padding(4);
            this.radio_rsa_key_format_pem.Name = "radio_rsa_key_format_pem";
            this.radio_rsa_key_format_pem.Size = new System.Drawing.Size(88, 18);
            this.radio_rsa_key_format_pem.TabIndex = 32;
            this.radio_rsa_key_format_pem.Text = "PEM-pkcs1";
            this.radio_rsa_key_format_pem.UseVisualStyleBackColor = true;
            this.radio_rsa_key_format_pem.CheckedChanged += new System.EventHandler(this.OnKeyFormatChange);
            // 
            // radio_rsa_key_format_xml
            // 
            this.radio_rsa_key_format_xml.AutoSize = true;
            this.radio_rsa_key_format_xml.Checked = true;
            this.radio_rsa_key_format_xml.Location = new System.Drawing.Point(4, 4);
            this.radio_rsa_key_format_xml.Margin = new System.Windows.Forms.Padding(4);
            this.radio_rsa_key_format_xml.Name = "radio_rsa_key_format_xml";
            this.radio_rsa_key_format_xml.Size = new System.Drawing.Size(46, 18);
            this.radio_rsa_key_format_xml.TabIndex = 31;
            this.radio_rsa_key_format_xml.TabStop = true;
            this.radio_rsa_key_format_xml.Text = "XML";
            this.radio_rsa_key_format_xml.UseVisualStyleBackColor = true;
            this.radio_rsa_key_format_xml.CheckedChanged += new System.EventHandler(this.OnKeyFormatChange);
            // 
            // btnRsaSignVerify
            // 
            this.btnRsaSignVerify.Location = new System.Drawing.Point(940, 8);
            this.btnRsaSignVerify.Margin = new System.Windows.Forms.Padding(4);
            this.btnRsaSignVerify.Name = "btnRsaSignVerify";
            this.btnRsaSignVerify.Size = new System.Drawing.Size(100, 47);
            this.btnRsaSignVerify.TabIndex = 30;
            this.btnRsaSignVerify.Text = "验签";
            this.btnRsaSignVerify.UseVisualStyleBackColor = true;
            this.btnRsaSignVerify.Click += new System.EventHandler(this.btnRsaSignVerify_Click);
            // 
            // btnExportCer
            // 
            this.btnExportCer.Location = new System.Drawing.Point(218, 288);
            this.btnExportCer.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportCer.Name = "btnExportCer";
            this.btnExportCer.Size = new System.Drawing.Size(100, 47);
            this.btnExportCer.TabIndex = 29;
            this.btnExportCer.Text = "导出公钥证书";
            this.btnExportCer.UseVisualStyleBackColor = true;
            this.btnExportCer.Click += new System.EventHandler(this.btnExportCer_Click);
            // 
            // btnExportPFX
            // 
            this.btnExportPFX.Location = new System.Drawing.Point(111, 288);
            this.btnExportPFX.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportPFX.Name = "btnExportPFX";
            this.btnExportPFX.Size = new System.Drawing.Size(100, 47);
            this.btnExportPFX.TabIndex = 28;
            this.btnExportPFX.Text = "导出私钥证书";
            this.btnExportPFX.UseVisualStyleBackColor = true;
            this.btnExportPFX.Click += new System.EventHandler(this.btnExportPFX_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 528);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "摘要算法";
            // 
            // btnBuildCert
            // 
            this.btnBuildCert.Location = new System.Drawing.Point(127, 74);
            this.btnBuildCert.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuildCert.Name = "btnBuildCert";
            this.btnBuildCert.Size = new System.Drawing.Size(90, 47);
            this.btnBuildCert.TabIndex = 25;
            this.btnBuildCert.Text = "创建新证书";
            this.btnBuildCert.UseVisualStyleBackColor = true;
            this.btnBuildCert.Click += new System.EventHandler(this.btnBuildCert_Click);
            // 
            // btnRsaSign
            // 
            this.btnRsaSign.Location = new System.Drawing.Point(792, 8);
            this.btnRsaSign.Margin = new System.Windows.Forms.Padding(4);
            this.btnRsaSign.Name = "btnRsaSign";
            this.btnRsaSign.Size = new System.Drawing.Size(100, 47);
            this.btnRsaSign.TabIndex = 24;
            this.btnRsaSign.Text = "签名";
            this.btnRsaSign.UseVisualStyleBackColor = true;
            this.btnRsaSign.Click += new System.EventHandler(this.btnRsaSign_Click);
            // 
            // btnRsaDecrypt
            // 
            this.btnRsaDecrypt.Location = new System.Drawing.Point(644, 8);
            this.btnRsaDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRsaDecrypt.Name = "btnRsaDecrypt";
            this.btnRsaDecrypt.Size = new System.Drawing.Size(100, 47);
            this.btnRsaDecrypt.TabIndex = 23;
            this.btnRsaDecrypt.Text = "解密";
            this.btnRsaDecrypt.UseVisualStyleBackColor = true;
            this.btnRsaDecrypt.Click += new System.EventHandler(this.btnRsaDecrypt_Click);
            // 
            // btnRsaEncrypt
            // 
            this.btnRsaEncrypt.Location = new System.Drawing.Point(496, 8);
            this.btnRsaEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnRsaEncrypt.Name = "btnRsaEncrypt";
            this.btnRsaEncrypt.Size = new System.Drawing.Size(100, 47);
            this.btnRsaEncrypt.TabIndex = 22;
            this.btnRsaEncrypt.Text = "加密";
            this.btnRsaEncrypt.UseVisualStyleBackColor = true;
            this.btnRsaEncrypt.Click += new System.EventHandler(this.btnRsaEncrypt_Click);
            // 
            // btnChooseCert
            // 
            this.btnChooseCert.Location = new System.Drawing.Point(9, 74);
            this.btnChooseCert.Margin = new System.Windows.Forms.Padding(4);
            this.btnChooseCert.Name = "btnChooseCert";
            this.btnChooseCert.Size = new System.Drawing.Size(100, 47);
            this.btnChooseCert.TabIndex = 21;
            this.btnChooseCert.Text = "选择X509证书";
            this.btnChooseCert.UseVisualStyleBackColor = true;
            this.btnChooseCert.Click += new System.EventHandler(this.btnChooseCert_Click);
            // 
            // btn_read_pem
            // 
            this.btn_read_pem.Location = new System.Drawing.Point(348, 8);
            this.btn_read_pem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_read_pem.Name = "btn_read_pem";
            this.btn_read_pem.Size = new System.Drawing.Size(100, 47);
            this.btn_read_pem.TabIndex = 20;
            this.btn_read_pem.Text = "读取PEM证书";
            this.btn_read_pem.UseVisualStyleBackColor = true;
            this.btn_read_pem.Click += new System.EventHandler(this.btn_read_pem_Click);
            // 
            // btn_rsa_folder
            // 
            this.btn_rsa_folder.Location = new System.Drawing.Point(162, 8);
            this.btn_rsa_folder.Margin = new System.Windows.Forms.Padding(4);
            this.btn_rsa_folder.Name = "btn_rsa_folder";
            this.btn_rsa_folder.Size = new System.Drawing.Size(138, 47);
            this.btn_rsa_folder.TabIndex = 19;
            this.btn_rsa_folder.Text = "选择证书存储目录";
            this.btn_rsa_folder.UseVisualStyleBackColor = true;
            this.btn_rsa_folder.Click += new System.EventHandler(this.btn_rsa_folder_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 591);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "证书工具";
            // 
            // txt_makecertpath
            // 
            this.txt_makecertpath.Location = new System.Drawing.Point(72, 586);
            this.txt_makecertpath.Margin = new System.Windows.Forms.Padding(4);
            this.txt_makecertpath.Name = "txt_makecertpath";
            this.txt_makecertpath.Size = new System.Drawing.Size(243, 22);
            this.txt_makecertpath.TabIndex = 17;
            this.txt_makecertpath.Text = "C:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v7.1A\\Bin\\makecert.exe";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 238);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "证书密码";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 14);
            this.label7.TabIndex = 15;
            this.label7.Text = "保存目录";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 149);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "证书名称";
            // 
            // txt_cert_pwd
            // 
            this.txt_cert_pwd.Location = new System.Drawing.Point(76, 234);
            this.txt_cert_pwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cert_pwd.Name = "txt_cert_pwd";
            this.txt_cert_pwd.Size = new System.Drawing.Size(243, 22);
            this.txt_cert_pwd.TabIndex = 13;
            // 
            // txt_cert_folder
            // 
            this.txt_cert_folder.Location = new System.Drawing.Point(76, 188);
            this.txt_cert_folder.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cert_folder.Name = "txt_cert_folder";
            this.txt_cert_folder.Size = new System.Drawing.Size(243, 22);
            this.txt_cert_folder.TabIndex = 12;
            // 
            // txt_cert_name
            // 
            this.txt_cert_name.Location = new System.Drawing.Point(76, 144);
            this.txt_cert_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cert_name.Name = "txt_cert_name";
            this.txt_cert_name.Size = new System.Drawing.Size(243, 22);
            this.txt_cert_name.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(335, 640);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "签名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 487);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "密文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(338, 363);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "明文";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(338, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "公钥";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "私钥";
            // 
            // txt_signature
            // 
            this.txt_signature.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_signature.Location = new System.Drawing.Point(338, 664);
            this.txt_signature.Margin = new System.Windows.Forms.Padding(4);
            this.txt_signature.Multiline = true;
            this.txt_signature.Name = "txt_signature";
            this.txt_signature.Size = new System.Drawing.Size(709, 113);
            this.txt_signature.TabIndex = 5;
            // 
            // txt_cipher
            // 
            this.txt_cipher.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cipher.Location = new System.Drawing.Point(340, 514);
            this.txt_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cipher.Multiline = true;
            this.txt_cipher.Name = "txt_cipher";
            this.txt_cipher.Size = new System.Drawing.Size(709, 116);
            this.txt_cipher.TabIndex = 4;
            // 
            // txt_plain
            // 
            this.txt_plain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_plain.Location = new System.Drawing.Point(342, 389);
            this.txt_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_plain.Multiline = true;
            this.txt_plain.Name = "txt_plain";
            this.txt_plain.Size = new System.Drawing.Size(709, 92);
            this.txt_plain.TabIndex = 3;
            // 
            // txt_public_key
            // 
            this.txt_public_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_public_key.Location = new System.Drawing.Point(342, 238);
            this.txt_public_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_public_key.Multiline = true;
            this.txt_public_key.Name = "txt_public_key";
            this.txt_public_key.Size = new System.Drawing.Size(709, 117);
            this.txt_public_key.TabIndex = 2;
            // 
            // txt_private_key
            // 
            this.txt_private_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_private_key.Location = new System.Drawing.Point(342, 103);
            this.txt_private_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_private_key.Multiline = true;
            this.txt_private_key.Name = "txt_private_key";
            this.txt_private_key.Size = new System.Drawing.Size(709, 107);
            this.txt_private_key.TabIndex = 1;
            // 
            // btn_genrsa
            // 
            this.btn_genrsa.Location = new System.Drawing.Point(9, 8);
            this.btn_genrsa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_genrsa.Name = "btn_genrsa";
            this.btn_genrsa.Size = new System.Drawing.Size(105, 47);
            this.btn_genrsa.TabIndex = 0;
            this.btn_genrsa.Text = "创建密钥";
            this.btn_genrsa.UseVisualStyleBackColor = true;
            this.btn_genrsa.Click += new System.EventHandler(this.btn_genrsa_Click);
            // 
            // tabPage_des
            // 
            this.tabPage_des.Controls.Add(this.cbox_des_padding_mode);
            this.tabPage_des.Controls.Add(this.cbox_des_cipher_mode);
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
            this.tabPage_des.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_des.Location = new System.Drawing.Point(4, 39);
            this.tabPage_des.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_des.Name = "tabPage_des";
            this.tabPage_des.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_des.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_des.TabIndex = 1;
            this.tabPage_des.Text = "DES";
            this.tabPage_des.UseVisualStyleBackColor = true;
            // 
            // cbox_des_padding_mode
            // 
            this.cbox_des_padding_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_des_padding_mode.FormattingEnabled = true;
            this.cbox_des_padding_mode.Items.AddRange(new object[] {
            "None",
            "PKCS7",
            "Zeros",
            "ANSIX923",
            "ISO10126"});
            this.cbox_des_padding_mode.Location = new System.Drawing.Point(602, 204);
            this.cbox_des_padding_mode.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_des_padding_mode.Name = "cbox_des_padding_mode";
            this.cbox_des_padding_mode.Size = new System.Drawing.Size(150, 22);
            this.cbox_des_padding_mode.TabIndex = 20;
            // 
            // cbox_des_cipher_mode
            // 
            this.cbox_des_cipher_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbox_des_cipher_mode.FormattingEnabled = true;
            this.cbox_des_cipher_mode.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.cbox_des_cipher_mode.Location = new System.Drawing.Point(282, 204);
            this.cbox_des_cipher_mode.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_des_cipher_mode.Name = "cbox_des_cipher_mode";
            this.cbox_des_cipher_mode.Size = new System.Drawing.Size(140, 22);
            this.cbox_des_cipher_mode.TabIndex = 19;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(533, 208);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 14);
            this.label28.TabIndex = 18;
            this.label28.Text = "加密模式";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(214, 208);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(63, 14);
            this.label27.TabIndex = 17;
            this.label27.Text = "填充方式";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(71, 208);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(63, 14);
            this.label26.TabIndex = 16;
            this.label26.Text = "加密参数";
            // 
            // btnDesDecrypt
            // 
            this.btnDesDecrypt.Location = new System.Drawing.Point(567, 662);
            this.btnDesDecrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesDecrypt.Name = "btnDesDecrypt";
            this.btnDesDecrypt.Size = new System.Drawing.Size(103, 47);
            this.btnDesDecrypt.TabIndex = 15;
            this.btnDesDecrypt.Text = "解密";
            this.btnDesDecrypt.UseVisualStyleBackColor = true;
            this.btnDesDecrypt.Click += new System.EventHandler(this.btnDesDecrypt_Click);
            // 
            // btnDesEncrypt
            // 
            this.btnDesEncrypt.Location = new System.Drawing.Point(410, 662);
            this.btnDesEncrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btnDesEncrypt.Name = "btnDesEncrypt";
            this.btnDesEncrypt.Size = new System.Drawing.Size(100, 47);
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
            this.cbox_des_cipher_encode.Location = new System.Drawing.Point(212, 357);
            this.cbox_des_cipher_encode.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_des_cipher_encode.Name = "cbox_des_cipher_encode";
            this.cbox_des_cipher_encode.Size = new System.Drawing.Size(751, 22);
            this.cbox_des_cipher_encode.TabIndex = 13;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(71, 361);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 14);
            this.label20.TabIndex = 12;
            this.label20.Text = "密文编码";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.radio_des_type_twicedes);
            this.panel6.Controls.Add(this.radio_des_type_1des);
            this.panel6.Controls.Add(this.radio_des_type_3des);
            this.panel6.Location = new System.Drawing.Point(212, 159);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(751, 28);
            this.panel6.TabIndex = 11;
            // 
            // radio_des_type_twicedes
            // 
            this.radio_des_type_twicedes.AutoSize = true;
            this.radio_des_type_twicedes.Location = new System.Drawing.Point(355, 3);
            this.radio_des_type_twicedes.Margin = new System.Windows.Forms.Padding(4);
            this.radio_des_type_twicedes.Name = "radio_des_type_twicedes";
            this.radio_des_type_twicedes.Size = new System.Drawing.Size(95, 18);
            this.radio_des_type_twicedes.TabIndex = 14;
            this.radio_des_type_twicedes.Text = "双倍长3DES";
            this.radio_des_type_twicedes.UseVisualStyleBackColor = true;
            // 
            // radio_des_type_1des
            // 
            this.radio_des_type_1des.AutoSize = true;
            this.radio_des_type_1des.Checked = true;
            this.radio_des_type_1des.Location = new System.Drawing.Point(4, 3);
            this.radio_des_type_1des.Margin = new System.Windows.Forms.Padding(4);
            this.radio_des_type_1des.Name = "radio_des_type_1des";
            this.radio_des_type_1des.Size = new System.Drawing.Size(74, 18);
            this.radio_des_type_1des.TabIndex = 12;
            this.radio_des_type_1des.TabStop = true;
            this.radio_des_type_1des.Text = "单倍DES";
            this.radio_des_type_1des.UseVisualStyleBackColor = true;
            // 
            // radio_des_type_3des
            // 
            this.radio_des_type_3des.AutoSize = true;
            this.radio_des_type_3des.Location = new System.Drawing.Point(180, 3);
            this.radio_des_type_3des.Margin = new System.Windows.Forms.Padding(4);
            this.radio_des_type_3des.Name = "radio_des_type_3des";
            this.radio_des_type_3des.Size = new System.Drawing.Size(53, 18);
            this.radio_des_type_3des.TabIndex = 13;
            this.radio_des_type_3des.Text = "3DES";
            this.radio_des_type_3des.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(71, 164);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 14);
            this.label19.TabIndex = 10;
            this.label19.Text = "加密方式";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radio_des_key_format_base64);
            this.panel5.Controls.Add(this.radio_des_key_format_hex);
            this.panel5.Controls.Add(this.radio_des_key_format_ascii);
            this.panel5.Location = new System.Drawing.Point(212, 119);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(751, 28);
            this.panel5.TabIndex = 9;
            // 
            // radio_des_key_format_base64
            // 
            this.radio_des_key_format_base64.AutoSize = true;
            this.radio_des_key_format_base64.Location = new System.Drawing.Point(253, 3);
            this.radio_des_key_format_base64.Margin = new System.Windows.Forms.Padding(4);
            this.radio_des_key_format_base64.Name = "radio_des_key_format_base64";
            this.radio_des_key_format_base64.Size = new System.Drawing.Size(67, 18);
            this.radio_des_key_format_base64.TabIndex = 12;
            this.radio_des_key_format_base64.Text = "BASE64";
            this.radio_des_key_format_base64.UseVisualStyleBackColor = true;
            // 
            // radio_des_key_format_hex
            // 
            this.radio_des_key_format_hex.AutoSize = true;
            this.radio_des_key_format_hex.Checked = true;
            this.radio_des_key_format_hex.Location = new System.Drawing.Point(4, 3);
            this.radio_des_key_format_hex.Margin = new System.Windows.Forms.Padding(4);
            this.radio_des_key_format_hex.Name = "radio_des_key_format_hex";
            this.radio_des_key_format_hex.Size = new System.Drawing.Size(46, 18);
            this.radio_des_key_format_hex.TabIndex = 10;
            this.radio_des_key_format_hex.TabStop = true;
            this.radio_des_key_format_hex.Text = "HEX";
            this.radio_des_key_format_hex.UseVisualStyleBackColor = true;
            // 
            // radio_des_key_format_ascii
            // 
            this.radio_des_key_format_ascii.AutoSize = true;
            this.radio_des_key_format_ascii.Location = new System.Drawing.Point(121, 3);
            this.radio_des_key_format_ascii.Margin = new System.Windows.Forms.Padding(4);
            this.radio_des_key_format_ascii.Name = "radio_des_key_format_ascii";
            this.radio_des_key_format_ascii.Size = new System.Drawing.Size(60, 18);
            this.radio_des_key_format_ascii.TabIndex = 11;
            this.radio_des_key_format_ascii.Text = "ASCII";
            this.radio_des_key_format_ascii.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(71, 125);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 14);
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
            this.cbox_des_plain_encode.Location = new System.Drawing.Point(212, 306);
            this.cbox_des_plain_encode.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_des_plain_encode.Name = "cbox_des_plain_encode";
            this.cbox_des_plain_encode.Size = new System.Drawing.Size(751, 22);
            this.cbox_des_plain_encode.TabIndex = 7;
            // 
            // txt_des_cipher
            // 
            this.txt_des_cipher.Location = new System.Drawing.Point(212, 416);
            this.txt_des_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_des_cipher.Multiline = true;
            this.txt_des_cipher.Name = "txt_des_cipher";
            this.txt_des_cipher.Size = new System.Drawing.Size(751, 177);
            this.txt_des_cipher.TabIndex = 6;
            // 
            // txt_des_plain
            // 
            this.txt_des_plain.Location = new System.Drawing.Point(212, 249);
            this.txt_des_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_des_plain.Name = "txt_des_plain";
            this.txt_des_plain.Size = new System.Drawing.Size(751, 22);
            this.txt_des_plain.TabIndex = 5;
            // 
            // txt_des_key
            // 
            this.txt_des_key.Location = new System.Drawing.Point(212, 69);
            this.txt_des_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_des_key.Name = "txt_des_key";
            this.txt_des_key.Size = new System.Drawing.Size(751, 22);
            this.txt_des_key.TabIndex = 4;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(99, 421);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 14);
            this.label17.TabIndex = 3;
            this.label17.Text = "密文";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(71, 310);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 14);
            this.label16.TabIndex = 2;
            this.label16.Text = "明文编码";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(99, 254);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 14);
            this.label15.TabIndex = 1;
            this.label15.Text = "明文";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(99, 74);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 14);
            this.label14.TabIndex = 0;
            this.label14.Text = "密钥";
            // 
            // tabPage_aes
            // 
            this.tabPage_aes.Controls.Add(this.cb_aes_cipher_mode);
            this.tabPage_aes.Controls.Add(this.cb_aes_padding_mode);
            this.tabPage_aes.Controls.Add(this.label39);
            this.tabPage_aes.Controls.Add(this.label40);
            this.tabPage_aes.Controls.Add(this.label41);
            this.tabPage_aes.Controls.Add(this.panel7);
            this.tabPage_aes.Controls.Add(this.label38);
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
            this.tabPage_aes.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_aes.Location = new System.Drawing.Point(4, 39);
            this.tabPage_aes.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_aes.Name = "tabPage_aes";
            this.tabPage_aes.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_aes.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_aes.TabIndex = 2;
            this.tabPage_aes.Text = "AES";
            this.tabPage_aes.UseVisualStyleBackColor = true;
            // 
            // cb_aes_cipher_mode
            // 
            this.cb_aes_cipher_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aes_cipher_mode.FormattingEnabled = true;
            this.cb_aes_cipher_mode.Items.AddRange(new object[] {
            "CBC",
            "ECB",
            "OFB",
            "CFB",
            "CTS"});
            this.cb_aes_cipher_mode.Location = new System.Drawing.Point(575, 181);
            this.cb_aes_cipher_mode.Margin = new System.Windows.Forms.Padding(4);
            this.cb_aes_cipher_mode.Name = "cb_aes_cipher_mode";
            this.cb_aes_cipher_mode.Size = new System.Drawing.Size(150, 22);
            this.cb_aes_cipher_mode.TabIndex = 25;
            // 
            // cb_aes_padding_mode
            // 
            this.cb_aes_padding_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_aes_padding_mode.FormattingEnabled = true;
            this.cb_aes_padding_mode.Items.AddRange(new object[] {
            "None",
            "PKCS7",
            "Zeros",
            "ANSIX923",
            "ISO10126"});
            this.cb_aes_padding_mode.Location = new System.Drawing.Point(255, 181);
            this.cb_aes_padding_mode.Margin = new System.Windows.Forms.Padding(4);
            this.cb_aes_padding_mode.Name = "cb_aes_padding_mode";
            this.cb_aes_padding_mode.Size = new System.Drawing.Size(140, 22);
            this.cb_aes_padding_mode.TabIndex = 24;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(506, 186);
            this.label39.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(63, 14);
            this.label39.TabIndex = 23;
            this.label39.Text = "加密模式";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(187, 186);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(63, 14);
            this.label40.TabIndex = 22;
            this.label40.Text = "填充方式";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(44, 186);
            this.label41.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(63, 14);
            this.label41.TabIndex = 21;
            this.label41.Text = "加密参数";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.radio_aes_key_format_hex);
            this.panel7.Controls.Add(this.radio_aes_key_format_base64);
            this.panel7.Controls.Add(this.radio_aes_key_format_ascii);
            this.panel7.Location = new System.Drawing.Point(124, 123);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(842, 42);
            this.panel7.TabIndex = 16;
            // 
            // radio_aes_key_format_hex
            // 
            this.radio_aes_key_format_hex.AutoSize = true;
            this.radio_aes_key_format_hex.Checked = true;
            this.radio_aes_key_format_hex.Location = new System.Drawing.Point(316, 10);
            this.radio_aes_key_format_hex.Margin = new System.Windows.Forms.Padding(4);
            this.radio_aes_key_format_hex.Name = "radio_aes_key_format_hex";
            this.radio_aes_key_format_hex.Size = new System.Drawing.Size(46, 18);
            this.radio_aes_key_format_hex.TabIndex = 2;
            this.radio_aes_key_format_hex.TabStop = true;
            this.radio_aes_key_format_hex.Text = "HEX";
            this.radio_aes_key_format_hex.UseVisualStyleBackColor = true;
            // 
            // radio_aes_key_format_base64
            // 
            this.radio_aes_key_format_base64.AutoSize = true;
            this.radio_aes_key_format_base64.Location = new System.Drawing.Point(159, 10);
            this.radio_aes_key_format_base64.Margin = new System.Windows.Forms.Padding(4);
            this.radio_aes_key_format_base64.Name = "radio_aes_key_format_base64";
            this.radio_aes_key_format_base64.Size = new System.Drawing.Size(67, 18);
            this.radio_aes_key_format_base64.TabIndex = 1;
            this.radio_aes_key_format_base64.TabStop = true;
            this.radio_aes_key_format_base64.Text = "base64";
            this.radio_aes_key_format_base64.UseVisualStyleBackColor = true;
            // 
            // radio_aes_key_format_ascii
            // 
            this.radio_aes_key_format_ascii.AutoSize = true;
            this.radio_aes_key_format_ascii.Location = new System.Drawing.Point(16, 10);
            this.radio_aes_key_format_ascii.Margin = new System.Windows.Forms.Padding(4);
            this.radio_aes_key_format_ascii.Name = "radio_aes_key_format_ascii";
            this.radio_aes_key_format_ascii.Size = new System.Drawing.Size(60, 18);
            this.radio_aes_key_format_ascii.TabIndex = 0;
            this.radio_aes_key_format_ascii.TabStop = true;
            this.radio_aes_key_format_ascii.Text = "ASCII";
            this.radio_aes_key_format_ascii.UseVisualStyleBackColor = true;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(44, 136);
            this.label38.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(63, 14);
            this.label38.TabIndex = 15;
            this.label38.Text = "密钥格式";
            // 
            // radio_aes_cipher_encode_base58
            // 
            this.radio_aes_cipher_encode_base58.AutoSize = true;
            this.radio_aes_cipher_encode_base58.Location = new System.Drawing.Point(440, 638);
            this.radio_aes_cipher_encode_base58.Margin = new System.Windows.Forms.Padding(4);
            this.radio_aes_cipher_encode_base58.Name = "radio_aes_cipher_encode_base58";
            this.radio_aes_cipher_encode_base58.Size = new System.Drawing.Size(67, 18);
            this.radio_aes_cipher_encode_base58.TabIndex = 14;
            this.radio_aes_cipher_encode_base58.Text = "BASE58";
            this.radio_aes_cipher_encode_base58.UseVisualStyleBackColor = true;
            // 
            // radio_aes_cipher_encode_hex
            // 
            this.radio_aes_cipher_encode_hex.AutoSize = true;
            this.radio_aes_cipher_encode_hex.Location = new System.Drawing.Point(300, 638);
            this.radio_aes_cipher_encode_hex.Margin = new System.Windows.Forms.Padding(4);
            this.radio_aes_cipher_encode_hex.Name = "radio_aes_cipher_encode_hex";
            this.radio_aes_cipher_encode_hex.Size = new System.Drawing.Size(46, 18);
            this.radio_aes_cipher_encode_hex.TabIndex = 13;
            this.radio_aes_cipher_encode_hex.Text = "HEX";
            this.radio_aes_cipher_encode_hex.UseVisualStyleBackColor = true;
            // 
            // radio_aes_cipher_encode_base64
            // 
            this.radio_aes_cipher_encode_base64.AutoSize = true;
            this.radio_aes_cipher_encode_base64.Checked = true;
            this.radio_aes_cipher_encode_base64.Location = new System.Drawing.Point(124, 638);
            this.radio_aes_cipher_encode_base64.Margin = new System.Windows.Forms.Padding(4);
            this.radio_aes_cipher_encode_base64.Name = "radio_aes_cipher_encode_base64";
            this.radio_aes_cipher_encode_base64.Size = new System.Drawing.Size(67, 18);
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
            this.cbox_aes_plain_encode.Location = new System.Drawing.Point(124, 415);
            this.cbox_aes_plain_encode.Margin = new System.Windows.Forms.Padding(4);
            this.cbox_aes_plain_encode.Name = "cbox_aes_plain_encode";
            this.cbox_aes_plain_encode.Size = new System.Drawing.Size(842, 22);
            this.cbox_aes_plain_encode.TabIndex = 11;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(44, 419);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 14);
            this.label25.TabIndex = 10;
            this.label25.Text = "明文编码";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(44, 641);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(63, 14);
            this.label24.TabIndex = 9;
            this.label24.Text = "密文编码";
            // 
            // btn_aes_decrypt
            // 
            this.btn_aes_decrypt.Location = new System.Drawing.Point(537, 698);
            this.btn_aes_decrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aes_decrypt.Name = "btn_aes_decrypt";
            this.btn_aes_decrypt.Size = new System.Drawing.Size(103, 47);
            this.btn_aes_decrypt.TabIndex = 8;
            this.btn_aes_decrypt.Text = "解密";
            this.btn_aes_decrypt.UseVisualStyleBackColor = true;
            this.btn_aes_decrypt.Click += new System.EventHandler(this.btn_aes_decrypt_Click);
            // 
            // btn_aes_encrypt
            // 
            this.btn_aes_encrypt.Location = new System.Drawing.Point(329, 698);
            this.btn_aes_encrypt.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aes_encrypt.Name = "btn_aes_encrypt";
            this.btn_aes_encrypt.Size = new System.Drawing.Size(103, 47);
            this.btn_aes_encrypt.TabIndex = 7;
            this.btn_aes_encrypt.Text = "加密";
            this.btn_aes_encrypt.UseVisualStyleBackColor = true;
            this.btn_aes_encrypt.Click += new System.EventHandler(this.btn_aes_encrypt_Click);
            // 
            // txt_aes_cipher
            // 
            this.txt_aes_cipher.Location = new System.Drawing.Point(124, 470);
            this.txt_aes_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aes_cipher.Multiline = true;
            this.txt_aes_cipher.Name = "txt_aes_cipher";
            this.txt_aes_cipher.Size = new System.Drawing.Size(842, 143);
            this.txt_aes_cipher.TabIndex = 6;
            // 
            // txt_aes_plain
            // 
            this.txt_aes_plain.Location = new System.Drawing.Point(124, 231);
            this.txt_aes_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aes_plain.Multiline = true;
            this.txt_aes_plain.Name = "txt_aes_plain";
            this.txt_aes_plain.Size = new System.Drawing.Size(842, 150);
            this.txt_aes_plain.TabIndex = 5;
            // 
            // txt_aes_key
            // 
            this.txt_aes_key.Location = new System.Drawing.Point(124, 69);
            this.txt_aes_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_aes_key.Name = "txt_aes_key";
            this.txt_aes_key.Size = new System.Drawing.Size(548, 22);
            this.txt_aes_key.TabIndex = 4;
            // 
            // check_aes_random
            // 
            this.check_aes_random.AutoSize = true;
            this.check_aes_random.Location = new System.Drawing.Point(679, 72);
            this.check_aes_random.Margin = new System.Windows.Forms.Padding(4);
            this.check_aes_random.Name = "check_aes_random";
            this.check_aes_random.Size = new System.Drawing.Size(285, 18);
            this.check_aes_random.TabIndex = 3;
            this.check_aes_random.Text = "使用JAVA随机安全密钥(SecureRandomKey)";
            this.check_aes_random.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(72, 475);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(35, 14);
            this.label23.TabIndex = 2;
            this.label23.Text = "密文";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(72, 235);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 14);
            this.label22.TabIndex = 1;
            this.label22.Text = "明文";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(72, 74);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 14);
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
            this.tabPage_base58.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_base58.Location = new System.Drawing.Point(4, 39);
            this.tabPage_base58.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_base58.Name = "tabPage_base58";
            this.tabPage_base58.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_base58.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_base58.TabIndex = 3;
            this.tabPage_base58.Text = "BASE58";
            this.tabPage_base58.UseVisualStyleBackColor = true;
            // 
            // radio_base58_gbk
            // 
            this.radio_base58_gbk.AutoSize = true;
            this.radio_base58_gbk.Location = new System.Drawing.Point(438, 48);
            this.radio_base58_gbk.Margin = new System.Windows.Forms.Padding(4);
            this.radio_base58_gbk.Name = "radio_base58_gbk";
            this.radio_base58_gbk.Size = new System.Drawing.Size(46, 18);
            this.radio_base58_gbk.TabIndex = 6;
            this.radio_base58_gbk.Text = "GBK";
            this.radio_base58_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_base58_ascii
            // 
            this.radio_base58_ascii.AutoSize = true;
            this.radio_base58_ascii.Location = new System.Drawing.Point(255, 48);
            this.radio_base58_ascii.Margin = new System.Windows.Forms.Padding(4);
            this.radio_base58_ascii.Name = "radio_base58_ascii";
            this.radio_base58_ascii.Size = new System.Drawing.Size(60, 18);
            this.radio_base58_ascii.TabIndex = 5;
            this.radio_base58_ascii.Text = "ASCII";
            this.radio_base58_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_base58_utf8
            // 
            this.radio_base58_utf8.AutoSize = true;
            this.radio_base58_utf8.Checked = true;
            this.radio_base58_utf8.Location = new System.Drawing.Point(74, 48);
            this.radio_base58_utf8.Margin = new System.Windows.Forms.Padding(4);
            this.radio_base58_utf8.Name = "radio_base58_utf8";
            this.radio_base58_utf8.Size = new System.Drawing.Size(60, 18);
            this.radio_base58_utf8.TabIndex = 4;
            this.radio_base58_utf8.TabStop = true;
            this.radio_base58_utf8.Text = "UTF-8";
            this.radio_base58_utf8.UseVisualStyleBackColor = true;
            // 
            // txt_base58_cipher
            // 
            this.txt_base58_cipher.Location = new System.Drawing.Point(74, 457);
            this.txt_base58_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_base58_cipher.Multiline = true;
            this.txt_base58_cipher.Name = "txt_base58_cipher";
            this.txt_base58_cipher.Size = new System.Drawing.Size(891, 200);
            this.txt_base58_cipher.TabIndex = 3;
            // 
            // btnBase58Decode
            // 
            this.btnBase58Decode.Location = new System.Drawing.Point(580, 361);
            this.btnBase58Decode.Margin = new System.Windows.Forms.Padding(4);
            this.btnBase58Decode.Name = "btnBase58Decode";
            this.btnBase58Decode.Size = new System.Drawing.Size(385, 47);
            this.btnBase58Decode.TabIndex = 2;
            this.btnBase58Decode.Text = "解码↑";
            this.btnBase58Decode.UseVisualStyleBackColor = true;
            this.btnBase58Decode.Click += new System.EventHandler(this.btnBase58Decode_Click);
            // 
            // btnBase58Encode
            // 
            this.btnBase58Encode.Location = new System.Drawing.Point(74, 361);
            this.btnBase58Encode.Margin = new System.Windows.Forms.Padding(4);
            this.btnBase58Encode.Name = "btnBase58Encode";
            this.btnBase58Encode.Size = new System.Drawing.Size(385, 47);
            this.btnBase58Encode.TabIndex = 1;
            this.btnBase58Encode.Text = "编码↓";
            this.btnBase58Encode.UseVisualStyleBackColor = true;
            this.btnBase58Encode.Click += new System.EventHandler(this.btnBase58Encode_Click);
            // 
            // txt_base58_plain
            // 
            this.txt_base58_plain.Location = new System.Drawing.Point(74, 115);
            this.txt_base58_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_base58_plain.Multiline = true;
            this.txt_base58_plain.Name = "txt_base58_plain";
            this.txt_base58_plain.Size = new System.Drawing.Size(891, 194);
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
            this.tabPage_base64.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_base64.Location = new System.Drawing.Point(4, 39);
            this.tabPage_base64.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_base64.Name = "tabPage_base64";
            this.tabPage_base64.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_base64.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_base64.TabIndex = 4;
            this.tabPage_base64.Text = "BASE64";
            this.tabPage_base64.UseVisualStyleBackColor = true;
            // 
            // btnBase64Decode
            // 
            this.btnBase64Decode.Location = new System.Drawing.Point(580, 354);
            this.btnBase64Decode.Margin = new System.Windows.Forms.Padding(4);
            this.btnBase64Decode.Name = "btnBase64Decode";
            this.btnBase64Decode.Size = new System.Drawing.Size(385, 47);
            this.btnBase64Decode.TabIndex = 6;
            this.btnBase64Decode.Text = "解码↑";
            this.btnBase64Decode.UseVisualStyleBackColor = true;
            this.btnBase64Decode.Click += new System.EventHandler(this.btnBase64Decode_Click);
            // 
            // btnBase64Encode
            // 
            this.btnBase64Encode.Location = new System.Drawing.Point(74, 354);
            this.btnBase64Encode.Margin = new System.Windows.Forms.Padding(4);
            this.btnBase64Encode.Name = "btnBase64Encode";
            this.btnBase64Encode.Size = new System.Drawing.Size(385, 47);
            this.btnBase64Encode.TabIndex = 5;
            this.btnBase64Encode.Text = "编码↓";
            this.btnBase64Encode.UseVisualStyleBackColor = true;
            this.btnBase64Encode.Click += new System.EventHandler(this.btnBase64Encode_Click);
            // 
            // txt_base64_cipher
            // 
            this.txt_base64_cipher.Location = new System.Drawing.Point(74, 450);
            this.txt_base64_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_base64_cipher.Multiline = true;
            this.txt_base64_cipher.Name = "txt_base64_cipher";
            this.txt_base64_cipher.Size = new System.Drawing.Size(891, 222);
            this.txt_base64_cipher.TabIndex = 4;
            // 
            // txt_base64_plain
            // 
            this.txt_base64_plain.Location = new System.Drawing.Point(74, 115);
            this.txt_base64_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_base64_plain.Multiline = true;
            this.txt_base64_plain.Name = "txt_base64_plain";
            this.txt_base64_plain.Size = new System.Drawing.Size(891, 202);
            this.txt_base64_plain.TabIndex = 3;
            // 
            // radio_base64_gbk
            // 
            this.radio_base64_gbk.AutoSize = true;
            this.radio_base64_gbk.Location = new System.Drawing.Point(438, 48);
            this.radio_base64_gbk.Margin = new System.Windows.Forms.Padding(4);
            this.radio_base64_gbk.Name = "radio_base64_gbk";
            this.radio_base64_gbk.Size = new System.Drawing.Size(46, 18);
            this.radio_base64_gbk.TabIndex = 2;
            this.radio_base64_gbk.Text = "GBK";
            this.radio_base64_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_base64_ascii
            // 
            this.radio_base64_ascii.AutoSize = true;
            this.radio_base64_ascii.Location = new System.Drawing.Point(255, 48);
            this.radio_base64_ascii.Margin = new System.Windows.Forms.Padding(4);
            this.radio_base64_ascii.Name = "radio_base64_ascii";
            this.radio_base64_ascii.Size = new System.Drawing.Size(60, 18);
            this.radio_base64_ascii.TabIndex = 1;
            this.radio_base64_ascii.Text = "ASCII";
            this.radio_base64_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_base64_utf8
            // 
            this.radio_base64_utf8.AutoSize = true;
            this.radio_base64_utf8.Checked = true;
            this.radio_base64_utf8.Location = new System.Drawing.Point(74, 48);
            this.radio_base64_utf8.Margin = new System.Windows.Forms.Padding(4);
            this.radio_base64_utf8.Name = "radio_base64_utf8";
            this.radio_base64_utf8.Size = new System.Drawing.Size(60, 18);
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
            this.tabPage_md5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_md5.Location = new System.Drawing.Point(4, 39);
            this.tabPage_md5.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_md5.Name = "tabPage_md5";
            this.tabPage_md5.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_md5.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_md5.TabIndex = 5;
            this.tabPage_md5.Text = "MD5";
            this.tabPage_md5.UseVisualStyleBackColor = true;
            // 
            // btnMd5Encode
            // 
            this.btnMd5Encode.Location = new System.Drawing.Point(76, 312);
            this.btnMd5Encode.Margin = new System.Windows.Forms.Padding(4);
            this.btnMd5Encode.Name = "btnMd5Encode";
            this.btnMd5Encode.Size = new System.Drawing.Size(891, 47);
            this.btnMd5Encode.TabIndex = 12;
            this.btnMd5Encode.Text = "编码↓";
            this.btnMd5Encode.UseVisualStyleBackColor = true;
            this.btnMd5Encode.Click += new System.EventHandler(this.btnMd5Encode_Click);
            // 
            // txt_md5_cipher
            // 
            this.txt_md5_cipher.Location = new System.Drawing.Point(76, 396);
            this.txt_md5_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_md5_cipher.Multiline = true;
            this.txt_md5_cipher.Name = "txt_md5_cipher";
            this.txt_md5_cipher.Size = new System.Drawing.Size(891, 200);
            this.txt_md5_cipher.TabIndex = 11;
            // 
            // txt_md5_plain
            // 
            this.txt_md5_plain.Location = new System.Drawing.Point(76, 113);
            this.txt_md5_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_md5_plain.Multiline = true;
            this.txt_md5_plain.Name = "txt_md5_plain";
            this.txt_md5_plain.Size = new System.Drawing.Size(891, 166);
            this.txt_md5_plain.TabIndex = 10;
            // 
            // radio_md5_gbk
            // 
            this.radio_md5_gbk.AutoSize = true;
            this.radio_md5_gbk.Location = new System.Drawing.Point(441, 48);
            this.radio_md5_gbk.Margin = new System.Windows.Forms.Padding(4);
            this.radio_md5_gbk.Name = "radio_md5_gbk";
            this.radio_md5_gbk.Size = new System.Drawing.Size(46, 18);
            this.radio_md5_gbk.TabIndex = 9;
            this.radio_md5_gbk.Text = "GBK";
            this.radio_md5_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_md5_ascii
            // 
            this.radio_md5_ascii.AutoSize = true;
            this.radio_md5_ascii.Location = new System.Drawing.Point(258, 48);
            this.radio_md5_ascii.Margin = new System.Windows.Forms.Padding(4);
            this.radio_md5_ascii.Name = "radio_md5_ascii";
            this.radio_md5_ascii.Size = new System.Drawing.Size(60, 18);
            this.radio_md5_ascii.TabIndex = 8;
            this.radio_md5_ascii.Text = "ASCII";
            this.radio_md5_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_md5_utf8
            // 
            this.radio_md5_utf8.AutoSize = true;
            this.radio_md5_utf8.Checked = true;
            this.radio_md5_utf8.Location = new System.Drawing.Point(74, 48);
            this.radio_md5_utf8.Margin = new System.Windows.Forms.Padding(4);
            this.radio_md5_utf8.Name = "radio_md5_utf8";
            this.radio_md5_utf8.Size = new System.Drawing.Size(60, 18);
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
            this.tabPage_sha.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_sha.Location = new System.Drawing.Point(4, 39);
            this.tabPage_sha.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_sha.Name = "tabPage_sha";
            this.tabPage_sha.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_sha.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_sha.TabIndex = 6;
            this.tabPage_sha.Text = "SHA";
            this.tabPage_sha.UseVisualStyleBackColor = true;
            // 
            // btnSha256
            // 
            this.btnSha256.Location = new System.Drawing.Point(391, 306);
            this.btnSha256.Margin = new System.Windows.Forms.Padding(4);
            this.btnSha256.Name = "btnSha256";
            this.btnSha256.Size = new System.Drawing.Size(257, 47);
            this.btnSha256.TabIndex = 14;
            this.btnSha256.Text = "SHA256↓";
            this.btnSha256.UseVisualStyleBackColor = true;
            this.btnSha256.Click += new System.EventHandler(this.btnSha256_Click);
            // 
            // btnSha512
            // 
            this.btnSha512.Location = new System.Drawing.Point(708, 306);
            this.btnSha512.Margin = new System.Windows.Forms.Padding(4);
            this.btnSha512.Name = "btnSha512";
            this.btnSha512.Size = new System.Drawing.Size(257, 47);
            this.btnSha512.TabIndex = 13;
            this.btnSha512.Text = "SHA512↓";
            this.btnSha512.UseVisualStyleBackColor = true;
            this.btnSha512.Click += new System.EventHandler(this.btnSha512_Click);
            // 
            // btnSha1
            // 
            this.btnSha1.Location = new System.Drawing.Point(74, 306);
            this.btnSha1.Margin = new System.Windows.Forms.Padding(4);
            this.btnSha1.Name = "btnSha1";
            this.btnSha1.Size = new System.Drawing.Size(257, 47);
            this.btnSha1.TabIndex = 12;
            this.btnSha1.Text = "SHA1↓";
            this.btnSha1.UseVisualStyleBackColor = true;
            this.btnSha1.Click += new System.EventHandler(this.btnSha1_Click);
            // 
            // txt_sha_cipher
            // 
            this.txt_sha_cipher.Location = new System.Drawing.Point(74, 402);
            this.txt_sha_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sha_cipher.Multiline = true;
            this.txt_sha_cipher.Name = "txt_sha_cipher";
            this.txt_sha_cipher.Size = new System.Drawing.Size(891, 175);
            this.txt_sha_cipher.TabIndex = 11;
            // 
            // txt_sha_plain
            // 
            this.txt_sha_plain.Location = new System.Drawing.Point(74, 115);
            this.txt_sha_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sha_plain.Multiline = true;
            this.txt_sha_plain.Name = "txt_sha_plain";
            this.txt_sha_plain.Size = new System.Drawing.Size(891, 153);
            this.txt_sha_plain.TabIndex = 10;
            // 
            // radio_sha_gbk
            // 
            this.radio_sha_gbk.AutoSize = true;
            this.radio_sha_gbk.Location = new System.Drawing.Point(438, 48);
            this.radio_sha_gbk.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sha_gbk.Name = "radio_sha_gbk";
            this.radio_sha_gbk.Size = new System.Drawing.Size(46, 18);
            this.radio_sha_gbk.TabIndex = 9;
            this.radio_sha_gbk.Text = "GBK";
            this.radio_sha_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_sha_ascii
            // 
            this.radio_sha_ascii.AutoSize = true;
            this.radio_sha_ascii.Location = new System.Drawing.Point(255, 48);
            this.radio_sha_ascii.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sha_ascii.Name = "radio_sha_ascii";
            this.radio_sha_ascii.Size = new System.Drawing.Size(60, 18);
            this.radio_sha_ascii.TabIndex = 8;
            this.radio_sha_ascii.Text = "ASCII";
            this.radio_sha_ascii.UseVisualStyleBackColor = true;
            // 
            // radio_sha_utf8
            // 
            this.radio_sha_utf8.AutoSize = true;
            this.radio_sha_utf8.Checked = true;
            this.radio_sha_utf8.Location = new System.Drawing.Point(74, 48);
            this.radio_sha_utf8.Margin = new System.Windows.Forms.Padding(4);
            this.radio_sha_utf8.Name = "radio_sha_utf8";
            this.radio_sha_utf8.Size = new System.Drawing.Size(60, 18);
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
            this.tabPage_urlencode.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage_urlencode.Location = new System.Drawing.Point(4, 39);
            this.tabPage_urlencode.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage_urlencode.Name = "tabPage_urlencode";
            this.tabPage_urlencode.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage_urlencode.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_urlencode.TabIndex = 7;
            this.tabPage_urlencode.Text = "URL ENCODE";
            this.tabPage_urlencode.UseVisualStyleBackColor = true;
            // 
            // btnUrlDecode
            // 
            this.btnUrlDecode.Location = new System.Drawing.Point(580, 339);
            this.btnUrlDecode.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrlDecode.Name = "btnUrlDecode";
            this.btnUrlDecode.Size = new System.Drawing.Size(385, 47);
            this.btnUrlDecode.TabIndex = 13;
            this.btnUrlDecode.Text = "解码↑";
            this.btnUrlDecode.UseVisualStyleBackColor = true;
            this.btnUrlDecode.Click += new System.EventHandler(this.btnUrlDecode_Click);
            // 
            // btnUrlEncode
            // 
            this.btnUrlEncode.Location = new System.Drawing.Point(74, 339);
            this.btnUrlEncode.Margin = new System.Windows.Forms.Padding(4);
            this.btnUrlEncode.Name = "btnUrlEncode";
            this.btnUrlEncode.Size = new System.Drawing.Size(385, 47);
            this.btnUrlEncode.TabIndex = 12;
            this.btnUrlEncode.Text = "编码↓";
            this.btnUrlEncode.UseVisualStyleBackColor = true;
            this.btnUrlEncode.Click += new System.EventHandler(this.btnUrlEncode_Click);
            // 
            // txt_urlencode_cipher
            // 
            this.txt_urlencode_cipher.Location = new System.Drawing.Point(74, 435);
            this.txt_urlencode_cipher.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urlencode_cipher.Multiline = true;
            this.txt_urlencode_cipher.Name = "txt_urlencode_cipher";
            this.txt_urlencode_cipher.Size = new System.Drawing.Size(891, 185);
            this.txt_urlencode_cipher.TabIndex = 11;
            // 
            // txt_urlencode_plain
            // 
            this.txt_urlencode_plain.Location = new System.Drawing.Point(74, 115);
            this.txt_urlencode_plain.Margin = new System.Windows.Forms.Padding(4);
            this.txt_urlencode_plain.Multiline = true;
            this.txt_urlencode_plain.Name = "txt_urlencode_plain";
            this.txt_urlencode_plain.Size = new System.Drawing.Size(891, 186);
            this.txt_urlencode_plain.TabIndex = 10;
            // 
            // radio_urlencode_gbk
            // 
            this.radio_urlencode_gbk.AutoSize = true;
            this.radio_urlencode_gbk.Location = new System.Drawing.Point(438, 48);
            this.radio_urlencode_gbk.Margin = new System.Windows.Forms.Padding(4);
            this.radio_urlencode_gbk.Name = "radio_urlencode_gbk";
            this.radio_urlencode_gbk.Size = new System.Drawing.Size(41, 16);
            this.radio_urlencode_gbk.TabIndex = 9;
            this.radio_urlencode_gbk.Text = "GBK";
            this.radio_urlencode_gbk.UseVisualStyleBackColor = true;
            // 
            // radio_urlencode_ascii
            // 
            this.radio_urlencode_ascii.AutoSize = true;
            this.radio_urlencode_ascii.Location = new System.Drawing.Point(255, 48);
            this.radio_urlencode_ascii.Margin = new System.Windows.Forms.Padding(4);
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
            this.radio_urlencode_utf8.Location = new System.Drawing.Point(74, 48);
            this.radio_urlencode_utf8.Margin = new System.Windows.Forms.Padding(4);
            this.radio_urlencode_utf8.Name = "radio_urlencode_utf8";
            this.radio_urlencode_utf8.Size = new System.Drawing.Size(53, 16);
            this.radio_urlencode_utf8.TabIndex = 7;
            this.radio_urlencode_utf8.TabStop = true;
            this.radio_urlencode_utf8.Text = "UTF-8";
            this.radio_urlencode_utf8.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnQrCodeGenerate);
            this.tabPage1.Controls.Add(this.picQrCode);
            this.tabPage1.Controls.Add(this.txt_qrcode_text);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1054, 787);
            this.tabPage1.TabIndex = 8;
            this.tabPage1.Text = "QRCode";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnQrCodeGenerate
            // 
            this.btnQrCodeGenerate.Location = new System.Drawing.Point(502, 728);
            this.btnQrCodeGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnQrCodeGenerate.Name = "btnQrCodeGenerate";
            this.btnQrCodeGenerate.Size = new System.Drawing.Size(547, 47);
            this.btnQrCodeGenerate.TabIndex = 2;
            this.btnQrCodeGenerate.Text = "生成二维码";
            this.btnQrCodeGenerate.UseVisualStyleBackColor = true;
            this.btnQrCodeGenerate.Click += new System.EventHandler(this.btnQrCodeGenerate_Click);
            // 
            // picQrCode
            // 
            this.picQrCode.Location = new System.Drawing.Point(502, 8);
            this.picQrCode.Margin = new System.Windows.Forms.Padding(4);
            this.picQrCode.Name = "picQrCode";
            this.picQrCode.Size = new System.Drawing.Size(547, 133);
            this.picQrCode.TabIndex = 1;
            this.picQrCode.TabStop = false;
            // 
            // txt_qrcode_text
            // 
            this.txt_qrcode_text.Location = new System.Drawing.Point(7, 8);
            this.txt_qrcode_text.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qrcode_text.Multiline = true;
            this.txt_qrcode_text.Name = "txt_qrcode_text";
            this.txt_qrcode_text.Size = new System.Drawing.Size(487, 767);
            this.txt_qrcode_text.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.txt_sign_sourcedata);
            this.tabPage2.Controls.Add(this.txt_sign_sign);
            this.tabPage2.Controls.Add(this.btn_sign_calculate);
            this.tabPage2.Controls.Add(this.txt_sign_service);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.txt_sign_key);
            this.tabPage2.Controls.Add(this.txt_sign_body);
            this.tabPage2.Controls.Add(this.txt_sign_token);
            this.tabPage2.Controls.Add(this.txt_sign_timestamp);
            this.tabPage2.Controls.Add(this.txt_sign_path);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.label29);
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1054, 787);
            this.tabPage2.TabIndex = 9;
            this.tabPage2.Text = "API签名计算";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(107, 600);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(56, 17);
            this.label36.TabIndex = 12;
            this.label36.Text = "签名值";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(91, 486);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 17);
            this.label35.TabIndex = 11;
            this.label35.Text = "签名源串";
            // 
            // txt_sign_sourcedata
            // 
            this.txt_sign_sourcedata.Location = new System.Drawing.Point(191, 482);
            this.txt_sign_sourcedata.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_sourcedata.Multiline = true;
            this.txt_sign_sourcedata.Name = "txt_sign_sourcedata";
            this.txt_sign_sourcedata.Size = new System.Drawing.Size(766, 80);
            this.txt_sign_sourcedata.TabIndex = 10;
            // 
            // txt_sign_sign
            // 
            this.txt_sign_sign.Location = new System.Drawing.Point(191, 595);
            this.txt_sign_sign.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_sign.Name = "txt_sign_sign";
            this.txt_sign_sign.Size = new System.Drawing.Size(766, 23);
            this.txt_sign_sign.TabIndex = 9;
            // 
            // btn_sign_calculate
            // 
            this.btn_sign_calculate.Location = new System.Drawing.Point(191, 402);
            this.btn_sign_calculate.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sign_calculate.Name = "btn_sign_calculate";
            this.btn_sign_calculate.Size = new System.Drawing.Size(766, 54);
            this.btn_sign_calculate.TabIndex = 6;
            this.btn_sign_calculate.Text = "计算MD5";
            this.btn_sign_calculate.UseVisualStyleBackColor = true;
            this.btn_sign_calculate.Click += new System.EventHandler(this.btn_sign_calculate_Click);
            // 
            // txt_sign_service
            // 
            this.txt_sign_service.Location = new System.Drawing.Point(191, 21);
            this.txt_sign_service.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_service.Name = "txt_sign_service";
            this.txt_sign_service.Size = new System.Drawing.Size(766, 23);
            this.txt_sign_service.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(99, 26);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(64, 17);
            this.label34.TabIndex = 6;
            this.label34.Text = "service";
            // 
            // txt_sign_key
            // 
            this.txt_sign_key.Location = new System.Drawing.Point(191, 356);
            this.txt_sign_key.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_key.Name = "txt_sign_key";
            this.txt_sign_key.Size = new System.Drawing.Size(766, 23);
            this.txt_sign_key.TabIndex = 5;
            // 
            // txt_sign_body
            // 
            this.txt_sign_body.Location = new System.Drawing.Point(191, 205);
            this.txt_sign_body.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_body.Multiline = true;
            this.txt_sign_body.Name = "txt_sign_body";
            this.txt_sign_body.Size = new System.Drawing.Size(766, 126);
            this.txt_sign_body.TabIndex = 4;
            // 
            // txt_sign_token
            // 
            this.txt_sign_token.Location = new System.Drawing.Point(191, 155);
            this.txt_sign_token.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_token.Name = "txt_sign_token";
            this.txt_sign_token.Size = new System.Drawing.Size(766, 23);
            this.txt_sign_token.TabIndex = 3;
            // 
            // txt_sign_timestamp
            // 
            this.txt_sign_timestamp.Location = new System.Drawing.Point(191, 105);
            this.txt_sign_timestamp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_timestamp.Name = "txt_sign_timestamp";
            this.txt_sign_timestamp.Size = new System.Drawing.Size(766, 23);
            this.txt_sign_timestamp.TabIndex = 2;
            // 
            // txt_sign_path
            // 
            this.txt_sign_path.Location = new System.Drawing.Point(191, 61);
            this.txt_sign_path.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sign_path.Name = "txt_sign_path";
            this.txt_sign_path.Size = new System.Drawing.Size(766, 23);
            this.txt_sign_path.TabIndex = 1;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(132, 360);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(32, 17);
            this.label33.TabIndex = 4;
            this.label33.Text = "key";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(124, 209);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(40, 17);
            this.label32.TabIndex = 3;
            this.label32.Text = "body";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(115, 159);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(48, 17);
            this.label31.TabIndex = 2;
            this.label31.Text = "token";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(83, 109);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 17);
            this.label30.TabIndex = 1;
            this.label30.Text = "timestamp";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(124, 65);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(40, 17);
            this.label29.TabIndex = 0;
            this.label29.Text = "path";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cb_guid_suffix);
            this.tabPage3.Controls.Add(this.cb_guid_nosplit);
            this.tabPage3.Controls.Add(this.cb_guid_case);
            this.tabPage3.Controls.Add(this.txt_guid_count);
            this.tabPage3.Controls.Add(this.label37);
            this.tabPage3.Controls.Add(this.btn_gen_guid);
            this.tabPage3.Controls.Add(this.txt_guid);
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1054, 787);
            this.tabPage3.TabIndex = 10;
            this.tabPage3.Text = "GUID";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cb_guid_suffix
            // 
            this.cb_guid_suffix.AutoSize = true;
            this.cb_guid_suffix.Location = new System.Drawing.Point(351, 122);
            this.cb_guid_suffix.Margin = new System.Windows.Forms.Padding(4);
            this.cb_guid_suffix.Name = "cb_guid_suffix";
            this.cb_guid_suffix.Size = new System.Drawing.Size(107, 21);
            this.cb_guid_suffix.TabIndex = 6;
            this.cb_guid_suffix.Text = "包含在\"{}\"";
            this.cb_guid_suffix.UseVisualStyleBackColor = true;
            // 
            // cb_guid_nosplit
            // 
            this.cb_guid_nosplit.AutoSize = true;
            this.cb_guid_nosplit.Checked = true;
            this.cb_guid_nosplit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_guid_nosplit.Location = new System.Drawing.Point(175, 122);
            this.cb_guid_nosplit.Margin = new System.Windows.Forms.Padding(4);
            this.cb_guid_nosplit.Name = "cb_guid_nosplit";
            this.cb_guid_nosplit.Size = new System.Drawing.Size(147, 21);
            this.cb_guid_nosplit.TabIndex = 5;
            this.cb_guid_nosplit.Text = "去掉分隔符（-）";
            this.cb_guid_nosplit.UseVisualStyleBackColor = true;
            // 
            // cb_guid_case
            // 
            this.cb_guid_case.AutoSize = true;
            this.cb_guid_case.Location = new System.Drawing.Point(78, 122);
            this.cb_guid_case.Margin = new System.Windows.Forms.Padding(4);
            this.cb_guid_case.Name = "cb_guid_case";
            this.cb_guid_case.Size = new System.Drawing.Size(59, 21);
            this.cb_guid_case.TabIndex = 4;
            this.cb_guid_case.Text = "大写";
            this.cb_guid_case.UseVisualStyleBackColor = true;
            // 
            // txt_guid_count
            // 
            this.txt_guid_count.Location = new System.Drawing.Point(78, 54);
            this.txt_guid_count.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guid_count.Name = "txt_guid_count";
            this.txt_guid_count.Size = new System.Drawing.Size(970, 23);
            this.txt_guid_count.TabIndex = 3;
            this.txt_guid_count.Text = "1";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(9, 58);
            this.label37.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 17);
            this.label37.TabIndex = 2;
            this.label37.Text = "数量";
            // 
            // btn_gen_guid
            // 
            this.btn_gen_guid.Location = new System.Drawing.Point(9, 179);
            this.btn_gen_guid.Margin = new System.Windows.Forms.Padding(4);
            this.btn_gen_guid.Name = "btn_gen_guid";
            this.btn_gen_guid.Size = new System.Drawing.Size(1040, 44);
            this.btn_gen_guid.TabIndex = 1;
            this.btn_gen_guid.Text = "生成GUID↓";
            this.btn_gen_guid.UseVisualStyleBackColor = true;
            this.btn_gen_guid.Click += new System.EventHandler(this.btn_gen_guid_Click);
            // 
            // txt_guid
            // 
            this.txt_guid.Location = new System.Drawing.Point(8, 255);
            this.txt_guid.Margin = new System.Windows.Forms.Padding(4);
            this.txt_guid.Multiline = true;
            this.txt_guid.Name = "txt_guid";
            this.txt_guid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_guid.Size = new System.Drawing.Size(1039, 391);
            this.txt_guid.TabIndex = 0;
            // 
            // tabPage_timestamp
            // 
            this.tabPage_timestamp.Controls.Add(this.btnTimeToTicks);
            this.tabPage_timestamp.Controls.Add(this.btnTicksToTime);
            this.tabPage_timestamp.Controls.Add(this.txtCurTimeTransform);
            this.tabPage_timestamp.Controls.Add(this.txtCurTimeStampTransform);
            this.tabPage_timestamp.Controls.Add(this.txtCurTime);
            this.tabPage_timestamp.Controls.Add(this.txtCurTimeStamp);
            this.tabPage_timestamp.Controls.Add(this.lbl_current_timestamp);
            this.tabPage_timestamp.Controls.Add(this.label43);
            this.tabPage_timestamp.Controls.Add(this.btnStopTimeTicks);
            this.tabPage_timestamp.Controls.Add(this.label45);
            this.tabPage_timestamp.Controls.Add(this.lbl_current_time);
            this.tabPage_timestamp.Controls.Add(this.label44);
            this.tabPage_timestamp.Controls.Add(this.label42);
            this.tabPage_timestamp.Location = new System.Drawing.Point(4, 39);
            this.tabPage_timestamp.Name = "tabPage_timestamp";
            this.tabPage_timestamp.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_timestamp.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_timestamp.TabIndex = 11;
            this.tabPage_timestamp.Text = "timestamp";
            this.tabPage_timestamp.UseVisualStyleBackColor = true;
            // 
            // btnTimeToTicks
            // 
            this.btnTimeToTicks.Location = new System.Drawing.Point(457, 223);
            this.btnTimeToTicks.Name = "btnTimeToTicks";
            this.btnTimeToTicks.Size = new System.Drawing.Size(75, 23);
            this.btnTimeToTicks.TabIndex = 6;
            this.btnTimeToTicks.Text = "转换>>";
            this.btnTimeToTicks.UseVisualStyleBackColor = true;
            this.btnTimeToTicks.Click += new System.EventHandler(this.btnTimeToTicks_Click);
            // 
            // btnTicksToTime
            // 
            this.btnTicksToTime.Location = new System.Drawing.Point(457, 172);
            this.btnTicksToTime.Name = "btnTicksToTime";
            this.btnTicksToTime.Size = new System.Drawing.Size(75, 23);
            this.btnTicksToTime.TabIndex = 6;
            this.btnTicksToTime.Text = "转换>>";
            this.btnTicksToTime.UseVisualStyleBackColor = true;
            this.btnTicksToTime.Click += new System.EventHandler(this.btnTicksToTime_Click);
            // 
            // txtCurTimeTransform
            // 
            this.txtCurTimeTransform.Location = new System.Drawing.Point(586, 223);
            this.txtCurTimeTransform.Name = "txtCurTimeTransform";
            this.txtCurTimeTransform.Size = new System.Drawing.Size(164, 23);
            this.txtCurTimeTransform.TabIndex = 5;
            // 
            // txtCurTimeStampTransform
            // 
            this.txtCurTimeStampTransform.Location = new System.Drawing.Point(586, 173);
            this.txtCurTimeStampTransform.Name = "txtCurTimeStampTransform";
            this.txtCurTimeStampTransform.Size = new System.Drawing.Size(164, 23);
            this.txtCurTimeStampTransform.TabIndex = 5;
            // 
            // txtCurTime
            // 
            this.txtCurTime.Location = new System.Drawing.Point(254, 223);
            this.txtCurTime.Name = "txtCurTime";
            this.txtCurTime.Size = new System.Drawing.Size(164, 23);
            this.txtCurTime.TabIndex = 5;
            // 
            // txtCurTimeStamp
            // 
            this.txtCurTimeStamp.Location = new System.Drawing.Point(254, 173);
            this.txtCurTimeStamp.Name = "txtCurTimeStamp";
            this.txtCurTimeStamp.Size = new System.Drawing.Size(164, 23);
            this.txtCurTimeStamp.TabIndex = 5;
            // 
            // lbl_current_timestamp
            // 
            this.lbl_current_timestamp.AutoSize = true;
            this.lbl_current_timestamp.Location = new System.Drawing.Point(244, 124);
            this.lbl_current_timestamp.Name = "lbl_current_timestamp";
            this.lbl_current_timestamp.Size = new System.Drawing.Size(64, 17);
            this.lbl_current_timestamp.TabIndex = 4;
            this.lbl_current_timestamp.Text = "label44";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(407, 124);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(88, 17);
            this.label43.TabIndex = 3;
            this.label43.Text = "北京时间：";
            // 
            // btnStopTimeTicks
            // 
            this.btnStopTimeTicks.Location = new System.Drawing.Point(675, 120);
            this.btnStopTimeTicks.Name = "btnStopTimeTicks";
            this.btnStopTimeTicks.Size = new System.Drawing.Size(75, 23);
            this.btnStopTimeTicks.TabIndex = 2;
            this.btnStopTimeTicks.Text = "停止";
            this.btnStopTimeTicks.UseVisualStyleBackColor = true;
            this.btnStopTimeTicks.Click += new System.EventHandler(this.btnStopTimeTicks_Click);
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(192, 226);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(56, 17);
            this.label45.TabIndex = 0;
            this.label45.Text = "时间：";
            // 
            // lbl_current_time
            // 
            this.lbl_current_time.AutoSize = true;
            this.lbl_current_time.Location = new System.Drawing.Point(503, 124);
            this.lbl_current_time.Name = "lbl_current_time";
            this.lbl_current_time.Size = new System.Drawing.Size(64, 17);
            this.lbl_current_time.TabIndex = 1;
            this.lbl_current_time.Text = "label43";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(176, 176);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(72, 17);
            this.label44.TabIndex = 0;
            this.label44.Text = "时间戳：";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(192, 124);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(56, 17);
            this.label42.TabIndex = 0;
            this.label42.Text = "现在：";
            // 
            // tabPage_jwt
            // 
            this.tabPage_jwt.Controls.Add(this.txtJwtDecodeJson);
            this.tabPage_jwt.Controls.Add(this.btnSensitiveDecode);
            this.tabPage_jwt.Controls.Add(this.txtSensitivePlainText);
            this.tabPage_jwt.Controls.Add(this.txtJwtSensitiveCipher);
            this.tabPage_jwt.Controls.Add(this.txtJwtTickets);
            this.tabPage_jwt.Controls.Add(this.label50);
            this.tabPage_jwt.Controls.Add(this.label49);
            this.tabPage_jwt.Controls.Add(this.label48);
            this.tabPage_jwt.Controls.Add(this.label47);
            this.tabPage_jwt.Controls.Add(this.txtJwtSeed);
            this.tabPage_jwt.Controls.Add(this.label46);
            this.tabPage_jwt.Controls.Add(this.txtJwtToken);
            this.tabPage_jwt.Location = new System.Drawing.Point(4, 39);
            this.tabPage_jwt.Name = "tabPage_jwt";
            this.tabPage_jwt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_jwt.Size = new System.Drawing.Size(1054, 787);
            this.tabPage_jwt.TabIndex = 12;
            this.tabPage_jwt.Text = "JsonWebToken";
            this.tabPage_jwt.UseVisualStyleBackColor = true;
            // 
            // txtJwtDecodeJson
            // 
            this.txtJwtDecodeJson.BackColor = System.Drawing.SystemColors.Window;
            this.txtJwtDecodeJson.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtJwtDecodeJson.Location = new System.Drawing.Point(110, 588);
            this.txtJwtDecodeJson.Multiline = true;
            this.txtJwtDecodeJson.Name = "txtJwtDecodeJson";
            this.txtJwtDecodeJson.ReadOnly = true;
            this.txtJwtDecodeJson.Size = new System.Drawing.Size(808, 117);
            this.txtJwtDecodeJson.TabIndex = 8;
            this.txtJwtDecodeJson.Visible = false;
            // 
            // btnSensitiveDecode
            // 
            this.btnSensitiveDecode.Location = new System.Drawing.Point(110, 514);
            this.btnSensitiveDecode.Name = "btnSensitiveDecode";
            this.btnSensitiveDecode.Size = new System.Drawing.Size(808, 38);
            this.btnSensitiveDecode.TabIndex = 7;
            this.btnSensitiveDecode.Text = "Run Decode";
            this.btnSensitiveDecode.UseVisualStyleBackColor = true;
            this.btnSensitiveDecode.Click += new System.EventHandler(this.btnSensitiveDecode_Click);
            // 
            // txtSensitivePlainText
            // 
            this.txtSensitivePlainText.Location = new System.Drawing.Point(110, 455);
            this.txtSensitivePlainText.Name = "txtSensitivePlainText";
            this.txtSensitivePlainText.Size = new System.Drawing.Size(808, 23);
            this.txtSensitivePlainText.TabIndex = 6;
            // 
            // txtJwtSensitiveCipher
            // 
            this.txtJwtSensitiveCipher.Location = new System.Drawing.Point(110, 390);
            this.txtJwtSensitiveCipher.Name = "txtJwtSensitiveCipher";
            this.txtJwtSensitiveCipher.Size = new System.Drawing.Size(808, 23);
            this.txtJwtSensitiveCipher.TabIndex = 5;
            // 
            // txtJwtTickets
            // 
            this.txtJwtTickets.Location = new System.Drawing.Point(110, 325);
            this.txtJwtTickets.Name = "txtJwtTickets";
            this.txtJwtTickets.Size = new System.Drawing.Size(808, 23);
            this.txtJwtTickets.TabIndex = 5;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(110, 426);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(88, 17);
            this.label50.TabIndex = 4;
            this.label50.Text = "PlainText:";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(110, 364);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(64, 17);
            this.label49.TabIndex = 4;
            this.label49.Text = "Cipher:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(110, 299);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(72, 17);
            this.label48.TabIndex = 4;
            this.label48.Text = "Tickets:";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(110, 232);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(48, 17);
            this.label47.TabIndex = 3;
            this.label47.Text = "Seed:";
            // 
            // txtJwtSeed
            // 
            this.txtJwtSeed.Location = new System.Drawing.Point(110, 257);
            this.txtJwtSeed.Name = "txtJwtSeed";
            this.txtJwtSeed.Size = new System.Drawing.Size(808, 23);
            this.txtJwtSeed.TabIndex = 2;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(110, 26);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(112, 17);
            this.label46.TabIndex = 1;
            this.label46.Text = "JsonWebToken:";
            // 
            // txtJwtToken
            // 
            this.txtJwtToken.Location = new System.Drawing.Point(110, 55);
            this.txtJwtToken.Multiline = true;
            this.txtJwtToken.Name = "txtJwtToken";
            this.txtJwtToken.Size = new System.Drawing.Size(808, 161);
            this.txtJwtToken.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 830);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "加解密工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
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
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQrCode)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage_timestamp.ResumeLayout(false);
            this.tabPage_timestamp.PerformLayout();
            this.tabPage_jwt.ResumeLayout(false);
            this.tabPage_jwt.PerformLayout();
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
        private System.Windows.Forms.RadioButton radio_rsa_key_format_pem;
        private System.Windows.Forms.RadioButton radio_rsa_key_format_xml;
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
        private System.Windows.Forms.ComboBox cbox_des_padding_mode;
        private System.Windows.Forms.ComboBox cbox_des_cipher_mode;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox picQrCode;
        private System.Windows.Forms.TextBox txt_qrcode_text;
        private System.Windows.Forms.Button btnQrCodeGenerate;
        private System.Windows.Forms.RadioButton radio_rsa_key_format_pem_pkcs8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_sign_key;
        private System.Windows.Forms.TextBox txt_sign_body;
        private System.Windows.Forms.TextBox txt_sign_token;
        private System.Windows.Forms.TextBox txt_sign_timestamp;
        private System.Windows.Forms.TextBox txt_sign_path;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txt_sign_service;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txt_sign_sign;
        private System.Windows.Forms.Button btn_sign_calculate;
        private System.Windows.Forms.TextBox txt_sign_sourcedata;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_gen_guid;
        private System.Windows.Forms.TextBox txt_guid;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.CheckBox cb_guid_nosplit;
        private System.Windows.Forms.CheckBox cb_guid_case;
        private System.Windows.Forms.TextBox txt_guid_count;
        private System.Windows.Forms.CheckBox cb_guid_suffix;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.RadioButton radio_aes_key_format_hex;
        private System.Windows.Forms.RadioButton radio_aes_key_format_base64;
        private System.Windows.Forms.RadioButton radio_aes_key_format_ascii;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cb_aes_cipher_mode;
        private System.Windows.Forms.ComboBox cb_aes_padding_mode;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TabPage tabPage_timestamp;
        private System.Windows.Forms.Label lbl_current_time;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Button btnStopTimeTicks;
        private System.Windows.Forms.Label lbl_current_timestamp;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Button btnTimeToTicks;
        private System.Windows.Forms.Button btnTicksToTime;
        private System.Windows.Forms.TextBox txtCurTimeTransform;
        private System.Windows.Forms.TextBox txtCurTimeStampTransform;
        private System.Windows.Forms.TextBox txtCurTime;
        private System.Windows.Forms.TextBox txtCurTimeStamp;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TabPage tabPage_jwt;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox txtJwtToken;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtJwtSeed;
        private System.Windows.Forms.TextBox txtSensitivePlainText;
        private System.Windows.Forms.TextBox txtJwtSensitiveCipher;
        private System.Windows.Forms.TextBox txtJwtTickets;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Button btnSensitiveDecode;
        private System.Windows.Forms.TextBox txtJwtDecodeJson;
    }
}

