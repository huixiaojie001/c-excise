using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d29
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 《三国演义》中，蜀国“五虎上将”是：关羽、张飞、赵云、马超、黄忠。
               请用数组保存五虎上将的名字，然后循环打印。
             */
            string[] jiang = new string[] { "关羽", "张飞", "赵云", "马超", "黄忠" };
                for(int x=0;x<jiang .Length;x++)
                {
                    Console.WriteLine(jiang[x]);
                }
        }
    }
}
