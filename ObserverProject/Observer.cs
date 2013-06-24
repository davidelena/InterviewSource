using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverProject
{
    /// <summary>
    /// 抽象观察者对象
    /// </summary>
    public abstract class Observer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public virtual void Update() { }
    }
}
