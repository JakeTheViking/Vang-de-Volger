using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    public partial class GameWindow : Form
    {
        public const int GAMEWINDOW_HEIGHT = 400;
        public const int GAMEWINDOW_WIDTH = 400;
        private int pauseCount;
        private bool paused;
        private Level _level;
        private Direction currentDirection;
        private Graphics g;
        public GameWindow()
        {
            InitializeComponent();
            Start();
        }
        private void DrawingArea_Paint(object sender, PaintEventArgs e)
        {

        }
        public void GameWindow_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.W):
                    currentDirection = Classes.Direction.North;
                    break;
                case (Keys.A):
                    currentDirection = Classes.Direction.West;
                    break;
                case (Keys.S):
                    currentDirection = Classes.Direction.South;
                    break;
                case (Keys.D):
                    currentDirection = Classes.Direction.East;
                    break;
            }
        }
        private void gameTimerTick(object sender, EventArgs e)
        {
        }

        private void Start()
        {
            g = DrawingArea.CreateGraphics();
            DrawingArea.Width = GAMEWINDOW_WIDTH;
            DrawingArea.Height = GAMEWINDOW_HEIGHT;
            this.Height = ((Level.LEVEL_HEIGHT + 2) * Entity.ASSET_SIZE);
            this.Width = ((Level.LEVEL_WIDTH + 2) * Entity.ASSET_SIZE);
            _level = new Level(g, Level.LEVEL_WIDTH, Level.LEVEL_HEIGHT);
        }
        private void Restart()
        {
            paused = false;
            currentDirection = Classes.Direction.None;
        }

        private void GameWindow_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.W):
                case (Keys.A):
                case (Keys.S):
                case (Keys.D):
                    break;
            }
        }

        private void GameWindow_Shown(object sender, EventArgs e)
        {
            _level.DrawSelf();
        }

        private void SmallMenuItem_Click(object sender, EventArgs e)
        {
            this.Height = ((Level.LEVEL_HEIGHT + 2) * Entity.ASSET_SIZE);
            this.Width = ((Level.LEVEL_WIDTH + 2) * Entity.ASSET_SIZE);
            _level = new Level(g, Level.LEVEL_HEIGHT, Level.LEVEL_WIDTH);
        }

        private void MediumMenuItem_Click(object sender, EventArgs e)
        {
            DrawingArea.Width = GAMEWINDOW_WIDTH * 2;
            DrawingArea.Height = GAMEWINDOW_HEIGHT * 2;
            this.Height = GAMEWINDOW_HEIGHT * 2;
            this.Width = GAMEWINDOW_WIDTH * 2;
            g = DrawingArea.CreateGraphics();
            _level = new Level(g, Level.LEVEL_HEIGHT + 5, Level.LEVEL_WIDTH + 5);
        }

        private void LargeMenuItem_Click(object sender, EventArgs e)
        {
            DrawingArea.Width = GAMEWINDOW_WIDTH * 2;
            DrawingArea.Height = GAMEWINDOW_HEIGHT * 2;
            this.Height = GAMEWINDOW_HEIGHT * 2;
            this.Width = GAMEWINDOW_WIDTH * 2;
            g = DrawingArea.CreateGraphics();
            _level = new Level(g, Level.LEVEL_HEIGHT * 2, Level.LEVEL_WIDTH * 2);
        }
    }
}
