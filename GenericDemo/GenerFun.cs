using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public class GenerFun
    {
        //ref:out-参数修饰符
        //作用：关键字使参数按引用传递
        //区别：ref 使用之前必须初始化；out 使用之前可以不用初始化
        //      ref 调用的参数可以在参数内部直接使用；out 调用的参数不可以直接使用
        //      out 方法可以返回多个值
        public static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
    }
}
