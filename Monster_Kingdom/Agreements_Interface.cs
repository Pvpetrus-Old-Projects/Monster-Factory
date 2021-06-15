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
                Console.WriteLine("5. Zakończ pracę nad potworem w umowie o pracę");
                Console.WriteLine("6. Zakończ pracę nad potworem w umowie o dzieło");
                try
                {
                    Program_Trwa = Int32.Parse(Console.ReadLine());
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }
                switch (Program_Trwa)
                {
                    case 0:
                        break;
                    case 1:
                        Show_Agreements(kingdom);
                        break;
                    case 2:
                        Add_Specific_Agreement(kingdom);
                        break;
                    case 3:
                        Add_Working_Agreement(kingdom);
                        break;
                    case 4:
                        Add_Monster_To_Agreement(kingdom);
                        break;
                    case 5:
                        End_Work_On_Monster(kingdom);
                        break;
                    case 6:
                        End_Work_On_Contract(kingdom);
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
            Double price;
            String origin;
            String name;
            String race;
            String color;
            Shapers_Interface.Show_Shapers(kingdom);
            Console.WriteLine("Podaj index tworzyciela:\nJeśli chcesz wyjść podaj 0");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 0 || index > kingdom.shapers.Count)
            {
                Console.WriteLine("Nie ma tworzyciela o takim indeksie");
                return;
            }
            index--;
            Console.WriteLine("Podaj cenę: ");
            price = Convert.ToDouble(Console.ReadLine());
            //dodawanie potwora do kontraktu
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

            if (origin == "Ork")
            {
                Console.WriteLine("Podaj kolor: ");
                color = Console.ReadLine();
                new_monster = new Ork(race, id, price, kingdom.shapers[index], color);
            }
            else
            {
                new_monster = new Demon(race, id, price, kingdom.shapers[index]);
            }
            Specific_Agreement agreement = new Specific_Agreement(price, kingdom.shapers[index], new_monster);
            try
            {
                kingdom.Add_Agreement(agreement);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Add_Working_Agreement(Kingdom kingdom)
        {
            //dokonczyc
            //dokonczyc
            Double price;
            Shapers_Interface.Show_Shapers(kingdom);
            Console.WriteLine("Podaj index tworzyciela:\nJeśli chcesz wyjść podaj 0");
            int index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 0 || index > kingdom.shapers.Count)
            {
                Console.WriteLine("Nie ma tworzyciela o takim indeksie");
                return;
            }
            index--;
            Console.WriteLine("Podaj cenę: ");
            price = Convert.ToDouble(Console.ReadLine());
            //dodawanie potwora do kontraktu
           
            Working_Agreement agreement = new Working_Agreement(price, kingdom.shapers[index],new List<Monster>());
            try
            {
                kingdom.Add_Agreement(agreement);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public static void Add_Monster_To_Agreement(Kingdom kingdom)//uwazac
        {
            Console.WriteLine("Wybierz umowe:\n Jeśli chcesz powrócić wybierz 0 ");
            int count = Show_Working_Agreements(kingdom);
            int index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 0 || index > count)//uwazac
            {
                Console.WriteLine("Nie ma umowy o takim indeksie");
                return;
            }
            index--;
            Working_Agreement new_agreement;
            //zrobic choose agreement
            foreach(Agreement agreement in kingdom.agreements)
            {
                if (agreement == Choose_Working_Agreement(kingdom, index))
                {
                    new_agreement = (Working_Agreement)agreement;
                }
            }
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
                new_agreement = (Working_Agreement)kingdom.agreements[index];//blad cant cast specific to working
                new_agreement.monsters.Add(new_monster);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public static void End_Work_On_Monster(Kingdom kingdom)//uwazac
        {
            Console.WriteLine("Wybierz umowę:\n Jeśli chcesz powrócić wybierz 0 ");
            int count=Show_Working_Agreements(kingdom);
            int index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 0 || index > count)
            {
                Console.WriteLine("Nie ma umowy o takim indeksie");
                return;
            }
            index--;
            Working_Agreement new_agreement = (Working_Agreement)Choose_Specific_Agreement(kingdom, index);
            int monster_index;
            Console.WriteLine("Wybierz potwora:\n Jeśli chcesz powrócić wybierz 0");
            Show_Agreement_Monsters(new_agreement);
            monster_index = Convert.ToInt32(Console.ReadLine());

            if (monster_index == 0) return;
            if (monster_index < 0 || monster_index > new_agreement.monsters.Count)
            {
                Console.WriteLine("Nie ma potwora o takim indeksie");
                return;
            }
            index--;
            //dokonczyc wypisywanie monsters
            kingdom.Add_Monster(new_agreement.monsters[index]);
            new_agreement.monsters.RemoveAt(index);

        }
        public static int Show_Specific_Agreements(Kingdom kingdom)
        {
            int index = 1;
            foreach(Agreement agreement in kingdom.agreements)
            {
                if (agreement is Specific_Agreement)
                {
                    Console.WriteLine(index + ". " + agreement);
                    index++;
                }
            }
            return index - 1;
        }
        public static int Show_Working_Agreements(Kingdom kingdom)
        {
            int index = 1;
            foreach (Agreement agreement in kingdom.agreements)
            {
                if( agreement is Working_Agreement)
                {
                Console.WriteLine(index + ". " + agreement);
                index++;
                }
            }
            return index - 1;
        }
        public static Agreement Choose_Specific_Agreement(Kingdom kingdom,int index)
        {

            foreach(Agreement agreement in kingdom.agreements)
            {
                if(agreement is Specific_Agreement)
                {
                if (index == 0)
                {
                    return agreement;
                }
                index--;
                }
            }
            return kingdom.agreements.FirstOrDefault();
        }
        public static Agreement Choose_Working_Agreement(Kingdom kingdom, int index)
        {

            foreach (Working_Agreement agreement in kingdom.agreements)
            {
                if (agreement is Working_Agreement)
                {
                    if (index == 0)
                    {
                    return agreement;
                    }
                    index--;
                }
            }
            return kingdom.agreements.FirstOrDefault();
        }
        public static void End_Work_On_Contract(Kingdom kingdom)
        {
            Console.WriteLine("Wybierz umowę:\n Jeśli chcesz powrócić wybierz 0 ");
            int count=Show_Specific_Agreements(kingdom);
            int index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 0 || index > count)
            {
                Console.WriteLine("Nie ma umowy o takim indeksie");
                return;
            }
            index--;
            Specific_Agreement comparable_agreement=(Specific_Agreement)Choose_Specific_Agreement(kingdom, index);
            foreach(Specific_Agreement agreement in kingdom.agreements)
            {
                if (agreement == comparable_agreement)
                {
                    try
                    {
                        kingdom.Add_Monster(agreement.monster);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }
            index = 0;
            foreach(Agreement agreement in kingdom.agreements)
            {
                if (agreement == comparable_agreement)
                {
                    kingdom.agreements.RemoveAt(index);
                    break;
                }
                index++;
            }
            //usuniecie umowy

        }
        public static void Show_Agreement_Monsters(Working_Agreement agreement)
        {
            int index = 1;
            foreach (Monster monster in agreement.monsters)
            {
                Console.WriteLine(index + ". " + monster);
                index++;
            }
        }
    }
    
}
