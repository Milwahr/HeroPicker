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
    public partial class Def_1 : Form
    {
        public Def_1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Def_2_1 def = new Def_2_1();
            def.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Def_2_2 def = new Def_2_2();
            def.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Def_2_3 def = new Def_2_3();
            def.Show();
            this.Close();
        }
    }
}
