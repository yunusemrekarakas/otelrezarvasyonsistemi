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
    public partial class personelkayit : Form
    {
        public personelkayit()
        {
            InitializeComponent();
        }
        veritabani bs = new veritabani();
        private void buttonsec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
        }

        private void buttonekle_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime dogumtarihi = Convert.ToDateTime(dateTimePicker2.Value);
            string cumle = "INSERT INTO personeller(adi,soyadi,tc,cinsiyet,telefon,mail,maas,girist,profil,dogumtarihi,adres,sifre) VALUES(@ad,@soyad,@tcno,@cinsi,@tel,@mailadres,@maaslar,@giristh,@profili,@dgt,@adr,@sifresi)";
            SqlCommand komut2 = new SqlCommand(cumle,bs.baglanti);
            komut2.Parameters.AddWithValue("@ad", txtAdi.Text);
            komut2.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            komut2.Parameters.AddWithValue("@tcno", txtTc.Text);
            komut2.Parameters.AddWithValue("@cinsi", combocinsiyet.Text);
            komut2.Parameters.AddWithValue("@tel", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@mailadres", txtMail.Text);
            komut2.Parameters.AddWithValue("@maaslar", txtmaas.Text);
            komut2.Parameters.AddWithValue("@giristh",girisTarihi );
            komut2.Parameters.AddWithValue("@profili", pictureBox1.ImageLocation);
            komut2.Parameters.AddWithValue("@dgt", dogumtarihi);
            komut2.Parameters.AddWithValue("@adr", txtadres.Text);
            komut2.Parameters.AddWithValue("@sifresi", txtsifre.Text);
            bs.baglanti.Open();
            komut2.ExecuteNonQuery();
            bs.baglanti.Close();
            MessageBox.Show("Personel Kayıt işlemi Başarılı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            combocinsiyet.Items.Clear();
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            pictureBox1.ImageLocation = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
