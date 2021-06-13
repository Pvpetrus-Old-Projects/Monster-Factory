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
    class Agreements_Interface
    {
        static public void Start(Kingdom kingdom, Army_Center army_Center)
        {
            int Program_Trwa=0;
            do
            {
                Console.Clear();
                Console.WriteLine("Interfejs umów:");
                Console.WriteLine("Wybierz jedną z opcji:");
                Console.WriteLine("0. Wyjdź z interfejsu umów");
                Console.WriteLine("1. Wyświetl umowy");
                Console.WriteLine("2. Dodaj umowę o potwora");
                Console.WriteLine("3. Dodaj umowę o pracę");
                Console.WriteLine("4. Dodaj potwora do umowy o pracę");
                Console.WriteLine("5. Zakończ pracę nad potworem");
                Program_Trwa=Int32.Parse(Console.ReadLine());
                switch (Program_Trwa)
                {
                    case 0:
                        break;
                    case 1:
                        Show_Agreements();
                        break;
                    case 2:
                        Add_Specific_Agreement();
                        break;
                    case 3:
                        Add_Working_Agreement();
                        break;
                    case 4:
                        Add_Monster_To_Agreement();
                        break;
                    case 5:
                        End_Work_On_Monster();
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
            } while (Program_Trwa!=0);

        }
        public static void Show_Agreements()
        {

        }
        public static void Add_Specific_Agreement()
        {

        }
        public static void Add_Working_Agreement()
        {

        }
        public static void Add_Monster_To_Agreement()
        {

        }
        public static void End_Work_On_Monster()
        {

        }
    }
    
}
