using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vang_de_Volger
{
    class Level
    {
        private static TextureID[,] blocks = new TextureID[Game.LEVEL_WIDTH, Game.LEVEL_HEIGHT];
        private const int playerX = 1;
        private const int playerY = 1;
        private const int enemyX = 14;
        private const int enemyY = 14;

        public static TextureID[,] Blocks
        {
            get { return blocks; }
            set { blocks = value; }
        }
        public static void initLevel()
        {
            Random rand = new Random();
            for (int i = 0; i < Game.LEVEL_WIDTH; i++)
            {
                for (int j = 0; j < Game.LEVEL_HEIGHT; j++)
                {
                    blocks[i, j] = TextureID.grass;
                    if (j == playerX && i == playerY)
                    {
                        blocks[i, j] = TextureID.player;
                    }
                    if (j == enemyX && i == enemyY)
                    {
                        blocks[i, j] = TextureID.enemy;
                    }
                    if (rand.Next(1, 100) <= 5)
                    {
                        if (blocks[i,j] == blocks[playerX, playerY] || blocks[i, j] == blocks[enemyX, enemyY])
                        {
                            continue;
                        }
                        else
                        {
                            blocks[i, j] = TextureID.unmovable;
                        }
                    }
                    if (rand.Next(1, 100) <= 20)
                    {
                        if (blocks[i, j] == blocks[playerX, playerY] || blocks[i, j] == blocks[enemyX, enemyY])
                        {
                            continue;
                        }
                        else
                        {
                            blocks[i, j] = TextureID.movable;
                        }
                    }
                    if (j == 0 || j == 15 || i == 0 || i == 15)
                    {
                        blocks[i, j] = TextureID.unmovable;
                    }
                }
            }
        }
    }
}
