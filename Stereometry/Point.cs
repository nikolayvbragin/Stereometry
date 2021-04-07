using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stereometry
{
    public class Point
    {
        public char Name { get; } = 'A';
        public int X { get; } = 0;
        public int Y { get; } = 0;

        public Point(int x, int y, char name)
        {
            X = x;
            Y = y;
            Name = name;
        }
    }
}
