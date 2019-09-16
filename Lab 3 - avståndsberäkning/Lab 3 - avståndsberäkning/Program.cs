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
            Position p1 = new Position { latitude = 0, longitude = 0 };
            Position p2 = new Position { latitude = 135, longitude = 180 };
            Position p3 = new Position { latitude = 0, longitude = 0 };
            Console.WriteLine(Distance(p1, p2));
            Location l1 = new Location { Position = p1 };
            Location l2 = new Location { Position = p2 };
            Location l3 = new Location { Position = p3 };
            Console.WriteLine(Distance(l1, l2));
        }

        static double Distance(Position p1, Position p2)
        {
            return Math.Sqrt(Math.Pow(p1.latitude - p2.latitude, 2) + Math.Pow(p1.longitude - p2.longitude, 2));
        }

        static double Distance(Location l1, Location l2)
        {
            return Distance(l1.Position, l2.Position);
        }

        static double Distance(Location[] locations)
        {
            Location lastlocation = locations[0];
            double totalDistance = 0;
            for (int i = 1; i < locations.Length; i++)
            {
                totalDistance += Distance(lastlocation, locations[i]);
                lastlocation = locations[i];
            }
            return totalDistance;
        }
    }
}
