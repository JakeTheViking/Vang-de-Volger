using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    class Level
    {
        public const int LEVEL_WIDTH = 10;
        public const int LEVEL_HEIGHT = 10;

        private Direction currentDirection;

        private Tiles _tiles;
        private Tiles[,] arrTiles;

        private int rows;
        private int columns;

        private const int wallPercentage = 5;
        private const int pillarPercentage = 20;

        public Level(Graphics g, int r, int c)
        {
            rows = r;
            columns = c;
            arrTiles = new Tiles[rows, columns];

            Random rand = new Random();

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < columns; y++)
                {
                    _tiles = new Tiles(x, y);
                    arrTiles[x, y] = _tiles;
                    if (y > 0)
                    {
                        _tiles.SaveNeighbour(Direction.North, arrTiles[x, (y - 1)]);
                    }
                    if (x > 0)
                    {
                        _tiles.SaveNeighbour(Direction.West, arrTiles[(x - 1), y]);
                    }
                    if (rand.Next(1, 101) < pillarPercentage)
                    {
                        arrTiles[x, y].SaveEntity(new Pillar(g, arrTiles[x, y].LocationInLevel()));
                    }
                    if (rand.Next(1, 101) < wallPercentage)
                    {
                        arrTiles[x, y].SaveEntity(new Wall(g, arrTiles[x, y].LocationInLevel()));
                    }
                    if (x == 0 || x == rows - 1 || y == 0 || y == columns - 1)
                    {
                        arrTiles[x, y].SaveEntity(new Wall(g, arrTiles[x, y].LocationInLevel()));
                    }
                    if (x == 1 && y == 1)
                    {
                        arrTiles[x, y].SaveEntity(new Player(g, arrTiles[x, y].LocationInLevel()));
                    }
                    if (x == rows - 2 && y == columns - 2)
                    {
                        arrTiles[rows - 2, columns - 2].SaveEntity(new Enemy(g, arrTiles[x, y].LocationInLevel()));
                    }
                }
            }
        }
        public void DrawSelf()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (arrTiles[i, j].GetEntity() == null)
                    {
                        continue;
                    }
                    else
                    {
                        arrTiles[i, j].GetEntity().Draw(arrTiles[i, j].LocationInLevel());
                    }
                }

            }
        }
    }
}
