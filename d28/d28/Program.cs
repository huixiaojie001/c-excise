using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d28
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 代码声明并初始化一个 string 数组存储“职位”
               将数组元素初始化为"经理","项目主管","技术总监","财务主管"。
             */
            string[] job = new string[] { "经理", "项目主管", "技术总监", "财务总管" };
            for (int i = 0; i < job.Length; i++)
            {
                Console.WriteLine(job[i]);
            }
        }
    }
}
