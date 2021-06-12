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
        protected Double price { get; set; }
        protected Shaper shaper { get; set; }
        public Agreement()
        {
            
        }
        public Agreement(Double price,Shaper shaper)
        {
            this.price = price;
            this.shaper = shaper;
        }
    }
}
