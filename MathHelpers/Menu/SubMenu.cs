using MathHelpers.Utils;
using System;

namespace MathHelpers.Menu
{
    internal static class SubMenu
    {
        public static void StartMenu( string[] item, Action[] action )
        {
            if ( item.Length != action.Length )
                throw new ArgumentException( "Invalid parameters!" );

            Console.WriteLine( "\n" + new string( '-', 25 ) );
            for ( int i = 0; i < item.Length; i++ )
                Console.WriteLine( $"{i}. {item[ i ]}" );
            Console.WriteLine( new string( '-', 25 ) );

            int choice = ReadNumValue.ReadInt( "Select option: ", n => n >= 0 && n <= item.Length - 1 );
            action[ choice ]();
        }
    }
}
