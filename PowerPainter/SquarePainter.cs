using System;
using System.Collections.Generic;
using System.Text;

using System.Drawing;

namespace PowerPainter
{
    class SquarePainter : IDrawObject
    {
        Graphics _g = null;

        public SquarePainter(Graphics g)
        {
            _g = g;
        }

        public void paint()
        {
            if (_g != null)
            {
                Pen p = new Pen(Color.Red, 3.0f);
                Rectangle r = new Rectangle(0, 0, 200, 200);
                _g.DrawRectangle(p, r);
            }
        }

        public void delete()
        {
            Pen p = new Pen(Color.Red, 3.0f);
            Rectangle r = new Rectangle(0, 0, 200, 200);
            _g.DrawRectangle(p, r);
        }      
    }
}
