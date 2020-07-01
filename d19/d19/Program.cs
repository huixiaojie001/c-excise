using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d19
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *求 1-30 的奇数的和 
             */
            int x = 1;
            int sum = 0;//和，初始化为0
            while(x<=30)//循环条件
            {
                if (x % 2 != 0)//筛选条件
                {
                    sum += x;
                }
                x++;
            }
            Console.WriteLine("1-30奇数的和:"+sum);
        }
    }
}
