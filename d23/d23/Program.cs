using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d23
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 循环输出 1-9 的整数，请使用 continue 关键字，使得 3 和 8 不会被打印
             */
            for (int x = 1; x < 10; x++)//循环语句
            {
                if (x == 3 || x == 8)//判断语句
                {
                    continue;
                }
                Console.WriteLine(x);
            }
        }
    }
}
