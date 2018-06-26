using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlagMaker3.Classes
{
    public class Level
    {

        public Color Color { get; set; }
        public Rectangle Bounds { get; set; }

        public Level()
        {
            this.Color = Color.White;
        }

        public void Draw(Graphics g)
        {

            g.FillRectangle(new SolidBrush(this.Color), this.Bounds);

        }

    }
}
