using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ZtashiaCompanyForm.DataBase_Folder;

namespace ZtashiaCompanyForm.Forms
{
    public partial class GelirSeceneklerForm : Form
    {
        public GelirSeceneklerForm()
        {
            InitializeComponent();
            LoadTheme();
            Gelir_kayitGetir();
            Gider_kayitGetir();
            GelirForm_kayitGetir();
        }
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;
        FormOrders formorders = new FormOrders();

        private void Gelir_kayitGetir()
        {
            conn.Open();
            string kayit = "SELECT * from dbo.Gelir";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            cmd = new SqlCommand(kayit, conn);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            formorders.dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }
        private void GelirForm_kayitGetir()
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
            Gelir_dataGridView.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

        private void Gider_kayitGetir()
        {
            conn.Open();
            string kayit = "SELECT * from dbo.Gider";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            cmd = new SqlCommand(kayit, conn);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            formorders.dataGridView2.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

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

        private void gEkle_button_Click(object sender, EventArgs e)
        {
            gelirDal glrdal = new gelirDal();
            try
            {
                if (gelirTur_combobox.SelectedItem != "Seçiniz...")
                {
                    var result = glrdal.Add(gelirAdi_textbox.Text, float.Parse(gelirMiktar_textbox.Text), gelirTarih_datetimepicker.Text, gelirTur_combobox.Text);
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
            Gelir_kayitGetir();
            Gider_kayitGetir();
        }

        private void gGuncelle_button_Click(object sender, EventArgs e)
        {
            gelirDal glrdal = new gelirDal();
            try
            {
                if(gelirTur_combobox.SelectedItem!="Seçiniz...")
                {
                    var result = glrdal.Update(int.Parse(gelirID_textbox.Text), gelirAdi_textbox.Text, float.Parse(gelirMiktar_textbox.Text), gelirTarih_datetimepicker.Text, gelirTur_combobox.Text);
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
            
            Gelir_kayitGetir();
            Gider_kayitGetir();
        }

        private void Gelir_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gelirAdi_textbox.Text = Gelir_dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
