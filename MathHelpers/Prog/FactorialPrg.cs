using System;
using MathHelpers.Types;
using MathHelpers.Utils;

namespace MathHelpers.Prog
{
    internal class FactorialPrg
    {
        public static void Test()
        {
            Console.Clear();
            Factorial f = new();

            Console.WriteLine( "<-- Finding the factorial of a number -->" );
            int num = ReadNumValue.ReadInt( "Enter a number [0 >= N <= 12]: ", n => n >= 0 && n <= 12 );

            Console.WriteLine( $"\nCalculating the factorial of a number '{num}' via Recursive algorithm:\n" +
                $"Factoiral = {f.Recursive( num )}" );

            Console.WriteLine( $"\nCalculating the factorial of a number '{num}' via Aggregate function LINQ:\n" +
                $"Factoiral = {f.Aggregate( num )}" );

            Menu.SubMenu.StartMenu( new string[] { "Main Menu", "Repeat item" }, new Action[] { Menu.MainMenu.Show, Test } );
        }
    }
}
