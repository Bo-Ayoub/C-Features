using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace project_echallenge
{


    internal class c_11
    {

        // 1️ Raw String Literals
        public void RawStringLiterals()
        {
            string json = """
        {
            "name": "Ayoub",
            "language": "Arabe"
        }
        """;
            Console.WriteLine("🔹 Raw String Literal:\n" + json);
        }

        // 2️ List Patterns
        public void ListPatterns()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            if (numbers is [1, .., 5])
            {
                Console.WriteLine("🔹 List Pattern matched!");
            }
        }

        // 3️⃣ Generic Math Support
        public T Add<T>(T a, T b) where T : INumber<T>
        {
            return a + b;
        }

        public void TestGenericMath()
        {
            Console.WriteLine($"🔹 Generic Math: {Add(10, 20)}");
            Console.WriteLine($"🔹 Generic Math: {Add(5.5, 2.3)}");
        }

        // 4️⃣ Generic Attributes
        public void GenericAttributes()
        {
            Console.WriteLine("🔹 Generic Attributes Example - No runtime impact.");
        }

        // 5️⃣ UTF-8 String Literals
        public void UTF8StringLiterals()
        {
            ReadOnlySpan<byte> utf8Bytes = "Hello C# 11"u8;
            Console.WriteLine("🔹 UTF-8 String Literal: " + System.Text.Encoding.UTF8.GetString(utf8Bytes));
        }

        // 6️⃣ Newlines in String Interpolation
        public void NewlineStringInterpolation()
        {
            string name = "Ayoub";
            Console.WriteLine($"""
        🔹 Name: {name}
        Welcome to C# 11!
        """);
        }

        // 7️⃣ File-Local Types (Demonstration - Cannot be used in this class)
        public void FileLocalTypes()
        {
            Console.WriteLine("🔹 File-local types: Not visible outside this file.");
        }

        // 8️⃣ Required Members
        public void RequiredMembers()
        {
            var person = new Person { Name = "Ayoub", Age = 25 };
            Console.WriteLine($"🔹 Required Members: {person.Name}, {person.Age}");
        }

        // 9️⃣ Auto-Default Structs
        public void AutoDefaultStructs()
        {
            var point = new Point();
            Console.WriteLine($"🔹 Auto-Default Structs: ({point.X}, {point.Y})");
        }

        // 🔟 Pattern Match Span<char> on Constant String
        public void PatternMatchSpan()
        {
            ReadOnlySpan<char> span = "hello";
            if (span is "hello")
            {
                Console.WriteLine("🔹 Pattern Matched Span<char>!");
            }
        }

        // 1️⃣1️⃣ Extended nameof Scope
        public void ExtendedNameofScope()
        {
            Console.WriteLine($"🔹 Extended nameof Scope: {nameof(this.ExtendedNameofScope)}");
        }

        // 1️⃣2️⃣ Numeric IntPtr
        public void NumericIntPtr()
        {
            nint nativeInt = 42;
            Console.WriteLine($"🔹 Numeric IntPtr: {nativeInt}");
        }

        // 1️⃣3️⃣ ref Fields and Scoped ref
        public void RefScoped()
        {
            Console.WriteLine("🔹 ref fields & scoped ref - Advanced feature, not commonly used.");
        }

        // 1️⃣4️⃣ Improved Method Group Conversion to Delegate
        public void MethodGroupConversion()
        {
            Func<int, int> square = Square;
            Console.WriteLine($"🔹 Method Group Conversion: {square(5)}");
        }

        private int Square(int x) => x * x;
    }

    // **Required Members Example**
    public class Person
    {
        public required string Name { get; init; }
        public required int Age { get; init; }
    }

    // **Auto-Default Struct Example**
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }


    }
}