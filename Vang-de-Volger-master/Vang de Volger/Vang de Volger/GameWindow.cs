using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger
{
    public partial class GameWindow : Form
    {
        private Game _game = new Game();
        private Player _player = new Player();

        public GameWindow()
        {
            InitializeComponent();
        }

        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {
            _game.loadLevel();
            Graphics g = DrawingArea.CreateGraphics();
            _game.Start(g);
        }

        private void GameWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            _game.Stop();
        }

        private void PauzeGUI_Click(object sender, EventArgs e)
        {
            _game.Stop();
        }

        private void RestartGUI_Click(object sender, EventArgs e)
        {
            _game.Stop();
            _game.loadLevel();
            Graphics g = DrawingArea.CreateGraphics();
            _game.Start(g);
        }

        private void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            Graphics g = DrawingArea.CreateGraphics();
            switch (e.KeyCode)
            {
                case (Keys.W):
                    _game.Stop();
                    MessageBox.Show("W");
                    _player.MoveUp();
                    _game.Start(g);
                    break;
                case (Keys.A):
                    _game.Stop();
                    MessageBox.Show("A");
                    _player.MoveLeft();
                    _game.Start(g);
                    break;
                case (Keys.S):
                    _game.Stop();
                    MessageBox.Show("S");
                    _player.MoveDown();
                    _game.Start(g);
                    break;
                case (Keys.D):
                    _game.Stop();
                    MessageBox.Show("D");
                    _player.MoveRight();
                    _game.Start(g);
                    break;
            }
        }
    }
}
