using G_NET_12_Adv01.NewFolder;
using System;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace G_NET_12_Adv01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:
            /*   What is a generic class? Why use generics?
             *  
            A Generic Class is a class that is defined with a type parameter 
            (usually denoted as <T>). 
            It allows you to write a class that can work with any data type while
            maintaining strong type checking. 
            You decide the actual type only when you create an instance of the class.

            * Why use generics ? 
            * 
            * Type Safety: The compiler checks the types at compile-time, 
            * reducing the risk of InvalidCastException during runtime. 
            * 
            * Reusability: You don't need to create multiple versions of the same 
            * class for different types (e.g., one for int, one for string).
            * 
            * Performance: Generics avoid "Boxing" and "Unboxing" operations
            * when working with value types, which leads to faster execution and less memory overhead.
            */
            #endregion

            #region Q2:
            /* 
            Container<int> intcon = new Container<int>();

            intcon.Add(10);
            intcon.Add (20);

            int num1 = intcon.Get(0);
            int num2 = intcon.Get(1);
            Console.WriteLine();
            Console.WriteLine($"The stored number is: {num1}");
            Console.WriteLine($"The stored number is: {num2}");
            Console.WriteLine();
            //===================================================

            Container <string> stringcon = new Container<string>();

            stringcon.Add("laila");
            stringcon.Add("Assmaa");

            string s1 = stringcon.Get(0);
            string s2 = stringcon.Get (1);

            Console.WriteLine($"The Stored  Name is : {s1}");
            Console.WriteLine($"The Stored  Name is : {s2}");
            */
            #endregion

            #region Q3:
             
            #region 1
            // What are multiple type parameters? 
            /*
            Multiple Type Parameters allow a generic class, interface, or method to work 
            with more than one unknown data type at the same time.
            Instead of using just <T>, we can use multiple placeholders like<TKey, TValue> 
            or<T1, T2>.This is useful when we need to define a relationship 
            between two different types of data.
           */
            #endregion

            #region 2
            //Write Pair<TKey, TValue>.
            /*
            Pair<int, bool> mpair = new Pair <int, bool>(2, true);
            mpair.Display();

            Console.WriteLine();

            Pair<char, decimal> npair = new Pair<char, decimal>('B', 4000.00M);
            npair.Display();
            */
            #endregion
            #endregion

            #region Q4: 
            #region 1
            //What is a generic method? 
            /*
            A Generic Method is a method that is declared with type parameters (usually <T>).
            This allows the method to perform the same logic on different data types 
            (like int, double, or string) without overloading the method for each type. 
            It provides Type Safety and reduces Code Duplication.
            */
            #endregion

            #region 2
            //* Write Swap<T> method.
            /*
             * 
            int x = 50;
            int y = 100;
            Console.WriteLine("---------Before Swap ---------");
            Console.WriteLine($"X : {x} --- Y : {y}");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("--------After Swap ----------");
            Utilities.Swap<int>(ref x, ref y);
            Console.WriteLine($"X : {x} --- Y {y}");

            Console.WriteLine("");
            Console.WriteLine("");
            //-----------------------------------------

            string first = "Mohamed";
            string last  = " Ahmed ";

            Console.WriteLine("--------Before Swap --------");
            Console.WriteLine($"First : {first} --- Last : {last}");
            // frist : Mohamed    // last : Ahmed 

            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("--------After Swap ----------");

            Utilities.Swap<string>(ref first, ref last);
            Console.WriteLine($"First : {first} --- Last : {last}");
            // frist : Ahmed    // last : Mohamed
            */

            #endregion
            #endregion

            #region Q5:

            /* 
            int maxint = Utilities.FindMax(20, 30);
            Console.WriteLine($"Max Number: {maxint}");

            Console.WriteLine("");

            decimal maxdec = Utilities.FindMax(2000.00m, 1000.00m);
            Console.WriteLine($"Max Number : {maxdec}");

            Console.WriteLine("");

            string max = Utilities.FindMax("A", "C");
            Console.WriteLine($"Max Letter : {max}");
            */
            #endregion

            #region Q6:
             
            #region 1
            // What is a generic interface? 
            /*
             * A Generic Interface is a blueprint for classes that allows them to
             * define methods and properties without specifying the exact data type
             * until the interface is implemented. 
             * It uses a placeholder (usually <T>) to ensure type safety and code reusability.

            */
            #endregion

            #region 2
            //Write IRepository<T>.
            /*

            RoomRepository re = new RoomRepository();
            //Add

            re.Add(new Room { id = 1  , RoomNumber = "101" });

            //Search
            Room r = re.GetById(1);

            Console.WriteLine($"Found Room:{r.RoomNumber}");
            */
            #endregion
            #endregion

            #region Q7: 

            #region 1 
            // What is the 'struct' constraint? 
            /*
             * The struct constraint specifies that the type argument T must be 
             * a Value Type (non-nullable). It prevents the use of Reference Types 
             * like classes or strings for that specific generic parameter
            */
            #endregion

            #region 2
            //Write an example.

            //  Helper.PrintValue(100); //int 
            //  Helper.PrintValue(true); // boll 
            //  Helper.PrintValue("Hello"); //string Erorr 
            #endregion

            #endregion

            #region Q8:
             
            #region
            //Q8: What is the 'class' constraint? 
            /*
             * The class constraint specifies that the type argument T must be a Reference Type.
             * It ensures that the type can be assigned a null value and prevents the use of
             * Value Types like int or struct.
            */
            #endregion

            #region 
            // Write an example.
            // HelperClass.Checknull("Malak"); //string

            // HelperClass.Checknull(10); //int // value type // error

            #endregion

            #endregion

            #region Q9: 

            #region 1
            //What is the 'new()' constraint? 
            /*
             * The new() constraint specifies that the type argument T must have a public
             * parameterless constructor. It allows the generic method to create
             * a new instance of the type.
            */
            #endregion

            #region 2
            // Write an example.
            // Employee emp = Factory.Create<Employee>();
            #endregion

            #endregion

            #region Q10:
             
            #region 1
            //Q10:  What is the interface constraint? 

            /*  The interface constraint specifies that the type argument T must implement
             *  a specific interface. This allows the generic method to call members defined
             *  in that interface safely.
             *  */
            #endregion

            #region 2
            //Write an example.
            /*
            Document doc = new Document();
            Printer.Show(doc);

            Photo Ph = new Photo();
            Printer.Show(Ph);
            */
            #endregion

            #endregion

            #region Q11: 

            #region 1
            //Q11: What is the base class constraint? 
            /*
             * The base class constraint specifies that the type argument T must be
             * or derive from a specific base class. This allows the generic method to 
             * access all public members of that base class.
            */
            #endregion

            #region 2
            //Write an example.
            //  Circle C = new Circle {Color = "Red" };
            //  ShapeHelper.ShowColor(C);

            #endregion

            #endregion

            #region Q12:

            #region 1
            //Q12: How do you apply multiple constraints?

            /*  Multiple constraints are applied by listing them after 
             *  the where keyword, separated by commas. 
             *  The order must be: Base Class (if any), then Interfaces, 
             *  and finally new(). 
             /* (الكلاس الأساسي أولاً، ثم الواجهات، وأخيراً قيد ()new). */
            #endregion

            #region 2
            //Write an example.
            // Report report = new Report();

            // Manager.Process(report);
            #endregion

            #endregion

            #region Q13:

            #region 1
            // : What does the 'default' keyword do in generics ?
            /* The default keyword returns the default value of a type 
             * parameter T. For Reference Types (classes), it returns null.
             * For Value Types (int, bool, etc.), it returns the initial
             * value (e.g., 0 for numbers or false for booleans).  */
            #endregion
            //------------
            #region 2
            /*
            int defint = Default.GetDefaultValue<int>();
            Console.WriteLine(defint); //0

            string defstring = Default.GetDefaultValue<string>();
            Console.WriteLine(defstring); // null

            bool defbool = Default.GetDefaultValue<bool>();
            Console.WriteLine(defbool); //false
            */

            #endregion

            #endregion

            #region Q14:

            #region 1
            // Write a SafeList<T> that returns default when the index is invalid.
            /* A SafeList<T> uses a generic list and a method to check
             * if the provided index is within the valid range. If not, 
             * it returns default(T) instead of throwing an exception.
             * */
            #endregion

            #region 2
            /*
            SafeList<int> S = new SafeList<int>();
            S.Add(30);  //0
            S.Add(50);  //1
            S.Add(100); //2
            S.Add(15); //3
                       //Count 4
            Console.WriteLine(S.GetItem(2));
            Console.WriteLine();
            Console.WriteLine(S.GetItem(3));
            Console.WriteLine();
            Console.WriteLine(S.GetItem(5)); // default 
            */
            #endregion

            #endregion

            #region Q15:

            #region 1
            //Q15: What is covariance?

            /*  Covariance allows you to use a more derived type than originally specified.
             *  In C#, it is applied to Interfaces and Delegates using the out keyword. */
            //==============================

            // Explain the 'out' keyword.

            /*  The out keyword marks a type parameter as covariant. 
             *  This means the type T can only be used as a return type of methods, 
             *  not as an input parameter. */

            #endregion
            #endregion

            #region Q16:
            /*
             * Q16: What is contravariance? 
             * Contravariance allows you to use a less derived type (Base class) 
             * than originally specified. In C#, it is applied to Interfaces and
             * Delegates using the in keyword.
             * 
             * Explain the 'in' keyword.
             * 
             * The in keyword marks a type parameter as contravariant.
             * This means the type T can only be used as an input parameter 
             * for methods, not as a return type.
            */
            #endregion

            #region Q17:
            /*
             * Q17: What is the difference between covariance and contravariance?
             * 
             * The difference lies in the direction of the type conversion
             * and how the type parameter T is used (either as an input or an output).
             * 
             * Covariance (out keyword):
             * 
             * Covariance allows a method to return a more derived type (Child)
             * than the one specified in the generic interface. It uses 
             * the out keyword because the type T is only used as an Output
             * (return type).
             * 
             * Logic:   Animal = Dog (A Dog is an Animal).
             * 
             * -------------------------------------------------
             * 
             * Contravariance (in keyword):

             * Contravariance allows a method to accept a less derived type
             * (Base/Parent) than the one specified. It uses the in keyword because
             * the type T is only used as an Input (parameter)
             * 
             * Logic: Dog = Animal 
             * (Someone who can handle all Animals can definitely handle a Dog).
             * 
            */
            #endregion

            #region Q18:
            /*  
             *   How do static members work in generic types?
             *  
             *  Static members in a generic class are not shared between 
             *  different closed types. The .NET Runtime creates a separate instance
             *  of the static member for each unique type argument 
             *  (e.g., int and string). Each type version maintains its own 
             *  independent static state.
             *  
             */
            #endregion

            #region Q19:
            /*  
             *  
             * How can you inherit from a generic class?
             *  
             *  There are two main ways to inherit from a generic class:
             *  
             * Generic Inheritance: The child class remains generic 
             * (e.g., Child<T> : Parent<T>).

             * Concrete Inheritance: The child class specifies a concrete type
             * for the parent (e.g., Child : Parent<int>).
             *  
             */
            #endregion

            #region Q20:
            // in MyChache 
            // We haven't had this point explained to us yet.
            #endregion

        }
    }
}
