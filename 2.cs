using System;
namespace ConsoleApp6
{
    class Arr
    {
        public int x, y, z;

        public Arr(int x = 0, int y = 0, int z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


        public static bool operator true(Arr obj1)
        {
            if ((obj1.x % 2 == 0)  (obj1.z % 2 == 0))
                return true;
            return false;

        }

        public static bool operator false(Arr obj1)
        {
            if ((obj1.x % 2 == 1)  (obj1.z % 2 == 1))
                return true;
            return false;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Arr a = new Arr(1, 3, 2);
            Arr b = new Arr(2, 3, 1);
            if (a)
            {
                Console.WriteLine("четные числа");
            }
            else
            {
                Console.WriteLine("нечетные числа");
            }
            if (b)
            {
                ("четные числа");
            }
            else
            {
                Console.WriteLine("нечетные числа");
            }

        }
    }
}
