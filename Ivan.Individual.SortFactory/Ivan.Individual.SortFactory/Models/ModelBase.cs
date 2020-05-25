using Ivan.Individual.SortFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.Models
{
    public abstract class ModelBase<T> :IComparable<T> 
    {
        protected Func<T, int> ComparisonMethod { get; set; }

        public ModelBase()
        {
            ComparisonMethod = CompareTo;
        }

        public abstract int CompareTo(T other);
    }
}
