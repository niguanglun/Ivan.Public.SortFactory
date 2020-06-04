using Ivan.Individual.SortFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.SortAlgorithm
{
    internal class InsertionSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void DoSort(T[] array)
        {
            DoInsertionSort(array);
        }

        private void DoInsertionSort(T[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    //if array[j] < array[i],swap
                    if (SortCompare(array[i], array[j]) == 1)
                    {
                        Swap(ref array[j], ref array[i]);
                    }
                }
            }
            foreach (var item in array)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }
}
