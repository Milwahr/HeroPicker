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
    public partial class InfoScreen : Form
    {
        public InfoScreen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutGame ag = new AboutGame();
            ag.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AboutHeroes ah = new AboutHeroes();
            ah.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Maps m = new Maps();
            m.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();
            mm.Show();
        }
    }
}
