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
        public int id { get; protected set; }
        public String race { get; protected set; }
        public Double price { get; protected set; }
        public Shaper shaper { get; protected set; }
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
        public override string ToString()
        {
            return "id: " + id + "Rasa: " + race + " cena: " + price;
        }
    }
}
