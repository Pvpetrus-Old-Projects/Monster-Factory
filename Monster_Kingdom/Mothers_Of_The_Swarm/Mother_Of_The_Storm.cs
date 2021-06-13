using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Monster_Kingdom.Army_Centers;
using Monster_Kingdom.Monsters;
using Monster_Kingdom.Kingdoms;
namespace Monster_Kingdom.Mothers_Of_The_Swarm
{
    class Mother_Of_The_Swarm
    {
        public bool ability_To_Spawn_Imps { get; private set; }
        public Mother_Of_The_Swarm()
        {

        }
        public Mother_Of_The_Swarm(bool ability_To_Spawn_Imps)
        {
            this.ability_To_Spawn_Imps = ability_To_Spawn_Imps;
        }
        public void Create(Monster monster,Kingdom kingdom)
        {
            try
            {
            kingdom.Add_Monster(monster);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
        }
        public Monster Create(Monster monster)
        {
            return monster;
        }
        public override string ToString()
        {
            return "Matka: umiejętność tworzenia impów: "+ability_To_Spawn_Imps;
        }
    }
}
