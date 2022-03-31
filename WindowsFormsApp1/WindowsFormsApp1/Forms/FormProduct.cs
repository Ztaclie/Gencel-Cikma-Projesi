using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZtashiaCompanyForm.DataBase_Folder;

namespace ZtashiaCompanyForm.Forms
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            LoadTheme();
        }
        string sql;
        SqlConnection conn = new SqlConnection(DataBase.GetConnectionString);
        SqlCommand cmd;


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
            label4.ForeColor = ThemeColor.SecondaryColor;
            sonuc_label.ForeColor = ThemeColor.PrimaryColor;
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            kayitGetir();
        }

        void arabaGetir()
        {
            List<string> marka = new List<string>();
            if (comboBox1.Text=="Volkswagen")
            {
                marka.Clear();
                comboBox2.Items.Clear();
                marka.Add("Seçiniz...");
                marka.Add("Amarok");
                marka.Add("Arteon");
                marka.Add("Bora");
                marka.Add("Buggy");
                marka.Add("Corrado");
                marka.Add("Derby");
                marka.Add("EOS");
                marka.Add("Fox");
                marka.Add("Golf");
                marka.Add("Jetta");
                marka.Add("Lupo");
                marka.Add("New Beetle");
                marka.Add("Passat");
                marka.Add("Phaeton");
                marka.Add("Polo");
                marka.Add("Santana");
                marka.Add("Scirocco");
                marka.Add("Sharan");
                marka.Add("Tiguan");
                marka.Add("Touareg");
                marka.Add("Touran");
                marka.Add("T-Roc");
                marka.Add("Vento");
            }
            else if(comboBox1.Text=="Audi")
            {
                marka.Clear();
                comboBox2.Items.Clear();
                marka.Add("Seçiniz...");
                marka.Add("100 Serisi");
                marka.Add("200 Serisi");
                marka.Add("80 Serisi");
                marka.Add("90 Serisi");
                marka.Add("A1");
                marka.Add("A2");
                marka.Add("A3");
                marka.Add("A4");
                marka.Add("A5");
                marka.Add("A6");
                marka.Add("A7");
                marka.Add("A8");
                marka.Add("Allroad");
                marka.Add("E-Tron");
                marka.Add("Q2");
                marka.Add("Q3");
                marka.Add("Q5");
                marka.Add("Q7");
                marka.Add("Q8");
                marka.Add("R8");
                marka.Add("RS");
                marka.Add("S Serisi");
                marka.Add("TT");
                marka.Add("V8");
            }
            else if(comboBox1.Text=="Seat")
            {
                marka.Clear();
                comboBox2.Items.Clear();
                marka.Add("Seçiniz...");
                marka.Add("Alhambra");
                marka.Add("Altea");
                marka.Add("Arona");
                marka.Add("Arosa");
                marka.Add("Ateca");
                marka.Add("Cordoba");
                marka.Add("Exeo");
                marka.Add("Ibiza");
                marka.Add("Leon");
                marka.Add("Malaga");
                marka.Add("Marbella");
                marka.Add("Toledo");
            }
            else if(comboBox1.Text=="Skoda")
            {
                marka.Clear();
                comboBox2.Items.Clear();
                marka.Add("Seçiniz...");
                marka.Add("Citigo");
                marka.Add("Fabia");
                marka.Add("Favorit");
                marka.Add("Felicia");
                marka.Add("Forman");
                marka.Add("Kamiq");
                marka.Add("Karoq");
                marka.Add("Kodiaq");
                marka.Add("Octavia");
                marka.Add("Rapid");
                marka.Add("Roomster");
                marka.Add("Scala");
                marka.Add("Superb");
                marka.Add("Yeti");
            }
            else
            {
                marka.Clear();
            }
            foreach (string item in marka)
            {
                comboBox2.Items.Add(item);
            }
        }

        private void kayitGetir()
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
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            conn.Close();
        }

        void KayıtSil(int uID)
        {
            string sql = "DELETE FROM dbo.Urunler WHERE uID=@uID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@uID", uID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunlerDal urndal = new urunlerDal();
            var result=urndal.Add(textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, int.Parse(textBox3.Text));
            if (result)
            {
                sonuc_label.Text = "Başarılı";
            }
            else
            {
                sonuc_label.Text = "Başarısız";
            }
            kayitGetir();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(comboBox1.Text=="Audi")
            {
                arabaGetir();
            }
            else if(comboBox1.Text=="Seat")
            {
                arabaGetir();
            }
            else if(comboBox1.Text=="Skoda")
            {
                arabaGetir();
            }
            else if(comboBox1.Text=="Volkswagen")
            {
                arabaGetir();
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            comboBox1.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            comboBox2.SelectedItem = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
        }



        private void button3_Click(object sender, EventArgs e)
        {
            urunlerDal urndal = new urunlerDal();
            var result = urndal.Update(int.Parse(textBox4.Text), textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text, int.Parse(textBox3.Text));
            if (result)
            {
                sonuc_label.Text = "Başarılı";
            }
            else
            {
                sonuc_label.Text = "Başarısız";
            }
            kayitGetir();
        }

        void textboxSifirla()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox2.SelectedIndex = 0;
            comboBox1.SelectedItem = "Seçiniz...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
            kayitGetir();
            textboxSifirla();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            urunlerDal urndal = new urunlerDal();
            if (textBox3.Text == "" || textBox4.Text=="") MessageBox.Show("Lütfen Satiri Seçiniz!!!");
            else
            {
                int adet = int.Parse(textBox3.Text);
                adet--;
                var result = urndal.AdetAzaltArttir(int.Parse(textBox4.Text), adet);
                if (result)
                {
                    sonuc_label.Text = "Başarılı";
                }
                else
                {
                    sonuc_label.Text = "Başarısız";
                }
                kayitGetir();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dataGridView1.ClearSelection();
                textboxSifirla();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            urunlerDal urndal = new urunlerDal();
            if (textBox3.Text == "" || textBox4.Text == "") MessageBox.Show("Lütfen Satiri Seçiniz!!!");
            else
            {
                int adet = int.Parse(textBox3.Text);
                adet++;
                var result = urndal.AdetAzaltArttir(int.Parse(textBox4.Text), adet);
                if (result)
                {
                    sonuc_label.Text = "Başarılı";
                }
                else
                {
                    sonuc_label.Text = "Başarısız";
                }
                kayitGetir();
                textBox3.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dataGridView1.ClearSelection();
                textboxSifirla();
            }
        }
    }
}
