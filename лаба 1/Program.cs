using System.Diagnostics;

namespace Algorithm
{
    public class Program
    {
        static int maxValue = 5000;
        static int maxN = 50000;
        public static void Main()
        {
            double sum = 0;
            int i = 0;
            double x = 1.5;
            int[] array = { 1, 3, 2 };
            for (; i < array.Length; i++)
            {
                sum += array[i] + Math.Pow(x, i - 1);
            }
            Console.Write(sum);
            //GetResults();
        }

        public static void GetResults()
        {
            Stopwatch watch = Stopwatch.StartNew();
            string[] result = new string[maxN];
            for (int n = 1; n <= maxN; n++)
            {
                double sumTime = 0;
                watch.Reset();
                for (int i = 0; i<5; i++)
                {
                    watch.Start();
                    Task1.DoMultiFunc(CreateVector(n));
                    watch.Stop();
                    sumTime += (double)watch.ElapsedMilliseconds;
                }
                result[n-1] = $"{n};{sumTime/5000}";
            }
            File.WriteAllLines("D:\\алгоритмы\\result.csv", result);
        }

        public static int[] CreateVector(int n)
        {
            int[] vector = new int[n];
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = random.Next(0, maxValue);
            }
            return vector;
        }
    }
}