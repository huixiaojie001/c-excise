using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d14
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 某银行营业部开展“储蓄赠礼”活动，存款达到或超过 100000 元的"送一台微波炉"；
             * 存款不到 100000 元但是达到 50000 元的"送一套茶具"；
             * 存款不到 50000 元但是达到 10000 元的"送一袋大米"；
             * 如果不到 10000 元则"没有礼品"。
             * 使用多重 if 结构实现上述功能。
             */
            double money = 70000.00;//存款金额
            if(money >= 100000)
            {
                Console.WriteLine("送一台微波炉");
            }
            else if(money < 100000 && money >= 50000)
            {
                Console.WriteLine("送一套茶具");
            }
            else if(money < 50000 && money >= 10000)
            {
                Console.WriteLine("送一袋大米");
            }
            else if(money < 10000)
            {
                Console.WriteLine("没有礼品");
            }
        }
    }
}
