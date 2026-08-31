using System;
using System.Collections.Generic;
using System.Text;

namespace Math.概念
{
    internal class 绝对值:函数
    {
        public override 区间 定义域 => new 区间(double.NegativeInfinity, double.PositiveInfinity, false, false);

        /// <summary>
        /// 绝对值函数的对应法则：f(x) = |x|，即当x>=0时，f(x)=x；当x<0时，f(x)=-x。
        /// </summary>
        /// <param name="x">自变量</param>
        /// <returns></returns>
        public override double 对应法则(double x)
        {
            
            if (x >= 0)
            {
                return x;
            }
            else
            {
                return -x;
            }
        }

    }

    internal class Sgn : 函数
    {
        public override 区间 定义域 => new 区间(double.NegativeInfinity, double.PositiveInfinity, false, false);
        /// <summary>
        /// 符号函数的对应法则：f(x) = sgn(x)，即当x>0时，f(x)=1；当x<0时，f(x)=-1；当x=0时，f(x)=0。
        /// </summary>
        /// <param name="x">自变量</param>
        /// <returns></returns>
        /// 
        public void 求定义域()
        {
            //1.函数规则，识别约束
            //2.写出条件
            //3.求解条件，得到定义域
            //4.写出定义域
        }
        public override double 对应法则(double x)
        {
            if (x > 0)
            {
                return 1;
            }
            else if (x < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }

    internal class  取整函数:函数
    {
        public override 区间 定义域 => new 区间(double.NegativeInfinity, double.PositiveInfinity, false, false);

        public override double 对应法则(double x)
        {
            // 强转 int 是"截断"（朝0方向），不是"向下取整"
            // 所以负数需要额外处理
            int 整数部分 = (int)x;

            // 如果 x 是负数，且 x 不是整数，截断结果比 Floor 大了 1
            if (x < 0 && x != 整数部分)
                return 整数部分 - 1;

            return 整数部分;
        }

    }
}
