using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CustomAttributeProject
{
    public enum MetricEnum
    {
        [Metric("印象数")]
        Impression = 1,

        [Metric("点击数")]
        Clicks,

        [Metric("点击率")]
        CTR,

        [Metric("独立印象数")]
        UV
    }
}
