
// Amir Moeini Rad
// May 25, 2025

// Main Concept: Iterators in C# using 'yield return' for lazy execution.

namespace IteratorsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("Iterators in C#.NET.");
            Console.WriteLine("--------------------\n");

            // In each iteration, only one value is returned from the CountToThree() method.
            // 'yield return' pauses execution and remembers where it left off.
            // The compiler creates a 'state machine' behind the scenes.
            // Lazy Execution: efficient memory and performance for large datasets.
            // Each yield statement represents a 'pause point'.
            foreach (int number in CountToThree())
            {
                Console.WriteLine($"Iteration {number}");
            }


            Console.WriteLine("\nDone.");
        }


        /////////////////////////////////////////////////


        // Iterator method using 'yield return' to return values one at a time.
        public static IEnumerable<int> CountToThree()
        {
            try
            {
                yield return 1;
                yield return 2;
                yield return 3;
            }
            finally
            {
                // Cleanup after lazy execution.
                Console.WriteLine("\nCleanup in finally block.");
            }
        }
    }
}
