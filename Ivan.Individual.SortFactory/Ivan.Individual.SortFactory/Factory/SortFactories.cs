using Ivan.Individual.SortFactory.Interface;
using Ivan.Individual.SortFactory.SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory
{
    public class MergeSortFactory<T> : ISortFactory<T> where T : IComparable<T>
    {
        public SortBase<T> CreateSort()
        {
            return new MergeSort<T>();
        }
    }
    public class QuickSortFactory<T> : ISortFactory<T> where T : IComparable<T>
    {
        public SortBase<T> CreateSort()
        {
            return new QuickSort<T>();
        }
    }
    public class InsertionSortFactory<T> : ISortFactory<T> where T : IComparable<T>
    {
        public SortBase<T> CreateSort()
        {
            return  new InsertionSort<T>();
        }
    }
    public class BubbleSortFactory<T> : ISortFactory<T> where T : IComparable<T>
    {
        public SortBase<T> CreateSort()
        {
            return new BubbleSort<T>();
        }
    }
    public class HeapSortFactory<T> : ISortFactory<T> where T : IComparable<T>
    {
        public SortBase<T> CreateSort()
        {
            return new HeapSort<T>();
        }
    }
}
