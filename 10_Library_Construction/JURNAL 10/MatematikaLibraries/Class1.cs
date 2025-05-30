using System;

namespace MatematikaLibraries
{
    public class Matematika
    {
        public static int FPB(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return Math.Abs(a);
        }

        public static int KPK(int a, int b)
        {
            return Math.Abs(a * b) / FPB(a, b);
        }

        public static string Turunan(int[] persamaan)
        {
            string hasil = "";
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * pangkat;
                if (koef == 0) continue;

                if (hasil != "" && koef > 0)
                    hasil += " + ";

                if (koef < 0)
                    hasil += " - " + Math.Abs(koef);
                else
                    hasil += koef;

                if (pangkat - 1 > 0)
                    hasil += "x" + (pangkat - 1);

                pangkat--;
            }

            return hasil;
        }

        public static string Integral(int[] persamaan)
        {
            string hasil = "";
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                double koef = (double)persamaan[i] / (pangkat - i);
                string strKoef = koef == 1 ? "" : koef == -1 ? "-" : koef.ToString();

                if (hasil != "" && koef > 0)
                    hasil += " + ";

                if (koef < 0 && hasil == "")
                    hasil += "-";

                hasil += strKoef + "x" + (pangkat - i);
            }

            hasil += " + C";
            return hasil;
        }
    }
}
