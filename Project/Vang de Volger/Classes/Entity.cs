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
        public const int ASSET_SIZE = 32;
        private Bitmap resized;
        private Tile thisTile;
        private Point currentLocation;
        private Bitmap frame;
        private Graphics frameGraphics;
        private bool pPaused;

        public Entity(Tile tile, Point point, Graphics g, bool paused)
        {
            pPaused = paused;
            frameGraphics = g;

            resized = new Bitmap(GetTexture, new Size(ASSET_SIZE, ASSET_SIZE));

            thisTile = tile;
        }
        public abstract Bitmap GetTexture
        {
            get;
        }
        public abstract bool Solid
        {
            get;
        }
        /// <summary>
        /// Draw constructor used to draw texture on screen at certain position.
        /// </summary>
        /// <param name="frameGraphics"></param>
        /// <param name="xCord"></param>
        /// <param name="yCord"></param>
        public void Draw(Point _location)
        {
            currentLocation = _location;
            frameGraphics.DrawImage(resized, _location);
        }
        public bool Move(Direction pDirection)
        {
            if (pPaused == false)
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
                    return true;
                }
                else if (neighborTile.GetEntity().ToString() == "Vang_de_Volger.Classes.Wall")
                {
                    return true;
                }
                else if (neighborTile.GetEntity().ToString() == "Vang_de_Volger.Classes.Pillar")
                {
                    //if (neighborTile.GetEntity().Move(pDirection) == true)
                    //{
                    //    return false;
                    //}
                    //else
                    //{
                    //    return true;
                    //}
                    return true;
                }
                else if (neighborTile.GetEntity().ToString() == "Vang_de_Volger.Classes.Player")
                {
                    MessageBox.Show("Gameover");
                    Application.Exit();
                    return true;
                }
                else if (neighborTile.GetEntity().ToString() == "Vang_de_Volger.Classes.Enemy")
                {
                    MessageBox.Show("Gameover");
                    Application.Exit();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
            //else ()

            //    if ()
            //     is er een vakje = return false
            //     zit er iets in het vakje = return true
            //    buurvakje(this)
            //    huidige(null) save entity
            //    this tile = neighbur
            //    true
            //    recursive doos
        }

        //protected void Move(Direction direction, bool pause)
        //{
        //    if (pause == false)
        //    {
        //        switch (direction)
        //        {
        //            case Direction.North:
        //                RedrawPast(Vang_de_Volger.Properties.Resources.Background32x32, currentLocation);
        //                currentLocation.Y -= Entity.ASSET_SIZE;
        //                Draw(currentLocation);
        //                break;
        //            case Direction.West:
        //                RedrawPast(Vang_de_Volger.Properties.Resources.Background32x32, currentLocation);
        //                currentLocation.X -= Entity.ASSET_SIZE;
        //                Draw(currentLocation);
        //                break;
        //            case Direction.South:
        //                RedrawPast(Vang_de_Volger.Properties.Resources.Background32x32, currentLocation);
        //                currentLocation.Y += Entity.ASSET_SIZE;
        //                Draw(currentLocation);
        //                break;
        //            case Direction.East:
        //                RedrawPast(Vang_de_Volger.Properties.Resources.Background32x32, currentLocation);
        //                currentLocation.X += Entity.ASSET_SIZE;
        //                Draw(currentLocation);
        //                break;
        //        }
        //    }
    }
}
