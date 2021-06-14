using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster_Kingdom.Shapers
{
    class Shaper
    {
        public  String name { get; set; }
        public  String surname { get; set; }
        public  int id { get; set; }
        public Shaper()
        {

        }
        public Shaper(String name,String surname,int id)
        {
            this.name = name;
            this.surname = surname;
            this.id = id;
        }
        public override string ToString()
        {
            return "Tworzyciel: ID: "+id+" Imię: "+name+" Nazwisko: "+surname ;
        }
    }
    
}
