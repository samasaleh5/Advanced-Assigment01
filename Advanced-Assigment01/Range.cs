using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assigment01
{
    internal class Range<T> where T :IComparable<T>
    {
        public T Max { get;}
        public T Min { get;}
        public Range(T max,T min)
        {
            if (min.CompareTo(max) > 0) 
            {
                throw new ArgumentException("Minimum value can not be greater than Maximum value");
            }
            Max = max;
            Min = min;
        }
        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }
        public double length()
        {
            double minvalue=Convert.ToDouble(Min);
            double maxvalue=Convert.ToDouble(Max);
            return maxvalue-minvalue;
        }
        public override string ToString()
        {
            return $"Range: [{Min},{Max}]";
        }

    }
}
