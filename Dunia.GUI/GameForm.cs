using Dunia.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dunia.GUI
{
    public partial class GameForm : Form
    {
        private Game game;

        public GameForm(Game game)
        {
            this.game = game;
            InitializeComponent();
        }
    }
}
