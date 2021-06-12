using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Shapers;
namespace Monster_Kingdom.Monsters
{
    abstract class Monster
    {
        protected String race { get; set; }
        protected int id { get; set; }
        protected Double price { get; set; }
        protected Shaper shaper { get; set; }
        public Monster()
        {

        }
        public Monster(String race,int id,Double price,Shaper shaper)
        {
            this.race = race;
            this.id = id;
            this.price = price;
            this.shaper = shaper;
        }
    }
}
