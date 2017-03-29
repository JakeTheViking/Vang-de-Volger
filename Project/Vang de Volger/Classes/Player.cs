using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    class Player : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Player32x32;
        private bool IsTileSolid;
        private Graphics drawer;
        private Direction currentDirection;

        public Player(Graphics g, Control control, Point point) : base (point)
        {
            drawer = g;
            IsTileSolid = true;
            Move(currentDirection);
            control.KeyUp += new System.Windows.Forms.KeyEventHandler(this.UpdateOn_KeyUp);
            control.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Direction_KeyDown);
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
        private void UpdateOn_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.W):
                case (Keys.A):
                case (Keys.S):
                case (Keys.D):
                    MessageBox.Show("Rerender");
                    break;
            }
        }

        public void Direction_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.W):
                    currentDirection = Classes.Direction.North;
                    break;
                case (Keys.A):
                    currentDirection = Classes.Direction.West;
                    break;
                case (Keys.S):
                    currentDirection = Classes.Direction.South;
                    break;
                case (Keys.D):
                    currentDirection = Classes.Direction.East;
                    break;
            }
        }
    }
}
