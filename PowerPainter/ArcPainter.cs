using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PowerPainter
{
    public class ArcPainter : IDrawObject
    {
        Graphics _g = null;

        public ArcPainter(Graphics g)
        {
            _g = g;
        }

        public void paint()
        {
            if (_g != null)
            {
                Pen p = new Pen(Color.Yellow, 3.0f);
                Rectangle r = new Rectangle(0, 0, 200, 200);
                _g.DrawArc(p, r, 0.0f, 180.0f);
            }
        }
        
        public void delete()
        {
            if (_g != null)
            {
                Pen p = new Pen(Color.White, 3.0f);
                Rectangle r = new Rectangle(0, 0, 200, 200);
                _g.DrawArc(p, r, 0.0f, 180.0f);
            }
        }
    }
}
