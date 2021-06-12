using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Shapers;
namespace Monster_Kingdom.Monsters
{
    class Ork:Monster
    {
        private String color { get; set; }
        public Ork() : base()
        {

        }
        public Ork(String race, int id, Double price, Shaper shaper,String color) : base(race, id, price, shaper)
        {
            this.color = color;
        }
    }
}
