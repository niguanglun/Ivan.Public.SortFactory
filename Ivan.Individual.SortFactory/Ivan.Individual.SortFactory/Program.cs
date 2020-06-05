using Ivan.Individual.SortFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example for c# Built-in types
            ISortFactory<int> m_sortFactory = new HeapSortFactory<int>();
            int[] array = { 6, 9, 7, 5, 4, 2, 1, 8, 0 };
            m_sortFactory.CreateSort().Sort(array, AscComparison);

            //Example for Person
            ISortFactory<Person> m_sortPersonFactory = new BubbleSortFactory<Person>();
            Person[] personArray = { new Person("aa", 1), new Person("cc", 3), new Person("dd", 4), new Person("bb", 2) };
            var bubbleSort = m_sortPersonFactory.CreateSort();
            bubbleSort.Sort(personArray);

            //Example for Point
            ISortFactory<Point> m_sortPointFactory = new QuickSortFactory<Point>();
            Point[] pointArray = { new Point(3, 1), new Point(1, 3), new Point(5, 4), new Point(0, 9) };
            m_sortPointFactory.CreateSort().Sort(pointArray);

            Console.ReadKey();

        }
        public static int AscComparison(int x, int y)
        {
            if (x > y)
            {
                return -1;
            }
            else if (x == y)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
