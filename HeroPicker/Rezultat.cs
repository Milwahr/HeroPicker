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
            }
        }
    }
}
