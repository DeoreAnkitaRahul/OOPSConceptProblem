using OopsProblem;

namespace OopsProblem
{
    class Program
    {
        public static void Main(string[] args)
        {

            CreateClass encapsulation = new CreateClass();
            Console.WriteLine(encapsulation.Name);
            encapsulation.Name = "Ankita";
            Console.WriteLine(encapsulation.Name);
            Console.WriteLine(encapsulation.Age = 23);

        }



    }
}
