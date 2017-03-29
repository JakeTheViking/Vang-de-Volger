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

        private Bitmap frame;
        private Graphics frameGraphics;

        public Entity(Point point)
        {
            frame = new Bitmap(800, 800);
            frameGraphics = Graphics.FromImage(frame);

            resized = new Bitmap(GetTexture, new Size(ASSET_SIZE, ASSET_SIZE));

            thisTile = new Tile(point.X, point.Y);
        }
        public abstract Bitmap GetTexture
        {
            get;
        }
        public abstract bool Solid
        {
            get;
        }
        public abstract Graphics GetDrawer
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
            frameGraphics.DrawImage(resized, _location);
            GetDrawer.DrawImage(frame, 0, 0);
        }

        public bool Move(Direction direction)
        {
            Tile neighborTile = thisTile.GetNeighbour();
            return false;
            //if ()
            // is er een vakje = return false
            // zit er iets in het vakje = return true
            //buurvakje(this)
            //huidige(null) save entity
            //this tile = neighbur
            //true
            //recursive doos
        }

        //public void Move(Direction direction)
        //{
        //    currentDirection = direction;

        //    switch (currentDirection)
        //    {
        //        case Direction.North:
        //            position = new Tuple<int, int>(GetPosition.Item1, GetPosition.Item2 - 1);
        //            currentDirection = Direction.None;
        //            break;
        //        case Direction.West:
        //            position = new Tuple<int, int>(GetPosition.Item1 - 1, GetPosition.Item2);
        //            currentDirection = Direction.None;
        //            break;
        //        case Direction.South:
        //            position = new Tuple<int, int>(GetPosition.Item1, GetPosition.Item2 + 1);
        //            currentDirection = Direction.None;
        //            break;
        //        case Direction.East:
        //            position = new Tuple<int, int>(GetPosition.Item1 + 1, GetPosition.Item2);
        //            currentDirection = Direction.None;
        //            break;
        //        case Direction.None:
        //            Draw();
        //            break;
        //    }
        //}


        //public bool CanMoveDirection(TextureID[,] array, Direction direction, int[] position)
        //{
        //    if (direction == Direction.North)
        //    {
        //        if (array[position[0], position[1] - 1] != TextureID.Wall && array[position[0], position[1] - 1] != TextureID.Pillar)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else if (direction == Direction.South)
        //    {
        //        if (array[position[0], position[1] + 1] != TextureID.Wall && array[position[0], position[1] + 1] != TextureID.Pillar)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else if (direction == Direction.West)
        //    {
        //        if (array[position[0] - 1, position[1]] != TextureID.Wall && array[position[0] - 1, position[1]] != TextureID.Pillar)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else if (direction == Direction.East)
        //    {
        //        if (array[position[0] + 1, position[1]] != TextureID.Wall && array[position[0] + 1, position[1]] != TextureID.Pillar)
        //        {
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        //public void MoveDirection(Direction direction, bool paused)
        //{
        //    if (Solid == true && paused == false)
        //    {
        //        currentDirection = direction;
        //        if (currentDirection == Classes.Direction.North)
        //        {
        //            if (CanMoveDirection(Level.blocks, currentDirection, GetPosition) == true)
        //            {
        //                GetPosition[1] -= 1;
        //                currentDirection = Classes.Direction.None;
        //            }
        //        }
        //        if (currentDirection == Classes.Direction.South)
        //        {
        //            if (CanMoveDirection(Level.blocks, currentDirection, GetPosition) == true)
        //            {
        //                GetPosition[1] += 1;
        //                currentDirection = Classes.Direction.None;
        //            }
        //        }
        //        if (currentDirection == Classes.Direction.East)
        //        {
        //            if (CanMoveDirection(Level.blocks, currentDirection, GetPosition) == true)
        //            {
        //                GetPosition[0] += 1;
        //                currentDirection = Classes.Direction.None;
        //            }
        //        }
        //        if (currentDirection == Classes.Direction.West)
        //        {
        //            if (CanMoveDirection(Level.blocks, currentDirection, GetPosition) == true)
        //            {
        //                GetPosition[0] -= 1;
        //                currentDirection = Classes.Direction.None;
        //            }
        //        }
        //    }
        //}
    }
}
