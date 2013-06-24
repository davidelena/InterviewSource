using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverProject
{
    /// <summary>
    /// 天气预报布告板类
    /// </summary>
    public class WeatherSignBoard : Subject
    {
        private double temperature;
        private string details;

        public WeatherSignBoard()
        {
            temperature = 0;
            details = string.Empty;
        }

        public string Details
        {
            get { return details; }
            set { details = value; }
        }

        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }

        /// <summary>
        /// 测试改变
        /// </summary>
        public void ChangeInfo()
        {
            Random rd = new Random();
            temperature = rd.Next(-20, 50);
            if (temperature <= 0)
                details = "霜冻";
            else if (temperature > 0 && temperature < 30)
                details = "舒适";
            else
                details = "炎热";
        }
    }
}
