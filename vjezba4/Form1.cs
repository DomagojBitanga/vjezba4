using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vjezba4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string linija;
            StreamReader sr = new StreamReader("student.txt", true);
            linija = sr.ReadLine();
            List<string> lstStr = new List<string>();
            while (linija != null)
            {
                linija = linija.Replace("|", " ");
                lstStr.Add(linija);
                linija = sr.ReadLine();
            }
            listBox1.DataSource = lstStr;

            sr.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string linija;
            linija = textBox1.Text + "|" + textBox2.Text;
            StreamWriter sw = new StreamWriter("student.txt", true);
            sw.WriteLine(linija);
            sw.Close();
            textBox2.Text = "";
            textBox1.Text = "";
            MessageBox.Show("Podaci su spremljeni!");


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
