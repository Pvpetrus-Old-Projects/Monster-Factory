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
    class Menu
    {
        static public void Start()
        {
            //
            //Przygotowanie programu do działania
            //
            List<Monster> Army_Center_monsters = new List<Monster>();
            List<Shaper> shapers= new List<Shaper>();
            List<Mother_Of_The_Swarm> mothers_Of_The_Swarm = new List<Mother_Of_The_Swarm>();
            List<Agreement> agreements = new List<Agreement>();
            List<Monster> monsters = new List<Monster>();
            Army_Center army_Center = new Army_Center(Army_Center_monsters);
            Mother_Of_The_Swarm mothers_Of_The_Swarm1 = new Mother_Of_The_Swarm(true);
            Mother_Of_The_Swarm mothers_Of_The_Swarm2 = new Mother_Of_The_Swarm(false);
            Mother_Of_The_Swarm mothers_Of_The_Swarm3 = new Mother_Of_The_Swarm(false);
            mothers_Of_The_Swarm.Add(mothers_Of_The_Swarm1);
            mothers_Of_The_Swarm.Add(mothers_Of_The_Swarm2);
            mothers_Of_The_Swarm.Add(mothers_Of_The_Swarm3);
            Kingdom kingdom = new Kingdom(shapers, mothers_Of_The_Swarm, agreements, monsters, army_Center);
            //
            //Dodanie matek roju żeby działało
            //
            int Program_Trwa = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu główne:");
                Console.WriteLine("0. Wyjdź z programu");
                Console.WriteLine("1. Wejdź do interfejsu armii");
                Console.WriteLine("2. Wejdź do iterfejsu umów");
                Console.WriteLine("3. Wejdź do interfejsu Tworzycieli");
                TimeSpan dt2 = DateTime.Now.Subtract(new DateTime(1970, 1, 1, 0, 0, 0));
                int id = Convert.ToInt32(dt2.TotalSeconds);
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
                        Army_Center_Interface.Start(kingdom,army_Center);
                        break;
                    case 2:
                        Agreements_Interface.Start(kingdom,army_Center);
                        break;
                    case 3:
                        Shapers_Interface.Start(kingdom,army_Center);
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
