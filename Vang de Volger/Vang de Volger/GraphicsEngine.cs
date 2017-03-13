using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Threading;

namespace Vang_de_Volger
{
    class GraphicsEngine
    {
        private Graphics drawer;
        private Thread renderThread;

        private Bitmap tex_grass;
        private Bitmap tex_player;
        private Bitmap tex_enemy;
        private Bitmap tex_unmovable;
        private Bitmap tex_movable;

        public GraphicsEngine(Graphics g)
        {
            drawer = g;
        }
        public void init()
        {
            //Load assets
            loadAssets();

            //Start render
            renderThread = new Thread(new ThreadStart(render));
            renderThread.Start();
        }
        public void stop()
        {
            renderThread.Abort();
        }
        private void loadAssets()
        {
            tex_grass = Vang_de_Volger.Properties.Resources.Grass;
            tex_player = Vang_de_Volger.Properties.Resources.Player;
            tex_enemy = Vang_de_Volger.Properties.Resources.Enemy;
            tex_movable = Vang_de_Volger.Properties.Resources.Movable;
            tex_unmovable = Vang_de_Volger.Properties.Resources.Unmovable;
        }
        private void render()
        {
            Bitmap frame = new Bitmap(Game.LEVEL_HEIGHT, Game.LEVEL_WIDTH);
            Graphics frameGraphics = Graphics.FromImage(frame);

            TextureID[,] textures = Level.Blocks;
            while(true)
            {
                // Background 
                for (int i = 0; i < Game.LEVEL_WIDTH; i++)
                {
                    for (int j = 0; j < Game.LEVEL_HEIGHT; j++)
                    {
                        switch (textures[i, j])
                        {
                            case TextureID.grass:
                                frameGraphics.DrawImage(tex_grass, i * Game.ASSET_SIZE, j * Game.ASSET_SIZE, Game.ASSET_SIZE, Game.ASSET_SIZE);
                                break;
                            case TextureID.movable:
                                frameGraphics.DrawImage(tex_movable, i * Game.ASSET_SIZE, j * Game.ASSET_SIZE, Game.ASSET_SIZE, Game.ASSET_SIZE);
                                break;
                            case TextureID.unmovable:
                                frameGraphics.DrawImage(tex_unmovable, i * Game.ASSET_SIZE, j * Game.ASSET_SIZE, Game.ASSET_SIZE, Game.ASSET_SIZE);
                                break;
                            case TextureID.player:
                                frameGraphics.DrawImage(tex_player, i * Game.ASSET_SIZE, j * Game.ASSET_SIZE, Game.ASSET_SIZE, Game.ASSET_SIZE);
                                break;
                            case TextureID.enemy:
                                frameGraphics.DrawImage(tex_enemy, i * Game.ASSET_SIZE, j * Game.ASSET_SIZE, Game.ASSET_SIZE, Game.ASSET_SIZE);
                                break;
                        }
                    }
                }
                //Draw frame on canvas
                drawer.DrawImage(frame, 0, 0);
            }
        }

    }
}
