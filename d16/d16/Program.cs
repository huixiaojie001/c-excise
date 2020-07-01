using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d16
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 小明发月饼，我们再用 switch 结构发一次
             */
            string job = "处长";//职务
            switch (job)
            {
                case "局长": Console.WriteLine("发双黄月饼"); break;
                case "处长": Console.WriteLine("发蛋黄月饼"); break;
                case "科长": Console.WriteLine("发枣泥月饼"); break;
                default: Console.WriteLine("发五仁月饼"); break;
            }
        }
    }
}
