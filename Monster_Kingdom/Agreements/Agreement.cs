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
        protected Double price;
        protected Shaper shaper;
        public Agreement(Double price,Shaper shaper)
        {
            this.price = price;
            this.shaper = shaper;
        }
    }
}
