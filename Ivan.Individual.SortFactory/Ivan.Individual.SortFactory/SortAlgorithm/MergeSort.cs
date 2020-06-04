using Ivan.Individual.SortFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.SortAlgorithm
{
    internal class MergeSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void DoSort(T[] array)
        {
            DoMergeSort(array);
        }

        private void DoMergeSort(T[] array)
        {
            Merge(array, 0, array.Length - 1);
        }
        private void Merge(T[] array,int first,int last)
        {
            if (first < last)
            {
                int middle = (first + last) / 2;
                Merge(array, first, middle);
                Merge(array, middle + 1, last);
                MergeMethod(array, first, middle, last);
            }
        }
        private void MergeMethod(T[] array, int first, int middle, int last)
        {
            Console.WriteLine("-----------------------");
            T[] temp = new T[last - first + 1];
            int nLeftStart = first;
            int nRightStart = middle + 1;
            int i = 0;
            while (nLeftStart <= middle && nRightStart <= last)
            {
                if (SortCompare(array[nLeftStart], array[nRightStart]) !=1) 
                {
                    temp[i] = array[nLeftStart];
                    nLeftStart++;
                }
                else
                {
                    temp[i] = array[nRightStart];
                    nRightStart++;
                }
                i++;
            }
            while (nLeftStart <= middle) 
            {
                temp[i] = array[nLeftStart];
                nLeftStart++;
                i++;
            }
            while (nRightStart < last)
            {
                temp[i] = array[nRightStart];
                nRightStart++;
                i++;
            }
            for (int n = 0; n < i; n++)
            {
                array[first + n] = temp[n];
            }
            foreach (var item in array)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }
    }
}
