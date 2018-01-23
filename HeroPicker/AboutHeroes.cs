using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HeroPicker
{
    public partial class AboutHeroes : Form
    {
        public AboutHeroes()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode.Text == "Doomfist")
            {
                pictureBox1.Image = Properties.Resources.Doomfist;
                textBox2.Text = Properties.Resources.Doomfist1;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(1);
            }
            else if (treeView1.SelectedNode.Text == "Genji")
            {
                pictureBox1.Image = Properties.Resources.Genji;
                textBox2.Text = Properties.Resources.Genji1;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(2);
            }
            else if (treeView1.SelectedNode.Text == "McCree")
            {
                pictureBox1.Image = Properties.Resources.Mccree;
                textBox2.Text = Properties.Resources.Mccree1;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(3);
            }
            else if (treeView1.SelectedNode.Text == "Pharah")
            {
                pictureBox1.Image = Properties.Resources.Pharah;
                textBox2.Text = Properties.Resources.Pharah1;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(4);
            }
            else if (treeView1.SelectedNode.Text == "Reaper")
            {
                pictureBox1.Image = Properties.Resources.Reaper;
                textBox2.Text = Properties.Resources.Reaper1;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(5);
            }
            else if (treeView1.SelectedNode.Text == "Soldier: 76")
            {
                pictureBox1.Image = Properties.Resources.Soldier76;
                textBox2.Text = Properties.Resources.Soldier761;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(6);
            }
            else if (treeView1.SelectedNode.Text == "Sombra")
            {
                pictureBox1.Image = Properties.Resources.Sombra;
                textBox2.Text = Properties.Resources.Sombra1;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(7);
            }
            else if (treeView1.SelectedNode.Text == "Tracer")
            {
                pictureBox1.Image = Properties.Resources.Tracer;
                textBox2.Text = Properties.Resources.Tracer1;
                textBox1.Text = Properties.Resources.Offense;
                prikaz_tabli(8);
            }
            else if (treeView1.SelectedNode.Text == "Bastion")
            {
                pictureBox1.Image = Properties.Resources.Bastion;
                textBox2.Text = Properties.Resources.Bastion1;
                textBox1.Text = Properties.Resources.Defense;
                prikaz_tabli(9);
            }
            else if (treeView1.SelectedNode.Text == "Hanzo")
            {
                pictureBox1.Image = Properties.Resources.Hanzo;
                textBox2.Text = Properties.Resources.Hanzo1;
                textBox1.Text = Properties.Resources.Defense;
                prikaz_tabli(10);
            }
            else if (treeView1.SelectedNode.Text == "Junkrat")
            {
                pictureBox1.Image = Properties.Resources.Junkrat;
                textBox2.Text = Properties.Resources.Junkrat1;
                textBox1.Text = Properties.Resources.Defense;
                prikaz_tabli(11);
            }
            else if (treeView1.SelectedNode.Text == "Mei")
            {
                pictureBox1.Image = Properties.Resources.Mei;
                textBox2.Text = Properties.Resources.Mei1;
                textBox1.Text = Properties.Resources.Defense;
                prikaz_tabli(12);
            }
            else if (treeView1.SelectedNode.Text == "Torbjorn")
            {
                pictureBox1.Image = Properties.Resources.Torbjorn;
                textBox2.Text = Properties.Resources.Torbjorn1;
                textBox1.Text = Properties.Resources.Defense;
                prikaz_tabli(13);
            }
            else if (treeView1.SelectedNode.Text == "Widowmaker")
            {
                pictureBox1.Image = Properties.Resources.Widowmaker;
                textBox2.Text = Properties.Resources.Widowmaker1;
                textBox1.Text = Properties.Resources.Defense;
                prikaz_tabli(14);
            }
            else if (treeView1.SelectedNode.Text == "D.Va")
            {
                pictureBox1.Image = Properties.Resources.D_Va;
                textBox2.Text = Properties.Resources.D_Va1;
                textBox1.Text = Properties.Resources.Tank;
                prikaz_tabli(15);
            }
            else if (treeView1.SelectedNode.Text == "Orisa")
            {
                pictureBox1.Image = Properties.Resources.Orisa;
                textBox2.Text = Properties.Resources.Orisa1;
                textBox1.Text = Properties.Resources.Tank;
                prikaz_tabli(16);
            }
            else if (treeView1.SelectedNode.Text == "Reinhardt")
            {
                pictureBox1.Image = Properties.Resources.Reinhardt;
                textBox2.Text = Properties.Resources.Reinhardt1;
                textBox1.Text = Properties.Resources.Tank;
                prikaz_tabli(17);
            }
            else if (treeView1.SelectedNode.Text == "Roadhog")
            {
                pictureBox1.Image = Properties.Resources.Roadhog;
                textBox2.Text = Properties.Resources.Roadhog1;
                textBox1.Text = Properties.Resources.Tank;
                prikaz_tabli(18);
            }
            else if (treeView1.SelectedNode.Text == "Winston")
            {
                pictureBox1.Image = Properties.Resources.Winston;
                textBox2.Text = Properties.Resources.Winston1;
                textBox1.Text = Properties.Resources.Tank;
                prikaz_tabli(19);
            }
            else if (treeView1.SelectedNode.Text == "Zarya")
            {
                pictureBox1.Image = Properties.Resources.Zarya;
                textBox2.Text = Properties.Resources.Zarya1;
                textBox1.Text = Properties.Resources.Tank;
                prikaz_tabli(20);
            }
            else if (treeView1.SelectedNode.Text == "Ana")
            {
                pictureBox1.Image = Properties.Resources.Ana;
                textBox2.Text = Properties.Resources.Ana1;
                textBox1.Text = Properties.Resources.Support;
                prikaz_tabli(21);
            }
            else if (treeView1.SelectedNode.Text == "Lucio")
            {
                pictureBox1.Image = Properties.Resources.Lucio;
                textBox2.Text = Properties.Resources.Lucio1;
                textBox1.Text = Properties.Resources.Support;
                prikaz_tabli(22);
            }
            else if (treeView1.SelectedNode.Text == "Mercy")
            {
                pictureBox1.Image = Properties.Resources.Mercy;
                textBox2.Text = Properties.Resources.Mercy1;
                textBox1.Text = Properties.Resources.Support;
                prikaz_tabli(23);
            }
            else if (treeView1.SelectedNode.Text == "Moira")
            {
                pictureBox1.Image = Properties.Resources.Moira;
                textBox2.Text = Properties.Resources.Moira1;
                textBox1.Text = Properties.Resources.Support;
                prikaz_tabli(24);
            }
            else if (treeView1.SelectedNode.Text == "Symmetra")
            {
                pictureBox1.Image = Properties.Resources.Symmetra;
                textBox2.Text = Properties.Resources.Symmetra1;
                textBox1.Text = Properties.Resources.Support;
                prikaz_tabli(25);
            }
            else if (treeView1.SelectedNode.Text == "Zenyatta")
            {
                pictureBox1.Image = Properties.Resources.Zenyatta;
                textBox2.Text = Properties.Resources.Zenyatta1;
                textBox1.Text = Properties.Resources.Support;
                prikaz_tabli(26);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoScreen IS = new InfoScreen();
            this.Hide();
            IS.Show();
        }
        public void prikaz_tabli(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\Roberto\Documents\Faks\HeroPicker\HeroPicker\HeroPicker\HeroPicker_DB.db"))
            {
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT HeroName, Age, Role, Health, Armour, Shield, Difficulty FROM Heroes WHERE id = " + id , con);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = rdr;
                dataGridView1.DataSource = source;
                con.Close();
                con.Open();
                SQLiteCommand cmd1 = new SQLiteCommand("Select ability1, ability2, ability3, ability4, ultimate from Ability where Ability.id = " + id, con);
                SQLiteDataReader rdr1 = cmd1.ExecuteReader();
                BindingSource source1 = new BindingSource();
                source1.DataSource = rdr1;
                dataGridView2.DataSource = source1;
                SQLiteCommand cmd2 = new SQLiteCommand("Select dh1, dh2, dh3, dh4, ulthd from DamHeal where DamHeal.id = " + id, con);
                SQLiteDataReader rdr2 = cmd2.ExecuteReader();
                BindingSource source2 = new BindingSource();
                source2.DataSource = rdr2;
                dataGridView3.DataSource = source2;
                con.Clone();
            }
        }
        public void prikaz_tabli2(int id)
        {

        }
    }
}
