using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_2_3
{
    static class Actions
    {
        public static void SortedPrint(this IEnumerable<Vehicle> vehicles)
        {
            var sorted = vehicles.OrderBy(ob => ob.Speed).ToArray();
            Array.ForEach(sorted, Console.WriteLine);
        }


    }
}
