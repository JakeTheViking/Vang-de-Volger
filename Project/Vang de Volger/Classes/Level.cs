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
        public static TextureID[,] blocks = new TextureID[Game.LEVEL_WIDTH, Game.LEVEL_HEIGHT];
        
        private Graphics drawer;
        private int wallPercentage = 5;
        private int pillarPercentage = 20;

        public static TextureID[,] Blocks
        {
            get { return blocks; }
            set { blocks = value; }
        }
        public Level(Graphics g)
        {
            drawer = g;
        }
        public void LoadMap()
        {
            Random rand = new Random();
            for (int x = 0; x < blocks.GetUpperBound(0); x++)
            {
                for (int y = 0; y < blocks.GetUpperBound(1); y++)
                {
                    blocks[x, y] = TextureID.Grass;
                    if (rand.Next(1, 100) < pillarPercentage)
                    {
                        blocks[x, y] = TextureID.Pillar;
                    }
                    if (x == 0 || x == 11 || y == 0 || y == 12)
                    {
                        blocks[x, y] = TextureID.Wall;
                    }
                    if (rand.Next(1, 100) < wallPercentage && x != 1 && x != 10 && y != 1 && y != 11)
                    {
                        blocks[x, y] = TextureID.Wall;
                    }
                    if (x == 1 && y == 1)
                    {
                        blocks[x, y] = TextureID.Player;
                    }
                    if (x == 10 && y == 11)
                    {
                        blocks[x, y] = TextureID.Enemy;
                    }
                }
            }
        }
        public void Render()
        {
            Bitmap frame = new Bitmap(Game.GAMEWINDOW_WIDTH, Game.GAMEWINDOW_HEIGHT);
            Graphics frameGraphics = Graphics.FromImage(frame);

            TextureID[,] textures = Blocks;
            // Background 
            for (int i = 0; i < blocks.GetUpperBound(0); i++)
            {
                for (int j = 0; j < blocks.GetUpperBound(1); j++)
                {
                    switch (textures[i, j])
                    {
                        case TextureID.Grass:
                            Entity _grass = new Grass();
                            _grass.Draw(frameGraphics, i, j);
                            break;
                        case TextureID.Wall:
                            Entity _wall = new Wall();
                            _wall.Draw(frameGraphics, i, j);
                            break;
                        case TextureID.Player:
                            Entity _player = new Player(i, j);
                            _player.Draw(frameGraphics, i, j);
                            break;
                        case TextureID.Enemy:
                            Entity _enemy = new Enemy(i, j);
                            _enemy.Draw(frameGraphics, i, j);
                            break;
                        case TextureID.Pillar:
                            Entity _pillar = new Pillar();
                            _pillar.Draw(frameGraphics, i, j);
                            break;
                    }
                }
            }
            //Draw frame on canvas
            drawer.DrawImage(frame, 0, 0);
        }
    }
}
