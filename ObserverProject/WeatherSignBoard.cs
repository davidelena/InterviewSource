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
        public delegate void CustomEventHandler();
        public event CustomEventHandler CustomUpdate;

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

        ///// <summary>
        ///// 也可以使用event委托的方式来添加函数引用注册相应的Update事件
        ///// </summary>
        //public override void Notify()
        //{
        //    if (CustomUpdate != null)
        //        CustomUpdate();
        //}

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
