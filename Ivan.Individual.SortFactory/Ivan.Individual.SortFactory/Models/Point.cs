using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ivan.Individual.SortFactory.Models
{
    public class Point: ModelBase<Point>
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public override string ToString()
        {
            return $"{X}, {Y}";
        }

        public override int CompareTo(Point other)
        {
            return (Compare(X, other.X) == 0) ? Compare(Y, other.Y): Compare(X, other.X);
        }
   
        private int Compare(int a, int b)
        {
            if (a > b)
            {
                return 1;
            }
            else if (a == b)
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
