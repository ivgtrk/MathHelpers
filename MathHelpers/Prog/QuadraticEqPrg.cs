using System;
using MathHelpers.Types;
using MathHelpers.Utils;

namespace MathHelpers.Prog
{
    internal class QuadraticEqPrg
    {
        public static void Test()
        {
            Console.Clear();
            Console.WriteLine( "<-- Quadratic Equation [ах^2 + bх + с = 0] -->" );
            double a = ReadNumValue.ReadDouble( "Enter koefficient a: ", n => n >= -500.0 && n <= 500.0 );
            a = a == 0 ? 1 : a; // Default value 1

            double b = ReadNumValue.ReadDouble( "Enter koefficient b: ", n => n >= -500.0 && n <= 500.0 );
            b = b == 0 ? 10 : b; // Default value 10

            double c = ReadNumValue.ReadDouble( "Enter koefficient c: ", n => n >= -500.0 && n <= 500.0 );
            c = c == 0 ? 16 : c; // Default value 16

            QuadraticEq eq = new( a, b, c );
            Console.WriteLine( $"\nEquation: {eq}\n" );
            eq.Calc();

            Menu.SubMenu.StartMenu( new string[] { "Main Menu", "Repeat item" }, new Action[] { Menu.MainMenu.Show, Test } );
        }
    }
}
