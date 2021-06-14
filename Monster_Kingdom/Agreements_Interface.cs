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
                        Show_Agreements(kingdom);
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
        public static void Show_Agreements(Kingdom kingdom)
        {
            int index = 1;
            foreach (Agreement agreement in kingdom.agreements)
            {
                Console.WriteLine(index + ". " + agreement);
            }
        }
        public static void Add_Specific_Agreement(Kingdom kingdom)
        {
            //dokonczyc
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
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Add_Working_Agreement()
        {
            //dokonczyc
        }
        public static void Add_Monster_To_Agreement(Kingdom kingdom)
        {
            Console.WriteLine("Wybierz tworzyciela:\n Jeśli chcesz powrócić wybierz 0 ");
            Show_Working_Agreements(kingdom);
            int index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 0 || index > kingdom.monsters.Count)
            {
                Console.WriteLine("Nie ma tworzyciela o takim indeksie");
                return;
            }
            index--;
            //wybrac agreement najpierw
            // zrobic
            String origin;
            String name;
            String race;
            Double price;
            String color;
            TimeSpan dt2 = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0));
            int id = Convert.ToInt32(dt2.TotalSeconds);
            Console.WriteLine("Wybierz pochodzenie: ");
            origin = Console.ReadLine();
            Console.WriteLine("Podaj imię: ");
            name = Console.ReadLine();
            Console.WriteLine("Podaj Rasę: ");
            race = Console.ReadLine();
            Console.WriteLine("Podaj cenę: ");
            price = Convert.ToDouble(Console.ReadLine());
            Monster new_monster;
            if(origin=="Ork")
            {
                Console.WriteLine("Podaj kolor: ");
                color=Console.ReadLine();
                new_monster = new Ork(race,id,price,kingdom.agreements[index].shaper,color);
            }
            else
            {
                new_monster = new Demon(race, id, price, kingdom.agreements[index].shaper);
            }
            try
            {
                Working_Agreement agreement = (Working_Agreement)kingdom.agreements[index];
                agreement.monsters.Add(new_monster);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public static void End_Work_On_Monster(Specific_Agreement agreement,Kingdom kingdom)
        {
            try
            {
                kingdom.Add_Monster(agreement.monster);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Show_Specific_Agreements(Kingdom kingdom)
        {
            int index = 1;
            foreach(Specific_Agreement agreement in kingdom.agreements)
            {
                Console.WriteLine(index+". "+agreement);
                index++;
            }
        }
        public static void Show_Working_Agreements(Kingdom kingdom)
        {
            int index = 1;
            foreach (Working_Agreement agreement in kingdom.agreements)
            {
                Console.WriteLine(index + ". " + agreement);
                index++;
            }
        }
    }
    
}
