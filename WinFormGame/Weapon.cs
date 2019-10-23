using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormGame;

namespace WinFormGame
{
    public class Weapon
    {
        public int AttributeModifier { get; set; }//
        public Enums.DamageTypes damageType { get; set; }
        public int WeaponLevel { get; set; }//retrict the level type to not be above the current level in the program
        public string WeaponName { get; set; }//prompt the user to give the weapon a name once they pick it up
        Random rand = new Random();

        /// <summary>
        /// autoconstructor for enemy character classes
        /// </summary>
        public Weapon(int weaponLevel)
        {
            this.WeaponLevel = weaponLevel;
            this.AttributeModifier = rand.Next(weaponLevel);//look at refactoring to create a method to return the level
            this.damageType = StaticFunctions.setGearType();
        }

        /// <summary>
        /// overloaded constructor for character classes
        /// </summary>
        /// <param name="weaponName"></param>
        public Weapon(string weaponName)
        {
            this.WeaponName = weaponName;
            this.AttributeModifier = rand.Next(this.WeaponLevel);//look at refactoring to create a method to return the level
            this.damageType = StaticFunctions.setGearType();

        }

        /// <summary>
        /// generates a weapon with a name and an initial value. Used on game start
        /// </summary>
        /// <param name="weaponName"></param>
        /// <param name="startingValue"></param>
        public Weapon(string weaponName, int startingValue)
        {
            this.WeaponName = weaponName;
            this.AttributeModifier = startingValue;
            this.damageType = StaticFunctions.setGearType();

        }

        /// <summary>
        /// generates a weapon with full attributes. Used in loot drops
        /// </summary>
        /// <param name="weaponName"></param>
        /// <param name="startingValue"></param>
        /// <param name="damageType"></param>
        public Weapon(string weaponName, int startingValue, Enums.DamageTypes damageType)
        {
            this.WeaponName = weaponName;
            this.AttributeModifier = startingValue;
            this.damageType = damageType;
        }




    }
}
