using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGame
{
    public partial class MainGame : Form
    {
        public PlayerCharacter playerCharacter { get; set; }
        public EnemyCharacter newEnemy { get; set; }
        double critModifier = 1.2;
        double weaknessModifier = 2;



        private static Random rand;
        static MainGame()
        {
            rand = new Random();
        }

        public MainGame(PlayerCharacter character)
        {
            InitializeComponent();
            this.playerCharacter = character;
        }

        private void MainGame_Load(object sender, EventArgs e)
        {
            BindControls();
            disableFightButtons();
            DisableLootButtons();
        }

        private void BindControls()
        {
            this.lblPlayerName.DataBindings.Clear();
            this.lblHealth.DataBindings.Clear();
            this.lblStrength.DataBindings.Clear();
            this.lblWisdom.DataBindings.Clear();
            this.lblIntelligence.DataBindings.Clear();
            this.lblDexterity.DataBindings.Clear();
            this.lblScore.DataBindings.Clear();
            this.lblSkillPoints.DataBindings.Clear();
            this.lblWeaponName.DataBindings.Clear();
            this.lblWeaponDamage.DataBindings.Clear();
            this.lblWeaponType.DataBindings.Clear();
            this.lblArmorBonusHealth.DataBindings.Clear();
            this.lblArmorName.DataBindings.Clear();
            this.lblArmorType.DataBindings.Clear();





            this.lblPlayerName.DataBindings.Add(new Binding("Text", playerCharacter, "PlayerName"));
            this.lblHealth.DataBindings.Add(new Binding("Text", playerCharacter, "Health"));
            this.lblStrength.DataBindings.Add(new Binding("Text", playerCharacter, "Strength"));
            this.lblWisdom.DataBindings.Add(new Binding("Text", playerCharacter, "Wisdom"));
            this.lblIntelligence.DataBindings.Add(new Binding("Text", playerCharacter, "Intelligence"));
            this.lblDexterity.DataBindings.Add(new Binding("Text", playerCharacter, "Dexterity"));
            this.lblWeaponName.DataBindings.Add(new Binding("Text", playerCharacter.EquippedWeapon, "WeaponName"));
            this.lblWeaponDamage.DataBindings.Add(new Binding("Text", playerCharacter.EquippedWeapon, "AttributeModifier"));
            this.lblWeaponType.DataBindings.Add(new Binding("Text", playerCharacter.EquippedWeapon, "damageType"));
            this.lblArmorType.DataBindings.Add(new Binding("Text", playerCharacter.EquippedArmor, "ResistantTo"));
            this.lblArmorName.DataBindings.Add(new Binding("Text", playerCharacter.EquippedArmor, "ArmorName"));
            this.lblArmorBonusHealth.DataBindings.Add(new Binding("Text", playerCharacter.EquippedArmor, "HealthModifier"));
            this.lblScore.DataBindings.Add(new Binding("Text", playerCharacter, "PlayerLevel"));

            this.lblSkillPoints.DataBindings.Add(new Binding("Text", playerCharacter, "UnspentSkillPoints"));

        }

        /// <summary>
        /// checks to see if there are avaliable skill points to spend. If there are, it enables the level up buttons
        /// otherwise it disalbes them
        /// </summary>
        private bool checkIfLevelUpIsAvaliable()
        {
            if (this.lblSkillPoints.Text.Equals("0"))
                return false;
            else
                return true;
        }

        /// <summary>
        /// generates the attributes to be assigned to a loot weapon and displays them in the lott control
        /// </summary>
        private void GenerateLoot()
        {
            //Generate start by generating the shared properties - Attribute modifier and attribute Type
            int attributeModifier;
            if (playerCharacter.PlayerLevel < 16)
                attributeModifier = rand.Next(16);
            else
                attributeModifier = rand.Next((playerCharacter.PlayerLevel - 10), playerCharacter.PlayerLevel + 10);

            string TypeChanceOutput = "";
            int typeChance = rand.Next();
            if (typeChance % 2 == 0 )
                TypeChanceOutput = "Magic";
            else
                TypeChanceOutput = "Physical";
            string EquipmentChanceOutput = "";
            int equipmentChance = rand.Next();

            if (equipmentChance % 2 == 0)
                EquipmentChanceOutput = "Weapon";
            else
                EquipmentChanceOutput = "Armor";

            this.lblLootType.Text = EquipmentChanceOutput;
            this.lblLootDamageType.Text = TypeChanceOutput;
            this.lblLootModAmount.Text = attributeModifier.ToString();
        }

        #region accidents
        /// <summary>
        /// accidental hit. please ignore thanxs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Label7_Click(object sender, EventArgs e)
        {

        }

        private void LblPlayerName_Click(object sender, EventArgs e)
        {

        }


        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }
        #endregion


        private void SeedFightData(EnemyCharacter currentEnemy)
        {
            if (currentEnemy.EquippedWeapon.damageType == Enums.DamageTypes.MAGIC)
                this.lblFightEnemyPower.Text = (currentEnemy.Intelligence + (currentEnemy.EquippedWeapon.AttributeModifier)*10).ToString();
            else
                this.lblFightEnemyPower.Text = (currentEnemy.Strength + (currentEnemy.EquippedWeapon.AttributeModifier) * 10).ToString();
            this.lblFightEnemyType.Text = currentEnemy.EquippedWeapon.damageType.ToString();
            this.numFightEnemyHealth.Value = (currentEnemy.Health + (currentEnemy.EquippedArmor.HealthModifier * 100));
            this.numFightPlayerHealth.Value = (playerCharacter.Health + (playerCharacter.EquippedArmor.HealthModifier * 100));
            int wisdomCheck = currentEnemy.Wisdom;
            if(playerCharacter.Wisdom > wisdomCheck)
            {
                this.lblFightWeakness.Text = currentEnemy.Weakness.ToString();
            }
            else
            {
                this.lblFightWeakness.Text = "You have a bad case of smol brain";
            }

            
        }

        /// <summary>
        /// clears the bindings of an old equipment and updates it. 
        /// </summary>
        private void UpdateEquipmentBindings()
        {
            this.lblWeaponName.DataBindings.Clear();
            this.lblWeaponType.DataBindings.Clear();
            this.lblWeaponDamage.DataBindings.Clear();
            this.lblWeaponName.DataBindings.Add(new Binding("Text", playerCharacter.EquippedWeapon, "WeaponName"));
            this.lblWeaponDamage.DataBindings.Add(new Binding("Text", playerCharacter.EquippedWeapon, "AttributeModifier"));
            this.lblWeaponType.DataBindings.Add(new Binding("Text", playerCharacter.EquippedWeapon, "damageType"));

            this.lblArmorBonusHealth.DataBindings.Clear();
            this.lblArmorName.DataBindings.Clear();
            this.lblArmorType.DataBindings.Clear();
            this.lblArmorType.DataBindings.Add(new Binding("Text", playerCharacter.EquippedArmor, "ResistantTo"));
            this.lblArmorName.DataBindings.Add(new Binding("Text", playerCharacter.EquippedArmor, "ArmorName"));
            this.lblArmorBonusHealth.DataBindings.Add(new Binding("Text", playerCharacter.EquippedArmor, "HealthModifier"));
        }

        /// <summary>
        /// generates a random enemy for the player to fight
        /// </summary>
        /// <returns></returns>
        private EnemyCharacter generateEnemyCharacter()
        {
            EnemyCharacter newEnemy = new EnemyCharacter(playerCharacter.FloorsCleared);

            return newEnemy;
        }

        /// <summary>
        /// generates a random weapon for the character to loot
        /// </summary>
        private void generateLootWeapon()
        {
            Enums.DamageTypes newType;
            if (this.lblLootDamageType.Text.Equals("Magic"))
                newType = Enums.DamageTypes.MAGIC;
            else
                newType = Enums.DamageTypes.PHYSICAL;
            int modAmount = int.Parse(this.lblLootModAmount.Text);

            Weapon newWeapon = new Weapon(this.txtLootName.Text, modAmount, newType);
            this.playerCharacter.EquippedWeapon = newWeapon;
            UpdateEquipmentBindings();
        }

        private void generateLootArmor()
        {
            Enums.DamageTypes newType;
            if (this.lblLootDamageType.Text.Equals("Magic"))
                newType = Enums.DamageTypes.MAGIC;
            else
                newType = Enums.DamageTypes.PHYSICAL;
            int modAmount = int.Parse(this.lblLootModAmount.Text);

            CharacterArmor newArmor = new CharacterArmor(this.txtLootName.Text, modAmount, newType);
            this.playerCharacter.EquippedArmor = newArmor;
            UpdateEquipmentBindings();
        }

        #region fight methods and functions
        ///Guiding principles
        ///a number will go in and be mutated to provide a mutliplier, which each function will then return
        ///these will all be called in a "master function" called calculate damage
        ///

        ///Determins if a character scored a critical hit
        private double critCheck(double startingValue)
        {
            double currentDamage = startingValue;
            int critChance = (playerCharacter.Dexterity * 5);
            int critOdds = rand.Next(0, (100 + playerCharacter.FloorsCleared));
            if (critChance >= critOdds)
                currentDamage = (currentDamage * critModifier);
            return currentDamage;
        }

        /// <summary>
        /// Checks to see if a character is dealing an enemies weakness type
        /// </summary>
        /// <param name="startingValue"></param>
        /// <param name="playerDamage"></param>
        /// <param name="enemyWeakness"></param>
        /// <returns></returns>
        private double weaknessCheck(double startingValue, Enums.DamageTypes playerDamage, Enums.DamageTypes enemyWeakness)
        {
            double currentDamage = startingValue;
            if (playerDamage.Equals(enemyWeakness))
                currentDamage = (currentDamage * weaknessModifier);
            return currentDamage;
        }

        /// <summary>
        /// determins a characters chance to dodge an attack
        /// </summary>
        /// <param name="dex"></param>
        /// <returns></returns>
        private bool dodgeAttack(int dex)
        {
            int dexCheck = rand.Next(0, (100 + (playerCharacter.FloorsCleared * 5)));
            if ((dex * 5) > dexCheck)
                return true;
            else
                return false;
        }

        /// <summary>
        /// determins how much damage a character will do with a physical attack
        /// </summary>
        /// <returns></returns>
        private int dealCharacterPhysicalDamage()
        {
            double weaponModifier = 0;
            if (playerCharacter.EquippedWeapon.damageType.Equals(Enums.DamageTypes.PHYSICAL))
                weaponModifier = 10 * playerCharacter.EquippedWeapon.AttributeModifier;

            

            double baseStrength = playerCharacter.Strength + weaponModifier;
            baseStrength = critCheck(baseStrength);
            baseStrength = weaknessCheck(baseStrength, Enums.DamageTypes.PHYSICAL, newEnemy.Weakness);
            
            return (int)(baseStrength);
        }

        /// <summary>
        /// determins how much damage a character deals with a magic attack
        /// </summary>
        /// <returns></returns>
        private int dealCharacterMagicDamage()
        {
            double weaponModifier = 0;
            if (playerCharacter.EquippedWeapon.damageType.Equals(Enums.DamageTypes.MAGIC))
                weaponModifier = 10 * playerCharacter.EquippedWeapon.AttributeModifier;



            double baseSmarts = playerCharacter.Strength + weaponModifier;
            baseSmarts = critCheck(baseSmarts);
            baseSmarts = weaknessCheck(baseSmarts, Enums.DamageTypes.PHYSICAL, newEnemy.Weakness);

            return (int)(baseSmarts);
        }

        private bool ResistanceCheck()
        {
            if (newEnemy.EnemyType.Equals(playerCharacter.EquippedArmor.ResistantTo))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Determins how much damage an enemy deals in an attack
        /// </summary>
        /// <returns></returns>
        private int dealEnemyDamage()
        {
            double baseStats = 0;
            if (newEnemy.EquippedWeapon.damageType.Equals(Enums.DamageTypes.MAGIC))
                baseStats = newEnemy.Intelligence + (newEnemy.EquippedWeapon.AttributeModifier * 10);
            else
                baseStats = newEnemy.Strength + (newEnemy.EquippedWeapon.AttributeModifier * 10);

            return (int)baseStats;

            

        }

        private void ScrollText(string newString)
        {
            string previousLogMid = this.lblLogMid.Text;
            string previousLogTop = this.lblLogTop.Text;
            this.lblLogBot.Text = this.lblLogMid.Text;
            this.lblLogMid.Text = this.lblLogTop.Text;
            this.lblLogTop.Text = newString;


        }
        # endregion



        private void enableFightButtons()
        {
            this.btnMagicAttack.Enabled = true;
            this.btnPhysicalAttack.Enabled = true;
        }

        private void disableMenuButtons()
        {
            this.btnFight.Enabled = false;
            this.btnLoot.Enabled = false;
        }

        private void enableMenuButtons()
        {
            this.btnFight.Enabled = true;
            this.btnLoot.Enabled = true;
        }

        private void disableFightButtons()
        {
            this.btnMagicAttack.Enabled = false;
            this.btnPhysicalAttack.Enabled = false;
        }

        /// <summary>
        /// Disables all buttons in the lootbox control group
        /// </summary>
        private void DisableLootButtons()
        {
            this.btnLootKeep.Enabled = false;
            this.btnLootDiscard.Enabled = false;
        }

        private void clearLootButtons()
        {
            this.lblLootDamageType.Text = "";
            this.lblLootModAmount.Text = "";
            this.lblLootType.Text = "";
        }

        /// <summary>
        /// endables all controls in the loot box buttons
        /// </summary>
        private void EnableLootButtons()
        {
            this.btnLootKeep.Enabled = true;
            this.btnLootDiscard.Enabled = true;
        }

        /// <summary>
        /// enables level up skill buttons
        /// </summary>
        private void EnableSkillButtons()
        {
            this.btnLevelUpHealth.Enabled = true;
            this.btnLevelUpStrength.Enabled = true;
            this.btnLevelUpInt.Enabled = true;
            this.btnLvlUpDex.Enabled = true;
            this.btnLvlUpWisdom.Enabled = true;
        }

        /// <summary>
        /// disables level up skill buttons
        /// </summary>
        private void DisableSkillButtons()
        {
            this.btnLevelUpHealth.Enabled = false;
            this.btnLevelUpStrength.Enabled = false;
            this.btnLevelUpInt.Enabled = false;
            this.btnLvlUpDex.Enabled = false;
            this.btnLvlUpWisdom.Enabled = false;
        }
        #region control events

        /// <summary>
        /// equip the dropped weapon to the character
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLootKeep_Click(object sender, EventArgs e)
        {
            if (this.lblLootType.Text.Equals("Weapon"))
            {
                generateLootWeapon();
                DisableLootButtons();
                enableMenuButtons();
            }
            else
            {
                generateLootArmor();
                DisableLootButtons();
                enableMenuButtons();
            }
        }

        /// <summary>
        /// enables the loot buttons when a piece of loot drops
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtNamedCharacter_TextChanged(object sender, EventArgs e)
        {
            this.btnLootKeep.Enabled = true;
        }



        private void BtnLoot_Click(object sender, EventArgs e)
        {
            this.playerCharacter.FloorsCleared++;
            clearLootButtons();
            EnableLootButtons();
            disableMenuButtons();
            GenerateLoot();
        }
        #endregion

        private void BtnFight_Click(object sender, EventArgs e)
        {
            disableMenuButtons();
            enableFightButtons();
            playerCharacter.FloorsCleared++;
            newEnemy = generateEnemyCharacter();
            SeedFightData(newEnemy);
        }

        private void BtnPhysicalAttack_Click(object sender, EventArgs e)
        {
            int damageDelt = dealCharacterPhysicalDamage();
            damageDelt = rand.Next(0, damageDelt);
            this.numFightEnemyHealth.Value -= damageDelt;
            string damageString = " you delt " + damageDelt + "Damage";
            ScrollText(damageString);
            if (this.numFightEnemyHealth.Value <= 0)
            {
                enableMenuButtons();
                disableFightButtons();
                playerCharacter.PlayerLevel++;
            }
            else
            {
                int enemyDamage = dealEnemyDamage();//Random object is created in method. Look into changing this!
                enemyDamage = rand.Next(0, enemyDamage);
                bool resist = ResistanceCheck();
                if (resist)
                    enemyDamage = (enemyDamage / 2);
                bool dodged = dodgeAttack(playerCharacter.Dexterity);
                if (!dodged)
                    this.numFightPlayerHealth.Value -= enemyDamage;
                else
                    enemyDamage = 0;
                string enemyDamageString = "the Enemy delt " + enemyDamage + "damage";
                ScrollText(enemyDamageString);
                if(numFightPlayerHealth.Value <= 0)
                {
                    disableFightButtons();
                    disableMenuButtons();
                    DisableSkillButtons();
                    DisableLootButtons();
                    string gameOver = "Game over, you made it to floor " + playerCharacter.PlayerLevel;
                    ScrollText(gameOver);
                }
            }
                
        }

        private void LblSkillPoints_TextChanged(object sender, EventArgs e)
        {
            if (lblSkillPoints.Text.Equals("0"))
                DisableSkillButtons();
            else
                EnableSkillButtons();
        }

        private void BtnMagicAttack_Click(object sender, EventArgs e)
        {
            int damageDelt = dealCharacterMagicDamage();
            damageDelt = rand.Next(0, damageDelt);
            this.numFightEnemyHealth.Value -= damageDelt;
            string damageString = " you delt " + damageDelt + " Damage to the enemy";
            ScrollText(damageString);
            if (this.numFightEnemyHealth.Value <= 0)
            {
                enableMenuButtons();
                disableFightButtons();
                playerCharacter.PlayerLevel++;
            }
            else
            {
                int enemyDamage = dealEnemyDamage();
                enemyDamage = rand.Next(0, enemyDamage);
                bool resist = ResistanceCheck();
                if (resist)
                    enemyDamage = (enemyDamage / 2);
                bool dodged = dodgeAttack(playerCharacter.Dexterity);
                if (!dodged)
                    this.numFightPlayerHealth.Value -= enemyDamage;
                else
                    enemyDamage = 0;
                string enemyDamageString = "the Enemy delt " + enemyDamage + "damage to you";
                ScrollText(enemyDamageString);
                if (numFightPlayerHealth.Value <= 0)
                {
                    disableFightButtons();
                    disableMenuButtons();
                    DisableSkillButtons();
                    DisableLootButtons();
                    string gameOver = "Game over, you made it to floor " + playerCharacter.PlayerLevel;
                    ScrollText(gameOver);
                }
            }
        }

        private void BtnLevelUpHealth_Click(object sender, EventArgs e)
        {
            playerCharacter.LevelUp(Enums.CharacterAttributes.HEALTH);
            BindControls();
        }

        private void BtnLevelUpStrength_Click(object sender, EventArgs e)
        {
            playerCharacter.LevelUp(Enums.CharacterAttributes.STRENGTH);
            BindControls();
        }

        private void BtnLvlUpWisdom_Click(object sender, EventArgs e)
        {
            playerCharacter.LevelUp(Enums.CharacterAttributes.WISDOM);
            BindControls();
        }

        private void BtnLevelUpInt_Click(object sender, EventArgs e)
        {
            playerCharacter.LevelUp(Enums.CharacterAttributes.ITELLIGENCE);
            BindControls();
        }

        private void BtnLvlUpDex_Click(object sender, EventArgs e)
        {
            playerCharacter.LevelUp(Enums.CharacterAttributes.DEX);
            BindControls();
        }

        private void NumFightEnemyHealth_ValueChanged(object sender, EventArgs e)
        {
            if (numFightEnemyHealth.Value < 0)
            {
                this.playerCharacter.UnspentSkillPoints++;
                enableMenuButtons();
            }
            BindControls();
        }

        private void BtnLootDiscard_Click(object sender, EventArgs e)
        {
            DisableLootButtons();
            enableMenuButtons();
        }
    }
}
