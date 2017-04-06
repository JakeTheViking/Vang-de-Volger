using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    public partial class Game : Form
    {
        private int selectedSpeed;
        GameWindow _gameWindow;
        public Game()
        {
            InitializeComponent();
            selectedSpeed = 1000;
        }
        /// <summary>
        /// This is for when the user clicks into the Size toolbar item and clicks Small.
        /// Firstly sets its own SmallMenuItem.Checked to true and rest to false. Explained in Restart() why.
        /// Changes the size of the panel to the a 10 by 10 multiplied by the size of each image.
        /// Changes the size of the window to the constant Form width and height respectively.
        /// Runs a ChangeLevel(int, int) method to restart the game and load it into its needed size.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallMenuItem_Click(object sender, EventArgs e)
        {
            if (_gameWindow != null)
            {
                _gameWindow.Dispose();
            }
            this.Hide();
            _gameWindow = new GameWindow(10, 10, GameWindow.FORM_WIDTH, GameWindow.FORM_HEIGHT, selectedSpeed);
            _gameWindow.FormClosed += this.GameFormClosing;
            _gameWindow.Show();
        }
        /// <summary>
        /// This is for when the user clicks into the Size toolbar item and clicks Medium.
        /// Firstly sets its own MediumMenuItem.Checked to true and rest to false.
        /// Changes the panel size to a multiple of 2 of Smalls size.
        /// Changes the form size to a multiple of 2 of Smalls size.
        /// Multiplies the number of tiles in the array also by 2.
        /// In theory it just doubles every single value creating a level twice as big.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumMenuItem_Click(object sender, EventArgs e)
        {
            if (_gameWindow != null)
            {
                _gameWindow.Dispose();
            }
            this.Hide();
            _gameWindow = new GameWindow(15, 15, GameWindow.FORM_WIDTH * 2, GameWindow.FORM_HEIGHT * 2, selectedSpeed);
            _gameWindow.FormClosed += this.GameFormClosing;
            _gameWindow.Show();
        }
        /// <summary>
        /// This is for when the user clicks into the Size toolbar item and clicks Large.
        /// Firstly sets its own LargeMenuItem.Checked to true and rest to false.
        /// Changes the panel's width to 3x and height to 2x the size of Smalls.
        /// Changes the forms width to 3x and height to 2x the size of Smalls.
        /// Adjusts the level to have 3x the number of tiles in rows and 2x in columns.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeMenuItem_Click(object sender, EventArgs e)
        {
            if (_gameWindow != null)
            {
                _gameWindow.Dispose();
            }
            this.Hide();
            _gameWindow = new GameWindow(20, 20, GameWindow.FORM_WIDTH * 3, GameWindow.FORM_HEIGHT * 3, selectedSpeed);
            _gameWindow.FormClosed += this.GameFormClosing;
            _gameWindow.Show();
            
        }
        private void GameFormClosing(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("http://lmgtfy.com/?q=I+don%27t+know+ask+Vincent+-+Tim");
        }
        private void slowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedSpeed = 5000;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedSpeed = 2000;
        }

        private void fastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedSpeed = 1000;
        }
    }
}
