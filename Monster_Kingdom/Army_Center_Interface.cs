using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom;
namespace Monster_Kingdom
{
    class Army_Center_Interface
    {
        static public void Start()
        {
            Console.WriteLine("Interfejs Armii:");
            Console.WriteLine("Wybierz jedną z opcji:");
            Console.WriteLine("1. Sklep");
            Console.WriteLine("2. Dział Zaopatrzeniowy");
            Army_Center_Interface_Shop.Start();
            Army_Center_Interface_Warehouse.Start();
        }
    }
}
