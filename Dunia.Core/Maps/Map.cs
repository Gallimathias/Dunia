using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunia.Core.Maps
{
    internal class Map
    {
        Cell[,] cells;

        public Map(int sizeX, int sizeY)
        {
            cells = new Cell[sizeX, sizeY];
        }

        internal static Map FromFile(string fullname)
        {
            throw new NotImplementedException();
        }

        internal static Map Generate(int sizeX, int sizeY)
        {
            var map = new Map(sizeX, sizeY);

            for (int x = 0; x < sizeX; x++)
            {
                for (int y = 0; y < sizeY; y++)
                {
                    map.cells[x, y] = new Cell();
                }
            }

            return map;
        }
    }
}
