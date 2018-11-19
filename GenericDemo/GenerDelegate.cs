using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    delegate T NumberChange<T>(T n);
    public class GenerDelegate
    {
        static int number = 10;

        public static int AddNum(int p)
        {
            number += p;
            return number;
        }

        public static int MulNum(int p)
        {
            number *= p;
            return number;
        }

        public static int GetNum()
        {
            return number;
        }
    }
}
