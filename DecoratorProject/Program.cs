using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorProject
{
    /// <summary>
    /// 装饰着模式，运行时动态添加功能即插即用
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            ITank tank = new Tank();
            TankAbility bfaTank = new BulletAbility(new ArmourAbility(new FlyAbility(tank)));
            TankAbility faTank = new FlyAbility(new ArmourAbility(tank));

            Console.WriteLine("This is first tank type:");
            bfaTank.ShowTankInfo();
            Console.WriteLine();
            Console.WriteLine("This is second tank type:");
            faTank.ShowTankInfo();

            Console.ReadLine();
        }
    }
}
