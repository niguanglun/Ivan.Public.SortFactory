using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.SortAlgorithm
{
    internal class HeapSort<T> : SortBase<T> where T : IComparable<T>
    {
        protected override void DoSort(T[] array)
        {
            BuildHeap(array);
            for (int i = array.Length - 1; i > 0; i--) 
            {
                Swap(ref array[i], ref array[0]);
                SingleNodeSort(array,i, 0);
            }
        }

        private void BuildHeap(T[] array)
        {
            for (int i = array.Length / 2 - 1; i >= 0; i--) 
            {
                SingleNodeSort(array, array.Length, i);
            }
        }
        
        private void SingleNodeSort(T[] array,int length, int rootIndex)
        {
            int leftChiledIndex = LeftChildNode(rootIndex);
            int rightChiledIndex = RightChildNode(rootIndex);
            int nMaxIndex = rootIndex;
            if (leftChiledIndex < length && SortCompare(array[leftChiledIndex], array[rootIndex]) == 1)
            {
                nMaxIndex = leftChiledIndex;
            }
            if (rightChiledIndex < length && SortCompare(array[rightChiledIndex], array[nMaxIndex]) == 1)
            {
                nMaxIndex = rightChiledIndex;
            }
            if (nMaxIndex != rootIndex)
            {
                Swap(ref array[nMaxIndex], ref array[rootIndex]);
                SingleNodeSort(array, length, nMaxIndex);
            }
        }
        #region helper function
        private int Parrent(int index)
        {
            return (index - 1) / 2;
        }
        private int LeftChildNode(int index)
        {
            return 2 * index + 1;
        }
        private int RightChildNode(int index)
        {
            return 2 * index + 2;
        }
        #endregion
    }
}
