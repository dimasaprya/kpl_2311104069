using System;

public class Penjumlahan
{
    public T JumlahTigaAngka<T>(T a, T b, T c) where T : struct
    {
        dynamic x = a;
        dynamic y = b;
        dynamic z = c;
        return x + y + z;
    }
}
