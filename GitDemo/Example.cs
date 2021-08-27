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

            // Resolved conflict 
            Console.WriteLine("hello world");
        }

        public Example(string example)
        {
            this.ExampleProp = example;
        }

        public string ExampleProp { get; set; }

        public virtual void MyMethod()
        {
            Console.Write("hello");
        }

        public override string ToString()
        {
            return $"{this.ExampleProp}";
        }
    }

    public class AnotherClass : Example 
    {
        public override void MyMethod()
        {
            Console.Write("Something example");
        }
    }

}
