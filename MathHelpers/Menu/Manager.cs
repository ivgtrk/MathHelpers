using System;
using System.Collections.Generic;
using System.Reflection;
using MathHelpers.Prog;

namespace MathHelpers.Menu
{
    internal class Manager
    {
        public Manager( int item )
        {
            object o = Activator.CreateInstance( types[ item ] );
            Type t = types[ item ];
            MethodInfo method = t.GetMethod( "Test" );
            method?.Invoke( o, null );
        }


        static readonly Dictionary<int, Type> types = new()
        {
            [ 0 ] = null,
            [ 1 ] = typeof( ComplexPrg ),
            [ 2 ] = typeof( FactorialPrg ),
            [ 3 ] = typeof( QuadraticEqPrg ),
            [ 4 ] = typeof( FibonacciPrg ),
            [ 5 ] = typeof( Vector2DPrg ),
            [ 6 ] = typeof( Vector3DPrg ),
            [ 7 ] = typeof( RPNProg ),
        };
    }
}
