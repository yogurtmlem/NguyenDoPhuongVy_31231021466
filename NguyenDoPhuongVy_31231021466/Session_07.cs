
namespace NguyenDoPhuongVy_31231021466
{
    internal class Session_07
    {
        public static void Mai32n(string[] args)
        {
            int[,] a;
            Console.Write("So dong = "); int rows = int.Parse(Console.ReadLine());
            Console.Write("So cot = "); int cols = int.Parse(Console.ReadLine());
            a = new int[rows, cols];
            NhapmanghaichieuNgauNhien(a);
            XuatMang(a);
            /*Console.WriteLine("Muon in cot nao? "); int selCol = int.Parse(Console.ReadLine());
            XuatColIndex(a, selCol);*/
            transpose(a);
            Console.WriteLine();
            /*PrimaryDiagonal(a);
            Console.WriteLine();
            SecondaryDiagonal(a);*/
        }
        public static void NhapmanghaichieuNgauNhien(int[,] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(100);
                }
            }
        }

        static void XuatMang(int[,] a)
        {
            for (int i = 0;i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a [i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        static void XuatColIndex(int[,] a, int ColIndex)
        {
            if (ColIndex < 0 || ColIndex > a.GetLength(0) - 1)
            {
                Console.WriteLine("No");
                return;
            }
            for (int i =0; i < a.GetLength(0); i++)
            {
                Console.WriteLine($"{a[i, ColIndex]} \t");
            }
        }

        static void transpose(int[,] a)
        {
            for (int i = 0; i <= a.GetLength(0); i++)
            {
                for (int j = 0; j <= a.GetLength(1); j++)
                {
                    a[i, j] = a[j, i];
                }
            }
        }
        static void SecondaryDiagonal(int[,] a)
        {
            for (int i = 0; i <= a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i + j == a.GetLength(0) - 1)
                        Console.Write(a[i, j] + "\t");
                }
            }
        }

        static void PrimaryDiagonal(int[,] a)
        {
            for (int i = 0; i <= a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i == j)
                        Console.Write(a[i, j] + "\t");
                }
            }
        }
       
    }
}
