using System;
using System.Collections.Generic;
using System.Drawing;

namespace MathHelpers.Types
{
    internal class Fibonacci
    {
        /// <summary>
        /// Fibonacci numbers generator
        /// </summary>
        /// <param name="n">Count of the numbers</param>
        /// <returns>List<int> contains numbers</int></returns>
        public List<int> Generate( int n )
        {
            List<int> res = new() { 0, 1, 1 };
            int fib, f = 1, s = 1;

            int count = 2;
            while ( n - 1 > count )
            {
                fib = f + s;
                f = s;
                s = fib;
                res.Add( fib );
                count++;
            }
            return res;
        }
    }
}
