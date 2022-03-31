
namespace ZtashiaCompanyForm.Forms
{
    partial class GiderSeceneklerForm
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
            this.gGuncelle_button = new System.Windows.Forms.Button();
            this.gEkle_button = new System.Windows.Forms.Button();
            this.giderTur_combobox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.giderTarih_datetimepicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.giderMiktar_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.giderAdi_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.giderID_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sonuc_label = new System.Windows.Forms.Label();
            this.Gider_dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gider_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // gGuncelle_button
            // 
            this.gGuncelle_button.Location = new System.Drawing.Point(186, 172);
            this.gGuncelle_button.Name = "gGuncelle_button";
            this.gGuncelle_button.Size = new System.Drawing.Size(104, 51);
            this.gGuncelle_button.TabIndex = 50;
            this.gGuncelle_button.Text = "Güncelle";
            this.gGuncelle_button.UseVisualStyleBackColor = true;
            this.gGuncelle_button.Click += new System.EventHandler(this.gGuncelle_button_Click);
            // 
            // gEkle_button
            // 
            this.gEkle_button.Location = new System.Drawing.Point(61, 172);
            this.gEkle_button.Name = "gEkle_button";
            this.gEkle_button.Size = new System.Drawing.Size(104, 51);
            this.gEkle_button.TabIndex = 49;
            this.gEkle_button.Text = "Ekle";
            this.gEkle_button.UseVisualStyleBackColor = true;
            this.gEkle_button.Click += new System.EventHandler(this.gEkle_button_Click);
            // 
            // giderTur_combobox
            // 
            this.giderTur_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.giderTur_combobox.FormattingEnabled = true;
            this.giderTur_combobox.Items.AddRange(new object[] {
            "Seçiniz...",
            "Nakit",
            "Kart"});
            this.giderTur_combobox.Location = new System.Drawing.Point(104, 127);
            this.giderTur_combobox.Name = "giderTur_combobox";
            this.giderTur_combobox.Size = new System.Drawing.Size(100, 21);
            this.giderTur_combobox.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Gider Türü:";
            // 
            // giderTarih_datetimepicker
            // 
            this.giderTarih_datetimepicker.Location = new System.Drawing.Point(104, 102);
            this.giderTarih_datetimepicker.Name = "giderTarih_datetimepicker";
            this.giderTarih_datetimepicker.Size = new System.Drawing.Size(200, 20);
            this.giderTarih_datetimepicker.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Gider Tarih:";
            // 
            // giderMiktar_textbox
            // 
            this.giderMiktar_textbox.Location = new System.Drawing.Point(104, 73);
            this.giderMiktar_textbox.Name = "giderMiktar_textbox";
            this.giderMiktar_textbox.Size = new System.Drawing.Size(100, 20);
            this.giderMiktar_textbox.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Gider Miktari:";
            // 
            // giderAdi_textbox
            // 
            this.giderAdi_textbox.Location = new System.Drawing.Point(104, 47);
            this.giderAdi_textbox.Name = "giderAdi_textbox";
            this.giderAdi_textbox.Size = new System.Drawing.Size(100, 20);
            this.giderAdi_textbox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Gider Adi:";
            // 
            // giderID_textbox
            // 
            this.giderID_textbox.Enabled = false;
            this.giderID_textbox.Location = new System.Drawing.Point(104, 21);
            this.giderID_textbox.Name = "giderID_textbox";
            this.giderID_textbox.Size = new System.Drawing.Size(100, 20);
            this.giderID_textbox.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Gider ID:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ZtashiaCompanyForm.Properties.Resources.BLACK_ZtashiaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(6, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // sonuc_label
            // 
            this.sonuc_label.AutoSize = true;
            this.sonuc_label.Location = new System.Drawing.Point(167, 254);
            this.sonuc_label.Name = "sonuc_label";
            this.sonuc_label.Size = new System.Drawing.Size(13, 13);
            this.sonuc_label.TabIndex = 52;
            this.sonuc_label.Text = "?";
            // 
            // Gider_dataGridView
            // 
            this.Gider_dataGridView.AllowUserToAddRows = false;
            this.Gider_dataGridView.AllowUserToDeleteRows = false;
            this.Gider_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gider_dataGridView.Location = new System.Drawing.Point(342, 32);
            this.Gider_dataGridView.Name = "Gider_dataGridView";
            this.Gider_dataGridView.ReadOnly = true;
            this.Gider_dataGridView.Size = new System.Drawing.Size(340, 234);
            this.Gider_dataGridView.TabIndex = 53;
            this.Gider_dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gider_dataGridView_CellClick);
            // 
            // GiderSeceneklerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 454);
            this.Controls.Add(this.Gider_dataGridView);
            this.Controls.Add(this.sonuc_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gGuncelle_button);
            this.Controls.Add(this.gEkle_button);
            this.Controls.Add(this.giderTur_combobox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.giderTarih_datetimepicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.giderMiktar_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.giderAdi_textbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.giderID_textbox);
            this.Controls.Add(this.label1);
            this.Name = "GiderSeceneklerForm";
            this.Text = "GiderSeceneklerForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gider_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button gGuncelle_button;
        private System.Windows.Forms.Button gEkle_button;
        private System.Windows.Forms.ComboBox giderTur_combobox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker giderTarih_datetimepicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox giderMiktar_textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox giderAdi_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox giderID_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label sonuc_label;
        private System.Windows.Forms.DataGridView Gider_dataGridView;
    }
}