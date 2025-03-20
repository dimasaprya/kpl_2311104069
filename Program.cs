class Program
{
    static void Main()
    {
        Penjumlahan penjumlahan = new Penjumlahan();
        long hasil = penjumlahan.JumlahTigaAngka(23, 11, 10); // Gunakan long karena NIM berakhiran 9
        Console.WriteLine($"Hasil penjumlahan: {hasil}");
    }
}
