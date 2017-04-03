using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Vang_de_Volger.Classes
{
    class Enemy : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Enemy32x32;
        private bool IsTileSolid;
        private Tile EnemyTile;
        private Direction rngDirection;
        private Timer movementTimer;
        public Enemy(Tile tile, Graphics g, Point point, bool paused) : base(tile, point, g, paused)
        {
            EnemyTile = tile;
            IsTileSolid = true;
            SetTimer();
        }
        private void SetTimer()
        {
            movementTimer = new Timer(500);
            movementTimer.Enabled = true;
            movementTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);

        }
        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            MoveRandomly();
        }
        public void MoveRandomly()
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 5);
            
            switch (count)
            {
                case 1:
                    rngDirection = Direction.North;
                    break;
                case 2:
                    rngDirection = Direction.South;
                    break;
                case 3:
                    rngDirection = Direction.East;
                    break;
                case 4:
                    rngDirection = Direction.West;
                    break;
            }
            Tile neighborTile = EnemyTile.GetNeighbour(rngDirection);

            if (neighborTile.GetEntity() == null || neighborTile.GetEntity().ToString() == "Vang_de_Volger.Classes.Player")
            {
                EnemyTile = neighborTile;
                Move(rngDirection);
            } else
            {
                count = rnd.Next(1, 5);
            }

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
