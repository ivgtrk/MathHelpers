using System;
using System.Collections.Generic;

namespace MathHelpers.Types
{
    internal class RPN
    {
        /// <summary>
        /// The method returns true if the checked character is a separator ("space" or "equal")
        /// </summary>
        static private bool IsDelimeter( char c )
        {
            if ( ( " =".IndexOf( c ) != -1 ) )
                return true;
            return false;
        }


        /// <summary>
        /// The method returns true if the checked character is an operator
        /// </summary>
        static private bool IsOperator( char с )
        {
            if ( ( "+-/*^()".IndexOf( с ) != -1 ) )
                return true;
            return false;
        }


        /// <summary>
        /// The method returns the operator priority
        /// </summary>
        static private byte GetPriority( char s )
        {
            byte b = s switch
            {
                '(' => 0,
                ')' => 1,
                '+' => 2,
                '-' => 3,
                '*' => 4,
                '/' => 4,
                '^' => 5,
                _ => 6
            };
            return b;
        }


        /// <summary>
        /// The "input" method of the class
        /// </summary>
        static public double Calculate( string input )
        {
            string output = GetExpression( input ); // Converting the expression to a postfix entry
            double result = Counting( output ); // Solving the resulting expression
            return result;
        }


        /// <summary>
        /// Get Expression
        /// </summary>
        static private string GetExpression( string input )
        {
            string output = string.Empty; // String to store the expression
            Stack<char> operStack = new Stack<char>(); // Stack for storing operators

            // For each character in the input string
            for ( int i = 0; i < input.Length; i++ ) 
            {
                // We skip the separators
                if ( IsDelimeter( input[ i ] ) )
                    continue; // Moving on to the next character

                // If the symbol is a digit, then we read the whole number
                if ( Char.IsDigit( input[ i ] ) ) //Если цифра
                {
                    // We read up to the separator or operator to get the number
                    while ( !IsDelimeter( input[ i ] ) && !IsOperator( input[ i ] ) )
                    {
                        // Adding each digit of the number to our string
                        output += input[ i ]; 
                        i++; // Moving on to the next character

                        // If the symbol is the last one, then we exit the loop
                        if ( i == input.Length ) break; 
                    }

                    output += " "; // We add a space after the number to the string with the expression
                    i--; // Going back one character to the character before the separator
                }

                // If the symbol is an operator
                if ( IsOperator( input[ i ] ) ) // If the operator
                {
                    if ( input[ i ] == '(' ) // If the character is an opening parenthesis
                        operStack.Push( input[ i ] ); // We write it to the stack
                    else if ( input[ i ] == ')' ) // If the character is a closing parenthesis
                    {
                        // We write out all the operators up to the opening parenthesis in the string
                        char s = operStack.Pop();

                        while ( s != '(' )
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else // If any other operator
                    {
                        // If there are elements in the stack
                        if ( operStack.Count > 0 )

                            // And if the priority of our operator is less than or equal to the priority of the operator at the top of the stack
                            if ( GetPriority( input[ i ] ) <= GetPriority( operStack.Peek() ) )

                                // Then we add the last operator from the stack to the string with the expression
                                output += operStack.Pop().ToString() + " ";

                        // If the stack is empty, or the operator's priority is higher, we add operators to the top of the stack
                        operStack.Push( char.Parse( input[ i ].ToString() ) );

                    }
                }
            }

            // When we have passed through all the characters, we throw all the remaining operators out of the stack into a string
            while ( operStack.Count > 0 )
                output += operStack.Pop() + " ";

            // Returning the expression in the postfix entry
            return output;
        }


        /// <summary>
        /// Calculation
        /// </summary>
        static private double Counting( string input )
        {
            double result = 0;
            Stack<double> temp = new Stack<double>(); // Stack for solution

            for ( int i = 0; i < input.Length; i++ ) // For each character in the string
            {
                // If the symbol is a digit, then we read the whole number and write it to the top of the stack
                if ( Char.IsDigit( input[ i ] ) )
                {
                    string a = string.Empty;

                    while ( !IsDelimeter( input[ i ] ) && !IsOperator( input[ i ] ) ) // Not yet a separator
                    {
                        a += input[ i ]; // Adding
                        i++;
                        if ( i == input.Length ) break;
                    }
                    temp.Push( double.Parse( a ) ); // Writing to the stack
                    i--;
                }
                else if ( IsOperator( input[ i ] ) ) // If the symbol is an operator
                {
                    // We take the last two values from the stack
                    double a = temp.Pop();
                    double b = temp.Pop();

                    switch ( input[ i ] ) // And we perform an action on them, according to the operator
                    {
                        case '+': result = b + a; break;
                        case '-': result = b - a; break;
                        case '*': result = b * a; break;
                        case '/': result = b / a; break;
                        case '^': result = double.Parse( Math.Pow( double.Parse( b.ToString() ), double.Parse( a.ToString() ) ).ToString() ); break;
                    }
                    temp.Push( result ); // The result of the calculation is written back to the stack
                }
            }
            return temp.Peek(); // We take the result of all calculations from the stack and return it
        }
    }
}
