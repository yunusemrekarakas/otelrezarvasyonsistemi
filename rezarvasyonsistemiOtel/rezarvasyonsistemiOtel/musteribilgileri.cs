using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;


namespace rezarvasyonsistemiOtel
{
    public partial class musteribilgileri : Form
    {
        
        public musteribilgileri()
        {
            InitializeComponent();
        }
        veritabani bs = new veritabani();
        private void verigoster()
        {

            SqlCommand sorgu = new SqlCommand("select * from mus", bs.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridView1.DataSource = tab;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bs.baglanti.Open();
            verigoster();
            bs.baglanti.Close();

        }

        private void musteribilgileri_Load(object sender, EventArgs e)
        {
            verigoster();
        }

       
        int id = 0;
        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            //id = Convert.ToInt32(dataGridView1.Rows[0].Cells["id"].Value);
            //txtAdi.Text = dataGridView1.Rows[0].Cells["adi"].Value.ToString();
            //txtSoyadi.Text = dataGridView1.Rows[0].Cells["soyadi"].Value.ToString();
            //combocinsiyet.Text= dataGridView1.Rows[0].Cells["cinsiyet"].Value.ToString();
            //txtTc.Text= dataGridView1.Rows[0].Cells["tcNo"].Value.ToString();
            //txtOda.Text= dataGridView1.Rows[0].Cells["odaNo"].Value.ToString();
            //txtMail.Text= dataGridView1.Rows[0].Cells["mail"].Value.ToString();
            //txtTelefon.Text= dataGridView1.Rows[0].Cells["telefon"].Value.ToString();
            //txtUcret.Text= dataGridView1.Rows[0].Cells["ucret"].Value.ToString();
            //dateTimePicker1.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["girisTarihi"].Value.ToString());
            //dateTimePicker2.Value = Convert.ToDateTime(dataGridView1.Rows[0].Cells["cikisTarihi"].Value.ToString());

        }

        private void buttonsil_Click(object sender, EventArgs e)
        {

            string cümle = "DELETE mus WHERE tcNo=@tckimlik";
            SqlCommand sorgular = new SqlCommand(cümle,bs.baglanti);
            sorgular.Parameters.AddWithValue("@tckimlik",txtTc.Text);
            bs.baglanti.Open();
            sorgular.ExecuteNonQuery();
            bs.baglanti.Close();
            verigoster();
            if (txtOda.Text=="1")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda1",bs.baglanti);
                sorgu2.ExecuteNonQuery();   
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "2")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda2", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "3")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda3", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "4")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda4", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "5")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda5", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "6")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda6", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "7")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda7", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "8")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda8", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "9")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda9", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "10")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda10", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "11")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda11", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "12")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda12", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "13")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda13", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "14")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda14", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "15")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda15", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "16")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda16", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "17")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda17", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "18")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda18", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "19")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda19", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "20")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda20", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "21")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda21", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            if (txtOda.Text == "22")
            {
                bs.baglanti.Open();
                SqlCommand sorgu2 = new SqlCommand("delete from oda22", bs.baglanti);
                sorgu2.ExecuteNonQuery();
                bs.baglanti.Close();
                verigoster();
            }
            MessageBox.Show("SİLME İŞLEMİ YAPILDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonguncelle_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime cikisTarihi = Convert.ToDateTime(dateTimePicker2.Value);
            bs.baglanti.Open();
            SqlCommand sorgu3 = new SqlCommand("UPDATE mus SET adi=@adi,soyadi=@soyadi,cinsiyet=@cinsiyet,telefon=@telefon,mail=@mail,tcNo=@tc,odaNo=@oda,ucret=@ucreti,girisTarihi=@gtarih,cikisTarihi=@ctarih WHERE tcNo=@tc ", bs.baglanti);
            sorgu3.Parameters.AddWithValue("@adi", txtAdi.Text);
            sorgu3.Parameters.AddWithValue("@soyadi", txtSoyadi.Text);
            sorgu3.Parameters.AddWithValue("@cinsiyet", combocinsiyet.Text);
            sorgu3.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            sorgu3.Parameters.AddWithValue("@mail", txtMail.Text);
            sorgu3.Parameters.AddWithValue("@tc", txtTc.Text);
            sorgu3.Parameters.AddWithValue("@oda", txtOda.Text);
            sorgu3.Parameters.AddWithValue("@ucreti", txtUcret.Text);
            sorgu3.Parameters.AddWithValue("@gtarih",girisTarihi );
            sorgu3.Parameters.AddWithValue("@ctarih", cikisTarihi);
            sorgu3.ExecuteNonQuery();
            bs.baglanti.Close();
            verigoster();
            MessageBox.Show("GÜNCELLEME İŞLEMİ YAPILDI", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
        }
        private void buttonara_Click(object sender, EventArgs e)
        {
            SqlCommand sorgu = new SqlCommand("select * from mus where tcNo like '%"+txtTc.Text+"%'", bs.baglanti);
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu);
            DataTable tab = new DataTable();
            adapter.Fill(tab);
            dataGridView1.DataSource = tab;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttontemiz_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtMail.Text = "";
            txtOda.Text = "";
            txtTc.Text = "";
            txtTelefon.Text = "";
            combocinsiyet.Text = "";
            txtUcret.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtAdi.Text = satir.Cells["adi"].Value.ToString();
            txtSoyadi.Text = satir.Cells["soyadi"].Value.ToString();
            combocinsiyet.Text = satir.Cells["cinsiyet"].Value.ToString();
            txtTc.Text = satir.Cells["tcNo"].Value.ToString();
            txtOda.Text = satir.Cells["odaNo"].Value.ToString();
            txtMail.Text = satir.Cells["mail"].Value.ToString();
            txtTelefon.Text = satir.Cells["telefon"].Value.ToString();
            txtUcret.Text = satir.Cells["ucret"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(satir.Cells["girisTarihi"].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(satir.Cells["cikisTarihi"].Value.ToString());
        }
    }
}


