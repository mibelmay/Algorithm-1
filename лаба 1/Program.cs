using System.Diagnostics;

namespace Algorithm
{
    public class Program
    {
        static int maxValue = 5000;
        static int maxN = 2000;
        public static void Main()
        {
            //GetResults();
            Matrix a = Matrix.CreateRandomMatrix(2);
            a.WriteMatrix();
            Console.WriteLine();
            Matrix b = Matrix.CreateRandomMatrix(2);
            b.WriteMatrix();
            Console.WriteLine();
            Matrix res = Matrix.Multiplicate(a, b, 2);

            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(res.Base[i,j] + " ");
                }
                Console.WriteLine();
            }
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

        public static void MultiplicateMatrix()
        {

        }

        public static int[] CreateVector(int n)
        {
            int[] vector = new int[n];
            var random = new Random();
            for (int i = 0; i < n; i++)
            {
                vector[i] = random.Next(0, 1000);
            }
            return vector;
        }
    }
}