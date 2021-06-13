using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Shapers;
namespace Monster_Kingdom.Monsters
{
    class Demon:Monster
    {
        public Demon():base()
        {

        }
        public Demon(String race,int id,Double price,Shaper shaper):base(race,id,price,shaper)
        {

        }
        public override string ToString()
        {
            return "Demon: "+base.ToString();
        }
    }
}
