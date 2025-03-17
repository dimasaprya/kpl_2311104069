using System;

namespace modul5_NIM
{
    class Penjumlahan
    {
        // Tambahkan keyword static di method ini
        public static T JumlahTigaAngka<T>(T angka1, T angka2, T angka3) where T : struct
        {
            dynamic a = angka1;
            dynamic b = angka2;
            dynamic c = angka3;
            return a + b + c;
        }
    }
}
