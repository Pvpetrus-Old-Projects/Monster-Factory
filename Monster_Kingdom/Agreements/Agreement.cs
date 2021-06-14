using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Shapers;
namespace Monster_Kingdom.Agreements
{
    class Agreement
    {
        public  Double price { get; protected set; }
        public  Shaper shaper { get; protected set; }
        public Agreement()
        {
            
        }
        public Agreement(Double price,Shaper shaper)
        {
            this.price = price;
            this.shaper = shaper;
        }
        public override string ToString()
        {
            return "Price: "+price +" "+ "Shaper: " +shaper;
        }



        /*public override string ToString()
        {
            return base.ToString() + $" Pracuje nad: {Items.Count} pozycją/pozycjami";
        }
        public override string ToString()
        {
            return $"{Author.Name} {Author.Surname}";
        }*/
        //pomocnicze
    }
}
