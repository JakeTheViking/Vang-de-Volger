using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vang_de_Volger.Classes
{
    class Grass : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Grass;
        public override Bitmap GetTexture
        {
            get
            {
                return texture;
            }
        }
    }
}
