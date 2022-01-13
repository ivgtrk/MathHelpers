using System;
using MathHelpers.Global;

namespace MathHelpers.Types
{
    internal class Vector2D
    {
        #region Properties & Constructor
        private Point ps;   // Starting point of vector
        private Point pe;   // End point of vector

        public Point Ps
        {
            get => ps; 
            set => ps = value; 
        }

        public Point Pe
        {
            get => pe;
            set => pe = value;
        }


        /// <summary>
        /// Get the current coordinates of the vector
        /// </summary>
        public Point VectCoord
        {
            get
            {
                Point p = new( pe.X - ps.X, pe.Y - ps.Y );
                return p;
            }
        }


        /// <summary>
        /// Get vector lenght
        /// </summary>
        public double VectLenght
        {
            get => Math.Abs( Math.Sqrt( VectCoord.X * VectCoord.X + VectCoord.Y * VectCoord.Y ) );
        }


        /// <summary>
        /// Projection of a vector on the Ox axis
        /// </summary>
        public double ProjectionOx
        {
            get => pe.X - ps.X;
        }


        /// <summary>
        /// Projection of a vector on the Oy axis
        /// </summary>
        public double ProjectionOy
        {
            get => pe.Y - ps.Y;
        }


        public Vector2D()
        {
            ps = new Point();
            pe = new Point();
        }

        public Vector2D( Point s, Point e ) : this()
        {
            ps = s;
            pe = e;
        }

        public Vector2D( double x0, double y0, double x1, double y1 ) : this()
        {
            ps.X = x0;
            ps.Y = y0;
            pe.X = x1;
            pe.Y = y1;
        }
        #endregion



        public static Point operator +( Vector2D a, Vector2D b ) => Sum( a, b );
        public static Point operator -( Vector2D a, Vector2D b ) => Substract( a, b );


        private static Point Sum ( Vector2D a, Vector2D b ) 
        {
            Point v = new()
            {
                X = a.VectCoord.X + b.VectCoord.X,
                Y = a.VectCoord.Y + b.VectCoord.Y
            };
            return v;
        }


        private static Point Substract( Vector2D a, Vector2D b )
        {
            Point v = new()
            {
                X = a.VectCoord.X - b.VectCoord.X,
                Y = a.VectCoord.Y - b.VectCoord.Y
            };
            return v;
        }


        public override string ToString() =>    $"Start point:       ({ps.X},{ps.Y})\n" +
                                                $"End point:         ({pe.X},{pe.Y})\n" +
                                                $"Vector coordinate: ({VectCoord.X},{VectCoord.Y})\n" +
                                                $"Vector lenght:     {VectLenght:F5}\n" +
                                                $"Projection Ox:     {ProjectionOx}\n" +
                                                $"Projection Oy:     {ProjectionOy}";
    }
}
