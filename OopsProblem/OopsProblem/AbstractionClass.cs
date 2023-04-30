using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblem
{
     public abstract class Abstractionclass
     {
            public abstract void draw();
            public void Rectangle()
            {
                Console.WriteLine("Draw rectangle");
            }
      }
        public class Triangle : Abstractionclass
        {
            public override void draw()
            {
                Console.WriteLine("Draw Triangle");
            }

        }
}

