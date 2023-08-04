using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    public class Truck : Icompany, IVehicle 
    {
        public string TruckBed { get; set; }  

        public bool RequiresCommercialLicenseToDrive { get; set; }
        public string CompanyName { get; set; }
        public string Logo { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsDriveable { get; set; }
    }
}
