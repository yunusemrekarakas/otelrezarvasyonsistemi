using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace rezarvasyonsistemiOtel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            giris lg = new giris();
            anasayfa frm = new anasayfa();
            if (textkullanici.Text == string.Empty || textsifre.Text == string.Empty)
            {
                MessageBox.Show("Kullancıc Adını Ve Şirenizi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lg.kullanicigirisleri(textkullanici.Text, textsifre.Text, DateTime.Now);
                string bilgi = textkullanici.Text + " " + textsifre.Text.ToString();
                if (lg.durumu == bilgi)
                {
                    frm.Show();
                    //textkullanici.Text = "";
                    //textsifre.Text = "";
                }
            }
            if (textkullanici.Text == string.Empty || textsifre.Text == string.Empty)
            {
                MessageBox.Show("Kullancıc Adını Ve Şirenizi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                lg.yoneticigiris(textkullanici.Text, textsifre.Text, DateTime.Now);
                string bilgi = textkullanici.Text + " " + textsifre.Text.ToString();
                if (lg.durumu == bilgi)
                {
                    frm.Show();
                    //textkullanici.Text = "";
                    //textsifre.Text = "";
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            sifremiunuttum sifre = new sifremiunuttum();
            sifre.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.CheckState==CheckState.Checked)
            {
                textsifre.UseSystemPasswordChar = true;
                checkBox1.Text = "Gizle";
            }
            else if(checkBox1.CheckState == CheckState.Unchecked)
            {
                textsifre.UseSystemPasswordChar = false;
                checkBox1.Text = "Göster";
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            giris yonetici = new giris();
            yoneticianasayfa a = new yoneticianasayfa();
            if (textadmin.Text == string.Empty || textadminsifre.Text == string.Empty)
            {
                MessageBox.Show("Kullanıcı Adını Ve Şirenizi Giriniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                yonetici.yoneticigiris(textadmin.Text, textadminsifre.Text, DateTime.Now);
                string bilgi = textadmin.Text + " " + textadminsifre.Text.ToString();
                if (yonetici.durumu == bilgi)
                {
                    a.Show();
                    textadmin.Text = "";
                    textadminsifre.Text = "";

                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                textadminsifre.UseSystemPasswordChar = true;
                checkBox2.Text = "Gizle";
            }
            else if (checkBox2.CheckState == CheckState.Unchecked)
            {
                textadminsifre.UseSystemPasswordChar = false;
                checkBox2.Text = "Göster";
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            yoneticiunuttum ys = new yoneticiunuttum();
            ys.Show();
        }
    }
}
