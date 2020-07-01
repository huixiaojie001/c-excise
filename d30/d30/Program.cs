using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d30
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 声明数组保存了一些分数，然后循环打印不及格的分数（也就是在数组中查找不及格分数）
             */
            int[] score = new int[] { 89, 29, 100, 41, 55, 67, 60 };//分数
            Console.Write("不及格的有：");
            for (int x = 0; x <score .Length; x++)
            {
                if (score [x]<60)
                {
                    Console.Write(score[x]+",");
                }
            }
        }
    }
}
