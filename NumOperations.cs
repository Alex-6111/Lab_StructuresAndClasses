
namespace Lab_StructuresAndClasses
{
    public class NumOperations
    {
        public  static void RangeOfNumbers(int num1, int num2, out int res)
        {
            res = 1;
            if (num1 == num2 || num1 > num2)
                throw new ArgumentException("Wrong range!");
            for (int i = num1; i <= num2; ++i)
                res = res * i;
        }
        public static bool FibonacciNum(int n)
        {
            if (Math.Sqrt(5 * (Math.Pow(n, 2)) - 4) % 1 == 0 || Math.Sqrt(5 * (Math.Pow(n, 2)) + 4) % 1 == 0)
                return true;
            else
                return false;
        }

       public static int[] SortByIncrease(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            return arr;
        }
       public static int[] SortByDecrease(int[] arr)
        {
            for (int i = arr.Length - 1; i > 0; --i)
            {
                for (int j = 0; j < i; ++j)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int tmp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = tmp;
                    }
                }
            }
            return arr;
        }
    }
}
