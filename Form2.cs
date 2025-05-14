using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pracownicy
{
    public partial class Form2 : Form
    {
        private string imie;
        private string nazwisko;
        private int wiek;
        private string stanowisko;
        private Form1 form1;
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            imie = tImie.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            nazwisko = tNazwisko.Text;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(tWiek.Text, out int result))
            {
                wiek = result;
                tWiek.BackColor = Color.White;
            }
            else
            {
                tWiek.BackColor = Color.LightCoral;
                wiek = 0;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            form1.imie = imie;
            form1.nazwisko = nazwisko;
            form1.wiek = wiek;
            form1.stanowisko = stanowisko;
            form1.adduser();

            tImie.Clear();
            tNazwisko.Clear();
            tWiek.Clear();
            cStanowisko.SelectedIndex = -1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cStanowisko.SelectedItem != null)
            {
                stanowisko = cStanowisko.SelectedItem.ToString();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            cStanowisko.Items.Add("Asystent");
            cStanowisko.Items.Add("Specjalista");
            cStanowisko.Items.Add("Manager");
            cStanowisko.Items.Add("Dyrektor");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
