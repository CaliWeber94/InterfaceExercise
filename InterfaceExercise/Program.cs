using System;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle
            
                /* Create 4 members that Car, Truck, & SUV all have in common.
                 * Example: All vehicles have a number of wheels... for now..
                 */
            

            //In ICompany
            
                /*Create 2 members that are specific to each every company
                 * regardless of vehicle type.
                 *
                 *
                 * Example: public string Logo { get; set; }
                 */

            //In each of your car, truck, and suv classes

                /*Create 2 members that are specific to each class
                 * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
                 *
                 * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
                 * 
                 */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var Honda = new Car();
            Honda.CompanyName = "Honda Motors";
            Honda.Make = "Honda";
            Honda.Model = "CRV";
            Honda.IsDriveable = true;
            Honda.Year = 2000;
            Honda.Logo = "Silver H";
            Honda.ThreeWheeledCar = false;
            Honda.HasTrunk = true;

            Console.WriteLine($"The company {Honda.CompanyName} makes the car {Honda.Make} {Honda.Model} made in the year {Honda.Year}.");
            Console.WriteLine("---------------------------------------------------------------------------");

            var Toyota = new Truck();
            Toyota.CompanyName = "Toyota Motors";
            Toyota.Make = "Toyota";
            Toyota.Model = "T";
            Toyota.IsDriveable = true;
            Toyota.Year = 2010;
            Toyota.Logo = "a fancy T";
            Toyota.TruckBed = "it has a big truck bed";
            Toyota.RequiresCommercialLicenseToDrive = false;
            Console.WriteLine($"The company {Toyota.CompanyName} makes the truck {Toyota.Make} {Toyota.Model} made in the year {Toyota.Year}");
            Console.WriteLine("-------------------------------------------------------------------------------");

            var BMW = new SUV();
            BMW.CompanyName = "BMW Motors";
            BMW.Make = "BMW";
            BMW.Model = "X3";
            BMW.IsDriveable = true;
            BMW.Year = 2020;
            BMW.Logo = "BMW in blue and white circle";
            BMW.SportMode = true;
            BMW.CargoSpace = "it has a small cargo space";
            Console.WriteLine($"The company {BMW.CompanyName} makes the the SUV {BMW.Make} {BMW.Model} made in the year {BMW.Year}");
        }
    }
}
