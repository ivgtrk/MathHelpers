using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathHelpers.Utils
{
    internal static class ReadNumValue
    {
        /// <summary>
        /// Reading Integer value
        /// </summary>
        /// <param name="prompt">Prompt line</param>
        /// <param name="condition">Integer range of the input values</param>
        /// <returns>Integer input value if correct</returns>
        public static int ReadInt( string prompt, Predicate<int> condition )
        {
        label1:
            Console.Write( prompt );

            if ( !int.TryParse( Console.ReadLine(), out int result ) )
            {
                Console.WriteLine( "Entered character is not a number!" );
                goto label1;
            }
            else if ( !condition( result ) )
            {
                Console.WriteLine( $"Entered value out of range!" );
                goto label1;
            }
            return result;
        }


        /// <summary>
        /// Reading Double value
        /// </summary>
        /// <param name="prompt">Prompt line</param>
        /// <param name="condition">Double range of the input values</param>
        /// <returns>Double input value if correct</returns>
        public static double ReadDouble( string prompt, Predicate<double> condition )
        {
        label1:
            Console.Write( prompt );

            if ( !double.TryParse( Console.ReadLine(), out double result ) )
            {
                Console.WriteLine( "Entered character is not a number!" );
                goto label1;
            }
            else if ( !condition( result ) )
            {
                Console.WriteLine( $"Entered value out of range!" );
                goto label1;
            }
            return result;
        }
    }
}
