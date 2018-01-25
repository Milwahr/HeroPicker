using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HeroPicker
{
    public partial class AboutGame : Form
    {
        public AboutGame()
        {
            InitializeComponent();
        }

        private void AboutGame_Load(object sender, EventArgs e)
        {
            try
            {
                string tekst = Properties.Resources.Overwatch_explanation1;
                textBox1.Text = tekst;
                string tekst1 = Properties.Resources.Blizzard_exp;
                textBox2.Text = tekst1;
            }
            catch
            {
                MessageBox.Show("File could not be read.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoScreen IS = new InfoScreen();
            this.Hide();
            IS.Show();
        }
    }
}
