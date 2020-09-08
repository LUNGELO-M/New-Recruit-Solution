using System;

namespace BackEndQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            string theInput = "Hello ";
            // test
            stackOverFlow(theInput);
        }

        // the method
        static void stackOverFlow(string theInput)
        {
            int theLength = theInput.Length;

            Boolean A = theLength % 2 == 0;
            Boolean B = theLength % 4 == 0;
            string message = "No result :-(";
            /* all multiples of 4 are multiples of 2 */
            if (B)
                message = "Stack Overflow";
            else if (A)
                message = "Stack";

            Console.WriteLine(message);
        } 
    }
}
