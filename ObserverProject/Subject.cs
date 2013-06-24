using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObserverProject
{
    public abstract class Subject
    {
        /// <summary>
        /// 存储观察者对象的List集合对象
        /// </summary>
        private IList<Observer> observerLs;

        /// <summary>
        /// 初始化观察者对象集合
        /// </summary>
        public Subject()
        {
            observerLs = new List<Observer>();
        }

        /// <summary>
        /// 添加观察者到List集合对象
        /// </summary>
        /// <param name="observer"></param>
        public void Attach(Observer observer)
        {
            observerLs.Add(observer);
        }

        /// <summary>
        /// 从List集合对象中删除观察者
        /// </summary>
        /// <param name="observer"></param>
        public void Detach(Observer observer)
        {
            observerLs.Remove(observer);
        }

        /// <summary>
        /// 通知所有观察者对象
        /// </summary>
        public virtual void Notify()
        {
            foreach (Observer observer in observerLs)
            {
                observer.Update();
            }
        }
    }
}
