using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d33
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  使用foreach() 结构，使得程序能够打印数组的所有元素。
             */
            string[] t = new string[] { "CD", "ds", "fS", "fr", "WW" };
            foreach (string x in t)
            {
                Console.Write(x + " ");
            }
        }
    }
}
