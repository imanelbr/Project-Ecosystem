using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    public abstract class SimulObject : DrawObject
    {
        public SimulObject(Color color, double x, double y) : base(color, x, y) { }

        abstract public void Update();
    }
}
