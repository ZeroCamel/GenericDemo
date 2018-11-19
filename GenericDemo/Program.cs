using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    class Program
    {
        /// <summary>
        /// 泛型
        /// 实际：微软的一种延迟机制；Lazy;
        /// 定义：允许类延迟编写类或方法中的编程元素的数据类型的规范
        /// 作用：一个可以和任何数据类型工作的类或方法
        /// 自定义：泛型接口、泛型类、泛型方法、泛型事件、泛型委托
        /// 泛型类型获取：类型信息可以在运行时使用反射获取
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //声明一个整型数组
            MyGenericArray<int> intArray = new MyGenericArray<int>(5);

            for (int i = 0; i < 5; i++)
            {
                intArray.SetItem(i, i + 1);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }

            //声明一个字符串数组
            MyGenericArray<string> stringArray = new MyGenericArray<string>(5);
            for (int i = 0; i < 5; i++)
            {
                stringArray.SetItem(i, "aaa" + i);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.Write(stringArray.GetItem(i) + " ");
            }

            Console.WriteLine();


            //Example 泛型方法
            int a, b;
            char c, d;

            a = 10;
            b = 20;
            c = 'I';
            d = 'v';

            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values before calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            GenerFun.Swap<int>(ref a, ref b);
            GenerFun.Swap<char>(ref c, ref d);

            Console.WriteLine("Int values after calling swap:");
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Console.WriteLine("Char values after calling swap:");
            Console.WriteLine("c = {0}, d = {1}", c, d);

            //Example 泛型委托
            NumberChange<int> nm1 = new NumberChange<int>(GenerDelegate.AddNum);
            NumberChange<int> nm2 = new NumberChange<int>(GenerDelegate.MulNum);

            nm1(10);
            Console.WriteLine(GenerDelegate.GetNum());

            nm2(10);
            Console.WriteLine(GenerDelegate.GetNum());

            
            Console.Read();
        }
    }
}
