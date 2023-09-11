using System.ComponentModel.Design;

namespace Algorithm
{
    public class Task1
    {
        public static void DoConstantFunc(int[] vector)
        {
            int length = vector.Length;
        }

        public static void DoSumFunc(int[] vector)
        {
            int sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i];
            }
        }

        public static void DoMultiFunc(int[] vector)
        {
            long result = 1;
            for (int i = 0; i < vector.Length; i++)
            {
                result *= vector[i];
            }
        }

        public static double DoGornerMethod(int[] vector, int i = 0)
        {
            double x = 1.5;
            if (i >= vector.Length)
                return 0;
            return vector[i] + x * DoGornerMethod(vector, i + 1);
        }
    }
}