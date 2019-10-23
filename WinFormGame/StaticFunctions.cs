using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGame
{
    public static class StaticFunctions
    {
        /// <summary>
        /// Sets the weapons damage type to be either magic of physical
        /// </summary>
        /// <returns>the damage type this weapon will deal</returns>
        public static Enums.DamageTypes setGearType()
        {
            Random rand = new Random();
            Enums.DamageTypes returnDamageType;

            int CoinFlip = rand.Next();
            if (CoinFlip % 2 == 0)
                returnDamageType = Enums.DamageTypes.MAGIC;
            else
                returnDamageType = Enums.DamageTypes.PHYSICAL;

            return returnDamageType;
        }

        /// <summary>
        /// sets the gear level found
        /// </summary>
        /// <param name="currentLevel">the relevent floor level or enemy level based on situation</param>
        /// <returns></returns>
        public static int setGearLevel(int currentLevel)
        {
            Random rand = new Random();
            int returnInt = rand.Next(currentLevel);
            return returnInt;

        }


    }
}
