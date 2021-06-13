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
        public List<Shaper> shapers { get; set; }
        public List<Mother_Of_The_Swarm> mothers_Of_The_Swarm { get; set; }
        public List<Agreement> agreements { get; set; }
        public List<Monster> monsters { get; set; }
        public Army_Center army_Center { get; set; }
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
            if (shapers.Contains(shaper)) throw new ArgumentException("There already is such a shaper");
            else shapers.Add(shaper);
        }
        public void Add_Mother_Of_The_Swarm(Mother_Of_The_Swarm mother_Of_The_Swarm)
        {
            if (mothers_Of_The_Swarm.Contains(mother_Of_The_Swarm)) throw new ArgumentException("There already is such a mother");
            else mothers_Of_The_Swarm.Add(mother_Of_The_Swarm);
        }
        public void Add_Agreement(Agreement agreement)
        {
            if (agreements.Contains(agreement)) throw new ArgumentException("There already is such an agreement");
            else agreements.Add(agreement);
        }
        public void Remove_Shaper(Shaper shaper)
        {
            if (shapers.Contains(shaper)) shapers.Remove(shaper);
            else throw new ArgumentException("There is no such shaper to remove");
        }
        public void Remove_Mother_Of_The_Swarm(Mother_Of_The_Swarm mother_Of_The_Swarm)
        {
            if (mothers_Of_The_Swarm.Contains(mother_Of_The_Swarm)) mothers_Of_The_Swarm.Remove(mother_Of_The_Swarm);
            else throw new ArgumentException("There is no such mother to remove");
        }
        public void Remove_Agreement(Agreement agreement)
        {
            if (agreements.Contains(agreement)) agreements.Remove(agreement);
            else throw new ArgumentException("There is no such agreement to remove");
        }
        public void Order(Monster monster)
        {
            bool no_Appropriate_Mother = true;
            Random random = new Random();
            int random_Number = random.Next(0, mothers_Of_The_Swarm.Count);
            if (mothers_Of_The_Swarm.Count == 0) throw new NullReferenceException("There are no mothers in the kingdom");
            if(monster is Demon)
            {
                if(monster.race=="Imp")
                {
                    foreach(Mother_Of_The_Swarm mother_Of_The_Swarm in mothers_Of_The_Swarm)
                    {
                        if(mother_Of_The_Swarm.ability_To_Spawn_Imps==true)
                        {
                            if (!monsters.Contains(monster)) monsters.Add(mother_Of_The_Swarm.Create(monster));
                            else throw new ArgumentException("Such monster already exists");
                            no_Appropriate_Mother = false;
                            break;
                        }
                        else
                        {
                            no_Appropriate_Mother = true;
                        }
                    }
                    if (no_Appropriate_Mother == true)
                    {
                        throw new NullReferenceException("There are no mothers of such qualifications");
                    }
                }
                else
                {
                    Mother_Of_The_Swarm mother = mothers_Of_The_Swarm.FirstOrDefault();
                    if (!monsters.Contains(monster)) monsters.Add(mother.Create(monster));
                    else throw new ArgumentException("Such monster already exists");
                }
            }
        }
        public void Add_Monster(Monster monster)
        {
            if (monsters.Contains(monster)) throw new ArgumentException("There already is such a monster ");
            else monsters.Add(monster);
        }
        public void Remove_Monster(Monster monster)
        {
            if (monsters.Contains(monster)) monsters.Remove(monster);
            else throw new ArgumentException("There is no such monster to remove");
        }
        public override string ToString()
        {
            return "Królestwo:\n"+"Tworzyciele:\n"+shapers+"Matki miotu:\n"+mothers_Of_The_Swarm+"Umowy:\n"+agreements+"Potwory:\n"+monsters+"Centrum wojska:\n"+army_Center;
        }
    }
}
