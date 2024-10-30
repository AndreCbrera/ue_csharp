using System;

namespace MultipleVars
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 6, z = 80;
            Console.WriteLine(x + y + z + "\n");

            /// You can also assign the same value to multiple variables in one line:
            int q, w, e;
            q = w = e = 100;
            Console.WriteLine(q + w + e);
        }
    }
}