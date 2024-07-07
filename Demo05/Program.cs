using System.Reflection.Metadata.Ecma335;

namespace Demo05
{
    // can write 4 types of things in a namespace
    // 1. Class (Reference Type)
    // 2. Struct (Value Type)
    // 3. Interface (Reference Type)
    // 4. Enum (Value Type)
    internal class Program
    {
        //Class can contain 
        // 1. Functions
        // 2. Data

        // 1. Function 
        // 1.1 Class member function (static function)
        // 1.2 Object member function (Non-static function) instance function

        // (*_*) -> 10
        //public static void PrintShape(int Count = 10, string Pattern = "*_*") // must give default values at the end 
        //{
        //    for(int i = 0; i < Count; i++)
        //        Console.WriteLine(Pattern);
        //}


        //public static void Swap(ref int X, ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static int SumArray(int[] Arr)
        //{
        //    int Sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        //public static int SumArray(ref int[] Arr)
        //{
        //    int Sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr[0] = 100;
        //        for (int i = 0; i < Arr.Length; i++)
        //            Sum += Arr[i];
        //    }
        //    return Sum;
        //}

        //public static int SumArray(ref int[] Arr)
        //{
        //    int sum = 0;
        //    if (Arr is not null)
        //    {
        //        Arr = new int[] {4, 5, 6 };
        //        for (int i = 0; i < Arr.Length; i++)
        //            sum += Arr[i];
        //    }
        //    return sum;
        //}

        //static Data SumMul(int x, int y)
        //{
        //    int Sum = x + y;
        //    int Mul = x * y;
        //    Data D = new Data();
        //    D.Sum = Sum;
        //    D.Mul = Mul;

        //    // return D; // or
        //    return new Data() { Sum = Sum,, Mul = Mul };

        //}

        //static void SumMul(int x, int y, out int Sum, out int Mul)
        //{
        //    Sum = x + y; 
        //    Mul = x * y; // must return both out put parameters 
            

        //}
        // Entry Point
        static void Main(string[] args)
        {
            // Session 05
            #region Casting [Boxing - Unboxing]
            //Boxing => casting from value type to reference type (safe)
            //Unboxing => casting from reference type to value type (unsafe)

            #region EX01
            //object O1;
            //O1 = "Ahmed";
            //O1 = 1; // Casting [Value type -> Reference type] Boxing
            //O1 = 'A'; // Casting [Value type -> Reference type] Boxing
            //O1 = 1.5; // Casting [Value type -> Reference type] Boxing 
            //#endregion

            //#region EX02

            //int X = 10;
            //object Obj = X; // Boxing (safe casting)
            //// Obj = new object(10);
            //// Parent => Child 
            //// Animal => Dog

            //object Obj2 = 10;
            //int Y = (int)Obj2; // Casting Unboxing (unsafe casting)
            ////New object(10) => 10
            //// Dog => Animal (Animal is a dog)

            //Console.WriteLine(Y);

            #endregion

            /*object obj = 1;*/ // Boxing 
                                // we dont use it anymore because of the performance and memory issue
                                // we use generics instead of boxing and unboxing

            #endregion

            #region Nullable Type

            // Null as a value is valid only with reference type

            #region Value Type C# 2.0 2005

            #region EX01
            // int X = null; // Error because int is a value type (non nullable)
            // int X => X allow only int numbers

            //int? Y = null; // Nullable type (int?) allow null as a value
            //int X = 10;
            //int? Z = Y; // Z = null
            //int? Z2 = X; // Z2 = 10
            //int? Z3 = Z;

            ////int? Num; 
            ////Nullable<int> Num; // Nullable is a struct that allow null as a value

            //decimal Num01 = 1m;
            //decimal? Num02 = Num01; // works

            //decimal? Num03 = Num02;
            // Num01 = Num02; does not work  
            #endregion

            #region EX02
            //int X = 10;
            //int? Y = X; //Valid implicit casting

            //int? Num01 = null;
            //int Num02 = (int)Num01; // Explicit casting (unsafe casting)
            ////invalid operartion => exception

            //int? K = null;
            //int L;
            //L = (int)K; // (unsafe)

            //if (K != null)
            //{
            //    L = (int)K; //Casting safe
            //}
            //else
            //{
            //    L = 0;
            //}

            //// or

            //if (K.HasValue)
            //{
            //    L = K.Value; // Not Casting (safe)
            //}
            //else
            //{
            //    L = 0;
            //}

            //or 

            //L = K.HasValue ? K.Value : 0;
            //L = L != null ? (int)K : 0;

            #endregion

            #endregion

            #region Reference Type C# 8.0 2019
            // Null is default value of reference type
            // STRING IS NON NULLABLE REFERENCE TYPE
            #region EX01
            //string Message; // null

            //Message = null; // valid with warning
            //Message = null!; // null -forgiving operator

            //string? Message2 = null; // nullable reference type
            //// valid without warning

            //Console.WriteLine(Message); // null 
            #endregion

            #region EX02
            //Employee Emp = new Employee();

            //string NotNull = "Hello";

            //string? NullableString = default;

            // NullableString = NotNull; // valid
            //NotNull = NullableString; // valid
            // NotNull = NullableString; // invalid 
            #endregion

            #endregion

            #endregion

            #region Null Propagation/ Coleasceing operator 

            #region EX01
            ////int[] Numbers = default; // Null

            ////for (int i = 0; Numbers != null && i < Numbers.Length; i++)
            ////{
            ////    Console.WriteLine(Numbers[i]); // Null reference exception handled poorly
            ////}

            ////for (int i = 0; i < Numbers?.Length; i++)
            ////{
            ////    Console.WriteLine(Numbers[i]); // Null reference exception handled poorly
            ////}

            ////if(Numbers != null)
            ////{
            ////    for (int i = 0; i < Numbers.Length; i++)
            ////    {
            ////        Console.WriteLine(Numbers[i]); // Null reference exception handled correctly
            ////    }
            ////}


            ////foreach ( int Num in Numbers)
            ////{
            ////    Console.WriteLine(Num); // Null reference exception not handled
            ////}

            //// NUmbers = null -> (Numbers?.Length) => null
            //// Numbers != null -> (Numbers?.Length) => Numbers.Length


            //// null propagation operator ?

            //// null coalescing operator ??

            ////int Length = Numbers?.Length ?? 0; // 0 
            #endregion

            #region EX02

            //Employee Emp1 = new Employee();
            // Emp1 (id = 0, Name = null, Department = null)

            // Emp1.Department = new Department();
            // Emp1 (id = 0, Name = null, Department = (Code = 0, Name = null))

            //if (Emp1 != null)
            //{
            //    if (Emp1.Department != null)
            //    {
            //        Console.WriteLine(Emp1.Department.Name); // Null reference exception handled
            //    }
            //}

            // Console.WriteLine(Emp1?.Department?.Name ?? "Department Not Found"); // Null reference exception handled
            #endregion

            #endregion

            #region Functions 

            #region Passing parameters

            #region EX01
            // printShape(); without parameters
            // PrintShape(10, "*_*"); // Passing Parameters with order
            // PrintShape("*_*", 10); // invalid
            // PrintShape(Pattern: "*_*", Count: 10); // Passing Parameters By name

            // PrintShape(); // using default values
            // PrintShape(Count: 5); // using default values
            // PrintShape(Pattern: "A_B"); // using default values

            //Hello to Route
            // Welcome Aliaa

            // Console.WriteLine("Hello to Route\nWelcome \t Aliaa");
            // \n => new line
            // \t => tab

            // C:\Users\muham\source\repos\Session05\Demo05\Demo05.csproj

            // string Path = "C:\\Users\\muham\\source\\repos\\Session05\\Demo05\\Demo05.csproj";
            // string Path1 = @"C:\Users\muham\source\repos\Session05\Demo05\Demo05.csproj";
            // Skipping the escape character
            // Skip \ => \\
            // Skip \ => @

            // 10 -> /*\ 
            // PrintShape("/*\", 10); // invalid
            // PrintShape(10, @"/*\");   
            #endregion

            #region Passing value type parameters
            // int, double, float, decimal, char, bool, struct

            #region Passing by value
            //int A = 10;
            //int B = 20;
            //Console.WriteLine($"A = {A}, B = {B}"); // A = 10, B = 20

            //Swap(A, B); // passing by value only and not by reference
            //Console.WriteLine($"A = {A}, B = {B}"); // A = 10, B = 20
            #endregion

            #region Passing by reference
            //int A = 10;
            //int B = 20;
            //Console.WriteLine($"A = {A}, B = {B}"); // A = 10, B = 20

            //Swap(ref A, ref B); // passing by reference input/output
            //Console.WriteLine($"A = {A}, B = {B}"); // A = 10, B = 20

            #endregion

            #endregion

            #region Passing reference type parameters
            // string, class, interface, enum, array

            #region by value
            //int[] Nums = { 1, 2, 3, 4, 5 };
            // Nums -> Reference [Address of Array] 

            //int Sum = SumArray(Nums); //passing by value  arr = nums

            //Console.WriteLine(Sum);
            #endregion

            #region By reference

            #region EX01
            //int[] Nums = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(Nums[0]); // 1
            //int Sum = SumArray( ref Nums); //passing by reference  arr = nums
            //Console.WriteLine(Nums[0]); // 100 
            #endregion

            #region EX02

            #region By value
            //int[] Nums = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(Nums[0]); // 1
            //int Sum = SumArray(Nums); //passing by value  arr = adress of nums
            //Console.WriteLine(Nums[0]); // 1  


            #endregion

            #region By reference
            //int[] Nums = { 1, 2, 3, 4, 5 };

            //Console.WriteLine(Nums[0]); // 1
            //int Sum = SumArray(ref Nums); //passing by value  arr = adress of nums
            //Console.WriteLine(Nums[0]); // 1
            #endregion

            #endregion

            #endregion

            #endregion

            #region Passing by out

            //int A = 10, B = 20;

            //int Sum, Mul;

            //SumMul(A, B, out Sum, out Mul); // the out params are passed by reference by default
            ////SumMul(A, B, ref Sum, ref Mul); // must be initialized before passing by ref

            //Console.WriteLine($"Sum = {Sum}, Mul = {Mul}");

            // Out => Out parameter
            // Ref => input output parameter
            #endregion



            #endregion

            #endregion
        }


    }
}
