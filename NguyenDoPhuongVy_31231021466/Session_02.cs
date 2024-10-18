

namespace NguyenDoPhuongVy_31231021466
{
    internal class Session_02
    {
        public static void Main7()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            Question_10();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        /// <summary>
        /// to Add/Sum Two Numbers.
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter a number a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b = ");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;

            Console.WriteLine($"{a} + {b} = {sum}");
            Console.WriteLine($"{a} * {b} = {product}");
        }

        /// <summary>
        /// to Swap Values of Two Variables.
        /// </summary>
        public static void Question_02()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"a =  {b}");
            Console.WriteLine($"b =  {a}");

        }
        /// <summary>
        /// to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            float product = a * b;
            Console.WriteLine($"{a} * {b} = {product}");
        }
        /// <summary>
        /// . to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine());
            double b = a * 0.3048;
            Console.WriteLine($"Your height in meter = {b}");
        }
        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Celsius =");
            double Celsius = double.Parse(Console.ReadLine());
            double Farenheit = Celsius * 33.8;
            Console.WriteLine($"Farenheit = {Farenheit}");
            Console.WriteLine("Press again to convert from Farenheit to Celsius");
            Console.ReadKey();
            Console.Write("Faren =");
            double Faren = double.Parse(Console.ReadLine());
            double Cel = (Faren - 32) * 5 / 9;
            Console.WriteLine($"Cel = {Cel}");

        }
        /// <summary>
        /// to find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            int x = sizeof(double);
            Console.Write("x= {0}", x);
        }
        /// <summary>
        /// to Print ASCII Value
        /// </summary>
        public static void Question_07()
        {
            Console.Write("enter a char = ");
            Console.WriteLine((int)Console.ReadLine()[0]);
        }
        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Enter a radius for a circle  r = ");
            float r = float.Parse(Console.ReadLine());
            float area = float.Pi * r * r;
            Console.WriteLine($"area = {area}");
        }
        /// <summary>
        /// to Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Enter a side for a square a = ");
            float a = float.Parse(Console.ReadLine());
            float area = a * a;
            Console.WriteLine($"area = {area}");
        }
        /// <summary>
        /// to convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Enter days= ");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int day_w = days - years * 365;
            int week = day_w / 7;
            int day = week % 7;
            Console.WriteLine($"year = {years}, week = {week}, day = {day}");
        }



    }
}
