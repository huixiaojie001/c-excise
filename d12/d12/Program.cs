using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 在我国，年满22岁的男性和年满20岁的女性可以结婚。
               请编写代码程序能够完成“是否达到法定婚龄”的验证。
             */
            char sex = '男';//性别
            int age = 21;//年龄
            if(sex==1)
            {
                if(age>=20)
                {
                    Console .WriteLine ("达到法定婚龄啦");
                }
                else
                {
                    Console .WriteLine ("没有达到哟");
                }
            }
            else
            {
                if(age>=22)
                {
                Console.WriteLine("达到法定婚龄！");
                }
                else
                {
                    Console.WriteLine("没有达到！");
                }                
            }
        }
    }
}
