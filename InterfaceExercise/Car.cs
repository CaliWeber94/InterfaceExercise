using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Car : Icompany, IVehicle 
    {
        public bool HasTrunk { get; set; }  

        public bool ThreeWheeledCar { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }
    }
}
