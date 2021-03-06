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
    public partial class sifremiunuttum : Form
    {
        public sifremiunuttum()
        {
            InitializeComponent();
        }
        veritabani bs = new veritabani();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textsifre.Text==textsifretekrar.Text)
            {
                bs.baglanti.Open();
                SqlCommand sorgu = new SqlCommand("update personeller set sifre=@sifreyeni,adi=@kullaniciadi where tc=@tcno", bs.baglanti);
                sorgu.Parameters.AddWithValue("@tcno", texttc.Text);
                sorgu.Parameters.AddWithValue("@sifreyeni",textsifre.Text);
                sorgu.Parameters.AddWithValue("@kullaniciadi",textkullanici.Text);
                sorgu.ExecuteNonQuery();
                bs.baglanti.Close();
                MessageBox.Show("ŞİFRE DEĞİŞTİRİLDİ.","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ŞİFRELER UYUŞMADI !","HATA",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.CheckState == CheckState.Checked)
            {
                textsifre.UseSystemPasswordChar = true;
                textsifretekrar.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if (checkBox1.CheckState == CheckState.Unchecked)
            {
                textsifre.UseSystemPasswordChar = false;
                textsifretekrar.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }
    }
}
