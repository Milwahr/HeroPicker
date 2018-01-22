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
    public partial class Sup_2_1 : Form
    {
        public Sup_2_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sup_3_1 sup = new Sup_3_1();
            sup.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sup_3_2 sup = new Sup_3_2();
            sup.Show();
            this.Close();
        }
    }
}
