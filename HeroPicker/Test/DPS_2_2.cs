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
    public partial class DPS_2_2 : Form
    {
        public DPS_2_2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DPS_3_1 dps3 = new DPS_3_1();
            dps3.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rjesenje r = new Rjesenje();
            r.Hendlanje(4);
            Rezultat r1 = new Rezultat(4);
            r1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DPS_3_3 dps3 = new DPS_3_3();
            dps3.Show();
            this.Close();
        }
    }
}
