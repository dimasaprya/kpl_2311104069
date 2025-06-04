// using System;

// class Program {
//     static void Main() {
//         Console.WriteLine("Masukkan nama buah:");
//         string buah = Console.ReadLine();
//         Console.WriteLine($"Kode buah {buah}: {KodeBuah.GetKodeBuah(buah)}");
//     }
// }


class Program {
    static void Main() {
        PosisiKarakterGame karakter = new PosisiKarakterGame();
        karakter.TekanTombol("S");
        karakter.TekanTombol("W");
    }
}
