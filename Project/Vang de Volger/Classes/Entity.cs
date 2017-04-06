using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    abstract class Entity
    {
        public const int ASSET_SIZE = 32; //Sets a constant size for all images to be 32 pixels.
        private Graphics frameGraphics; //Taken over from the Graphics from GameWindow. Used to draw on the panel.
        private Tile thisTile; //Creates a local tile for each entity that takes the Tile from the contructor.
        private Tile targetTile;
        private Level _level;
        private GameWindow _game;
        private Timer _timer;
        private bool IsEnemy;


        public Entity(GameWindow game, Level level, Timer timer, Tile tile, Point point, Graphics g, bool enemy)
        {
            _timer = timer;
            _game = game;
            _level = level;
            IsEnemy = enemy;
            frameGraphics = g;
            thisTile = tile;

        }
        /// <summary>
        /// Abstract class to get the texture from each child. Returns a bitmap.
        /// </summary>
        public abstract Bitmap GetTexture
        {
            get;
        }
        /// <summary>
        /// Abstract class to see if the child is solid. Used to check if the child is allowed to move.
        /// </summary>
        public abstract bool Solid
        {
            get;
        }
        /// <summary>
        /// Draw method used to draw texture on screen at certain position foreach entity.
        /// </summary>
        /// <param name="_location"></param>
        public void Draw(Point _location)
        {
            frameGraphics.DrawImage(GetTexture, _location);
        }
        /// <summary>
        /// Takes the direction and moves the Entity to the tile according to the direction.
        /// Checks if the game is paused and if the Entity is able to move.
        /// Asks if there is a neighbor tile next to the Entity in the current direction.
        /// Asks if something is in that tile.
        /// Depending what is in that tile, returns true (to not move) or false (to move).
        /// Moving the Entity saves it in that tile and saves null in its place.
        /// </summary>
        /// <param name="pDirection"></param>
        /// <returns></returns>
        ///
        public bool Move(Direction pDirection)
        {
            Tile neighborTile = thisTile.GetNeighbour(pDirection);

            if (neighborTile == null)
            {
                return false;
            }
            else if (neighborTile.GetEntity() == null)
            {
                neighborTile.SaveEntity(this);
                thisTile.SaveEntity(null);
                thisTile = neighborTile;
                _level.DrawEntities();
                return true;
            }
            else if (neighborTile.GetEntity() is Pillar && IsEnemy == false)
            {
                if (((Pillar)neighborTile.GetEntity()).Move(pDirection))
                {
                    neighborTile.SaveEntity(this);
                    thisTile.SaveEntity(null);
                    _level.DrawEntities();
                    thisTile = neighborTile;
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (neighborTile.GetEntity() is Player && IsEnemy == true)
            {
                _timer.Stop();
                thisTile.GetEntity().Move(Direction.None);
                GetTexture.Dispose();
                if (MessageBox.Show("You got hit by the enemy! Restart?", "Angry Chicken", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _game.Restart();
                }
                else
                {
                    Application.Exit();
                }
                return true;
            }
            else if (neighborTile.GetEntity() is Enemy)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
