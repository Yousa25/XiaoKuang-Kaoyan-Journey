using System;
using System.Collections.Generic;
using System.Text;

namespace OOP数学
{
    class 区间
    {
        double 左端点;
        double 右端点;
        bool 左闭合;
        bool 右闭合;

        public 区间(double 左端点, double 右端点, bool 左闭合 = true, bool 右闭合 = true)
        {
            this.左端点 = 左端点;
            this.右端点 = 右端点;
            this.左闭合 = 左闭合;
            this.右闭合 = 右闭合;
        }
    }
    class 函数 
    {
        区间 定义域;

        string 对应法则;

        区间 值域;

        void 求定义域()
        {
            // 1. 判断函数类型：比如分式，根式等等
            // 2. 根据函数类型，求出定义域
            // 3. 将定义域用区间表示中
        }

        void 求函数值(double x)
        {
        }



    }
    
    
}
