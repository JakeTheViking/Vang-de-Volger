using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vang_de_Volger
{
    class Game 
    {
        public const int CANVAS_HEIGHT = 662;
        public const int CANVAS_WIDTH = 800;
        public const int LEVEL_HEIGHT = 512;
        public const int LEVEL_WIDTH = 512;
        public const int ASSET_SIZE = 32;

        private GraphicsEngine graphicsEngine;

        public void loadLevel()
        {
            Level.initLevel();
        }
        public void Start(Graphics g)
        {
            graphicsEngine = new GraphicsEngine(g);
            graphicsEngine.init();
        }
        public void Stop()
        {
            graphicsEngine.stop();
        }
    }
    public enum TextureID
    {
        grass,
        player,
        enemy,
        unmovable,
        movable
    }
}
