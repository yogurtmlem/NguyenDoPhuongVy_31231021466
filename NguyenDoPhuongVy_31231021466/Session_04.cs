
namespace NguyenDoPhuongVy_31231021466
{
    internal class Session_04
    {
        public static void Main6(string[] args)
        {
            //Exercise_02();
            //Exercise_03();
            Exercise_04();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }

        public static void Exercise_02()
        {
            Console.Write("y= ");
            int y =int.Parse(Console.ReadLine());
            if (y >= -5 && y <= 5)
            {
                Console.WriteLine("x = {0}", Math.Pow(y, 2) + 2 * y + 1);
            }
            else
            {
                Console.WriteLine("Please enter a valid input");
            }
        }

        public static void Exercise_03()
        {
            Console.Write("distantkm= ");
            float distantkm =float.Parse(Console.ReadLine());
            Console.Write("hours=  ");
            float hours =float.Parse(Console.ReadLine());
            Console.Write("minutes= ");
            float minutes =float.Parse(Console.ReadLine());
            Console.Write("seconds= ");
            float seconds =float.Parse(Console.ReadLine());
            Console.WriteLine("time = {0}", (hours + (minutes / 60) + (seconds / 3600)));
            Console.WriteLine("Speed in km/h= " + (distantkm / (hours + (minutes / 60) + (seconds / 3600))));
            Console.WriteLine("Speed in miles/h= " + (distantkm * 0.621371192 / (hours + (minutes / 60) + (seconds / 3600))));

        }

        /// <summary>
        /// May tinh nghi ra mot so tu 1 => 100 <br/>
        /// Nguoi dung se doan so nay <br/>
        /// Neu doan thap/cao hon so may nghi thi se bao <br/>
        /// Bao ket qua doan trung sau bao nhieu lan <br/>
        /// </summary>
        public static void Exercise_04()
        {
            //1. May tinh ghi ra mot so ngau nhien tu 1 den 100
            Random random = new Random();
            int comp_num = random.Next(0, 100) + 1;
            int count = 0;
            do
            {
                count++;
                //2. Nhac nguoi dung doan so
                Console.Write("Ban doan so may [1,100]: ");
                int user_num = int.Parse(Console.ReadLine());
                if (user_num == comp_num)
                {
                    Console.WriteLine("ban la thien tai");
                    break;
                }
                else if (user_num > comp_num)
                {
                    Console.WriteLine("So ban nghi lon hon so may nghi");
                }
                else 
                {
                    Console.WriteLine("So ban nghi nho hon so may nghi");
                }
            } while (true);
            Console.WriteLine($"Ban da doan trung sau {count} lan");
        }
    }
}
