
namespace NguyenDoPhuongVy_31231021466
{
    internal class Session_03
    {
        public static void Main(string[] args)
        {
            //Exercise_01();
            //Exercise_02();
            Exercise_03();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        public static void Exercise_01()
        {
            Console.Write("Enter a number= ");
            int celsius = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("kelvin ={0}", celsius + 273);
            Console.WriteLine("fahrenheit ={0}", celsius * 18 / 10 + 32);

        }
        public static void Exercise_02()
        {
            Console.Write("Enter a radius= ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("surface = {0}", double.Pi * 4 * radius*radius);
            Console.WriteLine("volume = {0}", double.Pi * 4/3 *radius*radius*radius);
        }

        public static void Exercise_03() 
        {
            Console.Write(" a = ");
            float a = Convert.ToSingle(Console.ReadLine());
            Console.Write("b = ");
            float b = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("addition = {0}", a + b);
            Console.WriteLine("subtraction = {0}", a - b);
            Console.WriteLine("multiplication = {0}", a * b);
            Console.WriteLine("division = {0}", a / b);
            Console.WriteLine("modules = {0}", a % b);
        }
    }
}
