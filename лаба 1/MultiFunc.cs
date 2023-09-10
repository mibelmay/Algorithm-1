namespace Algorithm
{
    public class MultiFunc
    {
        public static void Start(int[] vector)
        {
            long result = 1;
            for (int i = 0; i < vector.Length; i++)
            {
               result *= vector[i];
            }
        }
    }
}