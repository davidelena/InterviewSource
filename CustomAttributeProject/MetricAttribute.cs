using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomAttributeProject
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false)]
    public class MetricAttribute : Attribute
    {
        private string metricDescription = string.Empty;

        public MetricAttribute(string description)
        {
            metricDescription = description;
        }

        public string MetricDescription
        {
            get { return metricDescription; }
        }
    }
}
