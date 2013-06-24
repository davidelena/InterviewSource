using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverProject
{
    public class IPad : Observer
    {
        private Subject subject;

        public IPad(Subject subject)
        {
            this.Name = "IPad";
            this.subject = subject;
        }

        public override void Update()
        {
            WeatherSignBoard s = subject as WeatherSignBoard;
            if (s == null)
                s = new WeatherSignBoard();

            Console.WriteLine("观察者：{0}，当前观察到的温度：{1}，天气情况：{2}", this.Name, s.Temperature, s.Details);
        }
    }

    public class IPadMini : Observer
    {
        private Subject subject;

        public IPadMini(Subject subject)
        {
            this.Name = "IPadMini";
            this.subject = subject;
        }

        public override void Update()
        {
            WeatherSignBoard s = subject as WeatherSignBoard;
            if (s == null)
                s = new WeatherSignBoard();

            Console.WriteLine("观察者：{0}，当前观察到的温度：{1}，天气情况：{2}", this.Name, s.Temperature, s.Details);
        }
    }

    public class Cellphone : Observer
    {
        private Subject subject;

        public Cellphone(Subject subject)
        {
            this.Name = "Cellphone";
            this.subject = subject;
        }

        public override void Update()
        {
            WeatherSignBoard s = subject as WeatherSignBoard;
            if (s == null)
                s = new WeatherSignBoard();

            Console.WriteLine("观察者：{0}，当前观察到的温度：{1}，天气情况：{2}", this.Name, s.Temperature, s.Details);
        }
    }

    public class PC : Observer
    {
        private Subject subject;

        public PC(Subject subject)
        {
            this.Name = "PC";
            this.subject = subject;
        }

        public override void Update()
        {
            WeatherSignBoard s = subject as WeatherSignBoard;
            if (s == null)
                s = new WeatherSignBoard();

            Console.WriteLine("观察者：{0}，当前观察到的温度：{1}，天气情况：{2}", this.Name, s.Temperature, s.Details);
        }
    }
}
