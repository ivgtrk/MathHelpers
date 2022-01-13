using System;

namespace MathHelpers.Types
{
    internal class Complex
    {
        public double r, i, abs;

        public Complex()
        {
            r = 0.0;
            i = 0.0;
        }

        public static Complex Sum( Complex a, Complex b )
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }

        public static Complex Multiplication( Complex a, Complex b )
        {
            Complex res = new Complex();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.i * b.r + a.r * b.i;
            return res;
        }

        public static Complex Subtract( Complex a, Complex b )
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }

        public static Complex Abs( Complex a )
        {
            Complex res = new Complex();
            res.abs = Math.Sqrt( a.r * a.r + a.i * a.i );
            return res;
        }

        public static Complex operator +( Complex a, Complex b )
        {
            return Sum( a, b );
        }

        public static Complex operator -( Complex a, Complex b )
        {
            return Subtract( a, b );
        }

        public static Complex operator *( Complex a, Complex b )
        {
            return Multiplication( a, b );
        }


        /** TODO: Add a Division method **/


        public override string ToString() => string.Format( $"{r} + {i}i" );

    }
}
