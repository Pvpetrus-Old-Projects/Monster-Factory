using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom;
namespace Monster_Kingdom
{
    class Menu
    {
        static public void Start()
        {
            int Program_Trwa = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Menu główne:");
                Console.WriteLine("0. Wyjdź z programu");
                Console.WriteLine("1. Wejdź do interfejsu armii");
                Console.WriteLine("2. Wejdź do iterfejsu umów");
                Console.WriteLine("3. Wejdź do interfejsu Tworzycieli");
                Program_Trwa = Int32.Parse(Console.ReadLine());
                switch (Program_Trwa)
                {
                    case 0:
                        break;
                    case 1:
                        Army_Center_Interface.Start();
                        break;
                    case 2:
                        Agreements_Interface.Start();
                        break;
                    case 3:
                        Shapers_Interface.Start();
                        break;
                    default:
                        Console.WriteLine("Zła akcja!");
                        break;

                }
                if (Program_Trwa == 0) break;
            } while (Program_Trwa != 0);
        }
    }
}
