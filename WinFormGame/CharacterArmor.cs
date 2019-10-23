using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGame
{
    public class CharacterArmor
    {
        Random rand = new Random();
        public int HealthModifier { get; set; }//how much health the armor will add to the player character
        //now based off player character instead of armor itself
        public int ArmorLevel { get; set; }//restrict this to be the level that the armor is found on
        public string ArmorName { get; set; }
        public Enums.DamageTypes ResistantTo { get; set; }

        /// <summary>
        /// base constructor for an enemy class
        /// </summary>
        public CharacterArmor(int levelFound)
        {
            this.ArmorLevel = levelFound;
            this.HealthModifier = StaticFunctions.setGearLevel(this.ArmorLevel);
        }

        /// <summary>
        /// constructor with a name and level. Used on game start
        /// </summary>
        /// <param name="levelFound"></param>
        /// <param name="armorName"></param>
        public CharacterArmor(int levelFound, string armorName)
        {
            this.ArmorLevel = levelFound;
            this.ArmorName = armorName;
            this.HealthModifier = StaticFunctions.setGearLevel(this.ArmorLevel);
        }

        /// <summary>
        /// Armor constructor with full definitition. Used in loot drops
        /// </summary>
        /// <param name="armorName"></param>
        /// <param name="level"></param>
        /// <param name="type"></param>
        public CharacterArmor(string armorName, int level, Enums.DamageTypes type)
        {
            this.ArmorName = armorName;
            this.HealthModifier = level;
            this.ResistantTo = type;
        }

    }
}
