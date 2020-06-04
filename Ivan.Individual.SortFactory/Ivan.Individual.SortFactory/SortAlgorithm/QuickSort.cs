using Ivan.Individual.SortFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.SortAlgorithm
{
    internal class QuickSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void DoSort(T[] array)
        {
            DoQuickSort(array, 0, array.Count() - 1);
        }
        private void DoQuickSort(T[] array,int left, int right)
        {
            if (left > right)
                return;

            T flag = array[left];
            int i = left;
            int j = right;
            while (i != j)
            {
                while (SortCompare(flag,array[j]) != 1 && i < j)
                {
                    j--;
                }
                while (SortCompare(flag, array[i]) != -1 && i < j)
                {
                    i++;
                }
                if (i < j) 
                {
                    Swap(ref array[i],ref array[j]);
                }
            }
            array[left] = array[i];
            array[i] = flag;
            DoQuickSort(array, left, i - 1);
            DoQuickSort(array, i + 1, right);

        }
    }
}
