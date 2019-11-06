using System.Drawing;

namespace PowerPainter
{
    public  class CirclePainter : IDrawObject
    {
        Graphics _g = null;

        public CirclePainter(Graphics g)
        {
            _g = g;
        }

        public void paint()
        {
            if (_g != null)
            {
                Pen p = new Pen(Color.Green, 3.0f);
                Rectangle r = new Rectangle(0, 0, 200, 200);
                _g.DrawEllipse(p, r);
            }
        }

        public void delete()
        {
            if (_g != null)
            {
                Pen p = new Pen(Color.White, 3.0f);
                Rectangle r = new Rectangle(0, 0, 200, 200);
                _g.DrawEllipse(p, r);
            }
        }
    }
}