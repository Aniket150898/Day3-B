namespace PracticeProblems
{
    internal class Program
    {
        public Program() //This Is User Defined Constuctor //Define Constuctor Name Same As Class Name
        {
            Console.WriteLine("Hello, I am Constuctor");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Guys!!! Performs Constructor ,Interface, Access Modifier");
            Program obj = new Program();//This is Defalut Constuctor
            ConstructorCar constructorCar = new ConstructorCar("BMW", 1998);
            
        }
    }
}