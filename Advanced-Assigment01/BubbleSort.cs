using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Assigment01
{
    internal class BubbleSort<T> where T : IComparable<T>
    {
        public static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
        //Optimization 1-Flag 2-last i elements already stored so we don't check them again
        public static void OptimizedBubbleSort(T[] arr) 
        { 
            int size=arr.Length;
            bool swapped;
            for (int i = 0; i < size - 1; i++) 
            {
                swapped = false;
                for (int j = 0; j < size - 1 - i; j++) 
                {
                    if (arr[j].CompareTo(arr[j+1]) > 0) 
                    { 
                        Swap(ref arr[j], ref arr[j+1]);
                        swapped = true;

                    }
                }
                if (!swapped)
                    break;
            }
        }
    }
}
