using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IOCProject
{
    /// <summary>
    /// IOD（依赖倒置，控制反转）简单实例
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            IOCDemo iocDemo = new IOCDemo();
            double result = iocDemo.Calculate(3, 2);
            Console.WriteLine("计算结果为：" + result);
            Console.ReadLine();
        }
    }
}
