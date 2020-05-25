using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.Interface
{
    public interface ISortKit<T>
    {
        void Sort(T[] array, Comparison<T> comparable = null);
    }
}
