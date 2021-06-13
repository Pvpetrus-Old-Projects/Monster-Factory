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
        public List<Monster> monsters { get; set; }
        public Specific_Agreement():base()
        {
            this.monsters = new List<Monster>();
        }
        public Specific_Agreement(Double price,Shaper shaper,List<Monster> monsters) : base(price,shaper)
        {
            this.monsters = monsters;
        }
        void Finish_Work(Kingdom kingdom)
        {
            
        }
    }
}
