namespace Demo05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Session 05
            #region Casting [Boxing - Unboxing]
            //Boxing => casting from value type to reference type (safe)
            //Unboxing => casting from reference type to value type (unsafe)

            #region EX01
            object O1;
            O1 = "Ahmed";
            O1 = 1; // Casting [Value type -> Reference type] Boxing
            O1 = 'A'; // Casting [Value type -> Reference type] Boxing
            O1 = 1.5; // Casting [Value type -> Reference type] Boxing 
            #endregion

            #region EX02

            int X = 10;
            object Obj = X; // Boxing (safe casting)
            // Obj = new object(10);
            // Parent => Child 
            // Animal => Dog

            object Obj2 = 10;
            int Y = (int)Obj2; // Casting Unboxing (unsafe casting)
            //New object(10) => 10
            // Dog => Animal (Animal is a dog)

            Console.WriteLine(Y);

            #endregion

            object obj = 1; // Boxing 
            // we dont use it anymore because of the performance and memory issue
            // we use generics instead of boxing and unboxing

            #endregion
        }
    }
}
