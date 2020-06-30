using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*这个程序用 2 个 double 类型变量，分别记录了苹果六手机的售价和本月的是发工资，
              缺少一个 if...else 结构的判断，请补充这个条件判断，
              如果本月工资够买手机的，输出“这月工资够买手机！”否则输出“这月工资不够买手机！”
             */
            double price = 4388;//手机的售价
            double salary = 4978.67;//本月实发工资
            if (salary > price)
            {
                Console.WriteLine("这个月工资够买手机！");
            }
            else
            {
                Console.WriteLine("这个月工资不够买手机！");
            }
        }
    }
}
