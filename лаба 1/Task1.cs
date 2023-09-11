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
    }
}