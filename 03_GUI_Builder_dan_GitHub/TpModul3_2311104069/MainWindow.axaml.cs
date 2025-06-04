using Avalonia.Controls;
using Avalonia.Interactivity;

namespace TpModul3_2311104069
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnSubmit.Click += BtnSubmit_Click;
        }

        private void BtnSubmit_Click(object? sender, RoutedEventArgs e)
        {
            string inputNama = txtInput.Text;
            lblOutput.Text = "Halo " + inputNama;
        }
    }
}
