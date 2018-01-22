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
        public Rezultat()
        {
            InitializeComponent();
        }
        public void prikaz_tabli(int id)
        {
            using (SQLiteConnection con = new SQLiteConnection(@"Data Source=C:\Users\Roberto\Documents\Faks\HeroPicker\HeroPicker\HeroPicker\HeroPicker_DB.db"))
            {
                Rjesenje r = new Rjesenje();
                con.Open();
                SQLiteCommand cmd = new SQLiteCommand("SELECT HeroName, Age, Role, Health, Armour, Shield, Difficulty FROM Heroes WHERE id = " + r.id_heroj, con);
                SQLiteDataReader rdr = cmd.ExecuteReader();
                BindingSource source = new BindingSource();
                source.DataSource = rdr;
                dataGridView1.DataSource = source;
                con.Close();
            }
        }
    }
}
