using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpmodul12_2311104069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Kosongkan label saat form pertama dibuka
            label1.Text = "";
        }

        // Method untuk menentukan tanda bilangan
        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        // Logika saat tombol ditekan
        private void button1_Click(object sender, EventArgs e)
        {
            int angka;

            if (int.TryParse(textBox1.Text, out angka))
            {
                string hasil = CariTandaBilangan(angka);
                label1.Text = hasil;
            }
            else
            {
                label1.Text = "Input tidak valid";
            }
        }
    }
}
