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
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {
            MessageBox.Show("You are about to start the test, press OK when you feel ready. Good luck!",
            "Starting the test", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DPS_1 dps1 = new DPS_1();
            dps1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tank_1 t = new Tank_1();
            t.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Def_1 def = new Def_1();
            def.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Sup_1 sup = new Sup_1();
            sup.Show();
            this.Close();
        }
    }
}
