using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomAttributeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Type metricType = typeof(MetricEnum);

            List<string> ls = new List<string>();

            foreach (var info in metricType.GetMembers())
            {
                MetricAttribute ma = (Attribute.GetCustomAttribute(info, typeof(MetricAttribute)) as MetricAttribute);
                if (ma != null)
                    Console.WriteLine("Name：{0}, Description：{1}", info.Name, ma.MetricDescription);
            }

            Console.ReadLine();
        }
    }
}
