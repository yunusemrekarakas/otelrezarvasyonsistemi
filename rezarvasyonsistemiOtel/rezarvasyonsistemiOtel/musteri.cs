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
    public partial class musteri : Form
    {
        veritabani bs = new veritabani();
        public musteri()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtOda.Text = "5";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda5(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
            
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime girisTarihi = Convert.ToDateTime(dateTimePicker1.Value);
            DateTime cikisTarihi = Convert.ToDateTime(dateTimePicker2.Value);
            bs.baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into mus (adi,soyadi,cinsiyet,telefon,mail,tcNo,odaNo,ucret,girisTarihi,cikisTarihi) values(@ad,@soyad,@cinsi,@tel,@mail,@tc,@oda,@ucreti,@gtarih,@ctarih)",bs.baglanti);
            komut.Parameters.AddWithValue("@ad",txtAdi.Text);
            komut.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            komut.Parameters.AddWithValue("@cinsi", combocinsiyet.Text);
            komut.Parameters.AddWithValue("@tel", txtTelefon.Text);
            komut.Parameters.AddWithValue("@mail", txtMail.Text);
            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@oda", txtOda.Text);
            komut.Parameters.AddWithValue("@ucreti", txtUcret.Text);
            komut.Parameters.AddWithValue("@gtarih", girisTarihi);
            komut.Parameters.AddWithValue("@ctarih", cikisTarihi);
            komut.ExecuteNonQuery();
            MessageBox.Show("Müşteri Kaydı Yapıldı Oda Teslim Edildi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void oda1_Click(object sender, EventArgs e)
        {
            txtOda.Text = "1";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda1(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda2_Click(object sender, EventArgs e)
        {
            txtOda.Text = "2";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda2(adi,soyadi) values(@ad,@soyad)",bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad",txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad",txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda3_Click(object sender, EventArgs e)
        {
            txtOda.Text = "3";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda3(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtOda.Text = "4";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda4(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void musteri_Load(object sender, EventArgs e)
        {
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("select * from oda1", bs.baglanti);
            SqlDataReader read = sorgu.ExecuteReader();
            while (read.Read())
            {
                oda1.Text = read["adi"].ToString() + " " + read["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda1.Text != "1")
            {
                oda1.BackColor = Color.Red;
                oda1.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu2 = new SqlCommand("select * from oda2", bs.baglanti);
            SqlDataReader read2 = sorgu2.ExecuteReader();
            while (read2.Read())
            {
                oda2.Text = read2["adi"].ToString() + " " + read2["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda2.Text != "2")
            {
                oda2.BackColor = Color.Red;
                oda2.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu3 = new SqlCommand("select * from oda3", bs.baglanti);
            SqlDataReader read3 = sorgu3.ExecuteReader();
            while (read3.Read())
            {
                oda3.Text = read3["adi"].ToString() + " " + read3["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda3.Text != "3")
            {
                oda3.BackColor = Color.Red;
                oda3.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu4 = new SqlCommand("select * from oda4", bs.baglanti);
            SqlDataReader read4 = sorgu4.ExecuteReader();
            while (read4.Read())
            {
                oda4.Text = read4["adi"].ToString() + " " + read4["soyadi"].ToString()+ "oda 4";
            }
            bs.baglanti.Close();
            if (oda4.Text != "4")
            {
                oda4.BackColor = Color.Red;
                oda4.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu5 = new SqlCommand("select * from oda5", bs.baglanti);
            SqlDataReader read5 = sorgu5.ExecuteReader();
            while (read5.Read())
            {
                oda5.Text = read5["adi"].ToString() + " " + read5["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda5.Text != "5")
            {
                oda5.BackColor = Color.Red;
                oda5.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu6 = new SqlCommand("select * from oda6", bs.baglanti);
            SqlDataReader read6 = sorgu6.ExecuteReader();
            while (read6.Read())
            {
                oda6.Text = read6["adi"].ToString() + " " + read6["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda6.Text != "6")
            {
                oda6.BackColor = Color.Red;
                oda6.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu7 = new SqlCommand("select * from oda7", bs.baglanti);
            SqlDataReader read7 = sorgu7.ExecuteReader();
            while (read7.Read())
            {
                oda7.Text = read7["adi"].ToString() + " " + read7["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda7.Text != "7")
            {
                oda7.BackColor = Color.Red;
                oda7.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu8 = new SqlCommand("select * from oda8", bs.baglanti);
            SqlDataReader read8 = sorgu8.ExecuteReader();
            while (read8.Read())
            {
                oda8.Text = read8["adi"].ToString() + " " + read8["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda8.Text != "8")
            {
                oda8.BackColor = Color.Red;
                oda8.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu9 = new SqlCommand("select * from oda9", bs.baglanti);
            SqlDataReader read9 = sorgu9.ExecuteReader();
            while (read9.Read())
            {
                oda9.Text = read9["adi"].ToString() + " " + read9["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda9.Text != "9")
            {
                oda9.BackColor = Color.Red;
                oda9.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu10 = new SqlCommand("select * from oda10", bs.baglanti);
            SqlDataReader read10 = sorgu10.ExecuteReader();
            while (read10.Read())
            {
                oda10.Text = read10["adi"].ToString() + " " + read10["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda10.Text != "10")
            {
                oda10.BackColor = Color.Red;
                oda10.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu11 = new SqlCommand("select * from oda11", bs.baglanti);
            SqlDataReader read11 = sorgu11.ExecuteReader();
            while (read11.Read())
            {
                oda11.Text = read11["adi"].ToString() + " " + read11["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda11.Text != "11")
            {
                oda11.BackColor = Color.Red;
                oda11.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu12 = new SqlCommand("select * from oda12", bs.baglanti);
            SqlDataReader read12 = sorgu12.ExecuteReader();
            while (read12.Read())
            {
                oda12.Text = read12["adi"].ToString() + " " + read12["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda12.Text != "12")
            {
                oda12.BackColor = Color.Red;
                oda12.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu13 = new SqlCommand("select * from oda13", bs.baglanti);
            SqlDataReader read13 = sorgu13.ExecuteReader();
            while (read13.Read())
            {
                oda13.Text = read13["adi"].ToString() + " " + read13["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda13.Text != "13")
            {
                oda13.BackColor = Color.Red;
                oda13.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu14 = new SqlCommand("select * from oda14", bs.baglanti);
            SqlDataReader read14 = sorgu14.ExecuteReader();
            while (read14.Read())
            {
                oda14.Text = read14["adi"].ToString() + " " + read14["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda14.Text != "14")
            {
                oda14.BackColor = Color.Red;
                oda14.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu15 = new SqlCommand("select * from oda15", bs.baglanti);
            SqlDataReader read15 = sorgu15.ExecuteReader();
            while (read15.Read())
            {
                oda15.Text = read15["adi"].ToString() + " " + read15["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda15.Text != "15")
            {
                oda15.BackColor = Color.Red;
                oda15.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu16 = new SqlCommand("select * from oda16", bs.baglanti);
            SqlDataReader read16 = sorgu16.ExecuteReader();
            while (read16.Read())
            {
                oda16.Text = read16["adi"].ToString() + " " + read16["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda16.Text != "16")
            {
                oda16.BackColor = Color.Red;
                oda16.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu17 = new SqlCommand("select * from oda17", bs.baglanti);
            SqlDataReader read17 = sorgu17.ExecuteReader();
            while (read17.Read())
            {
                oda17.Text = read17["adi"].ToString() + " " + read17["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda17.Text != "17")
            {
                oda17.BackColor = Color.Red;
                oda17.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu18 = new SqlCommand("select * from oda18", bs.baglanti);
            SqlDataReader read18 = sorgu18.ExecuteReader();
            while (read18.Read())
            {
                oda18.Text = read18["adi"].ToString() + " " + read18["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda18.Text != "18")
            {
                oda18.BackColor = Color.Red;
                oda18.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu19 = new SqlCommand("select * from oda19", bs.baglanti);
            SqlDataReader read19 = sorgu19.ExecuteReader();
            while (read19.Read())
            {
                oda19.Text = read19["adi"].ToString() + " " + read19["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda19.Text != "19")
            {
                oda19.BackColor = Color.Red;
                oda19.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu20 = new SqlCommand("select * from oda20", bs.baglanti);
            SqlDataReader read20 = sorgu20.ExecuteReader();
            while (read20.Read())
            {
                oda20.Text = read20["adi"].ToString() + " " + read20["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda20.Text != "20")
            {
                oda20.BackColor = Color.Red;
                oda20.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu21 = new SqlCommand("select * from oda21", bs.baglanti);
            SqlDataReader read21 = sorgu21.ExecuteReader();
            while (read21.Read())
            {
                oda21.Text = read21["adi"].ToString() + " " + read21["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda21.Text != "21")
            {
                oda21.BackColor = Color.Red;
                oda21.Enabled = false;
            }
            bs.baglanti.Open();
            SqlCommand sorgu22 = new SqlCommand("select * from oda22", bs.baglanti);
            SqlDataReader read22 = sorgu22.ExecuteReader();
            while (read22.Read())
            {
                oda22.Text = read22["adi"].ToString() + " " + read22["soyadi"].ToString();
            }
            bs.baglanti.Close();
            if (oda22.Text != "22")
            {
                oda22.BackColor = Color.Red;
                oda22.Enabled = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void oda6_Click(object sender, EventArgs e)
        {
            txtOda.Text = "6";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda6(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda7_Click(object sender, EventArgs e)
        {
            txtOda.Text = "7";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda7(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda8_Click(object sender, EventArgs e)
        {
            txtOda.Text = "8";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda8(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda9_Click(object sender, EventArgs e)
        {
            txtOda.Text = "9";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda9(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda10_Click(object sender, EventArgs e)
        {
            txtOda.Text = "10";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda10(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda11_Click(object sender, EventArgs e)
        {
            txtOda.Text = "11";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda11(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda12_Click(object sender, EventArgs e)
        {
            txtOda.Text = "12";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda12(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda13_Click(object sender, EventArgs e)
        {
            txtOda.Text = "13";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda13(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda14_Click(object sender, EventArgs e)
        {
            txtOda.Text = "14";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda14(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda15_Click(object sender, EventArgs e)
        {
            txtOda.Text = "15";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda15(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda16_Click(object sender, EventArgs e)
        {
            txtOda.Text = "16";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda16(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            int ucret;
            DateTime kck = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime buyuk = Convert.ToDateTime(dateTimePicker2.Text);

            TimeSpan sonuc = buyuk - kck;
            labelgun.Text= sonuc.TotalDays.ToString();
            ucret = Convert.ToInt32(labelgun.Text) * 50;
            txtUcret.Text = ucret.ToString();
        }

        private void oda17_Click(object sender, EventArgs e)
        {
            txtOda.Text = "17";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda17(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda18_Click(object sender, EventArgs e)
        {
            txtOda.Text = "18";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda18(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda19_Click(object sender, EventArgs e)
        {
            txtOda.Text = "19";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda19(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda20_Click(object sender, EventArgs e)
        {
            txtOda.Text = "20";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda20(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda21_Click(object sender, EventArgs e)
        {
            txtOda.Text = "21";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda21(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }

        private void oda22_Click(object sender, EventArgs e)
        {
            txtOda.Text = "22";
            bs.baglanti.Open();
            SqlCommand sorgu = new SqlCommand("insert into oda22(adi,soyadi) values(@ad,@soyad)", bs.baglanti);
            sorgu.Parameters.AddWithValue("@ad", txtAdi.Text);
            sorgu.Parameters.AddWithValue("@soyad", txtSoyadi.Text);
            sorgu.ExecuteNonQuery();
            bs.baglanti.Close();
        }
    }
}
