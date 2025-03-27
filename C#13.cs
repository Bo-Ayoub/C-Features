using System;
using System.Collections.Generic;
using System.Threading;
using System.Runtime.CompilerServices;

namespace project_echallenge
{
    internal class C_13
    {
        // New 'Lock' type for thread synchronization
        private readonly Lock _syncLock = new Lock();

        // Enhanced 'params' collections
        public void DisplayItems(params List<string> items)
        {
            Console.WriteLine("Items:");
            foreach (var item in items)
            {
                Console.WriteLine($"- {item}");
            }
        }

        // New escape sequence '\e' for ESC character
        public void DisplayEscapeSequence()
        {
            string message = $"This is an escape sequence: \e[1;31mRed Text\e[0m";
            Console.WriteLine(message);
        }

        // Implicit indexer access in object initializers
        public void InitializeArray()
        {
            var numbers = new int[5];
            numbers[^1] = 10; // Sets the last element to 10
            Console.WriteLine($"Last number: {numbers[^1]}");
        }

        // Method group natural type improvements
        public void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void InvokeShowMessage()
        {
            Action<string> messageAction = ShowMessage;
            messageAction("Method group natural type improvement in action.");
        }

        // 'ref' locals and unsafe contexts in iterators and async methods
        public async Task ProcessDataAsync()
        {
            Span<byte> buffer = stackalloc byte[1024];
            await Task.Yield();
            // Additional processing
        }

        // 'ref struct' types implementing interfaces
        public void UseRefStruct()
        {
            var spanWrapper = new SpanWrapper(new Span<byte>(new byte[10]));
            spanWrapper.Process();
        }

        // Partial properties and indexers
        public partial class PartialClass
        {
            public partial string Name { get; set; }
        }

        // Overload resolution priority
        public void DemonstrateOverloadResolution()
        {
            Console.WriteLine("Overload resolution priority demonstration.");
        }

        [OverloadResolutionPriority(1)]
        public void DemonstrateOverloadResolution(int number)
        {
            Console.WriteLine($"Overload with int: {number}");
        }
    }
}
