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
    public partial class Maps : Form
    {
        public Maps()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Hanamura")
            {
                pictureBox1.Image = Properties.Resources.Hanamura;
                textBox1.Text = Properties.Resources.Assault;
                textBox2.Text = Properties.Resources.Hanamura1;
            }
            else if (treeView1.SelectedNode.Text == "Horizon Lunar Colony")
            {
                pictureBox1.Image = Properties.Resources.Horizon;
                textBox1.Text = Properties.Resources.Assault;
                textBox2.Text = Properties.Resources.Horizon_colony;
            }
            else if (treeView1.SelectedNode.Text == "Temple of Anubis")
            {
                pictureBox1.Image = Properties.Resources.Anubis;
                textBox1.Text = Properties.Resources.Assault;
                textBox2.Text = Properties.Resources.Temple;
            }
            else if (treeView1.SelectedNode.Text == "Volskaya Industries")
            {
                pictureBox1.Image = Properties.Resources.Volskaya;
                textBox1.Text = Properties.Resources.Assault;
                textBox2.Text = Properties.Resources.Industries;
            }
            else if (treeView1.SelectedNode.Text == "Dorado")
            {
                pictureBox1.Image = Properties.Resources.Dorado;
                textBox1.Text = Properties.Resources.Escort;
                textBox2.Text = Properties.Resources.El_dorado;
            }
            else if (treeView1.SelectedNode.Text == "Junkertown")
            {
                pictureBox1.Image = Properties.Resources.Junkertown;
                textBox1.Text = Properties.Resources.Escort;
                textBox2.Text = Properties.Resources.Junker;
            }
            else if (treeView1.SelectedNode.Text == "Route 66")
            {
                pictureBox1.Image = Properties.Resources.Route66;
                textBox1.Text = Properties.Resources.Escort;
                textBox2.Text = Properties.Resources._66;
            }
            else if (treeView1.SelectedNode.Text == "Watchpoint: Gibraltar")
            {
                pictureBox1.Image = Properties.Resources.Gibraltar;
                textBox1.Text = Properties.Resources.Escort;
                textBox2.Text = Properties.Resources.Watchpoint;
            }
            else if (treeView1.SelectedNode.Text == "Eichenwalde")
            {
                pictureBox1.Image = Properties.Resources.Eichenwalde;
                textBox1.Text = Properties.Resources.Assault_Escort;
                textBox2.Text = Properties.Resources.Eiche;
            }
            else if (treeView1.SelectedNode.Text == "Hollywood")
            {
                pictureBox1.Image = Properties.Resources.Hollywood;
                textBox1.Text = Properties.Resources.Assault_Escort;
                textBox2.Text = Properties.Resources.Holly;
            }
            else if (treeView1.SelectedNode.Text == "King's Row")
            {
                pictureBox1.Image = Properties.Resources.King;
                textBox1.Text = Properties.Resources.Assault_Escort;
                textBox2.Text = Properties.Resources.Kings;
            }
            else if (treeView1.SelectedNode.Text == "Numbani")
            {
                pictureBox1.Image = Properties.Resources.Numbani;
                textBox1.Text = Properties.Resources.Assault_Escort;
                textBox2.Text = Properties.Resources.Numb;
            }
            else if (treeView1.SelectedNode.Text == "Ilios")
            {
                pictureBox1.Image = Properties.Resources.Ilios;
                textBox1.Text = Properties.Resources.Control;
                textBox2.Text = Properties.Resources.Ilios2;
            }
            else if (treeView1.SelectedNode.Text == "Lijiang Tower")
            {
                pictureBox1.Image = Properties.Resources.Lijiang;
                textBox1.Text = Properties.Resources.Control;
                textBox2.Text = Properties.Resources.Tower;
            }
            else if (treeView1.SelectedNode.Text == "Nepal")
            {
                pictureBox1.Image = Properties.Resources.Nepal;
                textBox1.Text = Properties.Resources.Control;
                textBox2.Text = Properties.Resources.Nepal2;
            }
            else if (treeView1.SelectedNode.Text == "Oasis")
            {
                pictureBox1.Image = Properties.Resources.Oasis;
                textBox1.Text = Properties.Resources.Control;
                textBox2.Text = Properties.Resources.Oasis2;
            }
            else if (treeView1.SelectedNode.Text == "Black Forest")
            {
                pictureBox1.Image = Properties.Resources.Black;
                textBox1.Text = Properties.Resources.Arcade;
                textBox2.Text = Properties.Resources.Forest;
            }
            else if (treeView1.SelectedNode.Text == "Castillo")
            {
                pictureBox1.Image = Properties.Resources.Castillo;
                textBox1.Text = Properties.Resources.Arcade;
                textBox2.Text = Properties.Resources.Casti;
            }
            else if (treeView1.SelectedNode.Text == "Chateau Guillard")
            {
                pictureBox1.Image = Properties.Resources.Chateau_Guillard;
                textBox1.Text = Properties.Resources.Arcade;
                textBox2.Text = Properties.Resources.Gui8llard;
            }
            else if (treeView1.SelectedNode.Text == "Ecopoint: Antarctica")
            {
                pictureBox1.Image = Properties.Resources.Eco;
                textBox1.Text = Properties.Resources.Arcade;
                textBox2.Text = Properties.Resources.Ecopoint;
            }
            else if (treeView1.SelectedNode.Text == "Necropolis")
            {
                pictureBox1.Image = Properties.Resources.Necropolis;
                textBox1.Text = Properties.Resources.Arcade;
                textBox2.Text = Properties.Resources.Necro;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            InfoScreen IS = new InfoScreen();
            IS.Show();
        }
    }
}
