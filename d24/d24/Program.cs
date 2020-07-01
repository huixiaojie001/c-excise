using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d24
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 打印 1-5 之间的奇数
             */
            for (int x = 1; x <= 5; x++)
            {
                if (x % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(x);
            }
            Console.WriteLine("");
            /*
             * 输出1-5的整数
             */
            int y = 1;
            while (true)//循环条件永远为true
            {
                Console.WriteLine(y);
                y++;
                if (y > 5)//判断条件
                {
                    break;//结束循环
                }
            }
        }
    }
}
