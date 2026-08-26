using System;

namespace Math.概念
{
    enum 单调性
    {
        单调递增,
        单调递减,
        非单调
    }

    enum 奇偶性
    {
        奇函数,   // f(-x) = -f(x)，关于原点对称
        偶函数,   // f(-x) = f(x)，关于y轴对称
        非奇非偶
    }
    /// <summary>
    /// 区间类：表示一个数的范围，如 [0, +∞) 
    /// 用来做为函数的定义域和值域
    /// </summary>
    /// double 左端点, double 右端点, bool 左闭 = true, bool 右闭 = true
    class 区间
    {
        public double 左端点 { get; }
        public double 右端点 { get; }
        public bool 左闭 { get; }
        public bool 右闭 { get; }

        public 区间(double 左端点, double 右端点, bool 左闭 = true, bool 右闭 = true)
        {
            this.左端点 = 左端点;
            this.右端点 = 右端点;
            this.左闭 = 左闭;
            this.右闭 = 右闭;
        }

        public bool 包含(double 值)
        {
            bool 左满足 = 左闭 ? (值 >= 左端点) : (值 > 左端点);
            bool 右满足 = 右闭 ? (值 <= 右端点) : (值 < 右端点);
            return 左满足 && 右满足;
        }

        public override string ToString()
        {
            string 左括号 = 左闭 ? "[" : "(";
            string 右括号 = 右闭 ? "]" : ")";
            return $"{左括号}{左端点}, {右端点}{右括号}";
        }
    }

    /// <summary>
    /// 函数定义：存在一个法则f，使得对于定义域中的每一个x，
    /// 都有唯一的y与之对应，记作 y=f(x)。
    /// 构成函数的三要素：定义域、对应法则、值域。
    /// </summary>
    abstract class 函数
    {
        /// <summary>
        /// 定义域：自变量x的取值范围（是一个区间）
        /// 函数"拥有"一个定义域，而不是"是"一个区间
        /// </summary>
        public abstract 区间 定义域 { get; }

        /// <summary>
        /// 对应法则：给定x，计算f(x)
        /// </summary>
        public abstract double 对应法则(double x);

        /// <summary>
        /// 函数值：给定x，返回f(x)的结果
        /// </summary>
        public double 函数值(double x)
        {
            if (!定义域.包含(x))
                throw new ArgumentException($"x={x} 不在定义域 {定义域} 内");

            return 对应法则(x);
        }

        // ========== 四种特性 ==========

        /// <summary>
        /// 有界性：函数值是否被限制在某个范围内
        /// 返回 null 表示无界，返回区间表示有界
        /// </summary>
        public abstract 区间 有界性 { get; }

        /// <summary>
        /// 单调性：在定义域上的增减趋势
        /// </summary>
        public abstract 单调性 单调性 { get; }

        /// <summary>
        /// 奇偶性：关于原点或y轴的对称性
        /// </summary>
        public abstract 奇偶性 奇偶性 { get; }

        /// <summary>
        /// 周期性：是否存在周期T使得f(x+T)=f(x)
        /// 返回 null 表示非周期函数，返回正数表示最小正周期
        /// </summary>
        public abstract double? 周期性 { get; }

        /// <summary>
        /// 求导：返回导函数
        /// </summary>
        //public abstract 函数 求导();
    }
}