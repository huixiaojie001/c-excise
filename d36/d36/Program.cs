using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d36
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 一次考试，各位同学的姓名和分数如图，请编写程序，输出分数最高的同学的姓名和分数
             */
            string[] names = { "吴松", "钱东宇", "伏晨", "陈陆", "周蕊", "林日鹏", "何昆", "关欣" };
            int[] scoer = { 89, 90, 98, 56, 60, 91, 93, 85 };
            string name = names[0];
            int sum = 0;
            for (int x = 0; x < 8; x++)
            {
                if (sum < scoer[x])
                {
                    sum = scoer[x];
                    name = names[x];
                }
                // Console.Write(sum);
            }
            Console.WriteLine("分数最高的是" + name + ",分数是" + sum);
        }
    }
}
