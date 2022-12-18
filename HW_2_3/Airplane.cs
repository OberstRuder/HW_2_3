using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    class Airplane : Vehicle
    {
        public Airplane(int speed, int weight, string info) : base(speed, weight, info)
        {
            Places = 188;
        }
        public override void Drive()
        {
            Console.WriteLine("Airplane is flying");
        }
    }
}
