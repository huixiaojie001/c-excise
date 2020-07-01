using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d31
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 有一组整数，请循环打印出其中的偶数。
             */
            int[] num = new int[] { 35, 23, 63, 64, 22, 56, 21, 67, 80 };
            Console .WriteLine("偶数有：");
            for (int x = 0; x < num.Length; x++)//循环语句
            {
                if (num[x] % 2 == 0)//判断条件
                {
                    Console.Write(num[x]+",");
                }
            }
        }
    }
}
