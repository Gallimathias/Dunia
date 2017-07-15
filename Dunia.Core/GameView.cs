using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dunia.Core
{
    public partial class GameView : UserControl
    {
        public int Y { get => y; set => y = CheckValue(value, Height, 0); }
        public int X { get => x; set => x = CheckValue(value, Width, 0); }

        public int SpeedX { get => speedX; set => speedX = CheckValue(value, 30, -30); }
        public int SpeedY { get => speedY; set => speedY = CheckValue(value, 30, -30); }

        private int x, y;

        Timer timer;
        int speedX, speedY;

        public GameView()
        {
            InitializeComponent();
            X = Width / 2;
            Y = Height / 2;

            speedY = 5;
            speedX = 0;

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

            using (var brush = new SolidBrush(Color.White))
            {
                e.Graphics.FillEllipse(brush, GetRectangle());
            }


            base.OnPaint(e);
        }

        private Rectangle GetRectangle()
        {
            //if (SpeedY != 0)
            //    SpeedY -= SpeedY - 2;

            //if (SpeedX != 0)
            //    SpeedX -= SpeedX - 2;

            int x = X + SpeedX;
            int y = Y + SpeedY;

            if (y + 100 > Height || y - 100 < 0)
            {
                SpeedY *= -1;
                SpeedX += 5;
            }

            if (x + 100 > Height || x - 100 < 0)
            {
                SpeedX *= -1;
                SpeedY += 5;
            }

            X = x;
            Y = y;

            return new Rectangle(X, Y, 100, 100);
        }

        private int CheckValue(int value, int max, int min)
        {
            if (value + 100 < min)
                return min - 100;

            if (value + 100 > max)
                return max - 100;

            return value;
        }
    }
}
