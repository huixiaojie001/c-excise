using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d15
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 假设能够被4整除的年份是闰年，其他年份是平年。
               请编写能判断平年或闰年的代码。
             */
            int year = 2012;//年份
            string text;
            text = year%4!=0?"平年":"闰年";
            Console.WriteLine("今年是{0}", text);
        }
    }
}
