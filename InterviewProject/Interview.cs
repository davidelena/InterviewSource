using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterviewProject
{
    public class Interview
    {
        /// <summary>
        /// 将10进制数转化为26进制
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public string ToNumberSystem26(int number)
        {
            string s = string.Empty;

            while (number > 0)
            {
                int m = number % 26;
                if (m == 0) m = 26;
                s = (char)(m + 64) + s;
                number = (number - m) / 26;
            }

            return s;
        }

        /// <summary>
        /// 将指定字符串转化为10进制数值
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int FromNumberSystem26(string s)
        {
            if (string.IsNullOrEmpty(s)) return 0;

            int number = 0;
            Stack<char> ls = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                char c = Char.ToUpper(s[i]);
                //在指定范围内转化26进制数
                if (c >= 'A' && c <= 'Z')
                    ls.Push(c);
                else
                    return 0;
            }

            int powerIndex = 0;
            while (ls.Count > 0)
            {
                char c = ls.Pop();
                number += ((int)(c - 64) * (int)Math.Pow(26, powerIndex));
                powerIndex++;
            }

            return number;
        }

        /// <summary>
        /// 测试多维数组行转列
        /// </summary>
        public void InterviewTest()
        {
            #region 1-矩阵转换

            int[][] testArray = new int[3][] {
                new int[]{100, 200, 300},
                new int[]{400, 500, 600},
                new int[]{700, 800, 900}
            };

            Console.WriteLine("转换前：\n");
            PrintArrayResult(testArray);
            Console.WriteLine();
            Console.WriteLine("转换后：\n");
            PrintArrayResult(TransformRowToColumn(testArray));
            Console.WriteLine();

            #endregion

            #region 2-数值计算

            Console.WriteLine("数值计算：\n");
            int number = 252;
            Console.WriteLine("输入数值：{0}，乘积值为：{1}", number, CalculateNumProduct(number));
            Console.WriteLine();

            #endregion

            #region 3-数值交换

            Console.WriteLine("数值交换：\n");
            Stack<int> stack = new Stack<int>();
            stack.Push(12);
            stack.Push(45);
            string s = string.Empty;
            while (stack.Count > 0)
            {
                int temp = ChangeNumberOrder(stack.Pop());
                s += (temp.ToString());
            }

            Console.WriteLine("交换后结果为：{0}", s);
            Console.WriteLine();

            #endregion

            #region 4-SQL查询

            //select userid, max(logintime) from user
            //group by userid
            //order by userid

            #endregion
        }

        /// <summary>
        /// 转化进制
        /// </summary>
        public void NumberTransformTest()
        {
            int number = 27;
            Console.WriteLine("------测试26进制转化为字母（1-26）=>（A-Z）-------");
            string result = ToNumberSystem26(number);
            string s = "AAA";
            int si = FromNumberSystem26(s);
            Console.WriteLine(si);
            Console.WriteLine("------测试26进制转化为数字（A-Z）=>（1-26）-------");
            Console.WriteLine(result);
        }

        /// <summary>
        /// 打印二维数组结果
        /// </summary>
        /// <param name="sourceArray"></param>
        private void PrintArrayResult(int[][] sourceArray)
        {
            for (int row = 0; row < sourceArray.Length; row++)
            {
                List<int> ls = new List<int>();
                for (int col = 0; col < sourceArray[row].Length; col++)
                {
                    ls.Add(sourceArray[row][col]);
                }
                Console.WriteLine(string.Join(",", ls));
            }
        }

        /// <summary>
        /// 行转列
        /// </summary>
        /// <param name="sourceArray"></param>
        /// <returns></returns>
        public int[][] TransformRowToColumn(int[][] sourceArray)
        {
            int[][] newArray = new int[3][]{
                new int[]{0,0,0},
                new int[]{0,0,0},
                new int[]{0,0,0}
            };

            for (int row = 0; row < sourceArray.Length; row++)
            {
                for (int col = 0; col < sourceArray[row].Length; col++)
                {
                    newArray[row][col] = sourceArray[col][row];
                }
            }

            return newArray;
        }

        /// <summary>
        /// 计算每个数的各个数字乘积
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int CalculateNumProduct(int number)
        {
            Stack<int> stack = new Stack<int>();
            int result = 1;
            while (number > 0)
            {
                int temp = number % 10;
                stack.Push(temp);
                number = number / 10;
            }

            while (stack.Count > 0)
            {
                result = result * stack.Pop();
            }

            return result;
        }

        /// <summary>
        /// 转换顺序
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int ChangeNumberOrder(int number)
        {
            List<int> ls = new List<int>();

            while (number > 0)
            {
                int temp = number % 10;
                ls.Add(temp);
                number = number / 10;
            }

            string s = string.Empty;
            for (int i = 0; i < ls.Count; i++)
            {
                s += ls[i].ToString();
            }

            return Convert.ToInt32(s);
        }

        /// <summary>
        /// 多维数组测试
        /// </summary>
        public void MutipleDimensionArrayTest()
        {
            int[,] arr = new int[3, 3] { 
                {100, 200, 300},
                {400, 500, 600},
                {700, 800, 900}
            };

            for (int i = 0; i < 3; i++)
            {
                List<int> ls = new List<int>();
                for (int j = 0; j < 3; j++)
                {
                    int num = arr[i, j];
                    ls.Add(num);
                }
                Console.WriteLine(string.Join(",", ls));
            }
        }

        /// <summary>
        /// 阶乘运算
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public long CalculateFactorialNum(int num)
        {
            if (num == 0) return 1;

            int result = 1;
            while (num > 0)
            {
                result *= num;
                num--;
            }

            return result;
        }

        /// <summary>
        /// 9*9乘法表
        /// </summary>
        public void NineMultipeNine()
        {
            int[,] arr = new int[9, 9];
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    arr[i, j] = (i + 1) * (j + 1);
                }
            }

            for (int i = 0; i < 9; i++)
            {
                List<int> ls = new List<int>();
                for (int j = 0; j < 9; j++)
                {
                    ls.Add(arr[i, j]);
                }
                Console.WriteLine(string.Join(" ", ls));
            }
        }
    }
}
