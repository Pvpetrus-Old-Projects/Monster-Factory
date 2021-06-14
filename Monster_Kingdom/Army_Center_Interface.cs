using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom;
using Monster_Kingdom.Kingdoms;
using Monster_Kingdom.Agreements;
using Monster_Kingdom.Army_Centers;
using Monster_Kingdom.Monsters;
using Monster_Kingdom.Mothers_Of_The_Swarm;
using Monster_Kingdom.Shapers;
namespace Monster_Kingdom
{
    class Army_Center_Interface
    {
        static public void Start(Kingdom kingdom, Army_Center army_Center)
        {   
            int Program_Trwa = 0;
            do 
            {
                Console.Clear();
                Console.WriteLine("Interfejs Armii:");
                Console.WriteLine("Wybierz jedną z opcji:");
                Console.WriteLine("0. Wyjdź z interfejsu Armii");
                Console.WriteLine("1. Sklep");
                Console.WriteLine("2. Dział Zaopatrzeniowy");
                Program_Trwa = Int32.Parse(Console.ReadLine());
                switch (Program_Trwa)
                {
                    case 0:
                        break;
                    case 1:
                        Army_Center_Interface_Shop.Start(kingdom,army_Center);
                        break;
                    case 2:
                        Army_Center_Interface_Warehouse.Start(kingdom,army_Center);
                        break;
                    default:
                        Console.WriteLine("Zła akcja!");
                        do
                        {
                            Console.WriteLine("Aby powrócić podaj 0:");
                        }
                        while (Console.ReadLine() != "0");
                        break;
                }
                if (Program_Trwa == 0) break;
            } while (Program_Trwa != 0);
        }
    }
}
