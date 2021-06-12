using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Kingdom
{
    class Army_Center_Interface_Shop
    {
        static public void Start()
        {
            int Program_Trwa = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Interfejs Sklepu Armii:");
                Console.WriteLine("Wybierz jedną z opcji:");
                Console.WriteLine("0. Wyjdź ze Sklepu Armii");
                Console.WriteLine("1. Wynajmij potwora");
                Console.WriteLine("2. Wyświetl dostępne potwory");
                Program_Trwa = Int32.Parse(Console.ReadLine());
                switch (Program_Trwa)
                {
                    case 0:
                        break;
                    case 1:
                        Buy_Monsters();
                        break;
                    case 2:
                        Show_Available_Monsters();
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
        static public void Buy_Monsters()
        {

        }

        static public void Show_Available_Monsters()
        {

        }
    }
}
