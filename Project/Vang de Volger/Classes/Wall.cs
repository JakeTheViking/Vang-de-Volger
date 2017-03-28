using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vang_de_Volger.Classes
{
    class Wall : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Wall;
        private bool IsTileSolid;
        private Graphics framegraphics;
        public Wall(Graphics frame, Point point)
        {
            framegraphics = frame;
            IsTileSolid = false;
            Draw(point);
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
                return framegraphics;
            }
        }
    }
}
