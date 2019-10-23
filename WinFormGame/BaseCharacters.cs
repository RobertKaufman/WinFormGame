using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormGame
{
    public abstract class BaseCharacters
    {

        //how much damage a character can take
        public int Health { get; set; }
        //how much physical damage they do
        public int Strength { get; set; }
        //how much magic damage they can do
        public int Intelligence { get; set; }
        //how likelyhood of recognizing a weakness
        public int Wisdom { get; set; }
        //modifies dodge chance
        public int Dexterity { get; set; }

        //the current armor they have equipped - modifies the health set
        public CharacterArmor EquippedArmor { get; set; }

        //the weapon they have equipped. modifies either strength or intelligence
        public Weapon EquippedWeapon { get; set; }

        //either the floor level or the choicesMade level, depending on whether it is a player character
        public int CurrentCharacterLevel { get; set; }

    }

    /// <summary>
    /// generates an enemy character for the player character to fight
    /// </summary>
    public class EnemyCharacter : BaseCharacters
    {
        private static Random rand;
        static EnemyCharacter()
        {
            rand = new Random();
        }

        public Enums.DamageTypes Weakness { get; set; }
        public Enums.DamageTypes EnemyType { get; set; }

        public EnemyCharacter(int choicesMade)
        {
            this.Health = ((choicesMade + 1) * 75);
            this.Intelligence = (rand.Next(1, (choicesMade + 1)) * 7);
            this.Strength = (rand.Next(1, (choicesMade + 1)) * 7);
            this.Wisdom = rand.Next(1, (choicesMade + 1));
            this.Dexterity = rand.Next(1, (choicesMade + 1));

            this.EquippedWeapon = new Weapon(choicesMade);
            this.EquippedArmor = new CharacterArmor(choicesMade);
            this.EnemyType = EquippedWeapon.damageType;

            if (rand.Next() % 2 == 0)
                Weakness = Enums.DamageTypes.MAGIC;
            else
                Weakness = Enums.DamageTypes.PHYSICAL;

        }

    }

    /// <summary>
    /// A represnetation of the play character. Distinct from EnemyCharacter.
    /// </summary>
    public class PlayerCharacter : BaseCharacters
    {
        public string PlayerName { get; set; }
        public int UnspentSkillPoints { get; set; }
        public int PlayerLevel { get; set; }
        public int FloorsCleared { get; set; }

        /// <summary>
        /// generates a new player character with all attributes defined
        /// </summary>
        /// <param name="name"></param>
        /// <param name="health"></param>
        /// <param name="strength"></param>
        /// <param name="wisdom"></param>
        /// <param name="intelligence"></param>
        /// <param name="dexterity"></param>
        public PlayerCharacter(string name, int health, int strength, int wisdom, int intelligence, int dexterity)
        {
            this.PlayerName = name;
            this.Health = (health * 100);
            this.Strength = (strength * 10);
            this.Wisdom = wisdom;
            this.Intelligence = (intelligence * 10);
            this.Dexterity = dexterity;
            this.UnspentSkillPoints = 0;
            this.PlayerLevel = 0;
            this.FloorsCleared = 0;
            this.EquippedArmor = new CharacterArmor(1, "Pure Stubborness");
            this.EquippedWeapon = new Weapon("Weak Punches", 1);
            //launch an alert if the player character has unspent skill points to level up
            //have a button to click if the player has unspent skill points

        }

        public void LevelUp(Enums.CharacterAttributes skillToLevelUp)
        {
            switch (skillToLevelUp)
            {
                case Enums.CharacterAttributes.HEALTH:
                    this.Health += 100;
                    this.UnspentSkillPoints--;
                    break;
                case Enums.CharacterAttributes.ITELLIGENCE:
                    this.Intelligence += 10;
                    this.UnspentSkillPoints--;
                    break;
                case Enums.CharacterAttributes.STRENGTH:
                    this.Strength += 10;
                    this.UnspentSkillPoints--;
                    break;
                case Enums.CharacterAttributes.WISDOM:
                    this.Wisdom++;
                    this.UnspentSkillPoints--;
                    break;
                case Enums.CharacterAttributes.DEX:
                    this.Dexterity++;
                    this.UnspentSkillPoints--;
                    break;
            }
              
        }
    }
}
