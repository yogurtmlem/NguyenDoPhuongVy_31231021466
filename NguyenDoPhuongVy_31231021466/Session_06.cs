

namespace NguyenDoPhuongVy_31231021466
{
    internal class Session_06
    {
        private static void Mainu(string[] args)
        {
            Console.WriteLine("Nhap so phan tu mang: ");
            int N = int.Parse(Console.ReadLine());
            int[] a = new int[N];
            enterItemValues(a);
            Print(a);
            increaseItems(a, 2);
            Print(a);
            int s = sum(a);
            Console.WriteLine($"Sum of array: {s} ");
        }

        static void enterItemValues(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap phan tu thu #{i}:");
                a[i] = int.Parse(Console.ReadLine());
            }
        }


        static void Print(int[] a)
        {
            foreach (int item in a) 
                Console.Write($"{item}, ");
            Console.WriteLine();
        }

        static void increaseItems(int[] a, int val)
        {
            for (int i = 0; i < a.Length; i++) 
                a[i] += val;
        }

        static int sum(int[] a)
        {
            int s = 0;
            foreach (int item in a)
                s += item;
            return s;   
        }
    }
}
