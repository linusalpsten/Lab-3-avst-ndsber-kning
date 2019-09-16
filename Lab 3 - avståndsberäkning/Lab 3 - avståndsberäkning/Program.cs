using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3___avståndsberäkning
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static double Distance(Location l1, Location l2)
        {
            return Math.Sqrt(Math.Pow(l1.latitude - l2.latitude, 2) + Math.Pow(l1.longitude - l2.longitude, 2));
        }
    }
}
