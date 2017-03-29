using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vang_de_Volger.Classes
{
    class Enemy : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Enemy32x32;
        private bool IsTileSolid;
        private Graphics drawer;
        public Enemy(Graphics g, Point point) : base(point)
        {
            drawer = g;
            IsTileSolid = true;
        }
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
