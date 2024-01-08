using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            int restart;
            all vol = new all();
            do
            {
                vol.sol();
                Console.WriteLine("click 1 to restart");
                restart = int.Parse(Console.ReadLine());
                Console.Clear();
            } while (restart == 1);
        }
    }

    class all
    {
        public void sol()
        {
            Console.WriteLine("select 1 for addition and select 2 for multiplication:");
            int sel = int.Parse(Console.ReadLine());

            if (sel == 1)
            {
                Console.WriteLine("select the number or operands to add 2 0r 3 : ");
                int s = int.Parse(Console.ReadLine());
                if (s == 2)
                {
                    Console.WriteLine("First Operand : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Second Operand : ");
                    int y = int.Parse(Console.ReadLine());
                    add sum = new add();
                    int result = sum.sumes(x, y);
                    Console.WriteLine("the sum is = " + result);
                }

                else
                {
                    Console.WriteLine("First Operand : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Second Operand : ");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Third Operand : ");
                    int z = int.Parse(Console.ReadLine());
                    add sum = new add();
                    int result = sum.sumes(x, y, z);
                    Console.WriteLine("the sum is = " + result);
                }
            }

            else
            {
                Console.WriteLine("select the number or operands to add 2 0r 3 : ");
                int s = int.Parse(Console.ReadLine());

                if (s == 2)
                {
                    Console.WriteLine("First Operand : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Second Operand : ");
                    int y = int.Parse(Console.ReadLine());
                    add sum = new add();
                    int result = sum.sume(x, y);
                    Console.WriteLine("the multiplication is = " + result);
                }

                else
                {
                    Console.WriteLine("First Operand : ");
                    int x = int.Parse(Console.ReadLine());
                    Console.WriteLine("Second Operand : ");
                    int y = int.Parse(Console.ReadLine());
                    Console.WriteLine("Third Operand : ");
                    int z = int.Parse(Console.ReadLine());
                    add sum = new add();
                    int result = sum.sume(x, y, z);
                    Console.WriteLine("the multiplication is = " + result);
                }
            }
        }
    }

    class add : multiply
    {
        public int sumes(int x, int y)
        {
            int i = x + y;
            return i;
        }

        public int sumes(int x, int y, int z)
        {
            int i = x + y + z;
            return i;
        }
    }

    class multiply
    {
        public int sume(int x, int y)
        {
            int i = x * y;
            return i;
        }

        public int sume(int x, int y, int z)
        {
            int i = x * y * z;
            return i;
        }
    }
}