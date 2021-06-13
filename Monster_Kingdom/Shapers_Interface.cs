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
    class Shapers_Interface
    {
        static public void Start(Kingdom kingdom, Army_Center army_Center)
        {
            int Program_Trwa = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Interfejs Tworzycieli:");
                Console.WriteLine("Wybierz jedną z opcji:");
                Console.WriteLine("0. Wyjdź z interfejsu tworzycieli");
                Console.WriteLine("1. Wyświetl tworzycieli");
                Console.WriteLine("2. Dodaj tworzyciela");
                Program_Trwa = Int32.Parse(Console.ReadLine());
                switch (Program_Trwa)
                {
                    case 0:
                        break;
                    case 1:
                        Show_Shapers();
                        break;
                    case 2:
                        Add_Shaper();
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
        public static void Show_Shapers()
        {

        }
        public static void Add_Shaper()
        {

        }
    }
}
