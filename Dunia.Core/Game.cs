using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace Dunia.Core
{
    public class Game
    {
        Thread backgroundThread;
        World world;

        public Game()
        {
            backgroundThread = new Thread(Update) {
                IsBackground = true
            };
            world = new World(this);
        }

        private void Update()
        {
            while (true)
            {
                world.Update();
            }
        }
    }
}
