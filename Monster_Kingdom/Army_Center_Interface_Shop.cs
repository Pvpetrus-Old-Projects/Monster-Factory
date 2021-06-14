﻿using System;
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
    class Army_Center_Interface_Shop
    {
        static public void Start(Kingdom kingdom, Army_Center army_Center)
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
                        Buy_Monsters(army_Center);
                        break;
                    case 2:
                        Show_Available_Monsters(army_Center.monsters);
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
        static public void Buy_Monsters(Army_Center army_Center)
        {
            int index = 0;
            Console.WriteLine("Wpisz numer potwora do kupienia. \nJeśli chcesz wyjść wpisz 0");
            Show_Available_Monsters(army_Center.monsters);
            index = Convert.ToInt32(Console.ReadLine());
            if (index == 0) return;
            if (index < 0 || index > army_Center.monsters.Count) throw new ArgumentOutOfRangeException("Nie ma potwora o takim numerze");
            index--;
            try
            {
                army_Center.monsters.RemoveAt(index);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e);
            }
        }

        static public void Show_Available_Monsters(List<Monster> monsters)
        {
            int index = 1;
            foreach (Monster monster in monsters)
            {
                Console.WriteLine(index + ". " + monster);
            }
        }
    }
}
