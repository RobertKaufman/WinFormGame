namespace WinFormGame
{
    partial class MainGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.grpCurrentStats = new System.Windows.Forms.GroupBox();
            this.lblSkillPoints = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDexterity = new System.Windows.Forms.Label();
            this.lblIntelligence = new System.Windows.Forms.Label();
            this.lblWisdom = new System.Windows.Forms.Label();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEquipment = new System.Windows.Forms.GroupBox();
            this.lblArmorName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblArmorBonusHealth = new System.Windows.Forms.Label();
            this.lblArmorType = new System.Windows.Forms.Label();
            this.lblWeaponDamage = new System.Windows.Forms.Label();
            this.lblWeaponType = new System.Windows.Forms.Label();
            this.lblWeaponName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnFight = new System.Windows.Forms.Button();
            this.btnLoot = new System.Windows.Forms.Button();
            this.btnLevelUpHealth = new System.Windows.Forms.Button();
            this.btnLevelUpStrength = new System.Windows.Forms.Button();
            this.btnLvlUpWisdom = new System.Windows.Forms.Button();
            this.btnLevelUpInt = new System.Windows.Forms.Button();
            this.btnLvlUpDex = new System.Windows.Forms.Button();
            this.grpCombat = new System.Windows.Forms.GroupBox();
            this.lblLogBot = new System.Windows.Forms.Label();
            this.lblLogMid = new System.Windows.Forms.Label();
            this.lblLogTop = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblFightWeakness = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnMagicAttack = new System.Windows.Forms.Button();
            this.btnPhysicalAttack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLootName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnLootDiscard = new System.Windows.Forms.Button();
            this.btnLootKeep = new System.Windows.Forms.Button();
            this.lblLootModAmount = new System.Windows.Forms.Label();
            this.lblLootDamageType = new System.Windows.Forms.Label();
            this.lblLootType = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblFightEnemyType = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblFightEnemyPower = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblFightPlayerHealth = new System.Windows.Forms.Label();
            this.numFightEnemyHealth = new System.Windows.Forms.NumericUpDown();
            this.numFightPlayerHealth = new System.Windows.Forms.NumericUpDown();
            this.grpCurrentStats.SuspendLayout();
            this.grpEquipment.SuspendLayout();
            this.grpCombat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFightEnemyHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFightPlayerHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to the game!";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(152, 29);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 13);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Click += new System.EventHandler(this.LblPlayerName_Click);
            // 
            // grpCurrentStats
            // 
            this.grpCurrentStats.Controls.Add(this.lblSkillPoints);
            this.grpCurrentStats.Controls.Add(this.label8);
            this.grpCurrentStats.Controls.Add(this.lblScore);
            this.grpCurrentStats.Controls.Add(this.label7);
            this.grpCurrentStats.Controls.Add(this.lblDexterity);
            this.grpCurrentStats.Controls.Add(this.lblIntelligence);
            this.grpCurrentStats.Controls.Add(this.lblWisdom);
            this.grpCurrentStats.Controls.Add(this.lblStrength);
            this.grpCurrentStats.Controls.Add(this.lblHealth);
            this.grpCurrentStats.Controls.Add(this.label6);
            this.grpCurrentStats.Controls.Add(this.label5);
            this.grpCurrentStats.Controls.Add(this.label4);
            this.grpCurrentStats.Controls.Add(this.label3);
            this.grpCurrentStats.Controls.Add(this.label2);
            this.grpCurrentStats.Location = new System.Drawing.Point(530, 60);
            this.grpCurrentStats.Name = "grpCurrentStats";
            this.grpCurrentStats.Size = new System.Drawing.Size(291, 228);
            this.grpCurrentStats.TabIndex = 2;
            this.grpCurrentStats.TabStop = false;
            this.grpCurrentStats.Text = "Current Stats";
            // 
            // lblSkillPoints
            // 
            this.lblSkillPoints.AutoSize = true;
            this.lblSkillPoints.Location = new System.Drawing.Point(159, 144);
            this.lblSkillPoints.Name = "lblSkillPoints";
            this.lblSkillPoints.Size = new System.Drawing.Size(0, 13);
            this.lblSkillPoints.TabIndex = 13;
            this.lblSkillPoints.TextChanged += new System.EventHandler(this.LblSkillPoints_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Avaliable Skill Points:";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(159, 166);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 13);
            this.lblScore.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Enabled = false;
            this.label7.Location = new System.Drawing.Point(10, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Monsters Killed: ";
            this.label7.Click += new System.EventHandler(this.Label7_Click);
            // 
            // lblDexterity
            // 
            this.lblDexterity.AutoSize = true;
            this.lblDexterity.Location = new System.Drawing.Point(159, 122);
            this.lblDexterity.Name = "lblDexterity";
            this.lblDexterity.Size = new System.Drawing.Size(0, 13);
            this.lblDexterity.TabIndex = 9;
            // 
            // lblIntelligence
            // 
            this.lblIntelligence.AutoSize = true;
            this.lblIntelligence.Location = new System.Drawing.Point(159, 97);
            this.lblIntelligence.Name = "lblIntelligence";
            this.lblIntelligence.Size = new System.Drawing.Size(0, 13);
            this.lblIntelligence.TabIndex = 8;
            // 
            // lblWisdom
            // 
            this.lblWisdom.AutoSize = true;
            this.lblWisdom.Location = new System.Drawing.Point(159, 75);
            this.lblWisdom.Name = "lblWisdom";
            this.lblWisdom.Size = new System.Drawing.Size(0, 13);
            this.lblWisdom.TabIndex = 7;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.Location = new System.Drawing.Point(159, 51);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(0, 13);
            this.lblStrength.TabIndex = 6;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(159, 26);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(0, 13);
            this.lblHealth.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Location = new System.Drawing.Point(10, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dexterity";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(10, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Intelligence:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(10, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Wisom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(10, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Strength";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(10, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Health";
            // 
            // grpEquipment
            // 
            this.grpEquipment.Controls.Add(this.lblArmorName);
            this.grpEquipment.Controls.Add(this.label14);
            this.grpEquipment.Controls.Add(this.lblArmorBonusHealth);
            this.grpEquipment.Controls.Add(this.lblArmorType);
            this.grpEquipment.Controls.Add(this.lblWeaponDamage);
            this.grpEquipment.Controls.Add(this.lblWeaponType);
            this.grpEquipment.Controls.Add(this.lblWeaponName);
            this.grpEquipment.Controls.Add(this.label13);
            this.grpEquipment.Controls.Add(this.label12);
            this.grpEquipment.Controls.Add(this.label11);
            this.grpEquipment.Controls.Add(this.label10);
            this.grpEquipment.Controls.Add(this.label9);
            this.grpEquipment.Location = new System.Drawing.Point(530, 314);
            this.grpEquipment.Name = "grpEquipment";
            this.grpEquipment.Size = new System.Drawing.Size(291, 232);
            this.grpEquipment.TabIndex = 3;
            this.grpEquipment.TabStop = false;
            this.grpEquipment.Text = "Current Equipment";
            // 
            // lblArmorName
            // 
            this.lblArmorName.AutoSize = true;
            this.lblArmorName.Location = new System.Drawing.Point(146, 141);
            this.lblArmorName.Name = "lblArmorName";
            this.lblArmorName.Size = new System.Drawing.Size(13, 13);
            this.lblArmorName.TabIndex = 11;
            this.lblArmorName.Text = "()";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Enabled = false;
            this.label14.Location = new System.Drawing.Point(13, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "Armor name";
            // 
            // lblArmorBonusHealth
            // 
            this.lblArmorBonusHealth.AutoSize = true;
            this.lblArmorBonusHealth.Location = new System.Drawing.Point(159, 172);
            this.lblArmorBonusHealth.Name = "lblArmorBonusHealth";
            this.lblArmorBonusHealth.Size = new System.Drawing.Size(0, 13);
            this.lblArmorBonusHealth.TabIndex = 9;
            // 
            // lblArmorType
            // 
            this.lblArmorType.AutoSize = true;
            this.lblArmorType.Location = new System.Drawing.Point(146, 199);
            this.lblArmorType.Name = "lblArmorType";
            this.lblArmorType.Size = new System.Drawing.Size(13, 13);
            this.lblArmorType.TabIndex = 8;
            this.lblArmorType.Text = "()";
            // 
            // lblWeaponDamage
            // 
            this.lblWeaponDamage.AutoSize = true;
            this.lblWeaponDamage.Location = new System.Drawing.Point(159, 105);
            this.lblWeaponDamage.Name = "lblWeaponDamage";
            this.lblWeaponDamage.Size = new System.Drawing.Size(0, 13);
            this.lblWeaponDamage.TabIndex = 7;
            // 
            // lblWeaponType
            // 
            this.lblWeaponType.AutoSize = true;
            this.lblWeaponType.Location = new System.Drawing.Point(159, 72);
            this.lblWeaponType.Name = "lblWeaponType";
            this.lblWeaponType.Size = new System.Drawing.Size(0, 13);
            this.lblWeaponType.TabIndex = 6;
            // 
            // lblWeaponName
            // 
            this.lblWeaponName.AutoSize = true;
            this.lblWeaponName.Location = new System.Drawing.Point(159, 33);
            this.lblWeaponName.Name = "lblWeaponName";
            this.lblWeaponName.Size = new System.Drawing.Size(0, 13);
            this.lblWeaponName.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(13, 172);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Armor Bonus Health:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Enabled = false;
            this.label12.Location = new System.Drawing.Point(13, 199);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Armor Type:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Enabled = false;
            this.label11.Location = new System.Drawing.Point(13, 105);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Weapon Damage:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Enabled = false;
            this.label10.Location = new System.Drawing.Point(13, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Weapon Type:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Enabled = false;
            this.label9.Location = new System.Drawing.Point(13, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Weapon Name:";
            // 
            // btnFight
            // 
            this.btnFight.Location = new System.Drawing.Point(16, 111);
            this.btnFight.Name = "btnFight";
            this.btnFight.Size = new System.Drawing.Size(250, 23);
            this.btnFight.TabIndex = 4;
            this.btnFight.Text = "Fight!";
            this.btnFight.UseVisualStyleBackColor = true;
            this.btnFight.Click += new System.EventHandler(this.BtnFight_Click);
            // 
            // btnLoot
            // 
            this.btnLoot.Location = new System.Drawing.Point(16, 146);
            this.btnLoot.Name = "btnLoot";
            this.btnLoot.Size = new System.Drawing.Size(250, 23);
            this.btnLoot.TabIndex = 5;
            this.btnLoot.Text = "Loot";
            this.btnLoot.UseVisualStyleBackColor = true;
            this.btnLoot.Click += new System.EventHandler(this.BtnLoot_Click);
            // 
            // btnLevelUpHealth
            // 
            this.btnLevelUpHealth.Enabled = false;
            this.btnLevelUpHealth.Location = new System.Drawing.Point(374, 81);
            this.btnLevelUpHealth.Name = "btnLevelUpHealth";
            this.btnLevelUpHealth.Size = new System.Drawing.Size(112, 23);
            this.btnLevelUpHealth.TabIndex = 6;
            this.btnLevelUpHealth.Text = "LevelUp Health";
            this.btnLevelUpHealth.UseVisualStyleBackColor = true;
            this.btnLevelUpHealth.Click += new System.EventHandler(this.BtnLevelUpHealth_Click);
            // 
            // btnLevelUpStrength
            // 
            this.btnLevelUpStrength.Enabled = false;
            this.btnLevelUpStrength.Location = new System.Drawing.Point(374, 106);
            this.btnLevelUpStrength.Name = "btnLevelUpStrength";
            this.btnLevelUpStrength.Size = new System.Drawing.Size(112, 23);
            this.btnLevelUpStrength.TabIndex = 7;
            this.btnLevelUpStrength.Text = "LevelUp Strength";
            this.btnLevelUpStrength.UseVisualStyleBackColor = true;
            this.btnLevelUpStrength.Click += new System.EventHandler(this.BtnLevelUpStrength_Click);
            // 
            // btnLvlUpWisdom
            // 
            this.btnLvlUpWisdom.Enabled = false;
            this.btnLvlUpWisdom.Location = new System.Drawing.Point(374, 130);
            this.btnLvlUpWisdom.Name = "btnLvlUpWisdom";
            this.btnLvlUpWisdom.Size = new System.Drawing.Size(112, 23);
            this.btnLvlUpWisdom.TabIndex = 8;
            this.btnLvlUpWisdom.Text = "Level UpWisom";
            this.btnLvlUpWisdom.UseVisualStyleBackColor = true;
            this.btnLvlUpWisdom.Click += new System.EventHandler(this.BtnLvlUpWisdom_Click);
            // 
            // btnLevelUpInt
            // 
            this.btnLevelUpInt.Enabled = false;
            this.btnLevelUpInt.Location = new System.Drawing.Point(374, 152);
            this.btnLevelUpInt.Name = "btnLevelUpInt";
            this.btnLevelUpInt.Size = new System.Drawing.Size(112, 23);
            this.btnLevelUpInt.TabIndex = 9;
            this.btnLevelUpInt.Text = "Level up big brain";
            this.btnLevelUpInt.UseVisualStyleBackColor = true;
            this.btnLevelUpInt.Click += new System.EventHandler(this.BtnLevelUpInt_Click);
            // 
            // btnLvlUpDex
            // 
            this.btnLvlUpDex.Enabled = false;
            this.btnLvlUpDex.Location = new System.Drawing.Point(374, 177);
            this.btnLvlUpDex.Name = "btnLvlUpDex";
            this.btnLvlUpDex.Size = new System.Drawing.Size(112, 23);
            this.btnLvlUpDex.TabIndex = 10;
            this.btnLvlUpDex.Text = "LevelUp Dex";
            this.btnLvlUpDex.UseVisualStyleBackColor = true;
            this.btnLvlUpDex.Click += new System.EventHandler(this.BtnLvlUpDex_Click);
            // 
            // grpCombat
            // 
            this.grpCombat.Controls.Add(this.numFightPlayerHealth);
            this.grpCombat.Controls.Add(this.numFightEnemyHealth);
            this.grpCombat.Controls.Add(this.lblFightPlayerHealth);
            this.grpCombat.Controls.Add(this.label24);
            this.grpCombat.Controls.Add(this.lblFightEnemyPower);
            this.grpCombat.Controls.Add(this.label23);
            this.grpCombat.Controls.Add(this.label22);
            this.grpCombat.Controls.Add(this.lblFightEnemyType);
            this.grpCombat.Controls.Add(this.label21);
            this.grpCombat.Controls.Add(this.lblLogBot);
            this.grpCombat.Controls.Add(this.lblLogMid);
            this.grpCombat.Controls.Add(this.lblLogTop);
            this.grpCombat.Controls.Add(this.label16);
            this.grpCombat.Controls.Add(this.lblFightWeakness);
            this.grpCombat.Controls.Add(this.label15);
            this.grpCombat.Controls.Add(this.btnMagicAttack);
            this.grpCombat.Controls.Add(this.btnPhysicalAttack);
            this.grpCombat.Location = new System.Drawing.Point(12, 226);
            this.grpCombat.Name = "grpCombat";
            this.grpCombat.Size = new System.Drawing.Size(474, 223);
            this.grpCombat.TabIndex = 11;
            this.grpCombat.TabStop = false;
            this.grpCombat.Text = "Combat";
            // 
            // lblLogBot
            // 
            this.lblLogBot.AutoSize = true;
            this.lblLogBot.Location = new System.Drawing.Point(8, 193);
            this.lblLogBot.Name = "lblLogBot";
            this.lblLogBot.Size = new System.Drawing.Size(41, 13);
            this.lblLogBot.TabIndex = 7;
            this.lblLogBot.Text = "label17";
            // 
            // lblLogMid
            // 
            this.lblLogMid.AutoSize = true;
            this.lblLogMid.Location = new System.Drawing.Point(9, 167);
            this.lblLogMid.Name = "lblLogMid";
            this.lblLogMid.Size = new System.Drawing.Size(41, 13);
            this.lblLogMid.TabIndex = 6;
            this.lblLogMid.Text = "label17";
            // 
            // lblLogTop
            // 
            this.lblLogTop.AutoSize = true;
            this.lblLogTop.Location = new System.Drawing.Point(9, 141);
            this.lblLogTop.Name = "lblLogTop";
            this.lblLogTop.Size = new System.Drawing.Size(41, 13);
            this.lblLogTop.TabIndex = 5;
            this.lblLogTop.Text = "label17";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Enabled = false;
            this.label16.Location = new System.Drawing.Point(6, 121);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 4;
            this.label16.Text = "Combat Log";
            // 
            // lblFightWeakness
            // 
            this.lblFightWeakness.AutoSize = true;
            this.lblFightWeakness.Enabled = false;
            this.lblFightWeakness.Location = new System.Drawing.Point(108, 49);
            this.lblFightWeakness.Name = "lblFightWeakness";
            this.lblFightWeakness.Size = new System.Drawing.Size(132, 13);
            this.lblFightWeakness.TabIndex = 3;
            this.lblFightWeakness.Text = "Not enought wisdom to tell";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(6, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Enemy Weakness:";
            // 
            // btnMagicAttack
            // 
            this.btnMagicAttack.Location = new System.Drawing.Point(352, 14);
            this.btnMagicAttack.Name = "btnMagicAttack";
            this.btnMagicAttack.Size = new System.Drawing.Size(105, 23);
            this.btnMagicAttack.TabIndex = 1;
            this.btnMagicAttack.Text = "Magic Attack";
            this.btnMagicAttack.UseVisualStyleBackColor = true;
            this.btnMagicAttack.Click += new System.EventHandler(this.BtnMagicAttack_Click);
            // 
            // btnPhysicalAttack
            // 
            this.btnPhysicalAttack.Location = new System.Drawing.Point(7, 14);
            this.btnPhysicalAttack.Name = "btnPhysicalAttack";
            this.btnPhysicalAttack.Size = new System.Drawing.Size(98, 23);
            this.btnPhysicalAttack.TabIndex = 0;
            this.btnPhysicalAttack.Text = "Physical Attack";
            this.btnPhysicalAttack.UseVisualStyleBackColor = true;
            this.btnPhysicalAttack.Click += new System.EventHandler(this.BtnPhysicalAttack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtLootName);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.btnLootDiscard);
            this.groupBox1.Controls.Add(this.btnLootKeep);
            this.groupBox1.Controls.Add(this.lblLootModAmount);
            this.groupBox1.Controls.Add(this.lblLootDamageType);
            this.groupBox1.Controls.Add(this.lblLootType);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Location = new System.Drawing.Point(24, 455);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 130);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loot Log";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // txtLootName
            // 
            this.txtLootName.Location = new System.Drawing.Point(142, 62);
            this.txtLootName.Name = "txtLootName";
            this.txtLootName.Size = new System.Drawing.Size(100, 20);
            this.txtLootName.TabIndex = 9;
            this.txtLootName.TextChanged += new System.EventHandler(this.TxtNamedCharacter_TextChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(14, 65);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(78, 13);
            this.label20.TabIndex = 8;
            this.label20.Text = "Give it a name!";
            // 
            // btnLootDiscard
            // 
            this.btnLootDiscard.Location = new System.Drawing.Point(387, 101);
            this.btnLootDiscard.Name = "btnLootDiscard";
            this.btnLootDiscard.Size = new System.Drawing.Size(75, 23);
            this.btnLootDiscard.TabIndex = 7;
            this.btnLootDiscard.Text = "Discard";
            this.btnLootDiscard.UseVisualStyleBackColor = true;
            this.btnLootDiscard.Click += new System.EventHandler(this.BtnLootDiscard_Click);
            // 
            // btnLootKeep
            // 
            this.btnLootKeep.Enabled = false;
            this.btnLootKeep.Location = new System.Drawing.Point(10, 101);
            this.btnLootKeep.Name = "btnLootKeep";
            this.btnLootKeep.Size = new System.Drawing.Size(75, 23);
            this.btnLootKeep.TabIndex = 6;
            this.btnLootKeep.Text = "Equip";
            this.btnLootKeep.UseVisualStyleBackColor = true;
            this.btnLootKeep.Click += new System.EventHandler(this.BtnLootKeep_Click);
            // 
            // lblLootModAmount
            // 
            this.lblLootModAmount.AutoSize = true;
            this.lblLootModAmount.Location = new System.Drawing.Point(414, 31);
            this.lblLootModAmount.Name = "lblLootModAmount";
            this.lblLootModAmount.Size = new System.Drawing.Size(0, 13);
            this.lblLootModAmount.TabIndex = 5;
            // 
            // lblLootDamageType
            // 
            this.lblLootDamageType.AutoSize = true;
            this.lblLootDamageType.Location = new System.Drawing.Point(239, 31);
            this.lblLootDamageType.Name = "lblLootDamageType";
            this.lblLootDamageType.Size = new System.Drawing.Size(0, 13);
            this.lblLootDamageType.TabIndex = 4;
            // 
            // lblLootType
            // 
            this.lblLootType.AutoSize = true;
            this.lblLootType.Location = new System.Drawing.Point(71, 31);
            this.lblLootType.Name = "lblLootType";
            this.lblLootType.Size = new System.Drawing.Size(0, 13);
            this.lblLootType.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(328, 31);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(86, 13);
            this.label19.TabIndex = 2;
            this.label19.Text = "Attribute Modifier";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(139, 31);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(77, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Damage Type:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 31);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(58, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Loot Type:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(279, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 13);
            this.label21.TabIndex = 8;
            this.label21.Text = "Enemy Damage Type:";
            // 
            // lblFightEnemyType
            // 
            this.lblFightEnemyType.AutoSize = true;
            this.lblFightEnemyType.Location = new System.Drawing.Point(397, 49);
            this.lblFightEnemyType.Name = "lblFightEnemyType";
            this.lblFightEnemyType.Size = new System.Drawing.Size(0, 13);
            this.lblFightEnemyType.TabIndex = 9;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(76, 13);
            this.label22.TabIndex = 10;
            this.label22.Text = "Enemy Health:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(241, 78);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(75, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Enemy Power:";
            // 
            // lblFightEnemyPower
            // 
            this.lblFightEnemyPower.AutoSize = true;
            this.lblFightEnemyPower.Location = new System.Drawing.Point(386, 78);
            this.lblFightEnemyPower.Name = "lblFightEnemyPower";
            this.lblFightEnemyPower.Size = new System.Drawing.Size(0, 13);
            this.lblFightEnemyPower.TabIndex = 13;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(241, 121);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(126, 13);
            this.label24.TabIndex = 14;
            this.label24.Text = "Remaining Player Health:";
            // 
            // lblFightPlayerHealth
            // 
            this.lblFightPlayerHealth.AutoSize = true;
            this.lblFightPlayerHealth.Location = new System.Drawing.Point(399, 120);
            this.lblFightPlayerHealth.Name = "lblFightPlayerHealth";
            this.lblFightPlayerHealth.Size = new System.Drawing.Size(0, 13);
            this.lblFightPlayerHealth.TabIndex = 15;
            // 
            // numFightEnemyHealth
            // 
            this.numFightEnemyHealth.Enabled = false;
            this.numFightEnemyHealth.Location = new System.Drawing.Point(88, 76);
            this.numFightEnemyHealth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFightEnemyHealth.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numFightEnemyHealth.Name = "numFightEnemyHealth";
            this.numFightEnemyHealth.Size = new System.Drawing.Size(120, 20);
            this.numFightEnemyHealth.TabIndex = 16;
            this.numFightEnemyHealth.ValueChanged += new System.EventHandler(this.NumFightEnemyHealth_ValueChanged);
            // 
            // numFightPlayerHealth
            // 
            this.numFightPlayerHealth.Enabled = false;
            this.numFightPlayerHealth.Location = new System.Drawing.Point(373, 118);
            this.numFightPlayerHealth.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numFightPlayerHealth.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            -2147483648});
            this.numFightPlayerHealth.Name = "numFightPlayerHealth";
            this.numFightPlayerHealth.Size = new System.Drawing.Size(91, 20);
            this.numFightPlayerHealth.TabIndex = 17;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 601);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCombat);
            this.Controls.Add(this.btnLvlUpDex);
            this.Controls.Add(this.btnLevelUpInt);
            this.Controls.Add(this.btnLvlUpWisdom);
            this.Controls.Add(this.btnLevelUpStrength);
            this.Controls.Add(this.btnLevelUpHealth);
            this.Controls.Add(this.btnLoot);
            this.Controls.Add(this.btnFight);
            this.Controls.Add(this.grpEquipment);
            this.Controls.Add(this.grpCurrentStats);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label1);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.Load += new System.EventHandler(this.MainGame_Load);
            this.grpCurrentStats.ResumeLayout(false);
            this.grpCurrentStats.PerformLayout();
            this.grpEquipment.ResumeLayout(false);
            this.grpEquipment.PerformLayout();
            this.grpCombat.ResumeLayout(false);
            this.grpCombat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFightEnemyHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFightPlayerHealth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.GroupBox grpCurrentStats;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDexterity;
        private System.Windows.Forms.Label lblIntelligence;
        private System.Windows.Forms.Label lblWisdom;
        private System.Windows.Forms.Label lblStrength;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSkillPoints;
        private System.Windows.Forms.GroupBox grpEquipment;
        private System.Windows.Forms.Label lblArmorBonusHealth;
        private System.Windows.Forms.Label lblArmorType;
        private System.Windows.Forms.Label lblWeaponDamage;
        private System.Windows.Forms.Label lblWeaponType;
        private System.Windows.Forms.Label lblWeaponName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblArmorName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnFight;
        private System.Windows.Forms.Button btnLoot;
        private System.Windows.Forms.Button btnLevelUpHealth;
        private System.Windows.Forms.Button btnLevelUpStrength;
        private System.Windows.Forms.Button btnLvlUpWisdom;
        private System.Windows.Forms.Button btnLevelUpInt;
        private System.Windows.Forms.Button btnLvlUpDex;
        private System.Windows.Forms.GroupBox grpCombat;
        private System.Windows.Forms.Label lblLogBot;
        private System.Windows.Forms.Label lblLogMid;
        private System.Windows.Forms.Label lblLogTop;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblFightWeakness;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnMagicAttack;
        private System.Windows.Forms.Button btnPhysicalAttack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLootDiscard;
        private System.Windows.Forms.Button btnLootKeep;
        private System.Windows.Forms.Label lblLootModAmount;
        private System.Windows.Forms.Label lblLootDamageType;
        private System.Windows.Forms.Label lblLootType;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtLootName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblFightEnemyPower;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblFightEnemyType;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.NumericUpDown numFightPlayerHealth;
        private System.Windows.Forms.NumericUpDown numFightEnemyHealth;
        private System.Windows.Forms.Label lblFightPlayerHealth;
        private System.Windows.Forms.Label label24;
    }
}