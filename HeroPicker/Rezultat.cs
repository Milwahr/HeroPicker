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
    public partial class Rezultat : Form
    {
        public int id_heroj=0;
        public Rezultat(int id)
        {
            InitializeComponent();
            id_heroj = id;
        }

        private void Rezultat_Load(object sender, EventArgs e)
        {
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\Roberto\source\repos\Testna\Testni.db"))
            {
                con.Open();
                Rjesenje r = new Rjesenje();
                SQLiteCommand cmd = new SQLiteCommand("SELECT heroname, age, role, health, armour, shield, difficulty FROM testna WHERE Id = " + id_heroj, con);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = rdr;
                dataGridView1.DataSource = source;
                con.Close();

                switch (id_heroj)
                {
                    case 1:
                        pictureBox1.Image = Properties.Resources.Doomfist;
                        textBox1.Text = Properties.Resources.Doomfist1;
                        break;

                    case 2:
                        pictureBox1.Image = Properties.Resources.Genji;
                        textBox1.Text = Properties.Resources.Genji1;
                        break;

                    case 3:
                        pictureBox1.Image = Properties.Resources.Mccree;
                        textBox1.Text = Properties.Resources.Mccree1;
                        break;

                    case 4:
                        pictureBox1.Image = Properties.Resources.Pharah;
                        textBox1.Text = Properties.Resources.Pharah1;
                        break;

                    case 5:
                        pictureBox1.Image = Properties.Resources.Reaper;
                        textBox1.Text = Properties.Resources.Reaper1;
                        break;

                    case 6:
                        pictureBox1.Image = Properties.Resources.Soldier76;
                        textBox1.Text = Properties.Resources.Soldier761;
                        break;

                    case 7:
                        pictureBox1.Image = Properties.Resources.Sombra;
                        textBox1.Text = Properties.Resources.Sombra1;
                        break;

                    case 8:
                        pictureBox1.Image = Properties.Resources.Tracer;
                        textBox1.Text = Properties.Resources.Tracer1;
                        break;

                    case 9:
                        pictureBox1.Image = Properties.Resources.Bastion;
                        textBox1.Text = Properties.Resources.Bastion1;
                        break;

                    case 10:
                        pictureBox1.Image = Properties.Resources.Hanzo;
                        textBox1.Text = Properties.Resources.Hanzo1;
                        break;

                    case 11:
                        pictureBox1.Image = Properties.Resources.Junkrat;
                        textBox1.Text = Properties.Resources.Junkrat1;
                        break;

                    case 12:
                        pictureBox1.Image = Properties.Resources.Mei;
                        textBox1.Text = Properties.Resources.Mei1;
                        break;

                    case 13:
                        pictureBox1.Image = Properties.Resources.Torbjorn;
                        textBox1.Text = Properties.Resources.Torbjorn1;
                        break;

                    case 14:
                        pictureBox1.Image = Properties.Resources.Widowmaker;
                        textBox1.Text = Properties.Resources.Widowmaker1;
                        break;

                    case 15:
                        pictureBox1.Image = Properties.Resources.D_Va;
                        textBox1.Text = Properties.Resources.D_Va1;
                        break;

                    case 16:
                        pictureBox1.Image = Properties.Resources.Orisa;
                        textBox1.Text = Properties.Resources.Orisa1;
                        break;

                    case 17:
                        pictureBox1.Image = Properties.Resources.Reinhardt;
                        textBox1.Text = Properties.Resources.Reinhardt1;
                        break;

                    case 18:
                        pictureBox1.Image = Properties.Resources.Roadhog;
                        textBox1.Text = Properties.Resources.Roadhog1;
                        break;

                    case 19:
                        pictureBox1.Image = Properties.Resources.Winston;
                        textBox1.Text = Properties.Resources.Winston1;
                        break;

                    case 20:
                        pictureBox1.Image = Properties.Resources.Zarya;
                        textBox1.Text = Properties.Resources.Zarya1;
                        break;

                    case 21:
                        pictureBox1.Image = Properties.Resources.Ana;
                        textBox1.Text = Properties.Resources.Ana1;
                        break;

                    case 22:
                        pictureBox1.Image = Properties.Resources.Lucio;
                        textBox1.Text = Properties.Resources.Lucio1;
                        break;

                    case 23:
                        pictureBox1.Image = Properties.Resources.Mercy;
                        textBox1.Text = Properties.Resources.Mercy1;
                        break;

                    case 24:
                        pictureBox1.Image = Properties.Resources.Moira;
                        textBox1.Text = Properties.Resources.Moira1;
                        break;

                    case 25:
                        pictureBox1.Image = Properties.Resources.Symmetra;
                        textBox1.Text = Properties.Resources.Symmetra1;
                        break;

                    case 26:
                        pictureBox1.Image = Properties.Resources.Zenyatta;
                        textBox1.Text = Properties.Resources.Zenyatta1;
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AboutHeroes ah = new AboutHeroes();
            ah.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }
    }
}
