using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqAndExtensions
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"({X},{Y})";
        }
    }

    public class Point3D : Point
    {
        public int Z { get; set; }

        public override string ToString()
        {
            return $"({X},{Y},{Z})";
        }

    }
}
