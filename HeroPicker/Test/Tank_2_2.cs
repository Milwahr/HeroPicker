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
    public partial class Tank_2_2 : Form
    {
        public Tank_2_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(16);
            r1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(20);
            r1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(17);
            r1.Show();
            this.Close();
        }
    }
}
