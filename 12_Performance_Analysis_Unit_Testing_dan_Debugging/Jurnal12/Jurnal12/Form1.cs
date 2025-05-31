using System;
using System.Windows.Forms;

namespace Jurnal12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(textBoxA.Text);
                int b = int.Parse(textBoxB.Text);

                long result = CariNilaiPangkat(a, b);

                if (result == -1)
                {
                    labelResult.Text = "Hasil: Error - Pangkat negatif tidak diperbolehkan";
                }
                else if (result == -2)
                {
                    labelResult.Text = "Hasil: Error - Input melebihi batas (a > 100 atau b > 10)";
                }
                else if (result == -3)
                {
                    labelResult.Text = "Hasil: Error - Hasil melebihi batas integer";
                }
                else
                {
                    labelResult.Text = $"Hasil: {a}^{b} = {result}";
                }
            }
            catch (FormatException)
            {
                labelResult.Text = "Hasil: Error - Input harus berupa angka";
            }
            catch (Exception ex)
            {
                labelResult.Text = $"Hasil: Error - {ex.Message}";
            }
        }

        public long CariNilaiPangkat(int a, int b)
        {
            // Aturan 1: Jika b = 0, return 1 (bahkan jika a = 0)
            if (b == 0)
            {
                return 1;
            }

            // Aturan 2: Jika b negatif, return -1
            if (b < 0)
            {
                return -1;
            }

            // Aturan 3: Jika a > 100 atau b > 10, return -2
            if (a > 100 || b > 10)
            {
                return -2;
            }

            // Hitung pangkat dengan iterasi
            long result = 1;

            try
            {
                for (int i = 0; i < b; i++)
                {
                    checked
                    {
                        result *= a;
                    }
                }
            }
            catch (OverflowException)
            {
                // Aturan 4: Jika overflow, return -3
                return -3;
            }

            return result;
        }
    }
}