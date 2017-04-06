using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    class Pillar : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Pillar32x32;
        private bool IsTileSolid;
        public Pillar(GameWindow game, Level level, Timer timer, Tile tile, Graphics g, Point point) : base(game, level, timer, tile, point, g, false)
        {
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
    }
}
