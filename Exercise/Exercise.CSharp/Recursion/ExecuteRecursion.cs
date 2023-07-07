using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.CSharp.Recursion
{
    public class ExecuteRecursion
    {
        public void Execute(int n)
        {
            Factorial factorial = new Factorial();

            Console.WriteLine(factorial.FactorialWithRecursion(n));

            Console.WriteLine(factorial.FactorialWithLoop(n));
        }
    }
}
