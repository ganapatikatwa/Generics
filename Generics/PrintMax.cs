using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class PrintMax<T> where T : IComparable
    {
        public T[] value;
        public PrintMax(T[] value)
        {
            this.value = value;
        }
        public T[] SortValue(T[] value)
        {
            Array.Sort(value);
            return value;
        }
        public T FindMax(T[] values)
        {
            var sortedValues= SortValue(this.value);
            return sortedValues[sortedValues.Length - 1];
        }
        public T FindMaxMethod()
        {
            var maxValue= FindMax(this.value);
            return maxValue;
        }
        public void Printmax()
        {
            var MaxValue= FindMax(this.value);
            Console.WriteLine("Maximum Value--"+MaxValue);
        }
    }
}
