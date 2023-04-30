using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblem
{
    public class CreateClass
    {
        // Polymorphism Overloading Program
        public void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public void Sum(string str_one)
        {
            Console.WriteLine(str_one);

        }
    }
}

