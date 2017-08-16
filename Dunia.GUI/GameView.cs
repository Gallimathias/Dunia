using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dunia.Core;

namespace Dunia.GUI
{
    public partial class GameView : UserControl
    {
        Timer timer;
        Game game;

        public GameView(Game game)
        {
            this.game = game;

            InitializeComponent();


            BackColor = Color.CornflowerBlue;

            timer = new Timer()
            {
                Interval = 20
            };

            timer.Tick += (s, e) => Invalidate();

            timer.Start();

        }

        protected override void OnPaint(PaintEventArgs e)
        {

        }


    }
}
