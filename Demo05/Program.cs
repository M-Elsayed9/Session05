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
        public static void PrintShape(int Count = 10, string Pattern = "*_*") // must give default values at the end 
        {
            for(int i = 0; i < Count; i++)
                Console.WriteLine(Pattern);
        }

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
        }


    }
}
