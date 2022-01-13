using System;
using MathHelpers.Types;
using MathHelpers.Utils;
using System.Collections.Generic;


namespace MathHelpers.Prog
{
    internal class FibonacciPrg
    {
        public static void Test()
        {
            Console.Clear();
            Console.WriteLine( "<--- Fibonacci --->" );
            Fibonacci f = new();

            int count = ReadNumValue.ReadInt( "Count of numbers [ 3 <= N ]: ", n => n >= 3 );
            List<int> fibonacciList = f.Generate( count );
            Console.WriteLine( string.Join( ", ", fibonacciList ) );
            
            Menu.SubMenu.StartMenu( new string[] { "Main Menu", "Repeat item" }, new Action[] { Menu.MainMenu.Show, Test } );
        } 
    }
}
