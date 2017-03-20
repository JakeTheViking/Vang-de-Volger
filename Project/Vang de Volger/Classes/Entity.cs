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
        /// <summary>
        /// An abstract contructor which is used in the Draw() method
        /// Set to abstract because child class is delivering properties (in this case a Bitmap texture)
        /// </summary>
        public abstract Bitmap GetTexture
        {
            get;
        }
        /// <summary>
        /// Draw constructor used to draw texture on screen at certain position.
        /// </summary>
        /// <param name="frameGraphics"></param>
        /// <param name="xCord"></param>
        /// <param name="yCord"></param>
        public void Draw(Graphics frameGraphics, int xCord, int yCord)
        {
            Bitmap resized = new Bitmap(GetTexture, new Size(Game.ASSET_SIZE, Game.ASSET_SIZE));

            frameGraphics.DrawImage(resized, xCord * Game.ASSET_SIZE, yCord * Game.ASSET_SIZE);
        }
    }
}
