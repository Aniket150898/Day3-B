using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    internal class User
    {
        protected string Name;     //This is Protected Access Modifier code is accessible within the same class, or
                                   //in a class that is inherited from that class.
        protected string Location;
        protected void GetUserDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Location: {0}", Location);
        }
    }
    class Program1 : User
    {
        static void Main(string[] args)
        {
            User u = new User();
            Program1 p = new Program1();
            // Complier Error
            // protected members can only accessible with derived classes
            //u.Name = "Aniket";
            p.Name = "Aniket";
            p.Location = "Mumbai";
            p.GetUserDetails();
            Console.WriteLine("\nPress Enter Key to Exit..");
            Console.ReadLine();
        }
    }
}
