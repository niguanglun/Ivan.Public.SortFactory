using Ivan.Individual.SortFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.SortAlgorithm
{
    internal class BubbleSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void DoSort(T[] array)
        {
            DoBubbleSort(array);
        }
        private void DoBubbleSort(T[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++) 
                {
                    if (SortCompare(array[i], array[j]) == 1) 
                    {
                        Swap(ref array[i], ref array[j]);
                    }
                }
            }
        }
    }
}
