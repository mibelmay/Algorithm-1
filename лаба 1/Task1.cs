using System.ComponentModel.Design;
using System.Formats.Asn1;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

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

        public static double DoNaiveMethod(int[] vector)
        {
            double sum = 0;
            double x = 1.5;
            for (int i = 0; i<vector.Length; i++)
            {
                sum += vector[i] + Math.Pow(x, i - 1);
            }
            return sum;
        }

        public static void DoBubbleSort(int[] vector)
        {
            int temp;
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - 1 - i; j++)
                {
                    if (vector[j] > vector[j+1])
                    {
                        temp = vector[j];
                        vector[j] = vector[j+1];
                        vector[j+1] = temp;
                    }
                
                }
            }
        }

        public static int FindPivot(int[] vector, int minIndex, int maxIndex)
        {
            int pivot = minIndex -1;
            int temp = 0;
            for(int i = minIndex; i < maxIndex; i++) 
            {
                if (vector[i] < vector[maxIndex])
                {
                    pivot++;
                    temp = vector[i];
                    vector[i] = vector[pivot];
                    vector[pivot] = temp;
                }
            }
            pivot++;
            temp = vector[maxIndex];
            vector[maxIndex] = vector[pivot];
            vector[pivot] = temp;

            return pivot;
        }
        public static void DoQuickSort(int[] vector, int minIndex, int maxIndex)
        {
            if(minIndex >= maxIndex)
            {
                return;
            }
            int pivot = FindPivot(vector, minIndex, maxIndex);
            DoQuickSort(vector, minIndex, pivot -1);
            DoQuickSort(vector, pivot + 1, maxIndex);
        }

        public static int DoQuickPow(int x, int n)
        {
            int c = x;
            int k = n;
            int f;
            if (k % 2 == 1)
                f = c;
            else
                f = 1;
            do
            {
                k = k / 2;
                c = c * c;
                if (k % 2 == 1)
                    f = f * c;
            } 
            while(k != 0);
            return f;

        }
        public static int DoClassicQuickPow(int x, int n)
        {
            int f = 1;
            int c = x;
            int k = n;

            while (k != 0)
            {
                if(k % 2 == 0)
                {
                    c = c * c;
                    k = k / 2;
                }
                else
                {
                    f = f * c;
                    k = k - 1;
                }
            }
            return f;
        }

        public static void CocktailSort(int[] vector)
        {
            int b = 0;
            int left = 0;
            int right = vector.Length - 1;
            while (left < right)
            {
                for(int i = left; i < right; i++)
                {
                    if (vector[i] > vector[i+1])
                    {
                        b = vector[i];
                        vector[i] = vector[i+1];
                        vector[i+1] = b;
                        b = i;
                    }
                }
                right = b;
                if (left >= right) break;
                for (int i = right; i > left; i--)
                {
                    if (vector[i-1] > vector[i])
                    {
                        b = vector[i];
                        vector[i] = vector[i-1];
                        vector[i-1] = b;
                        b = i;
                    }
                }
                left = b;
            }
        }
    }
}