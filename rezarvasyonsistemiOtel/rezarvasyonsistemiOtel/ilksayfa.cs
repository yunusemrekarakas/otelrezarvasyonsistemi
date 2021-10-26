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
    public partial class ilksayfa : Form
    {
        public ilksayfa()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width >= 800)
            {
                timer1.Stop();
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
        }

        private void ilksayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
