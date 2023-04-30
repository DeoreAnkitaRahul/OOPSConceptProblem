using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblem
{
    public class OverridingProgram
    {
        public virtual void Draw()
        {
            Console.WriteLine("Draw Any Angle");
        }
    }
    public class Circle : OverridingProgram
    {
        public override void Draw()
        {
            Console.WriteLine("Draw Circle");
        }
    }
}
