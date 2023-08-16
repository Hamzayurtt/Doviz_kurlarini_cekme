namespace döviz_kurlarını_çekme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_dolar = new System.Windows.Forms.Label();
            this.lbl_euro = new System.Windows.Forms.Label();
            this.lbl_sterlin = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_tarih = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_isviçre_frangı = new System.Windows.Forms.Label();
            this.lbl_arap_riyali = new System.Windows.Forms.Label();
            this.lbl_kuveyt_dinarı = new System.Windows.Forms.Label();
            this.txtbox_tl = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox_kur_değeri = new System.Windows.Forms.TextBox();
            this.frank_text = new System.Windows.Forms.TextBox();
            this.riyal_text = new System.Windows.Forms.TextBox();
            this.dinar_text = new System.Windows.Forms.TextBox();
            this.sterlin_text = new System.Windows.Forms.TextBox();
            this.euro_text = new System.Windows.Forms.TextBox();
            this.dolar_text = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtbox_ücret = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_dolar
            // 
            this.lbl_dolar.AutoSize = true;
            this.lbl_dolar.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_dolar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_dolar.Location = new System.Drawing.Point(232, 27);
            this.lbl_dolar.Name = "lbl_dolar";
            this.lbl_dolar.Size = new System.Drawing.Size(18, 27);
            this.lbl_dolar.TabIndex = 0;
            this.lbl_dolar.Text = " ";
            // 
            // lbl_euro
            // 
            this.lbl_euro.AutoSize = true;
            this.lbl_euro.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_euro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_euro.Location = new System.Drawing.Point(232, 71);
            this.lbl_euro.Name = "lbl_euro";
            this.lbl_euro.Size = new System.Drawing.Size(18, 27);
            this.lbl_euro.TabIndex = 1;
            this.lbl_euro.Text = " ";
            // 
            // lbl_sterlin
            // 
            this.lbl_sterlin.AutoSize = true;
            this.lbl_sterlin.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sterlin.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_sterlin.Location = new System.Drawing.Point(232, 112);
            this.lbl_sterlin.Name = "lbl_sterlin";
            this.lbl_sterlin.Size = new System.Drawing.Size(18, 27);
            this.lbl_sterlin.TabIndex = 2;
            this.lbl_sterlin.Text = " ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(12, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 117);
            this.button1.TabIndex = 1;
            this.button1.Text = "Döviz Kurlarını Getir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(27, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "STERLİN ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(27, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "EURO";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(27, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 26);
            this.label6.TabIndex = 4;
            this.label6.Text = "DOLAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(455, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "TARİH";
            // 
            // lbl_tarih
            // 
            this.lbl_tarih.AutoSize = true;
            this.lbl_tarih.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_tarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_tarih.Location = new System.Drawing.Point(581, 9);
            this.lbl_tarih.Name = "lbl_tarih";
            this.lbl_tarih.Size = new System.Drawing.Size(16, 23);
            this.lbl_tarih.TabIndex = 7;
            this.lbl_tarih.Text = " ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(27, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "ARAP RİYALİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 26);
            this.label2.TabIndex = 13;
            this.label2.Text = "İŞVİÇRE FRANGI ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calisto MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(27, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 26);
            this.label3.TabIndex = 12;
            this.label3.Text = "KUVEYT DİNARI ";
            // 
            // lbl_isviçre_frangı
            // 
            this.lbl_isviçre_frangı.AutoSize = true;
            this.lbl_isviçre_frangı.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_isviçre_frangı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_isviçre_frangı.Location = new System.Drawing.Point(232, 239);
            this.lbl_isviçre_frangı.Name = "lbl_isviçre_frangı";
            this.lbl_isviçre_frangı.Size = new System.Drawing.Size(18, 27);
            this.lbl_isviçre_frangı.TabIndex = 11;
            this.lbl_isviçre_frangı.Text = " ";
            // 
            // lbl_arap_riyali
            // 
            this.lbl_arap_riyali.AutoSize = true;
            this.lbl_arap_riyali.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_arap_riyali.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_arap_riyali.Location = new System.Drawing.Point(232, 198);
            this.lbl_arap_riyali.Name = "lbl_arap_riyali";
            this.lbl_arap_riyali.Size = new System.Drawing.Size(18, 27);
            this.lbl_arap_riyali.TabIndex = 10;
            this.lbl_arap_riyali.Text = " ";
            // 
            // lbl_kuveyt_dinarı
            // 
            this.lbl_kuveyt_dinarı.AutoSize = true;
            this.lbl_kuveyt_dinarı.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_kuveyt_dinarı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_kuveyt_dinarı.Location = new System.Drawing.Point(232, 154);
            this.lbl_kuveyt_dinarı.Name = "lbl_kuveyt_dinarı";
            this.lbl_kuveyt_dinarı.Size = new System.Drawing.Size(18, 27);
            this.lbl_kuveyt_dinarı.TabIndex = 9;
            this.lbl_kuveyt_dinarı.Text = " ";
            // 
            // txtbox_tl
            // 
            this.txtbox_tl.Location = new System.Drawing.Point(817, 209);
            this.txtbox_tl.Name = "txtbox_tl";
            this.txtbox_tl.Size = new System.Drawing.Size(158, 22);
            this.txtbox_tl.TabIndex = 17;
            this.txtbox_tl.TextChanged += new System.EventHandler(this.txtbox_tl_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(653, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Kur Değeri :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(550, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = " ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(805, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = " ";
            // 
            // textbox_kur_değeri
            // 
            this.textbox_kur_değeri.Location = new System.Drawing.Point(817, 166);
            this.textbox_kur_değeri.Name = "textbox_kur_değeri";
            this.textbox_kur_değeri.Size = new System.Drawing.Size(158, 22);
            this.textbox_kur_değeri.TabIndex = 4;
            // 
            // frank_text
            // 
            this.frank_text.Location = new System.Drawing.Point(318, 244);
            this.frank_text.Name = "frank_text";
            this.frank_text.Size = new System.Drawing.Size(130, 22);
            this.frank_text.TabIndex = 26;
            this.frank_text.Text = " ";
            // 
            // riyal_text
            // 
            this.riyal_text.Location = new System.Drawing.Point(318, 203);
            this.riyal_text.Name = "riyal_text";
            this.riyal_text.Size = new System.Drawing.Size(130, 22);
            this.riyal_text.TabIndex = 27;
            this.riyal_text.Text = " ";
            // 
            // dinar_text
            // 
            this.dinar_text.Location = new System.Drawing.Point(318, 154);
            this.dinar_text.Name = "dinar_text";
            this.dinar_text.Size = new System.Drawing.Size(130, 22);
            this.dinar_text.TabIndex = 28;
            this.dinar_text.Text = " ";
            // 
            // sterlin_text
            // 
            this.sterlin_text.Location = new System.Drawing.Point(318, 112);
            this.sterlin_text.Name = "sterlin_text";
            this.sterlin_text.Size = new System.Drawing.Size(130, 22);
            this.sterlin_text.TabIndex = 29;
            this.sterlin_text.Text = " ";
            // 
            // euro_text
            // 
            this.euro_text.Location = new System.Drawing.Point(318, 71);
            this.euro_text.Name = "euro_text";
            this.euro_text.Size = new System.Drawing.Size(130, 22);
            this.euro_text.TabIndex = 30;
            this.euro_text.Text = " ";
            // 
            // dolar_text
            // 
            this.dolar_text.Location = new System.Drawing.Point(318, 32);
            this.dolar_text.Name = "dolar_text";
            this.dolar_text.Size = new System.Drawing.Size(130, 22);
            this.dolar_text.TabIndex = 31;
            this.dolar_text.Text = " ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Sterlin",
            "Kuveyt Dinarı",
            "Arap Riyali",
            "İsviçre Frangı"});
            this.comboBox1.Location = new System.Drawing.Point(817, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtbox_ücret
            // 
            this.txtbox_ücret.Location = new System.Drawing.Point(817, 258);
            this.txtbox_ücret.Name = "txtbox_ücret";
            this.txtbox_ücret.Size = new System.Drawing.Size(158, 22);
            this.txtbox_ücret.TabIndex = 34;
            this.txtbox_ücret.Text = " ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(610, 257);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(170, 23);
            this.label11.TabIndex = 33;
            this.label11.Text = "Ödenecek Ücret :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(633, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 23);
            this.label12.TabIndex = 35;
            this.label12.Text = "Döviz Seçiniz :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(631, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(153, 23);
            this.label13.TabIndex = 36;
            this.label13.Text = "Seçilen Döviz : ";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton1.Location = new System.Drawing.Point(817, 90);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(65, 26);
            this.radioButton1.TabIndex = 39;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Alış ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(908, 90);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 26);
            this.radioButton2.TabIndex = 40;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Satış";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(191, 318);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 117);
            this.button2.TabIndex = 41;
            this.button2.Text = "Kaydet";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(338, 321);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 114);
            this.button3.TabIndex = 42;
            this.button3.Text = "Listele";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(92, 441);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(985, 203);
            this.dataGridView1.TabIndex = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(1208, 656);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtbox_ücret);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dolar_text);
            this.Controls.Add(this.euro_text);
            this.Controls.Add(this.sterlin_text);
            this.Controls.Add(this.dinar_text);
            this.Controls.Add(this.riyal_text);
            this.Controls.Add(this.frank_text);
            this.Controls.Add(this.textbox_kur_değeri);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbox_tl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_isviçre_frangı);
            this.Controls.Add(this.lbl_arap_riyali);
            this.Controls.Add(this.lbl_kuveyt_dinarı);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_tarih);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_sterlin);
            this.Controls.Add(this.lbl_euro);
            this.Controls.Add(this.lbl_dolar);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_dolar;
        private System.Windows.Forms.Label lbl_euro;
        private System.Windows.Forms.Label lbl_sterlin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_tarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_isviçre_frangı;
        private System.Windows.Forms.Label lbl_arap_riyali;
        private System.Windows.Forms.Label lbl_kuveyt_dinarı;
        private System.Windows.Forms.TextBox txtbox_tl;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textbox_kur_değeri;
        private System.Windows.Forms.TextBox frank_text;
        private System.Windows.Forms.TextBox riyal_text;
        private System.Windows.Forms.TextBox dinar_text;
        private System.Windows.Forms.TextBox sterlin_text;
        private System.Windows.Forms.TextBox euro_text;
        private System.Windows.Forms.TextBox dolar_text;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtbox_ücret;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

