using OopsProblem;
using System.Net.NetworkInformation;

namespace OopsProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            int Val = 20;
            int Val_one = 30;
            CreateClass obj= new CreateClass();
            obj.Value(Val,Val_one);
            obj.Value_One(ref Val,ref Val_one);
            Console.ReadKey();



        }
    }
}
