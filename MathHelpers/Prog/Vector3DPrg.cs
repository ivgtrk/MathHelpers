using System;
using MathHelpers.Types;
using MathHelpers.Utils;
using MathHelpers.Global;

namespace MathHelpers.Prog
{
    internal class Vector3DPrg
    {
        public static void Test()
        {
            Console.Clear();
            Console.WriteLine( "<--- 3D Vector --->" );
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write( "\nThis section is currently under development.\n" +
                            "Will be added in the following commits.\n" );
            Console.ResetColor();
            Console.WriteLine( "\nPress [Enter] for exit to Main Menu..." );
            Console.ReadKey();
            Menu.MainMenu.Show();
        }
    }
}
