using System;

class Program
{
    static void Main()
    {
        // Memuat konfigurasi dari file JSON
        CovidConfig config = CovidConfig.LoadConfig();

        Console.Write($"Berapa suhu badan Anda saat ini? Dalam satuan {config.SatuanSuhu}: ");
        double suhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) Anda terakhir memiliki gejala demam? ");
        int hariDemam = int.Parse(Console.ReadLine());

        // Mengecek apakah suhu badan berada dalam rentang normal
        bool suhuNormal = config.SatuanSuhu == "celcius"
            ? suhu >= 36.5 && suhu <= 37.5
            : suhu >= 97.7 && suhu <= 99.5;

        // Mengecek apakah sudah cukup lama tidak mengalami demam
        bool demamAman = hariDemam < config.BatasHariDemam;

        // Menentukan apakah diizinkan masuk gedung atau tidak
        if (suhuNormal && demamAman)
        {
            Console.WriteLine(config.PesanDiterima);
        }
        else
        {
            Console.WriteLine(config.PesanDitolak);
        }

        // Contoh pemanggilan method ubah satuan suhu
        config.UbahSatuan();
    }
}
