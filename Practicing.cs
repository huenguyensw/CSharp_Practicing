using System;
using System.Collections.Generic;
using System.Linq; // important for LINQ


namespace Practicing {
    class Program {
        public static void Run() {
            var numbers = new List<int> {3,6,9,12,15,18};

            var result = numbers.Where(n => n >10).OrderByDescending(n => n).ToList();

            Console.WriteLine(string.Join(",", result));
        }
    }
}