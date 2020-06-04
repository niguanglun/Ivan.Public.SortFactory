using Ivan.Individual.SortFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.SortAlgorithm
{

    public abstract class SortBase<T> : ISortKit<T> where T : IComparable<T>
    {
        private Comparison<T> CompareMethod = null;

        public void Sort(T[] array, Comparison<T> comparable = null)
        {
            CompareMethod = comparable;
            if (array.Count() == 0)
                return;
            DoSort(array);
            Print(array);
        }

        protected int SortCompare(T a, T b)
        {
            return (CompareMethod != null) ? CompareMethod(a, b) : a.CompareTo(b);
        }

        protected abstract void DoSort(T[] array);

        //The Print Func should be called outside after each successful sort.
        //Here, Print Func is integrated in "Sort" Func for convenient reason, 
        //which means the sorted array will be printed automatically without explicitly print func calling.
        private void Print(T[] array)
        {
            Console.WriteLine("\nFinal Sort Result is: ");
            foreach (var item in array)
            {
                Console.WriteLine($"{item.ToString()}");
            }
        }

        protected void Swap(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

    }
}
