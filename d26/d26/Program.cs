using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d26
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 嵌套的 for 循环实现图形
             */
            for (int x = 1; x <=7; x++)
            {
                for (int y = 1; y <= 7; y++)
                {
                    /*if (y == x || y+x == 8)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(".");
                    }*/
                    Console.Write(y == x || y + x == 8 ? "O" : ".");
                }
                Console.WriteLine();
            }
        }
    }
}
