using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Monsters;
using Monster_Kingdom.Shapers;
using Monster_Kingdom.Kingdoms;
namespace Monster_Kingdom.Agreements
{
    class Working_Agreement:Agreement
    {
        
        public List<Monster> monsters { get;  set; }
        public Working_Agreement() : base()
        {
            this.monsters = new List<Monster>();
        }
        public Working_Agreement(Double price, Shaper shaper, List<Monster> monsters) : base(price, shaper)
        {
            this.monsters = monsters;
        }
        public void Finish_Work_On_Monster(Monster monster,Kingdom kingdom)
        {
            if (monsters.Contains(monster))
            {
                try
                {
                    kingdom.Add_Monster(monster);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                throw new ArgumentException("There is no such monster in the contract");
            }
        }
        public override string ToString()
        {
            return base.ToString() + "Pracuje nad potworami: " + monsters;
        }
    }
}
