using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vang_de_Volger.Classes
{
    class Tiles
    {
        private Entity ContainsEntity;
        private int LocationX;
        private int LocationY;
        private Dictionary<Direction, Tiles> neighbor;
        public Tiles(int rows, int columns)
        {
            ContainsEntity = null;
            neighbor = new Dictionary<Direction, Tiles>();
            LocationX = rows;
            LocationY = columns;
        }

        public void SaveNeighbour(Direction direction, Tiles tile, bool greeting = true)
        {
            neighbor[direction] = tile;
            if (greeting)
            {
                tile.SaveNeighbour(~direction, this, false);
            }
        }


        public Point LocationInLevel()
        {
            return new Point((LocationX * Entity.ASSET_SIZE), (LocationY * Entity.ASSET_SIZE));
        }

        public void SaveEntity(Entity _entity)
        {
            ContainsEntity = _entity;
        }

        public Entity GetEntity()
        {
            return ContainsEntity;
        }
    }
}
