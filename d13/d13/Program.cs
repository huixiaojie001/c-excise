using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 小明负责发月饼。
               根据职务不同，局长发双黄的，处长发蛋黄的，科长发枣泥的，其他人发五仁的。
             */
            string job = "科员";
            if (job == "局长")
            {
                Console.WriteLine("发双黄月饼");
            }
            else if (job == "处长")
            {
                Console.WriteLine("发蛋黄月饼");
            }
            else if (job == "科长")
            {
                Console.WriteLine("发枣泥月饼");
            }
            else 
            {
                Console.WriteLine("发五仁月饼");
            }
        }
    }
}
