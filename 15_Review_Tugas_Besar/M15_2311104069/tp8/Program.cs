using System;

namespace Modul15_LoginApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var userManager = new UserManager();

            try
            {
                Console.WriteLine("=== REGISTRASI AKUN ===");
                Console.Write("Masukkan username: ");
                string username = Console.ReadLine();

                Console.Write("Masukkan password: ");
                string password = Console.ReadLine();

                userManager.Register(username, password);
                Console.WriteLine("✅ Registrasi berhasil!");

                Console.WriteLine("\n=== LOGIN AKUN ===");
                Console.Write("Masukkan username: ");
                string loginUsername = Console.ReadLine();

                Console.Write("Masukkan password: ");
                string loginPassword = Console.ReadLine();

                bool loginSuccess = userManager.Login(loginUsername, loginPassword);
                Console.WriteLine(loginSuccess ? "✅ Login sukses!" : "❌ Login gagal!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"⚠️ Error: {ex.Message}");
            }
        }
    }
}
    