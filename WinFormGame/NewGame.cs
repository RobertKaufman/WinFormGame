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
    public partial class NewGame : Form
    {
        public NewGame()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Method to ensure that a character has assigned all avaliable skill points before starting the game
        /// </summary>
        private void CheckTotalAssignmedStats()
        {
            int currentlyAssigned = (int)(this.numDexterity.Value + this.numHealth.Value + this.numStrength.Value + this.numWisdom.Value + this.numIntelligence.Value);
            this.lblSkillPoints.Text = (10 - currentlyAssigned).ToString();
            if (currentlyAssigned != 10 || this.txtCharacterName.Equals(null))
                this.btnStartGame.Enabled = false;
            if (currentlyAssigned == 10 && this.txtCharacterName != null)
                this.btnStartGame.Enabled = true;

        }

        private void NumHealth_ValueChanged(object sender, EventArgs e)
        {
            CheckTotalAssignmedStats();
        }



        private void NumStrength_ValueChanged(object sender, EventArgs e)
        {
            CheckTotalAssignmedStats();
        }

        private void NumWisdom_ValueChanged(object sender, EventArgs e)
        {
            CheckTotalAssignmedStats();
        }

        private void NumIntelligence_ValueChanged(object sender, EventArgs e)
        {
            CheckTotalAssignmedStats();
        }

        private void NumDexterity_ValueChanged(object sender, EventArgs e)
        {
            CheckTotalAssignmedStats();
        }

        private void BtnStartGame_Click(object sender, EventArgs e)
        {
            PlayerCharacter playerCharacter = new PlayerCharacter(txtCharacterName.Text, (int)numHealth.Value, (int)numStrength.Value, (int)numWisdom.Value, (int)numIntelligence.Value, (int)numDexterity.Value);
            MainGame launchedGame = new MainGame(playerCharacter);
            launchedGame.ShowDialog();

        }
    }
}
