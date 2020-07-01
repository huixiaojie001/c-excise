using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d35
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 填写 ch 数组的 3 个元素索引，使得程序能够打印出“工程师”。
             */
            string[,] ch = { { "我", "是", "一" }, { "名", "工", "程" }, { "师", "啦", "！" } };
            Console.Write("{0}{1}{2}",ch[1,1],ch[1,2],ch[2,0]);
        }
    }
}
