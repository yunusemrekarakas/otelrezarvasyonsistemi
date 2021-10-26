using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace rezarvasyonsistemiOtel
{
    class giris
    {
        veritabani vt = new veritabani();
        public string kad { get; set; }
        public string ksifrem { get; set; }
        public string durumu { get; set; }
        public void kullanicigirisleri(String kullanici, string kullanicisifre, DateTime tarihi)
        {
            if (vt.baglanti.State == System.Data.ConnectionState.Open)
            {
                vt.baglanti.Close();
            }
            try
            {
                vt.baglanti.Open();
                SqlCommand giris = new SqlCommand("SELECT  adi FROM personeller WHERE adi=@kullaniciadi", vt.baglanti);
                giris.Parameters.AddWithValue("@kullaniciadi", kullanici);
                SqlDataReader read = giris.ExecuteReader();
                if (read.Read())
                {
                    kad = read["adi"].ToString();
                    SqlCommand girisvt = new SqlCommand("SELECT  sifre FROM personeller WHERE sifre=@sifresi", vt.baglanti);
                    girisvt.Parameters.AddWithValue("@sifresi", kullanicisifre);
                    SqlDataReader oku = girisvt.ExecuteReader();
                    if (oku.Read())
                    {
                        ksifrem = oku["sifre"].ToString();
                        durumu = kad + " " + ksifrem;
                        SqlCommand dt = new SqlCommand("UPDATE personeller set girist=@th WHERE adi=@kullaniciadi AND sifre=@sifresi  ", vt.baglanti);
                        dt.Parameters.AddWithValue("@th", tarihi);
                        dt.Parameters.AddWithValue("@kullaniciadi", kad);
                        dt.Parameters.AddWithValue("@sifresi", ksifrem);
                        dt.ExecuteNonQuery();
                        dt.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifreyi Yanlış Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    read.Close();
                }
                
                vt.baglanti.Close();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
            }
            finally
            {
                vt.baglanti.Close();
            }
        }
        public void yoneticigiris(String kullaniciadi, string kullanicisifre, DateTime tarihi)
        {
            if (vt.baglanti.State == System.Data.ConnectionState.Open)
            {
                vt.baglanti.Close();
            }
            try
            {
                vt.baglanti.Open();
                SqlCommand giris = new SqlCommand("SELECT  kadi FROM Kullanicigiris WHERE kadi=@kullaniciadi", vt.baglanti);
                giris.Parameters.AddWithValue("@kullaniciadi", kullaniciadi);
                SqlDataReader read = giris.ExecuteReader();
                if (read.Read())
                {
                    kad = read["kadi"].ToString();
                    SqlCommand girisvt = new SqlCommand("SELECT  ksifre FROM Kullanicigiris WHERE ksifre=@sifresi", vt.baglanti);
                    girisvt.Parameters.AddWithValue("@sifresi", kullanicisifre);
                    SqlDataReader oku = girisvt.ExecuteReader();
                    if (oku.Read())
                    {
                        ksifrem = oku["ksifre"].ToString();
                        durumu = kad + " " + ksifrem;
                        SqlCommand dt = new SqlCommand("UPDATE Kullanicigiris set giristarihi=@th WHERE kadi=@kullaniciadi AND ksifre=@sifresi  ", vt.baglanti);
                        dt.Parameters.AddWithValue("@th", tarihi);
                        dt.Parameters.AddWithValue("@kullaniciadi", kad);
                        dt.Parameters.AddWithValue("@sifresi", ksifrem);
                        dt.ExecuteNonQuery();
                        dt.Dispose();

                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı Adı Veya Şifreyi Yanlış Girdiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    read.Close();
                }
                vt.baglanti.Close();
            }
            catch (Exception hata)
            {
                System.Windows.Forms.MessageBox.Show("" + hata);
            }
            finally
            {
                vt.baglanti.Close();
            }
        }
    }
}
