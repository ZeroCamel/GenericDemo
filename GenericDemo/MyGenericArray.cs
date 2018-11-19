using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
     public class MyGenericArray<T>
    {
        private T[] array;

        //构造函数初始化泛型
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }
}
