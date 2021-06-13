using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Monsters;
using Monster_Kingdom.Kingdoms;
namespace Monster_Kingdom.Army_Centers
{
    class Army_Center
    {
        public List<Monster> monsters { get; set; }
        public Army_Center()
        {
            this.monsters = new List<Monster>();
        }
        public Army_Center(List<Monster> monsters)
        {
            this.monsters = monsters;
        }
        public void Sell(Monster monster)
        {
            if(monsters.Contains(monster)) monsters.Remove(monster);
            else
            {
                throw new ArgumentException("There is no such monster for sale");
            }
        }

        public void Receive_Monster(Monster monster,Kingdom kingdom)
        {
            if (kingdom.monsters.Contains(monster))
            {
                monsters.Add(monster);
                kingdom.monsters.Remove(monster);
            }
            else
            {
                throw new ArgumentException("There is no such monster in the kingdom");
            }
        }
        //niepotrzebne
        public void Show_Available()
        {
            foreach(Monster monster in monsters)
            {
                Console.WriteLine(monster);
            }
        }

    }
}
