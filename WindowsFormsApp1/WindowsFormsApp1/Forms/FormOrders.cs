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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            LoadTheme();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
        }
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;

        public DataGridView Dgv { get; set; }
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
            farkSonuc_label.ForeColor = ThemeColor.SecondaryColor;
            toplamGelirSonuc_label.ForeColor = ThemeColor.SecondaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
            label9.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormOrders_Load(object sender, EventArgs e)
        {
            LoadTheme();
            Gelir_kayitGetir();
            Gider_kayitGetir();
        }

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
            dataGridView1.DataSource = dt;
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
            dataGridView2.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

        void GelirKayıtSil(int gID)
        {
            string sql = "DELETE FROM dbo.Gelir WHERE gID=@gID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@gID", gID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        void GiderKayıtSil(int gID)
        {
            string sql = "DELETE FROM dbo.Gider WHERE gID=@gID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@gID", gID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GelirSeceneklerForm glrfrm = new GelirSeceneklerForm();
            glrfrm.ShowDialog();
            Gelir_kayitGetir();
            Gider_kayitGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GiderSeceneklerForm gdrfrm = new GiderSeceneklerForm();
            gdrfrm.ShowDialog();
            Gelir_kayitGetir();
            Gider_kayitGetir();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hesaplaGelir();
            hesaplaGider();
            hesaplaFark();
            Gelir_kayitGetir();
            Gider_kayitGetir();

        }
        void hesaplaFark()
        {
            float a, b;
            a = float.Parse(toplamGelirSonuc_label.Text);
            b = float.Parse(toplamGiderSonuc_label.Text);
            float toplam = 0;
            if(a==b)
            {
                toplam = 0;
            }
            else
            {
                toplam = a - b;
            }
            farkSonuc_label.Text = toplam.ToString();
        }
        void hesaplaGelir()
        {
            int a = dataGridView1.RowCount;
            float sonuc = 0;
            for (int i = 0; i < a; i++)
            {
                sonuc += float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            toplamGelirSonuc_label.Text = sonuc.ToString();
        }
        void hesaplaGider()
        {
            int a = dataGridView2.RowCount;
            float sonuc = 0;
            for (int i = 0; i < a; i++)
            {
                sonuc += float.Parse(dataGridView2.Rows[i].Cells[2].Value.ToString());
            }
            toplamGiderSonuc_label.Text = sonuc.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                GelirKayıtSil(numara);
            }
            foreach (DataGridViewRow drow in dataGridView2.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                GiderKayıtSil(numara);
            }
            Gelir_kayitGetir();
            Gider_kayitGetir();
        }

        private void FormOrders_MouseEnter(object sender, EventArgs e)
        {
            if(toplamGelirSonuc_label.Text!="?" || toplamGiderSonuc_label.Text!="?"||farkSonuc_label.Text!="?")
            {
                hesaplaGelir();
                hesaplaGider();
                hesaplaFark();
            }
        }
    }
}
