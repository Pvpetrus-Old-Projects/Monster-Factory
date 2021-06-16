using System;
using System.IO;
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
            Kingdom kingdom = Read_Kingdom_From_File();
            Army_Center army_Center = Read_army_Center_From_File();
            /*
            List<Monster> Army_Center_monsters = new List<Monster>();
            List<Shaper> shapers= new List<Shaper>();
            List<Mother_Of_The_Swarm> mothers_Of_The_Swarm = new List<Mother_Of_The_Swarm>();
            List<Agreement> agreements = new List<Agreement>();
            List<Monster> monsters = new List<Monster>();
             army_Center = new Army_Center(Army_Center_monsters);
            Mother_Of_The_Swarm mothers_Of_The_Swarm1 = new Mother_Of_The_Swarm(true);
            Mother_Of_The_Swarm mothers_Of_The_Swarm2 = new Mother_Of_The_Swarm(false);
            Mother_Of_The_Swarm mothers_Of_The_Swarm3 = new Mother_Of_The_Swarm(false);
            mothers_Of_The_Swarm.Add(mothers_Of_The_Swarm1);
            mothers_Of_The_Swarm.Add(mothers_Of_The_Swarm2);
            mothers_Of_The_Swarm.Add(mothers_Of_The_Swarm3);
             kingdom = new Kingdom(shapers, mothers_Of_The_Swarm, agreements, monsters);
            */
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
                        Save_Kingdom_To_File();
                        Save_Army_Center_To_File();
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
        public static Kingdom Read_Kingdom_From_File()
        {
            List<Monster> monsters = new List<Monster>();
            List<Mother_Of_The_Swarm> mothers_Of_The_Swarm = new List<Mother_Of_The_Swarm>();
            List<Shaper> shapers = new List<Shaper>();
            List<Agreement> agreements = new List<Agreement>();
            string line;
            //mothers shapers agreements
            //demons
            using (StreamReader file = new StreamReader("demons.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    monsters.Add(new Demon(line, Convert.ToInt32(file.ReadLine()), Convert.ToDouble(file.ReadLine()),
                        new Shaper(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine()))));
                }
            }
            //orks
            using (StreamReader file = new StreamReader("orks.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    monsters.Add(new Ork(line, Convert.ToInt32(file.ReadLine()), Convert.ToDouble(file.ReadLine()),
                        new Shaper(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine())), file.ReadLine()));
                }
            }
            //mothers
            //ability
            using (StreamReader file = new StreamReader("mothers_Of_The_Swarm.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    mothers_Of_The_Swarm.Add(new Mother_Of_The_Swarm(Convert.ToBoolean(line)));
                }
            }
            //shapers
            //id name surname
            using (StreamReader file = new StreamReader("shapers.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    shapers.Add(new Shaper(line, file.ReadLine(), Convert.ToInt32(file.ReadLine())));
                }
            }
            //agreements
            //price shaper
            using (StreamReader file = new StreamReader("Specific_Agreements.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    agreements.Add(new Specific_Agreement(Convert.ToDouble(line), new Shaper(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine())), new Demon()));
                }//UWAGA TRZEBA ZROBIC WYBIERANIE DEMON CZY ORK
            }
            using (StreamReader file = new StreamReader("Working_Agreements.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    agreements.Add(new Working_Agreement(Convert.ToDouble(line), new Shaper(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine())),new List<Monster>()));
                }//UWAGA ZROBIC NEW LIST
            }
            return new  Kingdom(shapers,mothers_Of_The_Swarm,agreements,monsters);
        }
        public static Army_Center Read_army_Center_From_File()
        {
            List<Monster> army_Center_Shop_Monsters = new List<Monster>();
            string line;

            //id race price shaper
            using (StreamReader file = new StreamReader("army_Center_Shop_Demons.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    army_Center_Shop_Monsters.Add(new Demon(line, Convert.ToInt32(file.ReadLine()), Convert.ToDouble(file.ReadLine()),
                        new Shaper(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine()))));
                }
            }
            //id race price shaper color
            using (StreamReader file = new StreamReader("army_Center_Shop_Orks.txt"))
            {
                while ((line = file.ReadLine()) != null)
                {
                    army_Center_Shop_Monsters.Add(new Ork(line, Convert.ToInt32(file.ReadLine()), Convert.ToDouble(file.ReadLine()),
                        new Shaper(file.ReadLine(), file.ReadLine(), Convert.ToInt32(file.ReadLine())),file.ReadLine()));
                }
            }
            Army_Center army_Center = new Army_Center(army_Center_Shop_Monsters);
            return army_Center;
        }
        public static void Save_Kingdom_To_File()
        {

        }
        public static void Save_Army_Center_To_File()
        {

        }
    }
}
