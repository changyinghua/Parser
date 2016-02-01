using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JsonGenerator;

namespace JsonGeneratorTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator g = new Generator();
            Console.WriteLine(g.B());
            Console.ReadKey();
        }
    }
}
