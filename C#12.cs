using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
// 6️⃣ Alias Any Type
using MyInt = System.Int32;
using ListOfStrings = System.Collections.Generic.List<string>;

namespace project_echallenge
{
    internal class C_12
    {

        // 1️⃣ Primary Constructor
        public class Person(string name, int age)
        {
            public void Display() => Console.WriteLine($"🔹 Primary Constructor: {name}, {age} years old");
        }

        public void TestPrimaryConstructor()
        {
            var person = new Person("Ayoub", 25);
            person.Display();
        }

        // 2️⃣ Collection Expressions
        public void TestCollectionExpressions()
        {
            int[] numbers = [1, 2, 3, 4, 5];
            List<string> names = ["Alice", "Bob", "Charlie"];

            Console.WriteLine($"🔹 Collection Expression: {string.Join(", ", numbers)}");
            Console.WriteLine($"🔹 Collection Expression (List): {string.Join(", ", names)}");
        }

        // 3️⃣ Inline Arrays
        [InlineArray(3)]
        public struct InlineArrayExample
        {
            private int _values;
        }

        public void TestInlineArrays()
        {
            InlineArrayExample array = default;
            array[0] = 10;
            array[1] = 20;
            array[2] = 30;

            Console.WriteLine($"🔹 Inline Array: {array[0]}, {array[1]}, {array[2]}");
        }

        // 4️⃣ Optional Parameters in Lambda Expressions
        public void TestOptionalParametersLambda()
        {


            var lambdaDemo = (string name = "User") => Console.WriteLine($"Hello {name}");

            lambdaDemo();
            lambdaDemo("Gandalf");
            Console.WriteLine($"Default parameter value is: {lambdaDemo.Method.GetParameters()[0].DefaultValue}");
        }


        // 5️⃣ ref readonly Parameters
        public void TestRefReadonlyParameters()
        {
            int num = 42;
            RefReadonlyMethod(ref num);
        }

        public void RefReadonlyMethod(ref readonly int value)
        {
            Console.WriteLine($"🔹 ref readonly Parameter: {value}");
        }



        public void TestAliasAnyType()
        {
            MyInt number = 100;
            ListOfStrings names = ["Alice", "Bob", "Charlie"];

            Console.WriteLine($"🔹 Alias Example: {number}");
            Console.WriteLine($"🔹 Alias List Example: {string.Join(", ", names)}");
        }

        // 7️⃣ Experimental Attribute
        //public class ExperimentalExample
        //{
        //        [Experimental("CS1234", "This method is experimental and may change.")]
        //        public void TestExperimental()
        //        {
        //            Console.WriteLine("🔹 Experimental API - Use with caution.");
        //        }
        //    }

        //public void TestExperimentalFeature()
        //    {
        //        var experimental = new ExperimentalExample();
        //        experimental.TestExperimental();
        //    }

        // 8️⃣ Interceptors (Preview Feature)
        //public static class InterceptorExample
        //{
        //    [InterceptsLocation("Program.cs", 10, 20)]
        //    public static void InterceptedMethod()
        //    {
        //        Console.WriteLine("🔹 This method has been intercepted!");
        //    }
        //}

        //public void TestInterceptors()
        //    {
        //        InterceptorExample.InterceptedMethod();
        //    }
        //}
    }
}
