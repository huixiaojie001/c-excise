using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace d27
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] age = new int[4];//声明并初始化长度为4的整形数组
            age[0] = 12;//为数组元素赋值
            age[1] = 14;
            age[2] = 15;
            age[3] = 18;
            Console.Write("我的4名同学年龄是{0}、{1}、{2}、{3}",age[0],age [1],age[2],age[3]);
        }
    }
}
