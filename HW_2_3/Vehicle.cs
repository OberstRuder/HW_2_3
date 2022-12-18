﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    abstract class Vehicle
    {
        public Vehicle(int speed, int weight, string info)
        {
            Speed = speed;
            Weight = weight;
            Info = info;
        }
        public double Speed { get; set; }
        public double Weight { get; set; }
        public string Info { get; set; }

        public virtual void Drive() { }

        public override string ToString()
        {
            return $"VehicleInfo: {Info}\t Speed: {Speed} km/h\t Weight: {Weight}";
        }



    }
}
