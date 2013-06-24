using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverProject
{
    /// <summary>
    /// 观察者模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            WeatherSignBoard signBoard = new WeatherSignBoard() { Temperature = 20, Details = "舒适" };
            IList<Observer> observerLs = new List<Observer>()
            {
                new PC(signBoard),
                new IPad(signBoard),
                new IPadMini(signBoard),
                new Cellphone(signBoard)
            };

            foreach (var item in observerLs)
            {
                //signBoard.CustomUpdate += item.Update;
                signBoard.Attach(item);
            }

            signBoard.Notify();

            signBoard.ChangeInfo();
            Console.WriteLine("天气情况变化后...");

            signBoard.Notify();

            Console.ReadLine();
        }
    }
}
