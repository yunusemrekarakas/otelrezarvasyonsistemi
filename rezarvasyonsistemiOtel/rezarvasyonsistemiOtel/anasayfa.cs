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
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            musteri m = new musteri();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteribilgileri M = new musteribilgileri();
            M.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            odadurumu oda = new odadurumu();
            oda.Show();
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToShortTimeString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
