
namespace NguyenDoPhuongVy_31231021466
{
    internal class Session_05
    {
        public static void Maina(string[] args)
        {
            //Exercise_01();
            //Exercise_02();
            //Exercise_03();
            Exercise_04();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        static int max2Nums(int a, int b)
        {
            return a > b ? a : b;
        }

        static int max3Nums(int a, int b, int c)
        {
            return max2Nums(a, max2Nums(b, c));
        }

        public static void Exercise_01()
        {
            int a = 5, b = 9, c = 21;
            int max = max3Nums(a, b, c);
            Console.WriteLine(max);
        }

        public static void Exercise_02()
        {
            do
            {
                Console.Write("Enter a non-negative integer:");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    Console.Write("Please enter a non-negative integer.");
                }
                else
                {
                    long factorial = CalcFactorial(number);
                    Console.WriteLine($"Factorial of {number} is {factorial}");
                }


                static long CalcFactorial(int n)
                {
                    long result = 1;
                    for (int i = 2; i <= n; i++)
                    {
                        result *= i;
                    }
                    return result;
                }
            } while (true);
        }

        public static bool Prime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false; 
            }

            return true; 
        }
        public static void Exercise_03()
        {
            do 
            {
                Console.Write("Enter a number:");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    if (Prime(num))
                    {
                        Console.WriteLine($"{num} is a prime number.");
                    }
                    else
                    {
                        Console.WriteLine($"{num} is not a prime number.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid integer.");
                }
            } while(true);
            
        }
        static void primenumber(int MyNum)
        {
            int n = 0;
            for (int i = 2; i < (MyNum / 2 + 1); i++)
            {
                if (MyNum % i == 0)
                {
                    n++;
                    break;
                }
            }

            if (n == 0)
            {
                Console.Write(MyNum + " ");
            }
        }
        public static void Exercise_04()
        {
            Console.Write("x= ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Prime numbers less than " + x + " are: ");
            for (int i = 2; i < x + 1; i++)
            {
                primenumber(i);
            }
        }
        
    }
}
