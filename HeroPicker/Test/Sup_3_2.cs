using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroPicker
{
    public partial class Sup_3_2 : Form
    {
        public Sup_3_2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(26);
            r1.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(20);
            r1.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(24);
            r1.Show();
            this.Close();
        }
    }
}
