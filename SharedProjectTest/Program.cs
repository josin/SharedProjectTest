using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedProjectTest
{
    using SharedModels;

    public class Program
    {
        public static void Main(string[] args)
        {
            var foo = new Foo();
            foo.Bar();

            Console.Out.WriteLine("Done.");
        }
    }
}
