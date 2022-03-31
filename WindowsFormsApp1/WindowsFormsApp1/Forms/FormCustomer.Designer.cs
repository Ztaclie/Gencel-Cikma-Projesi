
namespace ZtashiaCompanyForm.Forms
{
    partial class FormCustomer
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sonuc_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.isim_textbox = new System.Windows.Forms.TextBox();
            this.sifre_textbox = new System.Windows.Forms.TextBox();
            this.kAdi_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.soyad_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tel_textbox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rol_combobox = new System.Windows.Forms.ComboBox();
            this.kID_textbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(296, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(450, 306);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // sonuc_label
            // 
            this.sonuc_label.AutoSize = true;
            this.sonuc_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonuc_label.Location = new System.Drawing.Point(92, 233);
            this.sonuc_label.Name = "sonuc_label";
            this.sonuc_label.Size = new System.Drawing.Size(64, 25);
            this.sonuc_label.TabIndex = 24;
            this.sonuc_label.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Çalışanlar";
            // 
            // isim_textbox
            // 
            this.isim_textbox.Location = new System.Drawing.Point(114, 95);
            this.isim_textbox.Name = "isim_textbox";
            this.isim_textbox.Size = new System.Drawing.Size(100, 20);
            this.isim_textbox.TabIndex = 22;
            // 
            // sifre_textbox
            // 
            this.sifre_textbox.Location = new System.Drawing.Point(114, 54);
            this.sifre_textbox.Name = "sifre_textbox";
            this.sifre_textbox.Size = new System.Drawing.Size(100, 20);
            this.sifre_textbox.TabIndex = 21;
            // 
            // kAdi_textbox
            // 
            this.kAdi_textbox.Location = new System.Drawing.Point(114, 24);
            this.kAdi_textbox.Name = "kAdi_textbox";
            this.kAdi_textbox.Size = new System.Drawing.Size(100, 20);
            this.kAdi_textbox.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Şifre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kullanıcı Adı:";
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(330, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 55);
            this.button3.TabIndex = 16;
            this.button3.Text = "Personel Güncelle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(461, 366);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 55);
            this.button2.TabIndex = 15;
            this.button2.Text = "Personel Çıkar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(199, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Personel Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // soyad_textbox
            // 
            this.soyad_textbox.Location = new System.Drawing.Point(114, 121);
            this.soyad_textbox.Name = "soyad_textbox";
            this.soyad_textbox.Size = new System.Drawing.Size(100, 20);
            this.soyad_textbox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Soyad:";
            // 
            // tel_textbox
            // 
            this.tel_textbox.Location = new System.Drawing.Point(114, 147);
            this.tel_textbox.MaxLength = 11;
            this.tel_textbox.Name = "tel_textbox";
            this.tel_textbox.Size = new System.Drawing.Size(100, 20);
            this.tel_textbox.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Telefon:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Rol:";
            // 
            // rol_combobox
            // 
            this.rol_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rol_combobox.FormattingEnabled = true;
            this.rol_combobox.Items.AddRange(new object[] {
            "BT_Elemani",
            "Patron",
            "Personel"});
            this.rol_combobox.Location = new System.Drawing.Point(114, 176);
            this.rol_combobox.Name = "rol_combobox";
            this.rol_combobox.Size = new System.Drawing.Size(100, 21);
            this.rol_combobox.TabIndex = 33;
            // 
            // kID_textbox
            // 
            this.kID_textbox.Enabled = false;
            this.kID_textbox.Location = new System.Drawing.Point(65, 317);
            this.kID_textbox.Name = "kID_textbox";
            this.kID_textbox.Size = new System.Drawing.Size(100, 20);
            this.kID_textbox.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 301);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Kullanıcı ID";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(673, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(57, 45);
            this.button4.TabIndex = 36;
            this.button4.Text = "Yenile";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.kID_textbox);
            this.Controls.Add(this.rol_combobox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tel_textbox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.soyad_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.sonuc_label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.isim_textbox);
            this.Controls.Add(this.sifre_textbox);
            this.Controls.Add(this.kAdi_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            this.Load += new System.EventHandler(this.FormCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label sonuc_label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox isim_textbox;
        private System.Windows.Forms.TextBox sifre_textbox;
        private System.Windows.Forms.TextBox kAdi_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox soyad_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tel_textbox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rol_combobox;
        private System.Windows.Forms.TextBox kID_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
    }
}