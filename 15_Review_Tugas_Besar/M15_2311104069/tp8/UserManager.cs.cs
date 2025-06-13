using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;

namespace Modul15_LoginApp
{
    public class UserManager
    {
        private const string FilePath = "users.json";
        private List<User> users = new();

        public UserManager()
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            if (File.Exists(FilePath))
            {
                string json = File.ReadAllText(FilePath);
                users = JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
            }
        }

        private void SaveUsers()
        {
            string json = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(FilePath, json);
        }

        private string HashPassword(string password)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(password);
            byte[] hash = sha256.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public void Register(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || username.Length < 5 || username.Length > 20)
                throw new Exception("Username harus antara 5 - 20 karakter dan tidak boleh kosong.");

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]+$"))
                throw new Exception("Username hanya boleh huruf dan angka.");

            if (password.Length < 8 || password.Length > 20)
                throw new Exception("Password harus 8 - 20 karakter.");

            if (!Regex.IsMatch(password, @"[!@#$%^&*]"))
                throw new Exception("Password harus mengandung minimal satu karakter spesial (!@#$%^&*).");

            if (password.ToLower().Contains(username.ToLower()))
                throw new Exception("Password tidak boleh mengandung bagian dari username.");

            users.Add(new User
            {
                Username = username,
                PasswordHash = HashPassword(password)
            });

            SaveUsers();
        }

        public bool Login(string username, string password)
        {
            string hash = HashPassword(password);
            return users.Any(u => u.Username == username && u.PasswordHash == hash);
        }
    }
}
