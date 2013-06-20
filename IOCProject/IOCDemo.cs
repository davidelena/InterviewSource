using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace IOCProject
{
    /// <summary>
    /// 依赖注入测试
    /// </summary>
    public class IOCDemo
    {
        private ICalculate config;
        private Dictionary<string, ICalculate> dict;

        public IOCDemo()
        {
            dict = GetInitConfigDict();
            //此处可以从配置文件中读取
            config = GetConfig();
        }

        /// <summary>
        /// 计算数值
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public double Calculate(int a, int b)
        {
            double aa = double.Parse(a.ToString());
            double bb = double.Parse(b.ToString());

            //此处依赖就是依赖注入的典范，从依赖具体的实例转变为依赖某个接口
            ICalculate calculateExpression = config;
            return config.Calculate(aa, bb);
        }

        /// <summary>
        /// 从配置文件中获取配置信息
        /// </summary>
        /// <returns></returns>
        private ICalculate GetConfig()
        {
            //此处就是控制反转的典范，原本控制权是在程序内部现在交由配置文件去读取。
            string config = AppDomain.CurrentDomain.BaseDirectory + "initConfig.ini";
            string configInfo = File.ReadAllText(config);

            if (dict.ContainsKey(configInfo))
                return dict[configInfo];
            else
                return new Add();
        }

        /// <summary>
        /// 初始化配置字典
        /// </summary>
        /// <returns></returns>
        private Dictionary<string, ICalculate> GetInitConfigDict()
        {
            Dictionary<string, ICalculate> configDict = new Dictionary<string, ICalculate>();

            configDict.Add("+", new Add());
            configDict.Add("-", new Substract());
            configDict.Add("*", new Multiplication());
            configDict.Add("/", new Divide());
            configDict.Add("*+", new Special());

            return configDict;
        }
    }
}
