using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d10
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 17;//年龄
            if (age > 18)//判断条件，bool类型
            {//分支1
                Console.WriteLine("你是成年人");
            }
            else
            {//分支2
                Console.WriteLine("你是小孩子");
            }
        }
    }
}
