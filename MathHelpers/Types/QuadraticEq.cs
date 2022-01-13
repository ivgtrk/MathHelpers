using System;

namespace MathHelpers.Types
{
    internal class QuadraticEq
    {
        private readonly double a;
        private readonly double b;
        private readonly double c;

        public QuadraticEq( double a, double b, double c ) 
        { 
            this.a = a;
            this.b = b;
            this.c = c;
        }


        public override string ToString()
        {
            string res = a < 0 ? a == -1 ? "-x^2 " : $"{a}x^2 " : a == 1 ? "x^2 " : $"{a}x^2 ";
            res += b < 0 ? b == -1 ? "- x " : $"- {Abs( b )}x " : b == 1 ? "+ x " : $"+ {b}x ";
            res += c < 0 ? $"- {Abs( c )} = 0" : $"+ {c} = 0";
            return res;
        }


        private static double Abs( double x ) => x < 0 ? -x : x;

        public void Calc()
        {
            // Roots
            double r1, r2;

            // Discriminant
            double d = b * b - 4 * a * c;

            // If the discriminant is negative, then there are no real roots
            if ( d < 0 )
                Console.WriteLine( "No roots." );

            // If the discriminant is zero, then there is exactly one real root
            else if ( d == 0 )
            {
                r1 = -b / 2 * a;
                Console.WriteLine( $"X1 = {r1}" );
            }

            // If the discriminant is positive, then there are two distinct roots
            else if ( d > 0 )
            {
                r1 = ( -b + Math.Sqrt( d ) ) / 2 * a;
                r2 = ( -b - Math.Sqrt( d ) ) / 2 * a;
                Console.WriteLine( $"X1 = {r1}\nX2 = {r2}" );
            }
        }

    }
}
