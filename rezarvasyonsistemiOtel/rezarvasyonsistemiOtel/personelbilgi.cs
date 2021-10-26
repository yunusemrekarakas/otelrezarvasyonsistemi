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
    public partial class personelbilgi : Form
    {
        public personelbilgi()
        {
            InitializeComponent();
        }
        void perssonellistelemesi()
        {

            bs.baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("Select *From personeller", bs.baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            dataGridView1.DataSource = tablo;
            bs.baglanti.Close();
        }
        veritabani bs = new veritabani();

        private void buttonekle_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime dogumtarihi = Convert.ToDateTime(dateTimePicker2.Value);
            string cumle = "UPDATE personeller SET adi=@ad,soyadi=@soyad,tc=@tcno,cinsiyet=@cinsi,telefon=@tel,mail=@mailadres,maas=@maaslar,girist=@giristh,profil=@profili,dogumtarihi=@dgt,adres=@adr,sifre=@sifresi WHERE tc=@tcno ";
            SqlCommand komut2 = new SqlCommand(cumle, bs.baglanti);
            komut2.Parameters.AddWithValue("@ad", txtAdi.Text);
            komut2.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            komut2.Parameters.AddWithValue("@tcno", txtTc.Text);
            komut2.Parameters.AddWithValue("@cinsi", combocinsiyet.Text);
            komut2.Parameters.AddWithValue("@tel", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@mailadres", txtMail.Text);
            komut2.Parameters.AddWithValue("@maaslar", txtmaas.Text);
            komut2.Parameters.AddWithValue("@giristh", girisTarihi);
            komut2.Parameters.AddWithValue("@profili", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@dgt", dogumtarihi);
            komut2.Parameters.AddWithValue("@adr", txtadres.Text);
            komut2.Parameters.AddWithValue("@sifresi", txtsifre.Text);
            bs.baglanti.Open();
            komut2.ExecuteNonQuery();
            bs.baglanti.Close();
            MessageBox.Show("Personel Güncellemesi Yapıldı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            perssonellistelemesi();
            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtAdi.Text = satir.Cells["adi"].Value.ToString();
            txtSoyadi.Text = satir.Cells["soyadi"].Value.ToString();
            txtTc.Text = satir.Cells["tc"].Value.ToString();
            combocinsiyet.Text = satir.Cells["cinsiyet"].Value.ToString();
            txtTelefon.Text = satir.Cells["telefon"].Value.ToString();
            txtMail.Text = satir.Cells["mail"].Value.ToString();
            txtmaas.Text = satir.Cells["maas"].Value.ToString();
            
            txtadres.Text = satir.Cells["adres"].Value.ToString();
            dateTimePicker1.Value = Convert.ToDateTime(satir.Cells["girist"].Value.ToString());
            dateTimePicker2.Value = Convert.ToDateTime(satir.Cells["dogumtarihi"].Value.ToString());

            pictureBox1.ImageLocation = satir.Cells["profil"].Value.ToString();
            txtsifre.Text = satir.Cells["sifre"].Value.ToString();
        }

        private void personelbilgi_Load(object sender, EventArgs e)
        {
            perssonellistelemesi();
        }

        private void buttonsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string cumle = "DELETE FROM personeller WHERE tc=@tcno ";
            SqlCommand komut2 = new SqlCommand(cumle, bs.baglanti);
            komut2.Parameters.AddWithValue("@tcno", txtTc.Text);
            bs.baglanti.Open();
            komut2.ExecuteNonQuery();
            bs.baglanti.Close();
            
            MessageBox.Show("Personel silme işlemi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            perssonellistelemesi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnarama_Click(object sender, EventArgs e)
        {
            SqlCommand sorgu3 = new SqlCommand("select * from personeller where tc like '%" + txtarama.Text+ "%'", bs.baglanti);
            SqlDataAdapter adapter3 = new SqlDataAdapter(sorgu3);
            DataTable tab = new DataTable();
            adapter3.Fill(tab);
            dataGridView1.DataSource = tab;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtAdi.Text = "";
            txtSoyadi.Text = "";
            txtMail.Text = "";
            txtTc.Text = "";
            txtTelefon.Text = "";
            txtadres.Text = "";
            txtmaas.Text = "";
            combocinsiyet.Text = "";
            txtsifre.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            pictureBox1.ImageLocation = "";
            
        }
    }
}
