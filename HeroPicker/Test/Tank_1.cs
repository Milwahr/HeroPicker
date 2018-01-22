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
    public partial class Tank_1 : Form
    {
        public Tank_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tank_2_1 t = new Tank_2_1();
            t.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tank_2_2 t = new Tank_2_2();
            t.Show();
            this.Close();
        }
    }
}
