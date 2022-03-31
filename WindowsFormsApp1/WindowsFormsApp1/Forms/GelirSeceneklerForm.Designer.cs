
namespace ZtashiaCompanyForm.Forms
{
    partial class GelirSeceneklerForm
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
            this.gelirID_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gelirAdi_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gelirMiktar_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gelirTarih_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.gelirTur_combobox = new System.Windows.Forms.ComboBox();
            this.gEkle_button = new System.Windows.Forms.Button();
            this.gGuncelle_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sonuc_label = new System.Windows.Forms.Label();
            this.Gelir_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gelir_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gelirID_textbox
            // 
            this.gelirID_textbox.Enabled = false;
            this.gelirID_textbox.Location = new System.Drawing.Point(104, 34);
            this.gelirID_textbox.Name = "gelirID_textbox";
            this.gelirID_textbox.Size = new System.Drawing.Size(100, 20);
            this.gelirID_textbox.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Gelir ID:";
            // 
            // gelirAdi_textbox
            // 
            this.gelirAdi_textbox.Location = new System.Drawing.Point(104, 60);
            this.gelirAdi_textbox.Name = "gelirAdi_textbox";
            this.gelirAdi_textbox.Size = new System.Drawing.Size(100, 20);
            this.gelirAdi_textbox.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Gelir Adi:";
            // 
            // gelirMiktar_textbox
            // 
            this.gelirMiktar_textbox.Location = new System.Drawing.Point(104, 86);
            this.gelirMiktar_textbox.Name = "gelirMiktar_textbox";
            this.gelirMiktar_textbox.Size = new System.Drawing.Size(100, 20);
            this.gelirMiktar_textbox.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Gelir Miktari:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Gelir Tarih:";
            // 
            // gelirTarih_datetimepicker
            // 
            this.gelirTarih_datetimepicker.Location = new System.Drawing.Point(104, 115);
            this.gelirTarih_datetimepicker.Name = "gelirTarih_datetimepicker";
            this.gelirTarih_datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.gelirTarih_datetimepicker.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Gelir Türü:";
            // 
            // gelirTur_combobox
            // 
            this.gelirTur_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gelirTur_combobox.FormattingEnabled = true;
            this.gelirTur_combobox.Items.AddRange(new object[] {
            "Seçiniz...",
            "Nakit",
            "Kart"});
            this.gelirTur_combobox.Location = new System.Drawing.Point(104, 140);
            this.gelirTur_combobox.Name = "gelirTur_combobox";
            this.gelirTur_combobox.Size = new System.Drawing.Size(100, 21);
            this.gelirTur_combobox.TabIndex = 35;
            // 
            // gEkle_button
            // 
            this.gEkle_button.Location = new System.Drawing.Point(61, 185);
            this.gEkle_button.Name = "gEkle_button";
            this.gEkle_button.Size = new System.Drawing.Size(104, 51);
            this.gEkle_button.TabIndex = 36;
            this.gEkle_button.Text = "Ekle";
            this.gEkle_button.UseVisualStyleBackColor = true;
            this.gEkle_button.Click += new System.EventHandler(this.gEkle_button_Click);
            // 
            // gGuncelle_button
            // 
            this.gGuncelle_button.Location = new System.Drawing.Point(186, 185);
            this.gGuncelle_button.Name = "gGuncelle_button";
            this.gGuncelle_button.Size = new System.Drawing.Size(104, 51);
            this.gGuncelle_button.TabIndex = 37;
            this.gGuncelle_button.Text = "Güncelle";
            this.gGuncelle_button.UseVisualStyleBackColor = true;
            this.gGuncelle_button.Click += new System.EventHandler(this.gGuncelle_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZtashiaCompanyForm.Properties.Resources.BLACK_ZtashiaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // sonuc_label
            // 
            this.sonuc_label.AutoSize = true;
            this.sonuc_label.Location = new System.Drawing.Point(148, 254);
            this.sonuc_label.Name = "sonuc_label";
            this.sonuc_label.Size = new System.Drawing.Size(13, 13);
            this.sonuc_label.TabIndex = 39;
            this.sonuc_label.Text = "?";
            // 
            // Gelir_dataGridView
            // 
            this.Gelir_dataGridView.AllowUserToAddRows = false;
            this.Gelir_dataGridView.AllowUserToDeleteRows = false;
            this.Gelir_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gelir_dataGridView.Location = new System.Drawing.Point(342, 32);
            this.Gelir_dataGridView.Name = "Gelir_dataGridView";
            this.Gelir_dataGridView.ReadOnly = true;
            this.Gelir_dataGridView.Size = new System.Drawing.Size(340, 234);
            this.Gelir_dataGridView.TabIndex = 41;
            this.Gelir_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gelir_dataGridView_CellClick);
            // 
            // GelirSeceneklerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 454);
            this.Controls.Add(this.Gelir_dataGridView);
            this.Controls.Add(this.sonuc_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gGuncelle_button);
            this.Controls.Add(this.gEkle_button);
            this.Controls.Add(this.gelirTur_combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gelirTarih_datetimepicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gelirMiktar_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gelirAdi_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gelirID_textbox);
            this.Controls.Add(this.label1);
            this.Name = "GelirSeceneklerForm";
            this.Text = "GelirSeceneklerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gelir_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gelirID_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gelirAdi_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gelirMiktar_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker gelirTarih_datetimepicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox gelirTur_combobox;
        private System.Windows.Forms.Button gEkle_button;
        private System.Windows.Forms.Button gGuncelle_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label sonuc_label;
        private System.Windows.Forms.DataGridView Gelir_dataGridView;
    }
}