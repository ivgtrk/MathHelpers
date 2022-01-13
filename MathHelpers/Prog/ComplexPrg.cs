using System;
using MathHelpers.Types;
using MathHelpers.Utils;


namespace MathHelpers.Prog
{
    internal class ComplexPrg
    {
        public static void Test()
        {
            Console.Clear();
            Complex c1 = new();
            Complex c2 = new();
            Console.WriteLine( "<--- Complex Number --->" );
            c1.r = ReadNumValue.ReadDouble( "Real part 1'st complex number [Re]: ", n => n >= -100.0 && n <= 100.0 );
            c1.i = ReadNumValue.ReadDouble( "Imaginary part 1'st complex number [Im]: ", n => n >= -100.0 && n <= 100.0 );
            c2.r = ReadNumValue.ReadDouble( "Real part 2'nd complex number [Re]: ", n => n >= -100.0 && n <= 100.0 );
            c2.i = ReadNumValue.ReadDouble( "Imaginary part 2'nd complex number [Im]: ", n => n >= -100.0 && n <= 100.0 );

            Console.Clear();
            Console.WriteLine( "<--- Complex Number --->" );
            Console.WriteLine( "Introduced complex numbers: " );
            Console.WriteLine( c1.ToString() + '\n' + c2.ToString() );
            Console.WriteLine();

            Console.WriteLine( "Addition of complex numbers:            {0} + {1}i", ( c1 + c2 ).r, ( c1 + c2 ).i );
            Console.WriteLine( "Subtraction of complex numbers:         {0} + {1}i", ( c1 - c2 ).r, ( c1 - c2 ).i );
            Console.WriteLine( "Multiplication of complex numbers:      {0} + {1}i", ( c1 * c2 ).r, ( c1 * c2 ).i );

            Menu.SubMenu.StartMenu( new string[] { "Main Menu", "Repeat item" }, new Action[] { Menu.MainMenu.Show, Test } );
        }
    }
}
