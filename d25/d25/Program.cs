using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d25
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 使用代码将数字打印成三角形
             */
            for (int x = 1; x < 8; x++)
            {
                for (int y = 1; y <= x; y++)
                {
                    Console.Write(y);
                }
                Console.WriteLine();//换行
            }
        }
    }
}
