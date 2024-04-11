using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("г. Нижний Новгород, ул. Ильинская, д. 65", 28000, 12000, 7800);            
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("г. Нижний Новгород, ул. Ильинская, д. 65", 28000, 12000, 7800,5);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();  
        }
    }
}
