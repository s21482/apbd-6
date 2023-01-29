using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task14();
            foreach (var task in t)
            {
                Console.WriteLine(task);
            }
            
            Console.WriteLine(LinqTasks.Task13(new int[] { 1, 1, 1, 1, 1, 1, 10, 1, 1, 1, 1 }));
        }
    }
}
