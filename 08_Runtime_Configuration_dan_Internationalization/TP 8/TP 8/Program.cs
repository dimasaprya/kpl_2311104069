using System;

class Program
{
    static void Main()
    {
        CovidConfig config = new CovidConfig();

        // Panggil method untuk ubah satuan (celcius <-> fahrenheit)
        config.UbahSatuan();

        Console.Write($"Berapa suhu badan anda saat ini? Dalam nilai {config.SatuanSuhu}: ");
        if (!double.TryParse(Console.ReadLine(), out double suhu))
        {
            Console.WriteLine("Input suhu tidak valid.");
            return;
        }

        Console.Write("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam? ");
        if (!int.TryParse(Console.ReadLine(), out int hariDemam))
        {
            Console.WriteLine("Input hari tidak valid.");
            return;
        }

        bool suhuNormal = false;

        if (config.SatuanSuhu == "celcius")
            suhuNormal = suhu >= 36.5 && suhu <= 37.5;
        else if (config.SatuanSuhu == "fahrenheit")
            suhuNormal = suhu >= 97.7 && suhu <= 99.5;

        if (suhuNormal && hariDemam < config.BatasHariDemam)
            Console.WriteLine(config.PesanDiterima);
        else
            Console.WriteLine(config.PesanDitolak);
    }
}
