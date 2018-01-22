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
    public partial class DPS_2_1 : Form
    {
        public DPS_2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rjesenje r1 = new Rjesenje();
            r1.Hendlanje(3);
            Rezultat r = new Rezultat(3);
            r.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rjesenje r1 = new Rjesenje();
            r1.Hendlanje(5);
            Rezultat r = new Rezultat(5);
            r.Show();
            this.Close();
        }
    }
}
