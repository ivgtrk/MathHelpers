using System.Linq;

namespace MathHelpers.Types
{
    internal class Factorial
    {
        /// <summary>
        /// Recursive algorithm
        /// </summary>
        /// <param name="x">Integer number</param>
        /// <returns>Factorial value of a number x</returns>
        public long Recursive( int x ) =>
            ( x == 0 ) ? 1 : x * Recursive( x - 1 );


        /// <summary>
        /// Aggregate function LINQ
        /// </summary>
        /// <param name="x">Integer number</param>
        /// <returns>Factorial value of a number x</returns>
        public long Aggregate( int x ) =>
            ( x != 0 ) ? Enumerable.Range( 1, x ).Aggregate( ( a, b ) => a * b ) : 1;
    }
}
