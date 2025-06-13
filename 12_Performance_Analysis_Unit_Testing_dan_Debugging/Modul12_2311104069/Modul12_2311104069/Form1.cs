using System;
using System.Windows.Forms;

namespace modul12_2311104069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CariNilaiPangkat(int a, int b)
        {
            if (b == 0) return 1;
            if (b < 0) return -1;
            if (b > 10 || a > 100) return -2;

            try
            {
                checked
                {
                    int hasil = 1;
                    for (int i = 0; i < b; i++)
                    {
                        hasil *= a;
                    }
                    return hasil;
                }
            }
            catch (OverflowException)
            {
                return -3;
            }
        }

        private void btnHitung_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtA.Text, out int a) && int.TryParse(txtB.Text, out int b))
            {
                int hasil = CariNilaiPangkat(a, b);
                lblHasil.Text = "Hasil: " + hasil.ToString();
            }
            else
            {
                lblHasil.Text = "Input tidak valid!";
            }
        }
    }
}
