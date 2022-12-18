using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    static class Actions
    {
        public static void Print(this IEnumerable<Vehicle> vehicles)
        {
            StringBuilder stringBuilder = new StringBuilder("");
            foreach (Vehicle item in vehicles)
            {
                stringBuilder.Append($"{item.ToString()} \n");
            }

            Console.WriteLine(stringBuilder);
        }
    }
}
