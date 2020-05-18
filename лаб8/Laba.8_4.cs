using System.Collections.Generic;
using System;
namespace lab_bp
{
    class Program
    {
        delegate int Operation(int a, int b);
        static void Main(string[] args)
        {
            Dictionary<String, Operation> op = new Dictionary<String, Operation>();
            op["add"] = (a, b) => a + b;
            op["mult"] = (a, b) => a * b;
            Console.WriteLine(op["add"](5, 3));
            Console.WriteLine(op["mult"](6, 7));
            Console.ReadLine();
        }
    }
}