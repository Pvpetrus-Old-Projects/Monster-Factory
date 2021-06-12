using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Mothers_Of_The_Swarm;
using Monster_Kingdom.Monsters;
using Monster_Kingdom.Agreements;
using Monster_Kingdom.Army_Centers;
using Monster_Kingdom.Shapers;

namespace Monster_Kingdom.Kingdoms
{
    class Kingdom
    {
        private List<Shaper> shapers { get; set; }
        private List<Mother_Of_The_Swarm> mothers_Of_The_Swarm { get; set; }
        private List<Agreement> agreements { get; set; }
        private List<Monster> monsters { get; set; }
        private Army_Center army_Center { get; set; }
        public Kingdom()
        {
            this.shapers = new List<Shaper>();
            this.mothers_Of_The_Swarm = new List<Mother_Of_The_Swarm>();
            this.agreements = new List<Agreement>();
            this.monsters = new List<Monster>();
        }
        public Kingdom(List<Shaper> shapers,List<Mother_Of_The_Swarm> mothers_Of_The_Swarm,List<Agreement> agreements,List<Monster> monsters,Army_Center army_Center)
        {
            this.shapers = shapers;
            this.mothers_Of_The_Swarm = mothers_Of_The_Swarm;
            this.agreements = agreements;
            this.monsters = monsters;
            this.army_Center = army_Center;
        }
        public void Add_Shaper(Shaper shaper)
        {

        }
        public void Add_Mother_Of_The_Swarm(Mother_Of_The_Swarm mother_Of_The_Swarm)
        {

        }
        public void Add_Agreement(Agreement agreement)
        {

        }
        public void Remove_Shaper(Shaper shaper)
        {

        }
        public void Remove_Mother_Of_The_Swarm(Mother_Of_The_Swarm mother_Of_The_Swarm)
        {

        }
        public void Remove_Agreement(Agreement agreement)
        {

        }
        public void Order(Monster monster)
        {

        }
        public void Add_Monster(Monster monster)
        {

        }
        public void Remove_Monster(Monster monster)
        {

        }
    }
}
