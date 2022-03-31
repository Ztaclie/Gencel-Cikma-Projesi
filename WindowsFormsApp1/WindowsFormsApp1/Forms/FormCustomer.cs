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
    public partial class FormCustomer : Form
    {
        public FormCustomer()
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

        private void FormCustomer_Load(object sender, EventArgs e)
        {
            LoadTheme();
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;        
            kayitGetir();
            

        }

        private void kayitGetir()
        {
            conn.Open();
            string kayit = "SELECT * from dbo.Calisanlar";
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
        void KayıtSil(int kID)
        {
            string sql = "DELETE FROM dbo.Calisanlar WHERE kID=@kID";
            cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kID", kID);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calisanlarDal clsdal = new calisanlarDal();
            var result=clsdal.Add(kAdi_textbox.Text, sifre_textbox.Text, isim_textbox.Text, soyad_textbox.Text, tel_textbox.Text, rol_combobox.Text);
            if(result)
            {
                sonuc_label.Text = "Başarılı";
            }
            else
            {
                sonuc_label.Text = "Başarısız";
            }

            


        }

        private void button3_Click(object sender, EventArgs e)
        {
            calisanlarDal clsdal = new calisanlarDal();
            var result = clsdal.Update(int.Parse(kID_textbox.Text), kAdi_textbox.Text, sifre_textbox.Text, isim_textbox.Text, soyad_textbox.Text, tel_textbox.Text, rol_combobox.Text);
            if (result)
            {
                sonuc_label.Text = "Başarılı";
            }
            else
            {
                sonuc_label.Text = "Başarısız";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //if (dataGridView1.SelectedRows.Count > 0)
            //{
            //    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            //}
            //else
            //{
            //    MessageBox.Show("Lüffen silinecek satırı seçin.");
            //}

            foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            {
                int numara = Convert.ToInt32(drow.Cells[0].Value);
                KayıtSil(numara);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kID_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            kAdi_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            sifre_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            isim_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            soyad_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tel_textbox.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            rol_combobox.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kayitGetir();
        }
    }
}
