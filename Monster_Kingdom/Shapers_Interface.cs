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
                        Show_Shapers(kingdom);
                        break;
                    case 2:
                        Add_Shaper(kingdom);
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
        public static void Show_Shapers(Kingdom kingdom)
        {
            int index = 1;
            foreach (Shaper shaper in kingdom.shapers)
            {
                Console.WriteLine(index + ". " + shaper);
            }
        }
        public static void Add_Shaper(Kingdom kingdom)
        {
            String name;
            String surname;
            TimeSpan dt2 = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0));
            int id = Convert.ToInt32(dt2.TotalSeconds);
            Console.WriteLine("Podaj imię: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko: ");
            surname = Console.ReadLine();
            Shaper shaper = new Shaper(name, surname, id);
            try
            {
                kingdom.Add_Shaper(shaper);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
