using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Kingdom.Shapers
{
    class Shaper
    {
        private String name { get; set; }
        private String surname { get; set; }
        private int id { get; set; }
        public Shaper()
        {

        }
        public Shaper(String name,String surname,int id)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
        }
    }
}
