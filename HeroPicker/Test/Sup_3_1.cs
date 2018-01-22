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
    public partial class Sup_3_1 : Form
    {
        public Sup_3_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(23);
            r1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(22);
            r1.Show();
            this.Close();
        }
    }
}
