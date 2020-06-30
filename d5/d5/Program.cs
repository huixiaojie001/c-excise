using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true || false );//要求输出true
            Console.WriteLine(true && false);//要求输出false
            Console.WriteLine(!false);//要求输出true
            /*
             * ！是逻辑非即相反
             * &&是逻辑与即两边为真即为真，一边为假就算假
             * ||是逻辑或即一边有真即为真，两边同假才是假
             */
        }
    }
}
