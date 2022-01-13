using System;
using MathHelpers.Types;

namespace MathHelpers.Prog
{
    internal class RPNProg
    {
        public static void Test()
        {
            Console.Clear();
            Console.WriteLine( "<--- Reverse Polish Notation --->" );


            Console.WriteLine( "\nA few examples of expressions:" );
            string expr = "8 + (5 * 4) - 12 + (3 * 7)";
            Console.WriteLine( $"{expr} = {RPN.Calculate( expr )}" );
            expr = "5^2 + 55 * (9 / 3)";
            Console.WriteLine( $"{expr} = {RPN.Calculate( expr )}" );
            expr = "3/2 + 5/2 + 7/2";
            Console.WriteLine( $"{expr} = {RPN.Calculate( expr )}" );

            Console.Write( "Enter expresssion: " );
            expr = Console.ReadLine();
            Console.WriteLine( $"{expr} = {RPN.Calculate( expr )}" );

            Menu.SubMenu.StartMenu( new string[] { "Main Menu", "Repeat item" }, new Action[] { Menu.MainMenu.Show, Test } );
        }
    }
}
