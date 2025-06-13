using System;

class Program
{
    static void Main()
    {
        CovidConfig config = CovidConfig.LoadConfig();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.satuan_suhu}: ");
        double suhu = double.Parse(Console.ReadLine());

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        int hari = int.Parse(Console.ReadLine());

        bool suhuNormal = config.satuan_suhu == "celcius"
            ? suhu >= 36.5 && suhu <= 37.5
            : suhu >= 97.7 && suhu <= 99.5;

        bool demamAman = hari < config.batas_hari_deman;

        Console.WriteLine((suhuNormal && demamAman) ? config.pesan_diterima : config.pesan_ditolak);

        // Contoh pemanggilan method UbahSatuan
        config.UbahSatuan();
    }
}
