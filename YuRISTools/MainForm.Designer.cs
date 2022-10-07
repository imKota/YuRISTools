using System.IO;

namespace YuRISTools
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.textBox_log = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.button_ystb_cipher_encrypt = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.textBox_ystb_text_patched_done = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox_ystb_text_patched_input = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox_ystb_text_output = new System.Windows.Forms.TextBox();
            this.button_ystb_text_patch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_ystb_text_patch = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_ystb_text_yscm = new System.Windows.Forms.TextBox();
            this.button_ystb_text_export = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_ystb_text_input = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_ystb_crc32_key = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_ystb_crc32 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox_ystb_cipher_key = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button_ystb_cipher_decrypt = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_ystb_cipher_output = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_ystb_cipher_input = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ypf_engine = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox_ypf_verify = new System.Windows.Forms.CheckBox();
            this.radioButton_ypf_murmur2 = new System.Windows.Forms.RadioButton();
            this.radioButton_ypf_crc32 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox_ypf_pack_no_packing = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ypf_pack_no_compress = new System.Windows.Forms.TextBox();
            this.button_ypf_pack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_ypf_pack_output = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_ypf_pack_input = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ypf_unpack = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_ypf_unpack_output = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_ypf_unpack_input = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_log
            // 
            this.textBox_log.BackColor = System.Drawing.Color.Black;
            this.textBox_log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_log.Font = new System.Drawing.Font("Consolas", 10F);
            this.textBox_log.ForeColor = System.Drawing.Color.Silver;
            this.textBox_log.Location = new System.Drawing.Point(0, 349);
            this.textBox_log.Multiline = true;
            this.textBox_log.Name = "textBox_log";
            this.textBox_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_log.Size = new System.Drawing.Size(651, 221);
            this.textBox_log.TabIndex = 1;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "json";
            this.saveFileDialog1.Filter = "JSON Files|*.json|All Files|*.*";
            this.saveFileDialog1.Title = "Save JSON";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox8);
            this.tabPage2.Controls.Add(this.groupBox7);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(646, 328);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "YSTB Tool";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.textBox1);
            this.groupBox8.Controls.Add(this.label16);
            this.groupBox8.Controls.Add(this.button_ystb_cipher_encrypt);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.textBox_ystb_text_patched_done);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Controls.Add(this.textBox_ystb_text_patched_input);
            this.groupBox8.Location = new System.Drawing.Point(6, 237);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(629, 80);
            this.groupBox8.TabIndex = 18;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "YSTB Cipher";
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.Location = new System.Drawing.Point(558, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(65, 20);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "58FFFB91";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(529, 22);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 15;
            this.label16.Text = "Key:";
            // 
            // button_ystb_cipher_encrypt
            // 
            this.button_ystb_cipher_encrypt.Location = new System.Drawing.Point(529, 49);
            this.button_ystb_cipher_encrypt.Name = "button_ystb_cipher_encrypt";
            this.button_ystb_cipher_encrypt.Size = new System.Drawing.Size(94, 23);
            this.button_ystb_cipher_encrypt.TabIndex = 14;
            this.button_ystb_cipher_encrypt.Text = "XOR Encrypt";
            this.button_ystb_cipher_encrypt.UseVisualStyleBackColor = true;
            this.button_ystb_cipher_encrypt.Click += new System.EventHandler(this.button_ystb_cipher_encrypt_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 54);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(42, 13);
            this.label17.TabIndex = 13;
            this.label17.Text = "Output:";
            // 
            // textBox_ystb_text_patched_done
            // 
            this.textBox_ystb_text_patched_done.AllowDrop = true;
            this.textBox_ystb_text_patched_done.Location = new System.Drawing.Point(59, 51);
            this.textBox_ystb_text_patched_done.Name = "textBox_ystb_text_patched_done";
            this.textBox_ystb_text_patched_done.Size = new System.Drawing.Size(464, 20);
            this.textBox_ystb_text_patched_done.TabIndex = 12;
            this.textBox_ystb_text_patched_done.Text = "4_ybn_done\\";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(34, 13);
            this.label18.TabIndex = 11;
            this.label18.Text = "Input:";
            // 
            // textBox_ystb_text_patched_input
            // 
            this.textBox_ystb_text_patched_input.AllowDrop = true;
            this.textBox_ystb_text_patched_input.Location = new System.Drawing.Point(59, 22);
            this.textBox_ystb_text_patched_input.Name = "textBox_ystb_text_patched_input";
            this.textBox_ystb_text_patched_input.Size = new System.Drawing.Size(464, 20);
            this.textBox_ystb_text_patched_input.TabIndex = 10;
            this.textBox_ystb_text_patched_input.Text = "3_ybn_patched\\";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.textBox_ystb_text_output);
            this.groupBox7.Controls.Add(this.button_ystb_text_patch);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.textBox_ystb_text_patch);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.textBox_ystb_text_yscm);
            this.groupBox7.Controls.Add(this.button_ystb_text_export);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.textBox_ystb_text_input);
            this.groupBox7.Location = new System.Drawing.Point(6, 151);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(629, 80);
            this.groupBox7.TabIndex = 17;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "YSTB Text Tool";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(274, 54);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 21;
            this.label15.Text = "Output:";
            // 
            // textBox_ystb_text_output
            // 
            this.textBox_ystb_text_output.AllowDrop = true;
            this.textBox_ystb_text_output.Location = new System.Drawing.Point(316, 51);
            this.textBox_ystb_text_output.Name = "textBox_ystb_text_output";
            this.textBox_ystb_text_output.Size = new System.Drawing.Size(205, 20);
            this.textBox_ystb_text_output.TabIndex = 20;
            this.textBox_ystb_text_output.Text = "3_ybn_patched\\";
            this.textBox_ystb_text_output.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ystb_text_output.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // button_ystb_text_patch
            // 
            this.button_ystb_text_patch.Location = new System.Drawing.Point(529, 49);
            this.button_ystb_text_patch.Name = "button_ystb_text_patch";
            this.button_ystb_text_patch.Size = new System.Drawing.Size(94, 23);
            this.button_ystb_text_patch.TabIndex = 19;
            this.button_ystb_text_patch.Text = "Patch";
            this.button_ystb_text_patch.UseVisualStyleBackColor = true;
            this.button_ystb_text_patch.Click += new System.EventHandler(this.button_ystb_text_patch_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Patch:";
            // 
            // textBox_ystb_text_patch
            // 
            this.textBox_ystb_text_patch.AllowDrop = true;
            this.textBox_ystb_text_patch.Location = new System.Drawing.Point(53, 51);
            this.textBox_ystb_text_patch.Name = "textBox_ystb_text_patch";
            this.textBox_ystb_text_patch.Size = new System.Drawing.Size(205, 20);
            this.textBox_ystb_text_patch.TabIndex = 17;
            this.textBox_ystb_text_patch.Text = "patch.json";
            this.textBox_ystb_text_patch.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ystb_text_patch.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 26);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "YSCM:";
            // 
            // textBox_ystb_text_yscm
            // 
            this.textBox_ystb_text_yscm.AllowDrop = true;
            this.textBox_ystb_text_yscm.Location = new System.Drawing.Point(316, 22);
            this.textBox_ystb_text_yscm.Name = "textBox_ystb_text_yscm";
            this.textBox_ystb_text_yscm.Size = new System.Drawing.Size(205, 20);
            this.textBox_ystb_text_yscm.TabIndex = 15;
            this.textBox_ystb_text_yscm.Text = "1_ybn_unpacked\\bn\\ysbin\\ysc.ybn";
            this.textBox_ystb_text_yscm.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ystb_text_yscm.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // button_ystb_text_export
            // 
            this.button_ystb_text_export.Location = new System.Drawing.Point(529, 21);
            this.button_ystb_text_export.Name = "button_ystb_text_export";
            this.button_ystb_text_export.Size = new System.Drawing.Size(94, 23);
            this.button_ystb_text_export.TabIndex = 14;
            this.button_ystb_text_export.Text = "Export";
            this.button_ystb_text_export.UseVisualStyleBackColor = true;
            this.button_ystb_text_export.Click += new System.EventHandler(this.button_ystb_text_export_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(43, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "YSTBs:";
            // 
            // textBox_ystb_text_input
            // 
            this.textBox_ystb_text_input.AllowDrop = true;
            this.textBox_ystb_text_input.Location = new System.Drawing.Point(53, 22);
            this.textBox_ystb_text_input.Name = "textBox_ystb_text_input";
            this.textBox_ystb_text_input.Size = new System.Drawing.Size(205, 20);
            this.textBox_ystb_text_input.TabIndex = 10;
            this.textBox_ystb_text_input.Text = "2_ybn_decrypted\\";
            this.textBox_ystb_text_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ystb_text_input.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_ystb_crc32_key);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.textBox_ystb_crc32);
            this.groupBox4.Location = new System.Drawing.Point(6, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(629, 51);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CRC32 Key Compute";
            // 
            // button_ystb_crc32_key
            // 
            this.button_ystb_crc32_key.Location = new System.Drawing.Point(529, 20);
            this.button_ystb_crc32_key.Name = "button_ystb_crc32_key";
            this.button_ystb_crc32_key.Size = new System.Drawing.Size(94, 23);
            this.button_ystb_crc32_key.TabIndex = 17;
            this.button_ystb_crc32_key.Text = "Hash && Fill";
            this.button_ystb_crc32_key.UseVisualStyleBackColor = true;
            this.button_ystb_crc32_key.Click += new System.EventHandler(this.button_ystb_crc32_key_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Input:";
            // 
            // textBox_ystb_crc32
            // 
            this.textBox_ystb_crc32.AllowDrop = true;
            this.textBox_ystb_crc32.Location = new System.Drawing.Point(53, 22);
            this.textBox_ystb_crc32.Name = "textBox_ystb_crc32";
            this.textBox_ystb_crc32.Size = new System.Drawing.Size(470, 20);
            this.textBox_ystb_crc32.TabIndex = 12;
            this.textBox_ystb_crc32.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ystb_crc32.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox_ystb_cipher_key);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.button_ystb_cipher_decrypt);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.textBox_ystb_cipher_output);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBox_ystb_cipher_input);
            this.groupBox3.Location = new System.Drawing.Point(6, 64);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(629, 80);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "YSTB Cipher";
            // 
            // textBox_ystb_cipher_key
            // 
            this.textBox_ystb_cipher_key.AllowDrop = true;
            this.textBox_ystb_cipher_key.Location = new System.Drawing.Point(558, 19);
            this.textBox_ystb_cipher_key.Name = "textBox_ystb_cipher_key";
            this.textBox_ystb_cipher_key.Size = new System.Drawing.Size(65, 20);
            this.textBox_ystb_cipher_key.TabIndex = 16;
            this.textBox_ystb_cipher_key.Text = "58FFFB91";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "Key:";
            // 
            // button_ystb_cipher_decrypt
            // 
            this.button_ystb_cipher_decrypt.Location = new System.Drawing.Point(529, 49);
            this.button_ystb_cipher_decrypt.Name = "button_ystb_cipher_decrypt";
            this.button_ystb_cipher_decrypt.Size = new System.Drawing.Size(94, 23);
            this.button_ystb_cipher_decrypt.TabIndex = 14;
            this.button_ystb_cipher_decrypt.Text = "XOR Decrypt";
            this.button_ystb_cipher_decrypt.UseVisualStyleBackColor = true;
            this.button_ystb_cipher_decrypt.Click += new System.EventHandler(this.button_ystb_cipher_decrypt_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Output:";
            // 
            // textBox_ystb_cipher_output
            // 
            this.textBox_ystb_cipher_output.AllowDrop = true;
            this.textBox_ystb_cipher_output.Location = new System.Drawing.Point(59, 51);
            this.textBox_ystb_cipher_output.Name = "textBox_ystb_cipher_output";
            this.textBox_ystb_cipher_output.Size = new System.Drawing.Size(464, 20);
            this.textBox_ystb_cipher_output.TabIndex = 12;
            this.textBox_ystb_cipher_output.Text = "2_ybn_decrypted\\";
            this.textBox_ystb_cipher_output.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ystb_cipher_output.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Input:";
            // 
            // textBox_ystb_cipher_input
            // 
            this.textBox_ystb_cipher_input.AllowDrop = true;
            this.textBox_ystb_cipher_input.Location = new System.Drawing.Point(59, 22);
            this.textBox_ystb_cipher_input.Name = "textBox_ystb_cipher_input";
            this.textBox_ystb_cipher_input.Size = new System.Drawing.Size(464, 20);
            this.textBox_ystb_cipher_input.TabIndex = 10;
            this.textBox_ystb_cipher_input.Text = "1_ybn_unpacked\\bn\\ysbin\\";
            this.textBox_ystb_cipher_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ystb_cipher_input.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(646, 328);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "YPF Tool";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.textBox_ypf_engine);
            this.groupBox6.Location = new System.Drawing.Point(524, 119);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(111, 51);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Packing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Engine:";
            // 
            // textBox_ypf_engine
            // 
            this.textBox_ypf_engine.Location = new System.Drawing.Point(59, 22);
            this.textBox_ypf_engine.Name = "textBox_ypf_engine";
            this.textBox_ypf_engine.Size = new System.Drawing.Size(43, 20);
            this.textBox_ypf_engine.TabIndex = 0;
            this.textBox_ypf_engine.Text = "500";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox_ypf_verify);
            this.groupBox5.Controls.Add(this.radioButton_ypf_murmur2);
            this.groupBox5.Controls.Add(this.radioButton_ypf_crc32);
            this.groupBox5.Location = new System.Drawing.Point(524, 7);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(111, 106);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Checksum";
            // 
            // checkBox_ypf_verify
            // 
            this.checkBox_ypf_verify.AutoSize = true;
            this.checkBox_ypf_verify.Location = new System.Drawing.Point(6, 82);
            this.checkBox_ypf_verify.Name = "checkBox_ypf_verify";
            this.checkBox_ypf_verify.Size = new System.Drawing.Size(52, 17);
            this.checkBox_ypf_verify.TabIndex = 16;
            this.checkBox_ypf_verify.Text = "Verify";
            this.checkBox_ypf_verify.UseVisualStyleBackColor = true;
            // 
            // radioButton_ypf_murmur2
            // 
            this.radioButton_ypf_murmur2.AutoSize = true;
            this.radioButton_ypf_murmur2.Checked = true;
            this.radioButton_ypf_murmur2.Location = new System.Drawing.Point(6, 22);
            this.radioButton_ypf_murmur2.Name = "radioButton_ypf_murmur2";
            this.radioButton_ypf_murmur2.Size = new System.Drawing.Size(66, 17);
            this.radioButton_ypf_murmur2.TabIndex = 1;
            this.radioButton_ypf_murmur2.TabStop = true;
            this.radioButton_ypf_murmur2.Text = "Murmur2";
            this.radioButton_ypf_murmur2.UseVisualStyleBackColor = true;
            // 
            // radioButton_ypf_crc32
            // 
            this.radioButton_ypf_crc32.AutoSize = true;
            this.radioButton_ypf_crc32.Location = new System.Drawing.Point(6, 46);
            this.radioButton_ypf_crc32.Name = "radioButton_ypf_crc32";
            this.radioButton_ypf_crc32.Size = new System.Drawing.Size(90, 30);
            this.radioButton_ypf_crc32.TabIndex = 15;
            this.radioButton_ypf_crc32.Text = "Name CRC32\r\nData Adler32";
            this.radioButton_ypf_crc32.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_ypf_pack_no_packing);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_ypf_pack_no_compress);
            this.groupBox2.Controls.Add(this.button_ypf_pack);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_ypf_pack_output);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_ypf_pack_input);
            this.groupBox2.Location = new System.Drawing.Point(6, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(512, 139);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pack";
            // 
            // textBox_ypf_pack_no_packing
            // 
            this.textBox_ypf_pack_no_packing.AllowDrop = true;
            this.textBox_ypf_pack_no_packing.Location = new System.Drawing.Point(161, 109);
            this.textBox_ypf_pack_no_packing.Name = "textBox_ypf_pack_no_packing";
            this.textBox_ypf_pack_no_packing.Size = new System.Drawing.Size(345, 20);
            this.textBox_ypf_pack_no_packing.TabIndex = 14;
            this.textBox_ypf_pack_no_packing.Text = "exe/dll/mpg/avi/swf/yst/txt/bat/sd/db/vix/bak";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Non-Packing Extensions:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Non-Compress Extensions:";
            // 
            // textBox_ypf_pack_no_compress
            // 
            this.textBox_ypf_pack_no_compress.AllowDrop = true;
            this.textBox_ypf_pack_no_compress.Location = new System.Drawing.Point(161, 80);
            this.textBox_ypf_pack_no_compress.Name = "textBox_ypf_pack_no_compress";
            this.textBox_ypf_pack_no_compress.Size = new System.Drawing.Size(345, 20);
            this.textBox_ypf_pack_no_compress.TabIndex = 11;
            this.textBox_ypf_pack_no_compress.Text = "png/gif/wav/ogg/psb";
            // 
            // button_ypf_pack
            // 
            this.button_ypf_pack.Location = new System.Drawing.Point(430, 20);
            this.button_ypf_pack.Name = "button_ypf_pack";
            this.button_ypf_pack.Size = new System.Drawing.Size(75, 23);
            this.button_ypf_pack.TabIndex = 9;
            this.button_ypf_pack.Text = "Pack";
            this.button_ypf_pack.UseVisualStyleBackColor = true;
            this.button_ypf_pack.Click += new System.EventHandler(this.button_ypf_pack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Output:";
            // 
            // textBox_ypf_pack_output
            // 
            this.textBox_ypf_pack_output.AllowDrop = true;
            this.textBox_ypf_pack_output.Location = new System.Drawing.Point(59, 51);
            this.textBox_ypf_pack_output.Name = "textBox_ypf_pack_output";
            this.textBox_ypf_pack_output.Size = new System.Drawing.Size(447, 20);
            this.textBox_ypf_pack_output.TabIndex = 7;
            this.textBox_ypf_pack_output.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ypf_pack_output.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Input:";
            // 
            // textBox_ypf_pack_input
            // 
            this.textBox_ypf_pack_input.AllowDrop = true;
            this.textBox_ypf_pack_input.Location = new System.Drawing.Point(59, 22);
            this.textBox_ypf_pack_input.Name = "textBox_ypf_pack_input";
            this.textBox_ypf_pack_input.Size = new System.Drawing.Size(365, 20);
            this.textBox_ypf_pack_input.TabIndex = 5;
            this.textBox_ypf_pack_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ypf_pack_input.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ypf_unpack);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBox_ypf_unpack_output);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox_ypf_unpack_input);
            this.groupBox1.Location = new System.Drawing.Point(6, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Unpack";
            // 
            // button_ypf_unpack
            // 
            this.button_ypf_unpack.Location = new System.Drawing.Point(430, 20);
            this.button_ypf_unpack.Name = "button_ypf_unpack";
            this.button_ypf_unpack.Size = new System.Drawing.Size(75, 23);
            this.button_ypf_unpack.TabIndex = 14;
            this.button_ypf_unpack.Text = "Unpack";
            this.button_ypf_unpack.UseVisualStyleBackColor = true;
            this.button_ypf_unpack.Click += new System.EventHandler(this.button_ypf_unpack_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Output:";
            // 
            // textBox_ypf_unpack_output
            // 
            this.textBox_ypf_unpack_output.AllowDrop = true;
            this.textBox_ypf_unpack_output.Location = new System.Drawing.Point(59, 51);
            this.textBox_ypf_unpack_output.Name = "textBox_ypf_unpack_output";
            this.textBox_ypf_unpack_output.Size = new System.Drawing.Size(447, 20);
            this.textBox_ypf_unpack_output.TabIndex = 12;
            this.textBox_ypf_unpack_output.Text = "1_ybn_unpacked\\";
            this.textBox_ypf_unpack_output.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ypf_unpack_output.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Input:";
            // 
            // textBox_ypf_unpack_input
            // 
            this.textBox_ypf_unpack_input.AllowDrop = true;
            this.textBox_ypf_unpack_input.Location = new System.Drawing.Point(59, 22);
            this.textBox_ypf_unpack_input.Name = "textBox_ypf_unpack_input";
            this.textBox_ypf_unpack_input.Size = new System.Drawing.Size(365, 20);
            this.textBox_ypf_unpack_input.TabIndex = 10;
            this.textBox_ypf_unpack_input.Text = "0_ypf\\";
            this.textBox_ypf_unpack_input.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox_DragDrop);
            this.textBox_ypf_unpack_input.DragOver += new System.Windows.Forms.DragEventHandler(this.textBox_DragOver);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(654, 354);
            this.tabControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 570);
            this.Controls.Add(this.textBox_log);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "YuRIS Tools";
            this.tabPage2.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_log;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textBox_ystb_text_output;
        private System.Windows.Forms.Button button_ystb_text_patch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBox_ystb_text_patch;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_ystb_text_yscm;
        private System.Windows.Forms.Button button_ystb_text_export;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_ystb_text_input;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_ystb_crc32_key;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_ystb_crc32;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox_ystb_cipher_key;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button_ystb_cipher_decrypt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_ystb_cipher_output;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_ystb_cipher_input;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_ypf_engine;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox_ypf_verify;
        private System.Windows.Forms.RadioButton radioButton_ypf_murmur2;
        private System.Windows.Forms.RadioButton radioButton_ypf_crc32;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_ypf_pack_no_packing;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_ypf_pack_no_compress;
        private System.Windows.Forms.Button button_ypf_pack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_ypf_pack_output;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_ypf_pack_input;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_ypf_unpack;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ypf_unpack_output;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_ypf_unpack_input;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button_ystb_cipher_encrypt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textBox_ystb_text_patched_done;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox textBox_ystb_text_patched_input;
    }
}

