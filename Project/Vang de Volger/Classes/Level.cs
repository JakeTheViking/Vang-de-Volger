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
        public const int LEVEL_WIDTH = 10;
        public const int LEVEL_HEIGHT = 10;
        private const int WALL_PERCENT = 5;
        private const int PILLAR_PERCENT = 20;

        private Tile[,] arrTiles;

        private Graphics _drawer;
        private Control _control;

        private Player _player;
        private Enemy _enemy;
        private Wall _wall;
        private Pillar _pillar;
        private int _r, _c;
        private bool _paused;

        public Level(Graphics g, Control control, bool pause)
        {
            _r = LEVEL_WIDTH;
            _c = LEVEL_HEIGHT;
            _paused = pause;
            _drawer = g;
            _control = control;
            LoadLevel();
        }
        public void LoadLevel()
        {
            arrTiles = new Tile[_r, _c];
            Random rand = new Random();
            for (int width = 0; width < _r; width++)
            {
                for (int height = 0; height < _c; height++)
                {
                    int percent = rand.Next(1, 101);
                    arrTiles[width, height] = new Tile(width, height);
                    if (height > 0)
                    {
                        arrTiles[width, height].SaveNeighbour(Direction.North, arrTiles[width, (height - 1)]);
                    }
                    if (width > 0)
                    {
                        arrTiles[width, height].SaveNeighbour(Direction.West, arrTiles[(width - 1), height]);
                    }

                    if (percent <= WALL_PERCENT + PILLAR_PERCENT)
                    {
                        if (percent <= PILLAR_PERCENT)
                        {
                            if (_pillar == null)
                            {
                                _pillar = new Pillar(arrTiles[width, height], _drawer, arrTiles[width, height].LocationInLevel(), _paused);
                            }
                            arrTiles[width, height].SaveEntity(_pillar);
                        }
                        else if (percent > PILLAR_PERCENT)
                        {
                            if (_wall == null)
                            {
                                _wall = new Wall(arrTiles[width, height], _drawer, arrTiles[width, height].LocationInLevel(), _paused);
                            }
                            arrTiles[width, height].SaveEntity(_wall);
                        }
                    }
                    if (width == 1 && height == 1)
                    {
                        _player = new Player(arrTiles[width, height], _drawer, _control, arrTiles[width, height].LocationInLevel(), _paused);
                        arrTiles[width, height].SaveEntity(_player);
                    }
                    if (width == _r - 2 && height == _c - 2)
                    {
                        _enemy = new Enemy(arrTiles[width, height], _drawer, arrTiles[width, height].LocationInLevel(), _paused);
                        arrTiles[width, height].SaveEntity(_enemy);
                    }
                }
            }
        }
        public void ChangeSize(int width, int height)
        {
            _r = width;
            _c = height;
            LoadLevel();
        }
        public void ChangePause(bool pause)
        {
            _paused = pause;
        }
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
        public void DrawEntities(Bitmap background)
        {
            for (int width = 0; width < _r; width++)
            {
                for (int height = 0; height < _c; height++)
                {
                    if (arrTiles[width, height].GetEntity() == null)
                    {
                        _drawer.DrawImage(background, arrTiles[width, height].LocationInLevel());
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
