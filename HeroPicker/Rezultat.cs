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
        public string role;
        public string hime;
        public Rezultat(int id)
        {
            InitializeComponent();
            id_heroj = id;
        }

        

        private void Rezultat_Load(object sender, EventArgs e)
        {
            switch (id_heroj)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources.Doomfist;
                    textBox1.Text = Properties.Resources.Doomfist1;
                    hime = "Doomfist";
                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources.Genji;
                    textBox1.Text = Properties.Resources.Genji1;
                    hime = "Genji";
                    break;

                case 3:
                    pictureBox1.Image = Properties.Resources.Mccree;
                    textBox1.Text = Properties.Resources.Mccree1;
                    hime = "McCree";
                    break;

                case 4:
                    pictureBox1.Image = Properties.Resources.Pharah;
                    textBox1.Text = Properties.Resources.Pharah1;
                    hime = "Pharah";
                    break;

                case 5:
                    pictureBox1.Image = Properties.Resources.Reaper;
                    textBox1.Text = Properties.Resources.Reaper1;
                    hime = "Reaper";
                    break;

                case 6:
                    pictureBox1.Image = Properties.Resources.Soldier76;
                    textBox1.Text = Properties.Resources.Soldier761;
                    hime = "Soldier76";
                    break;

                case 7:
                    pictureBox1.Image = Properties.Resources.Sombra;
                    textBox1.Text = Properties.Resources.Sombra1;
                    hime = "Sombra";
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources.Tracer;
                    textBox1.Text = Properties.Resources.Tracer1;
                    hime = "Tracer";
                    break;

                case 9:
                    pictureBox1.Image = Properties.Resources.Bastion;
                    textBox1.Text = Properties.Resources.Bastion1;
                    hime = "Bastion";
                    break;

                case 10:
                    pictureBox1.Image = Properties.Resources.Hanzo;
                    textBox1.Text = Properties.Resources.Hanzo1;
                    hime = "Hanzo";
                    break;

                case 11:
                    pictureBox1.Image = Properties.Resources.Junkrat;
                    textBox1.Text = Properties.Resources.Junkrat1;
                    hime = "Junkrat";
                    break;

                case 12:
                    pictureBox1.Image = Properties.Resources.Mei;
                    textBox1.Text = Properties.Resources.Mei1;
                    hime = "Mei";
                    break;

                case 13:
                    pictureBox1.Image = Properties.Resources.Torbjorn;
                    textBox1.Text = Properties.Resources.Torbjorn1;
                    hime = "Torbjorn";
                    break;

                case 14:
                    pictureBox1.Image = Properties.Resources.Widowmaker;
                    textBox1.Text = Properties.Resources.Widowmaker1;
                    hime = "Widowmaker";
                    break;

                case 15:
                    pictureBox1.Image = Properties.Resources.D_Va;
                    textBox1.Text = Properties.Resources.D_Va1;
                    hime = "Dva";
                    break;

                case 16:
                    pictureBox1.Image = Properties.Resources.Orisa;
                    textBox1.Text = Properties.Resources.Orisa1;
                    hime = "Orisa";
                    break;

                case 17:
                    pictureBox1.Image = Properties.Resources.Reinhardt;
                    textBox1.Text = Properties.Resources.Reinhardt1;
                    hime = "Reinhardt";
                    break;

                case 18:
                    pictureBox1.Image = Properties.Resources.Roadhog;
                    textBox1.Text = Properties.Resources.Roadhog1;
                    hime = "Roadhog";
                    break;

                case 19:
                    pictureBox1.Image = Properties.Resources.Winston;
                    textBox1.Text = Properties.Resources.Winston1;
                    hime = "Winston";
                    break;

                case 20:
                    pictureBox1.Image = Properties.Resources.Zarya;
                    textBox1.Text = Properties.Resources.Zarya1;
                    hime = "Zarya";
                    break;

                case 21:
                    pictureBox1.Image = Properties.Resources.Ana;
                    textBox1.Text = Properties.Resources.Ana1;
                    hime = "Ana";
                    break;

                case 22:
                    pictureBox1.Image = Properties.Resources.Lucio;
                    textBox1.Text = Properties.Resources.Lucio1;
                    hime = "Lucio";
                    break;

                case 23:
                    pictureBox1.Image = Properties.Resources.Mercy;
                    textBox1.Text = Properties.Resources.Mercy1;
                    hime = "Mercy";
                    break;

                case 24:
                    pictureBox1.Image = Properties.Resources.Moira;
                    textBox1.Text = Properties.Resources.Moira1;
                    hime = "Moira";
                    break;

                case 25:
                    pictureBox1.Image = Properties.Resources.Symmetra;
                    textBox1.Text = Properties.Resources.Symmetra1;
                    hime = "Symmetra";
                    break;

                case 26:
                    pictureBox1.Image = Properties.Resources.Zenyatta;
                    textBox1.Text = Properties.Resources.Zenyatta1;
                    hime = "Zenyatta";
                    break;
            }

            using (SQLiteConnection con = new SQLiteConnection(baze_put.datasource))
            {
                if (id_heroj > 0 && id_heroj <= 8)  role = "Offense";
                else if (id_heroj > 8 && id_heroj <= 14) role = "Defense";
                else if (id_heroj > 14 && id_heroj <= 20) role = "Tank";
                else if (id_heroj > 20 && id_heroj <= 26) role = "Support";
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT HeroName, Age, Role, Health, Armour, Shield, Difficulty FROM Heroes WHERE Id = " + id_heroj, con);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = rdr;
                dataGridView1.DataSource = source;
                SQLiteCommand cmd1 = new SQLiteCommand("UPDATE Heroes SET Predlozen = Predlozen + 1 WHERE id = " + id_heroj, con);
                cmd1.ExecuteNonQuery();
                SQLiteCommand cmd2 = new SQLiteCommand("UPDATE Roles SET Predlozen = Predlozen + 1 WHERE Role = '" + role + "'", con);
                cmd2.ExecuteNonQuery();
                SQLiteCommand cmd3 = new SQLiteCommand("UPDATE User_Heroes SET " + hime + " = " + hime + " + 1 WHERE id = " + id_korisnik.id_kor, con);
                cmd3.ExecuteNonQuery();
                SQLiteCommand cmd4 = new SQLiteCommand("UPDATE User_Role SET " + role + " = " + role + " + 1 WHERE Id =" + id_korisnik.id_kor , con);
                cmd4.ExecuteNonQuery();
                con.Close();

                
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
            WWStat ww = new WWStat();
            ww.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            mm.Show();
            this.Close();
        }
        
    }
}
