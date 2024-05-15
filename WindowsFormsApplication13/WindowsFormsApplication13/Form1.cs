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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
        }
        OleDbCommand komut;
        OleDbConnection baglanti;
        OleDbDataAdapter da;


        private void button1_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=OtelY.mdb");

            komut = new OleDbCommand("SELECT*From kullanıcılar", baglanti);
            baglanti.Open();
            OleDbDataReader oku = komut.ExecuteReader();
            oku.Read();

            if (oku.GetValue(1).ToString() == textBox1.Text && oku.GetValue(2).ToString() == textBox2.Text)
            {
                Form2 m = new Form2();
                m.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("yanlış");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
               
            }

            else
            {
                textBox2.PasswordChar = '*';
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
