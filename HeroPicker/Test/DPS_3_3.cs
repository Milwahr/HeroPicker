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
    public partial class DPS_3_3 : Form
    {
        public DPS_3_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(1);
            r1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(6);
            r1.Show();
            this.Close();
        }
    }
}
