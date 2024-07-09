using System.ComponentModel;
using System.Data.Common;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Threading.Channels;

namespace Assignment05
{
    internal class Program
    {

        //static int Sum(int X, int Y)
        //{
        //    X++;
        //    Y++;

        //    return X + Y; 

        //}

        //static int Sum1(ref int X, ref int Y)
        //{
        //    X++;
        //    Y++;

        //    return X + Y; 
        //}

        //static int Sum(int[] Nums)
        //{
        //    int sum = 0;

        //    for(int i = 0; i < Nums.Length; i++) // affects the original object
        //    {
        //        Nums[i]++;
        //    }

        //    Nums = new int[] {10, 20, 30 ,40, 50 }; // does not affect the original object and does not change its reference 

        //    for (int i = 0; i < Nums.Length; i++)
        //    {
        //        sum += Nums[i];
        //    }

        //    return sum;
        //}

        //static int Sum1(ref int[] Nums)
        //{
        //    int sum = 0;

        //    for (int i = 0; i < Nums.Length; i++) // affects the original object
        //    {
        //        Nums[i]++;
        //    }

        //    Nums = new int[] { 10, 20, 30, 40, 50 }; // does affect the original object and change its reference 

        //    for (int i = 0; i < Nums.Length; i++)
        //    {
        //        sum += Nums[i];
        //    }

        //    return sum;
        //}

        //static void SumMinus(int X, int Y, out int SumResult, out int MinusResult)
        //{
        //    SumResult = X + Y;

        //    MinusResult = X - Y;

        //}
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

            // By Value
            //When a reference type parameter is passed by value, a copy of the reference(not the object)
            //is passed to the method. This means the method works with the same object, but reassigning
            //the parameter to a new object inside the method does not affect the original reference.

            //int[] Nums = { 1, 2, 3, 4, 5 };

            //int Result = Sum(Nums);

            //foreach (int i in Nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(Result);

            //By Reference
            //When a reference type parameter is passed by reference using the ref keyword,
            //the method can modify the reference itself, making it point to a different object.
            //Any changes to the object itself will still affect the original reference.

            //int[] Nums = { 1, 2, 3, 4, 5 };

            //int Result = Sum1(ref Nums);

            //foreach (int i in Nums)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(Result);
            #endregion

            #region Question 3

            // 3 - Write a c# Function that accept 4 parameters from user and
            // return result of summation and subtracting of two numbers

            //int X = 10, Y = 20, SumResult, MinusResult;

            //SumMinus(X, Y, out SumResult, out MinusResult);

            //Console.WriteLine($"Sum Result: {SumResult}, Minus Result: {MinusResult} ");

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
