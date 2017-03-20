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
        private int pauseCount;
        private int tickCounter = 0;
        private Game _game = new Game();
        private Direction currentDirection;
        private Direction lastInput;
        private int positionX, positionY;
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
                    tickCounter = 0;
                    lastInput = Classes.Direction.North;
                    break;
                case (Keys.A):
                    tickCounter = 0;
                    lastInput = Classes.Direction.West;
                    break;
                case (Keys.S):
                    tickCounter = 0;
                    lastInput = Classes.Direction.South;
                    break;
                case (Keys.D):
                    tickCounter = 0;
                    lastInput = Classes.Direction.East;
                    break;
            }
        }
        private bool AllowedToTurn(Direction direction)
        {
            if (direction == Classes.Direction.North || direction == Classes.Direction.South || direction == Classes.Direction.East || direction == Classes.Direction.West)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void pauseClick(object sender, EventArgs e)
        {
            pauseCount++;
            lastInput = Classes.Direction.None;
            switch (pauseCount)
            {
                case 1:
                    gameTimer.Stop();
                    break;
                case 2:
                    gameTimer.Start();
                    pauseCount = 0;
                    break;
            }
        }

        private void restartClick(object sender, EventArgs e)
        {
            Restart();
        }

        private void gameTimerTick(object sender, EventArgs e)
        {
            if (currentDirection != lastInput && tickCounter < 1) // Checks the current direction to the last direction and updates once according to counter
            {
                if (AllowedToTurn(lastInput))
                {
                    currentDirection = lastInput;
                }
            }
            MoveDirection(currentDirection);

            tickCounter++;

        }
        private bool CanPushBlock()
        {
            return false;
        }
        private void ReferencePosition(TextureID[,] array, TextureID texture)
        {
            for (int x = 0; x < array.GetUpperBound(0); x++)
            {
                for (int y = 0; y < array.GetUpperBound(1); y++)
                {
                    if (array[x, y] == texture)
                    {
                        positionX = x;
                        positionY = y;
                    }
                }
            }
        }
        private bool CanMoveDirection(TextureID[,] array, Direction direction, int x, int y)
        {
            if (direction == Direction.North)
            {
                if (array[x, y - 1] != TextureID.Wall && array[x, y - 1] != TextureID.Pillar)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (direction == Direction.South)
            {
                if (array[x, y + 1] != TextureID.Wall && array[x, y + 1] != TextureID.Pillar)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (direction == Direction.West)
            {
                if (array[x - 1, y] != TextureID.Wall && array[x - 1, y] != TextureID.Pillar)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            if (direction == Direction.East)
            {
                if (array[x + 1, y] != TextureID.Wall && array[x + 1, y] != TextureID.Pillar)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        private bool NoMove(TextureID[,] array, int x, int y)
        {
            if (array[x, y - 1] == TextureID.Wall || array[x, y - 1] == TextureID.Pillar)
            {
                if (array[x, y + 1] == TextureID.Wall || array[x, y + 1] == TextureID.Pillar)
                {
                    if (array[x - 1, y] == TextureID.Wall || array[x - 1, y] == TextureID.Pillar)
                    {
                        if (array[x + 1, y] == TextureID.Wall || array[x + 1, y] == TextureID.Pillar)
                        {
                            return true;
                        }
                        return false;
                    }
                    return false;
                }
                return false;
            }
            else
            {
                return false;
            }
        }
        private void MoveDirection(Direction direction)
        {
            Render();
            if (currentDirection == Classes.Direction.North)
            {
                ReferencePosition(Level.blocks, TextureID.Player);
                if (CanMoveDirection(Level.blocks, currentDirection, positionX, positionY) == true)
                {
                    Level.blocks[positionX, positionY] = TextureID.Grass;
                    Level.blocks[positionX, positionY - 1] = TextureID.Player;
                    Render();
                    currentDirection = Classes.Direction.None;
                }
            }
            if (currentDirection == Classes.Direction.South)
            {
                ReferencePosition(Level.blocks, TextureID.Player);
                if (CanMoveDirection(Level.blocks, currentDirection, positionX, positionY) == true)
                {
                    Level.blocks[positionX, positionY] = TextureID.Grass;
                    Level.blocks[positionX, positionY + 1] = TextureID.Player;
                    Render();
                    currentDirection = Classes.Direction.None;
                }
            }
            if (currentDirection == Classes.Direction.East)
            {
                ReferencePosition(Level.blocks, TextureID.Player);
                if (CanMoveDirection(Level.blocks, currentDirection, positionX, positionY) == true)
                {
                    Level.blocks[positionX, positionY] = TextureID.Grass;
                    Level.blocks[positionX + 1, positionY] = TextureID.Player;
                    Render();
                    currentDirection = Classes.Direction.None;
                }
            }
            if (currentDirection == Classes.Direction.West)
            {
                ReferencePosition(Level.blocks, TextureID.Player);
                if (CanMoveDirection(Level.blocks, currentDirection, positionX, positionY) == true)
                {
                    Level.blocks[positionX, positionY] = TextureID.Grass;
                    Level.blocks[positionX - 1, positionY] = TextureID.Player;
                    Render();
                    currentDirection = Classes.Direction.None;
                }
            }
        }

        private void Start()
        {
            _game.LoadLevel(g);
            //_game.RenderLevel(g);
        }
        private void Restart()
        {
            currentDirection = Classes.Direction.None;
            lastInput = Classes.Direction.None;
            _game.LoadLevel(g);
        }
        private void Render()
        {
            _game.RenderLevel(g);
        }

        private void GameWindow_Load(object sender, EventArgs e)
        {
            g = DrawingArea.CreateGraphics();
        }
    }
}
