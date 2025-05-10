namespace Assignment_4
{
    internal class Program
    {

        #region Q1
        static void PassByValue(int x)
        {
            x = x + 10;
        }

        static void PassByReference(ref int x)
        {
            x = x + 10;
        }

        static void Main()
        {
            int num = 5;
            PassByValue(num);
            Console.WriteLine("After PassByValue: " + num);

            PassByReference(ref num);
            Console.WriteLine("After PassByReference: " + num);
        }
        #endregion

        #region Q2
        class Sample
        {
            public int Value = 10;
        }

        class Program
        {
            static void PassByValue(Sample obj)
            {
                obj.Value = 20;
                obj = new Sample();
                obj.Value = 99;
            }

            static void PassByReference(ref Sample obj)
            {
                obj = new Sample();
                obj.Value = 77;
            }

            static void Main()
            {
                Sample s = new Sample();
                PassByValue(s);
                Console.WriteLine("After PassByValue: " + s.Value);

                PassByReference(ref s);
                Console.WriteLine("After PassByReference: " + s.Value);
            }
        }
        #endregion

        #region Q3 
        class Program
        {
            static void SumSubtract(int a, int b, out int sum, out int subtract)
            {
                sum = a + b;
                subtract = a - b;
            }

            static void Main()
            {
                Console.Write("Enter first number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int y = int.Parse(Console.ReadLine());

                SumSubtract(x, y, out int sum, out int subtract);
                Console.WriteLine($"Sum: {sum}, Subtraction: {subtract}");
            }
        }
        #endregion

        #region Q4
        class Program
        {
            static int SumOfDigits(int number)
            {
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                return sum;
            }

            static void Main()
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                int result = SumOfDigits(num);
                Console.WriteLine($"The sum of the digits of the number {num} is: {result}");
            }

        }
        #endregion

        #region Q5 
        class Program
        {
            static bool IsPrime(int number)
            {
                if (number <= 1) return false;
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            }

            static void Main()
            {
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(IsPrime(num) ? "It is prime." : "It is not prime.");
            }
        }
        #endregion

        #region Q6 
        {
            static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];
            foreach (int num in arr)
            {
                if (num < min) min = num;
                if (num > max) max = num;
            }
        }

        static void Main()
        {
            int[] numbers = { 5, 1, 9, 3, 7 };
            int min = 0, max = 0;
            MinMaxArray(numbers, ref min, ref max);
            Console.WriteLine($"Min: {min}, Max: {max}");
        }
    }
    #endregion

        #region Q7 
    class Program
    {
        static long Factorial(int number)
        {
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        static void Main()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Factorial of {num} is {Factorial(num)}");
        }
    }
    #endregion
}
