using System;
using MathHelpers.Types;
using MathHelpers.Utils;
using MathHelpers.Global;

namespace MathHelpers.Prog
{
    internal class Vector2DPrg
    {
        public static void Test()
        {
            Console.Clear();
            Console.WriteLine( "<--- 2D Vector --->" );

            Point ps = new( 2, 2 );
            Point pe = new( 6, 4 );

            Vector2D vect = new( ps, pe );
            Console.WriteLine( vect );

            Menu.SubMenu.StartMenu( new string[] { "Main Menu", "Repeat item" }, new Action[] { Menu.MainMenu.Show, Test } );
        }
    }
}
