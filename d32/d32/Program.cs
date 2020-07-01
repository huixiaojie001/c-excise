using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d32
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 检查了一组考试分数，看有没有考试不及格的，请仔细阅读代码，了解程序逻辑，完成功能。
             */
            int[] score = { 28, 45, 64, 72, 32, 63, 88, 100 };//分数
            bool fight = false;//记录是否有不及格的，默认为false
            int x;
            for ( x = 0; x < score.Length; x++)
            {
                if (score[x] < 60)//如果有不及格的
                {
                    fight = true;
                }
            }
                if (fight)
                {
                    Console.WriteLine("有人不及格");
                }
                else
                {
                    Console.WriteLine("都及格了！");
                }           
        }
    }
}
