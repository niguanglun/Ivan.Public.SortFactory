using Ivan.Individual.SortFactory.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.Models
{
    public class Person : ModelBase<Person>
    {
        public int Age { get; set; }
        public string Name { get; set; }

        public Person()
        {
        }

        public Person(string name, int age) : this()
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name}: {Age}";
        }

        // CompareTo is the implementation of IComparable
        public override int CompareTo(Person other)
        {
            if (this.Age > other.Age)
            {
                return 1;
            }
            else if (this.Age == other.Age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
