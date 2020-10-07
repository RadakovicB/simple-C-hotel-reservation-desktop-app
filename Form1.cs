using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Zadatak2_Grupa2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            tbPrezime.Clear();
            comboBox1.Text = "";
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {
            Form2 forma = new Form2();
            Hotel.Ime = tbIme.Text;
            Hotel.Prezime = tbPrezime.Text;
            Hotel.Smestaj = comboBox1.Text;
            if (checkBox1.Checked) Hotel.Obroci = "Dorucak";
            if (checkBox2.Checked) Hotel.Obroci +="\r\nRucak";
            if (checkBox3.Checked) Hotel.Obroci += "\r\nVecera";
            if (forma.ShowDialog()== DialogResult.OK)
            {
                textBox1.Text = Hotel.Ime;
                tbPrezime.Text = Hotel.Prezime;
                comboBox1.Text = Hotel.Smestaj;
                if (checkBox1.Checked) Hotel.Obroci = "Dorucak";
                if (checkBox2.Checked) Hotel.Obroci += "\r\nRucak";
                if (checkBox3.Checked) Hotel.Obroci += "\r\nVecera";

            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (Information.IsDate(textBox2.Text)==false)

            {
                errorProvider1.SetError(textBox2, " Unesite brojevnu vrednost");
                textBox2.Focus();
                textBox2.SelectAll();

            }
        }

        
    }
}
