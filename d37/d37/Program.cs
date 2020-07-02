using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d37
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "景珍", "林惠洋", "成蓉", "洪南昌", "龙玉民", "单江开", "田武山", "王三明" };//定义名称数组
            int[] scoer = { 90, 65, 88, 70, 46, 81, 100, 68 };//定义分数数组
            int x = 0;//总分
            double y=0;//平均分
            for (int i = 0; i < scoer.Length; i++)
            {
                x += scoer[i];//计数总分
            }
            y = x / scoer.Length;//计数平均分
            Console.Write("平均分是" + y + "，高于平均分的有：");//输出
            for (int i = 0; i < scoer.Length; i++)
            {
                if (y < scoer[i])
                {
                    Console.Write(names[i]+" ");//输出高于平均分的人名
                }
                else
                {
                    continue;//终止一次循环
                }
            }
            Console.ReadKey();
        }
    }
}
