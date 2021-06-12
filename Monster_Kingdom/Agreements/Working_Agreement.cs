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
        private Monster monster;
        public Working_Agreement(Double price,Shaper shaper) : base(price, shaper)
        {

        }
        void Finish_Work_On_Monster(Monster monster,Kingdom kingdom)
        {

        }
    }
}
