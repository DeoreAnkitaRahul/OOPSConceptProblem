using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblem
{
    public class CreateClass
    {
        private string name = "Patil"; //Defined field is in private
        private int age = 25;
        public string Name  //Property

        {
            get
            {
                return name;
            }
            set
            {
                name = value; //name = value : It will set or assign value to the name
            }
        }
        public int Age
        {
            get {
                
              return age;
            }
            set
            {
                age = value;
            }
        }


    }
}

