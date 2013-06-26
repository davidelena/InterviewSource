using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Security.Cryptography;
using System.IO;

namespace InterviewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Interview test = new Interview();

            //Type t = test.GetType();
            //MethodInfo method = t.GetMethod("SayHello");
            //foreach (var item in method.GetParameters())
            //{
            //    Console.WriteLine("Parameter Name:{0}, Parameter Type:{1}", item.Name, item.ParameterType);
            //}

            //test.NumberTransformTest();
            //test.InterviewTest();
            //Console.WriteLine(test.CalculateFactorialNum(5));
            //test.NineMultipeNine();

            //string sourceStr = Console.ReadLine();
            //Console.WriteLine(test.DealWithDuplicatedString(sourceStr));

            //int[] sourceArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //test.DisorderArray(sourceArr);
            //Console.WriteLine(string.Join(",", sourceArr));

            //string sourceStr = Console.ReadLine();
            //test.CalculateCharCount(sourceStr);

            //int[] sourceArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine(string.Join(",", test.ReverseArray(sourceArr)));

            //Console.WriteLine(test.Fib(7));   

            #region 语法糖测试

            //SyntaticSugar.Handler handler = new SyntaticSugar.Handler(SyntaticSugar.ShowNum);
            //handler(1);

            //SyntaticSugar.ShowDelegateNum(delegate(int num)
            //{
            //    Console.WriteLine(num);
            //}, 13);

            //SyntaticSugar.ShowDelegateNum(n => Console.WriteLine(n), 13);

            //SyntaticSugar.ls.ForEach(n => Console.WriteLine(n));

            //SyntaticSugar.ShowCommaSample(34);

            //string password = "David123!";
            //Console.WriteLine("明码为：{0}", password);            
            //Console.WriteLine("加密后的：{0}", test.EncryptString(password));
            //Console.WriteLine("------------");
            //string password2 = "David123!";
            //Console.WriteLine("明码为：{0}", password2);
            //Console.WriteLine("加密后的：{0}", test.EncryptString(password2));

            string password = "David123!";
            Console.WriteLine("明码为：{0}", password);
            string ap = test.DesEncryptString(password);
            Console.WriteLine("加密后：{0}，源字符串长度：{1}，加密后长度：{2}", ap, password.Length, ap.Length);
            Console.WriteLine();
            Console.WriteLine("密文为：{0}", ap);

            #endregion

            Console.ReadLine();
        }
    }
}
