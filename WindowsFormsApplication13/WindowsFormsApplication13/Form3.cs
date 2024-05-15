using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication13
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=OtelY.mdb");
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
           baglanti.Open();
           OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM musteriler", baglanti);
           DataTable tablo = new DataTable();
           da.Fill(tablo);
           dataGridView1.DataSource = tablo;
           baglanti.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 m = new Form2();
            m.Show();
            this.Hide();
        }
    }
}
