namespace Algorithm
{
    public class SumFunc
    {
        public static void Start(int[] vector)
        {
            int sum = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sum += vector[i];
            }
        }
    }
}