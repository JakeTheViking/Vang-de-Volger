using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vang_de_Volger.Classes
{
    class Enemy : Entity
    {
        private Bitmap texture = Vang_de_Volger.Properties.Resources.Enemy32x32;
        private bool IsTileSolid;
        private Tile EnemyTile;
        private Direction rngDirection;
        private Level _level;
        private Timer _timer;
        private GameWindow _game;
        private Tile thisTile; //Creates a local tile for each entity that takes the Tile from the contructor.
        public Enemy(GameWindow game, Level level, Timer timer, Tile tile, Graphics g, Point point) : base(game, level, timer, tile, point, g, true)
        {
            _game = game;
            _level = level;
            EnemyTile = tile;
            IsTileSolid = true;
            thisTile = tile;
            _timer = timer;
            _timer.Enabled = true;
            _timer.Tick += new EventHandler(OnTimedEvent);
        }
        private void OnTimedEvent(Object myObject, EventArgs myEventArgs)
        {
            MoveRandomly(GetRandomNumber());
        }
        private int GetRandomNumber()
        {
            Random rnd = new Random();
            int count = rnd.Next(1, 5);
            return count;
        }
        public void MoveRandomly(int count)
        {
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

            if (neighborTile.GetEntity() == null || neighborTile.GetEntity() is Player)
            {
                Move(rngDirection);
            }

            if (Move(Direction.North) == false && Move(~Direction.North) == false && Move(Direction.West) == false && Move(~Direction.West) == false)
            {
                _timer.Stop();
                if (MessageBox.Show("You win! Restart?", "Angry Chicken", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    _game.Restart();
                } else
                {
                    Application.Exit();
                }
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
