using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPainter
{
    public partial class MainForm : Form
    {
        //private List<IDrawObject> toPaint;               

        public MainForm()
        {
            InitializeComponent();
            
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Text = "PowerPainter v1.0";
            this.BackColor = Color.White;

            // Windows uses paint events that are sent to the form to update the items on your form.
            // Like with button clicks, we subscribe a method to an eventhandler that should
            // intercept the paint events and perform some action

            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.formPaintMethod);
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.formPaintClass);
            //this.Paint += new System.Windows.Forms.PaintEventHandler(this.formPaintMultipleTypes);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.formPaintGeneric);
        }

        private void formPaintMethod(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(Color.Red, 3.0f);
            Rectangle r = new Rectangle(0, 0, 200, 200);
            g.DrawRectangle(p, r);
        }

        // Instead of methods in the form that paint a rectangle we now want to 
        // make a class responsible to draw itself on the form canvas
        private void formPaintClass(object sender, System.Windows.Forms.PaintEventArgs e)
        {     
            Graphics g = this.CreateGraphics();
            SquarePainter sp = new SquarePainter(g);
            sp.paint();            
        }

        // Now let's add a new type of painter class
        // Let's draw also a circle
        private void formPaintMultipleTypes(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            SquarePainter sp = new SquarePainter(g);
            sp.paint();


            CirclePainter cp = new CirclePainter(g);
            cp.paint();
        }

        // Can't we generalize the multiple types code?
        // Actually we calling the same method (behavior), only how it the class does it (how) is different.
        // Yes we can! Introducing an interface as painter type can do this
        private void formPaintGeneric(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            List<IDrawObject> toPaint = new List<IDrawObject>();
            Graphics g = this.CreateGraphics();
            toPaint.Add(new SquarePainter(g));
            toPaint.Add(new CirclePainter(g));

            foreach (IDrawObject p in toPaint)
                p.paint();

            //===> Clean-up/refactor our code here

            // Ahh, we support now a new type .. an Arc (partial circles)
            toPaint.Add(new ArcPainter(g));
            foreach (IDrawObject p in toPaint)
                p.paint();

            // Paint everything except square
            foreach (IDrawObject p in toPaint)
            { 
                if (p.GetType() != typeof(SquarePainter))
                    p.paint();
            }

            System.Threading.Thread.Sleep(2000);

            // Delete circles
            foreach (IDrawObject p in toPaint)
            {
                if (p.GetType() == typeof(CirclePainter))
                    p.delete();
            }
        }

    }
}
