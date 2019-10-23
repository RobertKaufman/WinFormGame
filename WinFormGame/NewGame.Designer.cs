namespace WinFormGame
{
    partial class NewGame
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
            this.txtCharacterName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSkillPoints = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numHealth = new System.Windows.Forms.NumericUpDown();
            this.numStrength = new System.Windows.Forms.NumericUpDown();
            this.numWisdom = new System.Windows.Forms.NumericUpDown();
            this.numIntelligence = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numDexterity = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWisdom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please Choose a name";
            // 
            // txtCharacterName
            // 
            this.txtCharacterName.Location = new System.Drawing.Point(147, 36);
            this.txtCharacterName.Name = "txtCharacterName";
            this.txtCharacterName.Size = new System.Drawing.Size(100, 20);
            this.txtCharacterName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Avaliable Skill Points:";
            // 
            // lblSkillPoints
            // 
            this.lblSkillPoints.AutoSize = true;
            this.lblSkillPoints.Location = new System.Drawing.Point(417, 39);
            this.lblSkillPoints.Name = "lblSkillPoints";
            this.lblSkillPoints.Size = new System.Drawing.Size(19, 13);
            this.lblSkillPoints.TabIndex = 3;
            this.lblSkillPoints.Text = "10";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Health:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Strength:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wisom:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Intelligence:";
            // 
            // numHealth
            // 
            this.numHealth.Location = new System.Drawing.Point(147, 68);
            this.numHealth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHealth.Name = "numHealth";
            this.numHealth.Size = new System.Drawing.Size(120, 20);
            this.numHealth.TabIndex = 8;
            this.numHealth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHealth.ValueChanged += new System.EventHandler(this.NumHealth_ValueChanged);
            // 
            // numStrength
            // 
            this.numStrength.Location = new System.Drawing.Point(147, 92);
            this.numStrength.Name = "numStrength";
            this.numStrength.Size = new System.Drawing.Size(120, 20);
            this.numStrength.TabIndex = 9;
            this.numStrength.ValueChanged += new System.EventHandler(this.NumStrength_ValueChanged);
            // 
            // numWisdom
            // 
            this.numWisdom.Location = new System.Drawing.Point(147, 118);
            this.numWisdom.Name = "numWisdom";
            this.numWisdom.Size = new System.Drawing.Size(120, 20);
            this.numWisdom.TabIndex = 10;
            this.numWisdom.ValueChanged += new System.EventHandler(this.NumWisdom_ValueChanged);
            // 
            // numIntelligence
            // 
            this.numIntelligence.Location = new System.Drawing.Point(147, 145);
            this.numIntelligence.Name = "numIntelligence";
            this.numIntelligence.Size = new System.Drawing.Size(120, 20);
            this.numIntelligence.TabIndex = 11;
            this.numIntelligence.ValueChanged += new System.EventHandler(this.NumIntelligence_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "How much damage you can take";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dexterity:";
            // 
            // numDexterity
            // 
            this.numDexterity.Location = new System.Drawing.Point(147, 173);
            this.numDexterity.Name = "numDexterity";
            this.numDexterity.Size = new System.Drawing.Size(120, 20);
            this.numDexterity.TabIndex = 14;
            this.numDexterity.ValueChanged += new System.EventHandler(this.NumDexterity_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(303, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "How much physical damage you do";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(303, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Your ability to find weaknesses";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(303, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(186, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "How much magic damage you can do";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(303, 175);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Your chance of dodging and critical hitting";
            // 
            // btnStartGame
            // 
            this.btnStartGame.Enabled = false;
            this.btnStartGame.Location = new System.Drawing.Point(15, 287);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(121, 23);
            this.btnStartGame.TabIndex = 19;
            this.btnStartGame.Text = "Start your journey!";
            this.btnStartGame.UseVisualStyleBackColor = true;
            this.btnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // NewGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numDexterity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numIntelligence);
            this.Controls.Add(this.numWisdom);
            this.Controls.Add(this.numStrength);
            this.Controls.Add(this.numHealth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSkillPoints);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCharacterName);
            this.Controls.Add(this.label1);
            this.Name = "NewGame";
            this.Text = "NewGame";
            ((System.ComponentModel.ISupportInitialize)(this.numHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numStrength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWisdom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numIntelligence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDexterity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCharacterName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSkillPoints;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numHealth;
        private System.Windows.Forms.NumericUpDown numStrength;
        private System.Windows.Forms.NumericUpDown numWisdom;
        private System.Windows.Forms.NumericUpDown numIntelligence;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numDexterity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnStartGame;
    }
}