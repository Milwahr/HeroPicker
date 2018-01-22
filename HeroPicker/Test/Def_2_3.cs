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
    public partial class Def_2_3 : Form
    {
        public Def_2_3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(12);
            r1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(11);
            r1.Show();
            this.Close();
        }
    }
}
