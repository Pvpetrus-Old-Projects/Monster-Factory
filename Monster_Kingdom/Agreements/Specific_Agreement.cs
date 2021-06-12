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
        private List<Monster> monsters;
        public Specific_Agreement(Double price,Shaper shaper) : base(price,shaper)
        {
            this.monsters = new List<Monster>();
        }
        void Finish_Work(Kingdom kingdom)
        {
            
        }
    }
}
