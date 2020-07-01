using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d18
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 循环打印 5 次“加油！”
             */
            int x;//循环计数变量
            x=0;//计数变量初始化
            while(x<5)//循环条件
            {
                Console.WriteLine("加油！");
                x++;//计数变量的自加语句
            }
        }
    }
}
