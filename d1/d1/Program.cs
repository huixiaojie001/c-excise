using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d1
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 6000.00;//基本工资
            double prize = 3200.00;//奖金
            double tax = 4500.00;//交税
            Console.WriteLine("我的工资奖金总额是{0}元", salary + prize);
            Console.WriteLine("我的税后收入是{0}元", salary + prize - tax);
        }
    }
}
