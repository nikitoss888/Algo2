using static System.Console;
using static System.Math;
using static System.Text.Encoding;

namespace T1
{
    class Program
    {
        static void Main()
        {
            InputEncoding = Unicode;
            OutputEncoding = Unicode;
            ulong a = 48271, c = 0, m = (ulong)Pow(2, 32) - 1, limit = 5000;
            ulong x = 1, y = 0, j = 0;
            int[] array = new int[5000];
            for(ulong i = 0; i < limit; i++)
            {
                x = (a * x + c) % m;
                array[j] = (int)(x * 300 / (m - 1));
                j++;
                Write($"{x * 300 / (m - 1)} ");
            }
            WriteLine();
            double spod = 0, disp = spod;
            for(int i = 0; i < 300; i++)
            {
                y = 0;
                for(j = 0; j < 5000; j++)
                {
                    if (array[j] == i)
                    {
                        y++;
                    }
                }
                spod += i * (y / 5000.0);
                disp += Pow((i - spod), 2) * (y / 5000.0);
                WriteLine($"Кількість {i}-ок: {y}\tЧастота: {y / 5000.0}");
            }
            WriteLine($"Математичне сподівання: {spod}\n" +
                $"Дисперсія: {disp}, середньоквадратичне відхилення: {Sqrt(disp)}");
            ReadKey();
        }
    }
}
