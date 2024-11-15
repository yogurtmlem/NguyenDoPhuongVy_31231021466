
namespace NguyenDoPhuongVy_31231021466
{
    internal class NguyenDoPhuongVy_31231021466
    {
        public static void Main()
        {
            Console.Write("Nhap so dong = "); int rows = int.Parse(Console.ReadLine());
            int[][] a = new int[rows][];

            NhapMaTranNgauNhien(a);
            XuatMang(a);
            SortElements(a);
            Console.WriteLine("Ma tran sau khi sap xep theo thu tu tang dan: ");
            XuatMang(a);
            MaxMinEachRow(a);
            int maxValue = FindMax(a);
            Console.WriteLine($"Phan tu lon nhat trong ma tran la = {maxValue}");
            int minValue = FindMin(a);
            Console.WriteLine($"Phan tu nho nhat trong ma tran la = {minValue}");
            InSoNguyenTo(a);
            Console.Write("Nhap so x can tim: ");
            int x = int.Parse(Console.ReadLine());
            InViTriXuatHien(a, x);
        }

        public static void XuatMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
        /// <summary>
        /// 1.	In ra ma trận đã nhập
        /// </summary>
        /// <param name="a"></param>
        public static void NhapMaTranNgauNhien(int[][] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cua dong {i}: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols];
                for (int j = 0; j < cols; j++)
                {
                    a[i][j] = random.Next(100);
                }
            }
        }
        /// <summary>
        /// 2.	In ra phần tử lớn nhất, nhỏ nhất trên mỗi dòng và trên toàn bộ ma trận
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>

        public static void MaxMinEachRow(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int max = a[i][0]; 
                int min = a[i][0]; 

                for (int j = 1; j < a[i].Length; j++)
                {
                    if (a[i][j] > max)
                    {
                        max = a[i][j];
                    }
                    if (a[i][j] < min)
                    {
                        min = a[i][j];
                    }
                }

                Console.WriteLine($"Dong {i}: Phan tu lon nhat = {max}, Phan tu nho nhat = {min}");
            }
        }
        public static int FindMax(int[][] a)
        {
            int maxElement = int.MinValue;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] > maxElement)
                    {
                        maxElement = a[i][j];
                    }
                }
            }
            return maxElement;
        }

        public static int FindMin(int[][] a)
        {
            int minElement = int.MaxValue;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] < minElement)
                    {
                        minElement = a[i][j];
                    }
                }
            }
            return minElement;
        }

        /// <summary>
        /// 3.	Sắp xếp các dòng theo thứ tự tang dần
        /// </summary>
        /// <param name="a"></param>
        public static void SortElements(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                int n = a[i].Length;
                for (int j = 0; j < n - 1; j++)
                {
                    for (int k = 0; k < n - 1 - j; k++)
                    {
                        if (a[i][k] > a[i][k + 1])
                        {
                            int temp = a[i][k];
                            a[i][k] = a[i][k + 1];
                            a[i][k + 1] = temp;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 4.	In ra các phần tử của dòng là số nguyên tố
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        public static void InSoNguyenTo(int[][] a)
        {
            Console.WriteLine("Cac so nguyen to trong ma tran la: ");
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (IsPrime(a[i][j]))
                    {
                        Console.Write($"{a[i][j]}\t");
                    }
                }
            }
            Console.WriteLine(); 
        }
        /// <summary>
        /// 5.	In ra tất cả các vị trí xuất hiện của một số X nhập từ người dùng.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        public static void InViTriXuatHien(int[][] a, int x)
        {
            bool found = false; 
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j] == x)
                    {
                        Console.WriteLine($"So {x} xuat hien tai vi tri: Dong {i}, Cot {j}");
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine($"So {x} khong co trong ma tran.");
            }
        }

    }
}
