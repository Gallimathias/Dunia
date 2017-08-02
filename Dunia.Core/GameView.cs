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

            int x = X + SpeedX;
            int y = Y + SpeedY;

            if (y + 100 > Height && SpeedY > 0)
            {
                Y = Height - 100;
                SpeedY *= -1;
                SpeedX += 5;
            }
            else if (y - 100 < 0 && SpeedY < 0)
            {
                y = 0;
                SpeedY *= -1;
                SpeedX += 5;
            }

            if (x + 100 > Width && SpeedX > 0)
            {
                x = Width - 100;
                SpeedX *= -1;
                SpeedY += 5;
            }
            else if (x - 100 < 0 && SpeedX < 0)
            {
                SpeedX *= -1;
                SpeedY += 5;
                x = 0;
            }

            X = x + SpeedX;
            Y = y + SpeedY;

            return new Rectangle(X, Y, 100, 100);
        }

        private int CheckValue(int value, int max, int min)
        {

            if (value < min)
                return min == 0 ? -1 : min;

            if (value > max)
                return max == 0 ? 1 : max;

            return value == 0 ? 1 : value;
        }
    }
}
