using System.Diagnostics;

namespace Algorithm
{
    public class Program
    {
        static int maxValue = 50000;
        static int maxN = 50000;
        public static void Main()
        {
            GetResults();
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
                    MultiFunc.Start(CreateVector(n));
                    watch.Stop();
                    sumTime += (double)watch.ElapsedMilliseconds;
                }
                result[n-1] = $"{n};{sumTime/5}";
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