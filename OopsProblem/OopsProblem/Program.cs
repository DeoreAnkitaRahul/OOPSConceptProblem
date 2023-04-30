using OopsProblem;

namespace OopsProblem
{
    class Program
    {
        public static void Main(string[] args)
        {
            //CreateClass obj= new CreateClass();
            // obj.Sum(2,3);
            // obj.Sum(7.1,3.7);
            // obj.Sum("Total");
            

            OverridingProgram obj = new OverridingProgram();
            obj.Draw();
            Circle obj_one = new Circle();
            obj_one.Draw();
            Console.ReadKey();
           

        }

        
        
    }
}
