using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MoreThenTherees<T> where T : IComparable
    {
        public T first, second, third, forth;
        public MoreThenTherees(T first, T second, T third, T forth)
        {
            this.first = first;
            this.second = second;
            this.third = third;
            this.forth = forth;
        }
        public T GenericCompare()
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0 && first.CompareTo(forth) > 0)
                return first;
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0 && second.CompareTo(forth) > 0)
                return second;
            else if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0 && third.CompareTo(forth) > 0)
                return third;
            else if (forth.CompareTo(first) > 0 && forth.CompareTo(second) > 0 && forth.CompareTo(third) > 0)
                return forth;
            return default;
        }
    }
}
