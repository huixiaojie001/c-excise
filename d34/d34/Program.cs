using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d34
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 程序中有一个 int 型数组，包含了若干整数。请检查其中是否有“7的整倍数”
             */
            int[] num = { 3, 34, 43, 2, 11, 19, 30, 55, 20 };//声明整数数组，保存一组数据
            bool figth = false;
            foreach (int x in num)
            {
                if (x % 7 == 0)
                {
                    figth = true;
                }
            }
            if (figth)
            {
                Console.WriteLine("这组数据中有7的整倍数");
            }
            else 
            {
                Console.WriteLine("这组数据中没有7的被整数");
            }
        }
    }
}
