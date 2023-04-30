using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblem
{
    public class CreateClass
    {
        
        //value Type
        public void Value(int num_One, int num_Two)
        {
            Console.WriteLine($"Sum : {num_One + num_Two}");
        }

       //Referance Type
             public void Value_One(ref int num_One, ref int num_Two)
        {
            Console.WriteLine($"Reference Sum : {num_One + num_Two}");
        }

    }
}
