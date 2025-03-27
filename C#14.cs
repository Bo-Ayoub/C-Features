using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
// File-scoped using directive
using System.IO;

namespace project_echallenge
{
    internal class C_14
    {
        // Field-backed property
        public int Value
        {
            get => @field;
            set => @field = value < 0 ? 0 : value;
        }
        private int field;

   

    // Target-typed conditional expression
    public void DisplayMessage(bool isSuccess)
    {
        string message = isSuccess is true ? "Operation succeeded." : "Operation failed.";
        Console.WriteLine(message);
    }

    // Partial constructor
    public partial class SampleClass
    {
        public SampleClass() : this(0) { }
        public SampleClass(int value) { }
    }

    // Partial event
    public partial class EventPublisher
    {
        public partial event EventHandler<EventArgs> DataProcessed;
    }

    // Using 'nameof' with unbound generics
    public void DisplayTypeName()
        {
            Console.WriteLine(nameof(List<>)); // Outputs: List<>
        }

        // File-local using directive
        // using System.IO; // Uncomment to use within this file
    }
}

