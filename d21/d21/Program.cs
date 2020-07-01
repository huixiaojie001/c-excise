using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d21
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 使其程序能输出3个数字
             */
            int x = 2;
            do
            {
                x++;
                Console.WriteLine(x);
            }
            while (x > 2 && x <= 4);
        }
    }
}
