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
    public partial class yoneticianasayfa : Form
    {
        public yoneticianasayfa()
        {
            InitializeComponent();
        }
        veritabani bs = new veritabani();
        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            personelkayit ps = new personelkayit();
            ps.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            personelbilgi ps = new personelbilgi();
            ps.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            yoneticioda oda = new yoneticioda();
            oda.Show();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void yoneticianasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
