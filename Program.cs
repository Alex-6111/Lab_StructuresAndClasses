
namespace Lab_StructuresAndClasses
{
    internal class Program
    {
        static void Main()
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
        }
         static void Problem1()
        {
            int res = 0;
            Console.Write("Enter start: "); 
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter end: "); 
            int num2 = Convert.ToInt32(Console.ReadLine());
            NumOperations.RangeOfNumbers(num1, num2, out res);
            Console.WriteLine($"Result -> {res}");
        }
         static void Problem2()
        {
            int n = 0;
            Console.Write("Enter number -> ");
            n = Convert.ToInt32(Console.ReadLine());
            if (NumOperations.FibonacciNum(n) == false)
                Console.WriteLine("Not Fibonacci number!");
            else
                Console.WriteLine("Fibonacci number!");
        }
         static void Problem3()
        {
            Random random = new Random();
            int size = 0, tmp = 0;
            Console.Write($"Enter array size -> ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
                arr[i] = random.Next(0, 20);
            Console.Write("Your array ->  ");
            foreach (var elem in arr)
                Console.Write($"{elem}\t");
            Console.WriteLine();
            Console.WriteLine("Which sorting? \n 0 - By increase \n 1 - By decrease");
            Console.Write("Enter -> ");
            tmp = Convert.ToInt32(Console.ReadLine());
            switch (tmp)
            {
                case 0:
                    NumOperations.SortByIncrease(arr);
                    break;
                case 1:
                    NumOperations.SortByDecrease(arr);
                    break;
            }
            var sortedArr = string.Join("\t", arr);
            Console.WriteLine($"Sorted array -> {sortedArr}");
        }

        static void Problem4()
        {
            var testCity = new City();
            testCity.EnterInfo();
            testCity.ToString();
        }

        static void Problem5()
        {
            var testEmployee = new Employee();
            testEmployee.EnterInfo();
            testEmployee.ToString();
        }

        static void Problem6()
        {
            var testAirplane = new Airplane();
            testAirplane.EnterInfo();
            testAirplane.ToString();
        }
    }
}