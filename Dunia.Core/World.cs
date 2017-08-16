using Dunia.Core.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dunia.Core
{
    internal class World
    {
        Map map;
        Game game;

        public World(Game game)
        {
            this.game = game;
            map = Map.FromFile("");
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
