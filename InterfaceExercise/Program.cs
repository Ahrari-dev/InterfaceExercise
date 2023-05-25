using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Car();

            var truck = new Truck();
            var vehicles = new List<IVehicle>() { car, truck };

            foreach (var vehicle in vehicles)
            {
                vehicle.Drive();
                vehicle.ChangeGears(true);
                vehicle.Reverse();
            }
        }
    }
}
