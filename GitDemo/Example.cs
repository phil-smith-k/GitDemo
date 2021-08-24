using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitDemo
{
    public class Example
    {
        public Example()
        {
            var message = "Cookie";
            Console.WriteLine($"{message} are good!");
        }

        public Example(string example)
        {
            this.ExampleProp = example;
        }

        public string ExampleProp { get; set; }
    }
}
