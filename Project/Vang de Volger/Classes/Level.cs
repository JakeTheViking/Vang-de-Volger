using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    class Level 
    {
        /// <summary> Default constant level size with 10 tiles in the width. </summary>
        public const int LEVEL_WIDTH = 10;
        /// <summary> Default constant level size with 10 tiles in the height. </summary>
        public const int LEVEL_HEIGHT = 10; 
        /// <summary> Percent chance of a wall being made. </summary>
        private const int WALL_PERCENT = 5;
        /// <summary> Percent chance of a pillar being made. </summary>
        private const int PILLAR_PERCENT = 20;
        /// <summary> A Tile array that stores all the tiles. </summary>
        private Tile[,] arrTiles;
        /// <summary> Taken from the GameWindow class. Used to draw Graphics on the panel. Will be redistruted to each Entity. </summary>
        private Graphics _drawer;
        /// <summary> Controls going to be given to the Player allowing them to take in the keyboard handler from panel. </summary>
        private Control _control;

        private Player _player; 
        private Enemy _enemy; 
        private Wall _wall;
        private Pillar _pillar;

        /// <summary> Taken over from GameWindow and adds control to Level. </summary>
        private GameWindow _game;
        /// <summary> The gameTimer from GameWindow, which will later be given to Enemy so that the Enemy can call methods on the same timer as other Entities (stops async calls for methods). </summary>
        private Timer _gameTimer;
        /// <summary> Int for the rows and columns of the 2D array. </summary>
        private int _r, _c;
        /// <summary>
        /// On creation of Level it runs this code. Firstly takes some parameters and sets it equal to local variables and then runs the LoadLevel() method.
        /// </summary>
        /// <param name="rows"> Used for calling how many rows are generated. </param>
        /// <param name="columns"> Used for calling how many columns are generated. </param>
        /// <param name="game"> The Form class that this Level was instantiated in. </param>
        /// <param name="gameTimer"> A timer running in the Form which will be passed on the Entities. </param>
        /// <param name="g"> Forms panel graphics. Allows the Level and Entities to draw on the panel. </param>
        /// <param name="control"> Passed to the Player, allowing it to capture KeyUp and KeyDown from the Form. </param>
        /// <param name="pause"> Check if the game is paused or not and pass along to Entities. </param>
        public Level(int rows, int columns, GameWindow game, Timer gameTimer, Graphics g, Control control)
        {
            _r = rows; 
            _c = columns;
            _drawer = g;
            _game = game;
            _control = control;
            _gameTimer = gameTimer;

            /// <summary> Runs the method LoadLevel() which places Entities in their Tiles. </summary>
            LoadLevel(LoadTileArray(_r, _c));
        }
        public Tile[,] LoadTileArray(int rows, int columns)
        {
            arrTiles = new Tile[rows, columns];
            return arrTiles;
        }
        /// <summary>
        /// Fills the Tiles array with the size _r and _c corresponding to the rows and columns.
        /// Sets for each place in the Tile array an empty null tile.
        /// Immediately saves the neighbour of each tile. (Thanks Veronica).
        /// If a random number chosen between 1 and 100 is less than 25 percent (in this case WALL_PERCENT + PILLAR_PERCENT) then either a pillar or wall is placed there.
        /// If that number less than 25 percent is less than 20 place and pillar else a wall.
        /// On [1, 1] set the Player.
        /// On [rows - 2 , columns - 2] set the Enemy. This is good practice because if we change the size it will always be 2 off the corner no matter the size.
        /// Finally create a ring around the whole area of walls. Not needed, but in the design of the game we thought it was better. Also part of our story that the two are trapped.
        /// </summary>
        public void LoadLevel(Tile[,] arrTiles)
        {
            Random rand = new Random();
            for (int width = 0; width < _r; width++)
            {
                for (int height = 0; height < _c; height++)
                {
                    int percent = rand.Next(1, 101);
                    arrTiles[width, height] = new Tile(width, height);
                    

                    if (percent <= WALL_PERCENT + PILLAR_PERCENT)
                    {
                        if (percent <= PILLAR_PERCENT)
                        {
                            _pillar = new Pillar(_game, this, _gameTimer, arrTiles[width, height], _drawer, arrTiles[width, height].LocationInLevel());

                            arrTiles[width, height].SaveEntity(_pillar);
                        }
                        else
                        {
                            _wall = new Wall(_game, this, _gameTimer, arrTiles[width, height], _drawer, arrTiles[width, height].LocationInLevel());

                            arrTiles[width, height].SaveEntity(_wall);
                        }
                    }
                    if (width == 1 && height == 1)
                    {
                        _player = new Player(_game, this, _gameTimer, arrTiles[width, height], _drawer, _control, arrTiles[width, height].LocationInLevel());
                        arrTiles[width, height].SaveEntity(_player);
                    }
                    if (width == _r - 2 && height == _c - 2)
                    {
                        _enemy = new Enemy(_game, this, _gameTimer, arrTiles[width, height], _drawer, arrTiles[width, height].LocationInLevel());
                        arrTiles[width, height].SaveEntity(_enemy);
                    }
                    if (width == 0 || width == _r - 1 || height == 0 || height == _c - 1)
                    {
                        if (_wall == null)
                        {
                            _wall = new Wall(_game, this, _gameTimer, arrTiles[width, height], _drawer, arrTiles[width, height].LocationInLevel());
                        }
                        arrTiles[width, height].SaveEntity(_wall);
                    }
                    if (height > 0)
                    {
                        arrTiles[width, height].SaveNeighbour(Direction.North, arrTiles[width, (height - 1)]);
                    }
                    if (width > 0)
                    {
                        arrTiles[width, height].SaveNeighbour(Direction.West, arrTiles[(width - 1), height]);
                    }
                }
            }
        }
        /// <summary>
        /// Reset method runs through the entire Tile array and sets every value to null.
        /// This means when we draw it, everything will draw grass.
        /// </summary>
        public void Reset()
        {
            for (int width = 0; width < _r; width++)
            {
                for (int height = 0; height < _c; height++)
                {
                    arrTiles[width, height].SaveEntity(null);
                }
            }
        }
        /// <summary>
        /// Draw Entities displays what is in each tile.
        /// Runs through each tile in the array.
        /// Firstly checks if the tile is null. If it is null it draws the background on that location and continues to the next tile.
        /// If the tile has a value in it (no matter what it is). Asks what what Entity is and then tells that Entity to perform is own method called Draw.
        /// Entity then draws itself on the location it was given through by the tile.
        /// </summary>
        /// <param name="background"></param>
        public void DrawEntities()
        {
            for (int width = 0; width < _r; width++)
            {
                for (int height = 0; height < _c; height++)
                {
                    
                    if (arrTiles[width, height].GetEntity() == null)
                    {
                        _drawer.DrawImage(Vang_de_Volger.Properties.Resources.Background32x32, arrTiles[width, height].LocationInLevel());
                        continue;
                    }
                    else
                    {
                        arrTiles[width, height].GetEntity().Draw(arrTiles[width, height].LocationInLevel());
                    }
                }

            }
        }
    }
}
