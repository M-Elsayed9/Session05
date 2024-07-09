using System.ComponentModel;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Assignment05
{
    internal class Program
    {

        static int Sum(int X, int Y)
        {
            X++;
            Y++;

            return X + Y; 
        
        }

        static int Sum1(ref int X, ref int Y)
        {
            X++;
            Y++;

            return X + Y; 
        }
        static void Main(string[] args)
        {
            #region Question 1
            //1 - Explain the difference between passing(Value type parameters)
            //by value and by reference then write a suitable c# example.

            // Value types are stored in the stack, and reference types are stored in the heap.

            // By Value
            // When a value type parameter is passed by value, a copy of the variable
            // is passed to the method. Changes made to the parameter inside the method
            // do not affect the original variable.

            //int X = 10, Y = 33;

            //int Result = Sum(X, Y);
            //Console.WriteLine(Result);
            //Console.WriteLine($"X: {X}, Y: {Y}");

            //By Reference
            //When a value type parameter is passed by reference using the ref or out
            //keyword, the method receives a reference to the actual variable.
            //Changes made to the parameter inside the method do affect the original variable.

            //int X = 10, Y = 33;

            //int Result = Sum1(ref X, ref Y);
            //Console.WriteLine(Result);
            //Console.WriteLine($"X: {X}, Y: {Y}");

            #endregion

            #region Question 2

            //2 - Explain the difference between passing(Reference type parameters)
            //by value and by reference then write a suitable c# example.



            #endregion

            #region Question 3



            #endregion

            #region Question 4

            #endregion

            #region Question 5

            #endregion

            #region Question 6

            #endregion

            #region Question 7

            #endregion

            #region Question 8

            #endregion
        }
    }
}
