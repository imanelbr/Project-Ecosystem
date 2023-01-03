using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    public abstract class Animal : LifeForm
    {
        private bool Sorts;
        private float ZoneView= 20;
        public Animal(double x, double y, bool Sorts) : base(Colors.Red, x, y) {
            this.Sorts = Sorts;
        }
       
        public bool getSorts() { return Sorts; }
        public float getZoneView() { return ZoneView; }
        public int Poop()
        {
            return 2;
        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), l'Animal {2} ", this.getX(), this.getY(), this.GetHashCode());
        }
        public override int State()
        {
            return Poop();
        }
    }
}
