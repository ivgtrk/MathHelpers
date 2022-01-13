using System;
using System.Collections.Generic;
using System.Linq;
using MathHelpers.Utils;

namespace MathHelpers.Menu
{
    internal static class MainMenu
    {
        
        static readonly Dictionary<int, string> Items = new()
        {
            { 1, "Complex numbers" },
            { 2, "Factorial" },
            { 3, "Quadratic equations" },
            { 4, "Fibonacci" },
            { 5, "Vector 2D" },
            { 6, "Vector 3D" },
            { 7, "Reverse Polish Notation" },
        };

        public static void Show() 
        {
            Console.Clear();
            Console.WriteLine( "Available options:" );

            // Print Menu items
            foreach ( KeyValuePair<int, string> pair in Items )
                Console.WriteLine( $"{pair.Key}. {pair.Value}" );
            Console.WriteLine( new string( '-', 25 ) );
            
            // Select option
        label1:
            int item = ReadNumValue.ReadInt( "Select option: ", n => n > 0 && n <= Items.Count );

            if ( !Items.Keys.Contains( item ) )
            {
                Console.WriteLine( $"Items does not contain option '{item}'" );
                goto label1;
            }

            // Correct input value
            Console.Clear();
            Console.WriteLine( $"Selected item: {item} - {Items[ item ]}" );
            Console.WriteLine( new string( '-', 25 ) + "\n0. Exit\n1. Start\n" + new string( '-', 25 ) );
            int choice = ReadNumValue.ReadInt( "Select option: ", n => n == 0 || n == 1 );

            if ( choice == 0 ) Show();

            // Start selected item...
            Manager _ = new( item );
            Console.Read();
        }
    }
}
