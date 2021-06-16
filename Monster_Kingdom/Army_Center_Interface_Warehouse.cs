using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Kingdoms;
using Monster_Kingdom.Agreements;
using Monster_Kingdom.Army_Centers;
using Monster_Kingdom.Monsters;
using Monster_Kingdom.Mothers_Of_The_Swarm;
using Monster_Kingdom.Shapers;
namespace Monster_Kingdom
{
    class Army_Center_Interface_Warehouse
    {
        static public void Start(Kingdom kingdom,Army_Center army_Center)
        {
            int Program_Trwa = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Interfejs Zaopatrzenia Armii:");
                Console.WriteLine("Wybierz jedną z opcji:");
                Console.WriteLine("0. Wyjdź z zaopatrzenia Armii");
                Console.WriteLine("1. Zamów potwora");
                Console.WriteLine("2. Wyświetl dostępne potwory");
                try
                {
                    Program_Trwa = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                
                switch (Program_Trwa)
                {
                    case 0:
                        break;
                    case 1:
                        Order_Monster(kingdom,army_Center);
                        break;
                    case 2:
                        Show_Available_Monsters(kingdom.monsters);
                        break;
                    default:
                        Console.WriteLine("Zła akcja!");
                        break;
                }
                if (Program_Trwa == 0) break;
                do
                {
                    Console.WriteLine("Aby powrócić podaj 0:");
                }
                while (Console.ReadLine() != "0");
            } while (Program_Trwa != 0);
        }
        static public void Order_Monster(Kingdom kingdom,Army_Center army_Center)
        {
            int index = 0;
            Console.WriteLine("Wpisz numer potwora do dodania. \nJeśli chcesz wyjść wpisz 0");
            Show_Available_Monsters(kingdom.monsters);
            index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 1 || index > kingdom.monsters.Count) throw new ArgumentOutOfRangeException("Nie ma potwora o takim numerze");
            index--; 
            try
            {
            army_Center.Receive_Monster(kingdom.monsters[index], kingdom);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e);
            }

        }
        static public void Show_Available_Monsters(List<Monster> monsters)
        {
            int index = 1;
            foreach(Monster monster in monsters)
            {
                Console.WriteLine(index+". "+monster);
            }
        }
    }
}
