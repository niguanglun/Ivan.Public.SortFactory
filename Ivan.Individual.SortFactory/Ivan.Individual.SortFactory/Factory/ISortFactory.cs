using Ivan.Individual.SortFactory.Interface;
using Ivan.Individual.SortFactory.SortAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory
{
    public interface ISortFactory<T> where T : IComparable<T>
    {
        SortBase<T> CreateSort();
    }

}
