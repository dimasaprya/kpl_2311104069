using System;
using System.Windows.Forms;

namespace tp12  
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupForm();
        }

        // Method untuk setup tampilan form
        private void SetupForm()
        {
            this.Text = "TP Modul 12 - Cari Tanda Bilangan";
            this.Size = new System.Drawing.Size(400, 250);
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Method utama untuk menentukan tanda bilangan
        public string CariTandaBilangan(int a)
        {
            if (a < 0)
                return "Negatif";
            else if (a > 0)
                return "Positif";
            else
                return "Nol";
        }

        // Event handler untuk button click
        private void buttonCek_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi input kosong
                if (string.IsNullOrWhiteSpace(textBoxInput.Text))
                {
                    labelOutput.Text = "Hasil: Mohon masukkan angka!";
                    labelOutput.ForeColor = System.Drawing.Color.Red;
                    return;
                }

                // Parsing input ke integer
                int input;
                if (int.TryParse(textBoxInput.Text, out input))
                {
                    // Panggil method CariTandaBilangan
                    string hasil = CariTandaBilangan(input);

                    // Tampilkan hasil dengan warna yang sesuai
                    labelOutput.Text = "Hasil: " + hasil;

                    // Set warna berdasarkan hasil
                    switch (hasil)
                    {
                        case "Positif":
                            labelOutput.ForeColor = System.Drawing.Color.Green;
                            break;
                        case "Negatif":
                            labelOutput.ForeColor = System.Drawing.Color.Red;
                            break;
                        case "Nol":
                            labelOutput.ForeColor = System.Drawing.Color.Blue;
                            break;
                    }
                }
                else
                {
                    labelOutput.Text = "Hasil: Input bukan angka yang valid!";
                    labelOutput.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception ex)
            {
                labelOutput.Text = "Hasil: Terjadi kesalahan - " + ex.Message;
                labelOutput.ForeColor = System.Drawing.Color.Red;
            }
        }

        // Event handler untuk clear/reset
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            labelOutput.Text = "Hasil: ";
            labelOutput.ForeColor = System.Drawing.Color.Black;
            textBoxInput.Focus();
        }

        // Event handler untuk Enter key di textbox
        private void textBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Hanya izinkan angka, minus, dan backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true;
            }

            // Hanya izinkan satu tanda minus di awal
            if (e.KeyChar == '-' && ((sender as TextBox).Text.IndexOf('-') > -1))
            {
                e.Handled = true;
            }

            // Tekan Enter untuk memproses
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonCek_Click(sender, e);
            }
        }
    }
}