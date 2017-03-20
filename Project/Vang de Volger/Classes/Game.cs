using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vang_de_Volger.Classes
{
    class Game
    {
        public const int GAMEWINDOW_HEIGHT = 512;
        public const int GAMEWINDOW_WIDTH = 512;
        public const int LEVEL_HEIGHT = 14;
        public const int LEVEL_WIDTH = 13;
        public const int ASSET_SIZE = 32;
        private Level _level;

        public void LoadLevel(Graphics g)
        {
            _level = new Level(g);
            _level.LoadMap();
        }
        public void RenderLevel(Graphics g)
        {
            _level = new Level(g);
            _level.Render();
        }
    }
}
