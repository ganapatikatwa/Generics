using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericMethod
    {
        public T GenericCompare<T>(T first, T second, T third) where T: IComparable
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
