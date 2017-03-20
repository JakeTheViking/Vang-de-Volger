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
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Enemy;
        private int xPos { get; set; }
        private int yPos { get; set; }

        public Enemy(int i, int j)
        {
            xPos = i;
            yPos = j;
        }
        public override Bitmap GetTexture
        {
            get
            {
                return texture;
            }
        }
    }
}
