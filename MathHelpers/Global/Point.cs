using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelpers.Global
{
    /// <summary>
    /// The structure of a point in space
    /// For two-dimensional planes, the Z coordinate can be ignored
    /// </summary>
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Point( double x, double y, double z = 0.0 )
        {
            X = x; Y = y; Z= z;
        }
    }
}
