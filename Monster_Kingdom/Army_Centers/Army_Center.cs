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
        private List<Monster> monsters { get; set; }
        public Army_Center()
        {
            this.monsters = new List<Monster>();
        }
        public Army_Center(List<Monster> monsters)
        {
            this.monsters = monsters;
        }
        public void Sell()
        {

        }

        public void Receive_Monster(Monster monster,Kingdom kingdom)
        {

        }
        //niepotrzebne
        /*public void Request_Creation(Kingdom kingdom,Monster monster)
        {

        }*/

    }
}
