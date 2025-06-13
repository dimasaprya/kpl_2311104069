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
            return a;
        }

        public static int KPK(int a, int b)
        {
            return (a * b) / FPB(a, b);
        }

        public static string Turunan(int[] persamaan)
        {
            string result = "";
            int pangkat = persamaan.Length - 1;

            for (int i = 0; i < persamaan.Length - 1; i++)
            {
                int koef = persamaan[i] * (pangkat - i);
                int pangkatBaru = pangkat - i - 1;

                if (koef == 0) continue;

                if (koef > 0 && result != "") result += " + ";
                else if (koef < 0) result += " - ";

                result += $"{Math.Abs(koef)}";
                if (pangkatBaru > 0)
                    result += $"x{(pangkatBaru > 1 ? pangkatBaru.ToString() : "")}";
            }

            return result;
        }

        public static string Integral(int[] persamaan)
        {
            string result = "";
            int pangkat = persamaan.Length;

            for (int i = 0; i < persamaan.Length; i++)
            {
                double koefBaru = (double)persamaan[i] / (pangkat - i);
                int pangkatBaru = pangkat - i;

                if (koefBaru == 0) continue;

                if (koefBaru > 0 && result != "") result += " + ";
                else if (koefBaru < 0) result += " - ";

                result += $"{Math.Abs(koefBaru)}";
                if (pangkatBaru > 0)
                    result += $"x{(pangkatBaru > 1 ? pangkatBaru.ToString() : "")}";
            }

            result += " + C";
            return result;
        }
    }
}
