using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            x = y = 2;//从左往右赋值，x、y的值都是2
            x /= 0.5;
            y %= 2;
            Console.WriteLine(x-y);//输出值要为4
            /*
             * 加赋值 “+=”先加再赋值
             * 减赋值 “-=”先减再赋值
             * 乘赋值 “*=”先乘再赋值
             * 除赋值 “/=”先除再赋值
             * 取余赋值 “%=”先取余再赋值
             */
        }
    }
}
