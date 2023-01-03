using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    public class Simulation : IDrawable
    {
        List<SimulObject> objects;
        public Simulation()
        {
            objects = new List<SimulObject>();

            objects.Add(new Animal);
            objects.Add(new Plant);
        }

        public void Update()
        {
            foreach (SimulObject drawable in objects)
            {
                drawable.Update();
            }
        }

        public void Draw(ICanvas canvas, RectF dirtyRect)
        {
            foreach (SimulObject drawable in objects)
            {
                canvas.FillColor = drawable.Color;
                canvas.FillCircle(new Point(drawable.X, drawable.Y), 5.0);
            }
        }
    }
}
}
