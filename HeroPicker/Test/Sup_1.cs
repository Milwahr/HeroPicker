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
    public partial class Sup_1 : Form
    {
        public Sup_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Rezultat r1 = new Rezultat(25);
            r1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sup_2_1 sup = new Sup_2_1();
            sup.Show();
            this.Close();
        }
    }
}
