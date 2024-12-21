using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced
{
    public class range<T> where T : IComparable<T>
    {
        public T MinValue { get; set; }
        public T MaxValue { get; set; } 
        public range() {
            MinValue = MinValue;
            MaxValue = MaxValue;
        }
        public bool IsInRange(T value)
        {
                
            return value.CompareTo(MinValue)>= 0&& value.CompareTo(MaxValue)<= 0;
        }

    }
}
