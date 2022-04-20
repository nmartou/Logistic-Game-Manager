using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace VehicleClass
{
    [System.Serializable]
    public class Vehicle
    {
        public string name;
        public int levelVehicle;
        public int levelWheels; // 1
        public int levelEngine; // 2
        public int levelGearbox; // 3, Boite de vitesse
        public int levelSuspension; // 4
        public int levelControle; // 5
        public int levelFuel; // 6

        public Vehicle(string nameVehicle, int vehicle, int wheel, int engine, int gearbox, int suspension, int controle, int fuel)
        {
            name = nameVehicle;
            levelVehicle = vehicle;
            levelWheels = wheel;
            levelEngine = engine;
            levelGearbox = gearbox;
            levelSuspension = suspension;
            levelControle = controle;
            levelFuel = fuel;
        }

        public Vehicle()
        {
            name = "Car";
            levelVehicle = 0;
            levelWheels = 1;
            levelEngine = 1;
            levelGearbox = 1;
            levelSuspension = 1;
            levelControle = 1;
            levelFuel = 1;
        }
    }
}
