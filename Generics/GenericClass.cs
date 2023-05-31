using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericClass<T> where T : IComparable
    {
        public T first, second, third;
        public GenericClass(T first, T second, T third)
        {
            this.first = first;
            this.second = second;
            this.third= third;
        }
        public T GenericCompare() 
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
                return first;
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
                return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
                return third;
            return default;
        }
    }
}
