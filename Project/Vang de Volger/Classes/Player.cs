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
        public int xPos { get; set; }
        public int yPos { get; set; }
        public Player(int i, int j)
        {
            xPos = i;
            yPos = j;
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
    }
}
