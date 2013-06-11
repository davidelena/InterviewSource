using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Interview test = new Interview();
            
            //test.NumberTransformTest();
            //test.InterviewTest();
            //Console.WriteLine(test.CalculateFactorialNum(5));
            //test.NineMultipeNine();

            //string sourceStr = Console.ReadLine();
            //Console.WriteLine(test.DealWithDuplicatedString(sourceStr));

            //int[] sourceArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //test.DisorderArray(sourceArr);
            //Console.WriteLine(string.Join(",", sourceArr));

            string sourceStr = Console.ReadLine();
            test.CalculateCharCount(sourceStr);

            Console.ReadLine();
        }
    }
}
