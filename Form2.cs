using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadatak2_Grupa2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(@"C:\Users\Bojan\Desktop\Nova fascikla\Zadatak 1/.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("Uspesno ste sacuvali fajl", "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Ime:" + Hotel.Ime + "\r\nPrezime:" + Hotel.Prezime + "\r\nSmestaj:" + Hotel.Smestaj + "\r\nObroci:" + Hotel.Obroci;
        }
    }
}
