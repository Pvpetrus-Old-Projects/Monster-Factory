using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Agreements;
using Monster_Kingdom.Monsters;
using Monster_Kingdom.Shapers;
using Monster_Kingdom.Kingdoms;
namespace Monster_Kingdom.Agreements
{
    class Specific_Agreement:Agreement
    {
        
        public Monster monster { get; set; }
        public Specific_Agreement() : base()
        {

        }
        public Specific_Agreement(Double price, Shaper shaper, Monster monster) : base(price, shaper)
        {
            this.monster = monster;
        }
        void Finish_Work_On_Monster(Kingdom kingdom)
        {
            try
            {
                kingdom.Add_Monster(monster);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public override string ToString()
        {
            return base.ToString() + "Pracuje nad potworem: "+monster;
        }
    }
}
