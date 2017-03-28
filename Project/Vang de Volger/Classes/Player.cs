using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    class Player : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Player;
        private bool IsTileSolid;
        private Graphics drawer;
        public Player(Graphics g, Point point)
        {
            drawer = g;
            IsTileSolid = true;
            //Point _point = new Point(32, 64);
            //Move(currentDirection);
            Draw(point);
        }
        /// <summary>
        /// Override of GetTexture method
        /// Returns texture property linked to this class
        /// </summary>
        public override Bitmap GetTexture
        {
            get
            {
                return texture;
            }
        }
        public override bool Solid
        {
            get
            {
                return IsTileSolid;
            }
        }
        public override Graphics GetDrawer
        {
            get
            {
                return drawer;
            }
        }


    }
}
