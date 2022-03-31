using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZtashiaCompanyForm.DataBase_Folder;

namespace ZtashiaCompanyForm.Forms
{
    public partial class GiderSeceneklerForm : Form
    {
        public GiderSeceneklerForm()
        {
            InitializeComponent();
            LoadTheme();
            GiderForm_kayitGetir();
        }

        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        FormOrders formorders = new FormOrders();

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btns.BackColor = ThemeColor.PrimaryColor;
                    btns.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.SecondaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }
        private void GiderForm_kayitGetir()
        {
            conn.Open();
            string kayit = "SELECT * from dbo.Urunler";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            cmd = new SqlCommand(kayit, conn);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            Gider_dataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

        private void gEkle_button_Click(object sender, EventArgs e)
        {
            giderDal gdrdal = new giderDal();
            try
            {
                if (giderTur_combobox.SelectedItem != "Seçiniz...")
                {
                    var result = gdrdal.Add(giderAdi_textbox.Text, float.Parse(giderMiktar_textbox.Text), giderTarih_datetimepicker.Text, giderTur_combobox.Text);
                    if (result)
                    {
                        sonuc_label.Text = "Başarılı";
                    }
                    else
                    {
                        sonuc_label.Text = "Başarısız!!";
                    }
                }

            }
            catch (FormatException)
            {

                MessageBox.Show("Lütfen Girdiğiniz Verileri Kontrol Edin!");
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void gGuncelle_button_Click(object sender, EventArgs e)
        {
            giderDal gdrdal = new giderDal();
            try
            {
                if(giderTur_combobox.SelectedItem!="Seçiniz...")
                {
                    var result = gdrdal.Update(int.Parse(giderID_textbox.Text), giderAdi_textbox.Text, float.Parse(giderMiktar_textbox.Text), giderTarih_datetimepicker.Text, giderTur_combobox.Text);
                    if (result)
                    {
                        sonuc_label.Text = "Başarılı";
                    }
                    else
                    {
                        sonuc_label.Text = "Başarısız!!";
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Girdiğiniz Verileri Kontrol Edin!");
                throw;
            }
            catch(Exception)
            {

            }
            
        }

        private void Gider_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            giderAdi_textbox.Text = Gider_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
