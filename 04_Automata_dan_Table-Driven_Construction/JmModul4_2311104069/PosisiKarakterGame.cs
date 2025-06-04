using System;

class PosisiKarakterGame {
    enum State { Berdiri, Tengkurap, Jongkok, Terbang }
    private State posisi;

    public PosisiKarakterGame() {
        posisi = State.Berdiri;
        Console.WriteLine("Posisi awal: Berdiri");
    }

    public void TekanTombol(string tombol) {
        switch (tombol) {
            case "S":
                Console.WriteLine("Tombol arah bawah ditekan");
                break;
            case "W":
                Console.WriteLine("Tombol arah atas ditekan");
                break;
            default:
                Console.WriteLine("Tombol tidak dikenali");
                break;
        }
    }
}
