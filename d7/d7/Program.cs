using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            bool a = ++x * x > 3;
            bool b=true;
            Console.WriteLine(a==b);//输出true
            /*
             * 运算符优先级顺序：
             * 1、括号
             * 2、一元运算符有些运算符两边有2个操作数，比如2+3、6%5等等，这些叫做二元运算符。
                  只有一个操作数的叫做一元运算符，它们的优先级高于二元运算符。
                  一元运算符包括：++(自加) 、 --（自减） 、 !（逻辑非）。
             * 3、*（乘）、/（除）、%（取余）
             * 4、+（加）、-（减）
             * 5、>（大于）、<（小于）、>=（大于等于）、<=（小于等于）
             * 6、==（等于）、!=(不等于)
             * 7、&&（逻辑与）
             * 8、||（逻辑或）
             * 9、赋值运算符（=、+=、-=、*=、/=、%=）
             * 优先级相同的运算符从左向右计算（赋值运算符相反）
             */ 
        }
    }
}
