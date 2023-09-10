using System;
namespace ConsoleApp5
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

        public static bool operator ==(Arr a, Arr b)
        {
            if ((a.x == b.x) && (a.y == b.y) && (a.z == b.z))
                return true;
            return false;
        }
        public static bool operator !=(Arr a, Arr b)
        {
            if ((a.x != b.x)&(a.z != b.z))
                return true;
            return false;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Arr a = new Arr(4, 5, 12);
            Arr b = new Arr(4, 5, 12);
            if (a == b)
            {
                Console.WriteLine("Объекты равны");
            }
            Arr c = new Arr(4, 6, 12);
            Arr d = new Arr(4, 5, 12);
            if (c == d)
            {
                Console.WriteLine("Объекты равны");
            }
            else
            {
                Console.WriteLine("Объекты не равны");
            }
        }
    }
}
