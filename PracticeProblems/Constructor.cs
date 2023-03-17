using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
        class ConstructorCar
    {
        string carModel;
        int carYear;
        public ConstructorCar(string Model, int Year) //This is Parameterised Constuctor
        {
            carModel = Model;
            carYear = Year;
            Console.WriteLine("Mode:-" + carModel);
            Console.WriteLine("Year:-" + carYear);
        }
    }
}
