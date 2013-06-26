using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    public class SyntaticSugar
    {
        #region 语法糖1-属性

        //private string _prop;

        //public string Prop
        //{
        //    get { return _prop; }
        //    set { _prop = value; }
        //}

        //public string Prop { get; set; }

        #endregion

        #region 语法糖2-委托变异

        public delegate void Handler(int num);

        public static void ShowNum(int num)
        {
            Console.WriteLine(num);
        }

        public static void ShowDelegateNum(Handler handler, int num)
        {
            handler(10 * num);
        }

        #endregion

        #region 语法糖3-声明List

        //public static List<string> ls = new List<string>() { "a", "b", "c" };

        #endregion

        #region 语法糖4-逗号

        public static void ShowCommaSample(object num)
        {
            object a = 1;
            object b = num;
            a = b ?? -1;
            Console.WriteLine(a);
        }

        #endregion
    }
}
