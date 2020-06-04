using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.SortAlgorithm
{
    internal class AdvancedFlagBubbleSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void DoSort(T[] array)
        {
            bool bSwaped = true;
            for (int i = 0; i < array.Length; i++)
            {
                bSwaped = false;
                for (int j = i + 1; j < array.Length; j++) 
                {
                    if (SortCompare(array[i], array[j]) == 1)
                    {
                        Swap(ref array[i], ref array[j]);
                        bSwaped = true;
                    }
                }  
                if (!bSwaped)
                    break;
            }
        }
    }
}
