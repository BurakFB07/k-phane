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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OleDb.4.0;Data Source=OtelY.mdb");
        private void pictureBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Form3 m = new Form3();
            m.Show();
            this.Hide();
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form3 m = new Form3();
            m.Show();
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            textBox5.Text = "101";
            pictureBox3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu = "INSERT INTO musteriler (AdSoyad , TCnumarası , TelNo ,Tarih,OdaNo) VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','"+textBox4.Text+"','"+textBox5.Text+"')";

            OleDbCommand komut = new OleDbCommand(sorgu, baglanti);

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            pictureBox3.Visible = true;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            textBox5.Text = "102";
            pictureBox4.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            pictureBox4.Visible = true;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox5.Text = "103";
            pictureBox6.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            pictureBox6.Visible = true;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            pictureBox8.Visible = true;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            textBox5.Text = "203";
            pictureBox8.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            textBox5.Text = "204";
            pictureBox10.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            pictureBox10.Visible = true;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            textBox5.Text = "205";
            pictureBox12.Visible = false;
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            pictureBox12.Visible = true;
        }
    }
}
