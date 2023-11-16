using System.Diagnostics;
namespace USRS4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int[] arr = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            sw.Start();
            int sum1 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    sum1 += arr[i] * arr[i];
                }
            }
            Console.WriteLine(sw.Elapsed.ToString());
            sw.Restart();
            int sum2 = 0;
            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    sum2 += i * i;
                }
            }
            Console.WriteLine(sw.Elapsed.ToString());
            sw.Restart();
            int sum3 = (from i in arr
                       where i % 2 == 0
                       select i * i).Sum();
            Console.WriteLine(sw.Elapsed.ToString());
            sw.Restart();
            int sum4 = (from i in
                        arr.Where(i => i % 2 == 0)
                        select i * i).Sum();
            Console.WriteLine(sw.Elapsed.ToString());
            sw.Stop();
            Console.WriteLine("{0} {1} {2} {3}", sum1, sum2, sum3, sum4);
        }
    }
}