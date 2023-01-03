using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    class Plant : LifeForm
    {
        private float ZoneSemis = 10;
        private float ZoneRoot = 10;
        public Plant(double x, double y) : base(Colors.Green, x, y)
        {

        }
        public float getZoneSemis() { return ZoneSemis; }
        public float getZoneRoot() { return ZoneRoot; }
        public override int Die()
        {
            return 1;
        }
        public override int Interaction(Entity proie)
        {
            return 0;
        }
        public override int Breed()
        {
            return 4;
        }
        public override int Eat(Entity proie)
        {
            return 1;
        }
        public override void Move(float x, float y)
        {

        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), la Plante {2} ", this.getX(), this.getY(), this.GetHashCode());
        }
        public override int State()
        {
            return 1;
        }
    }
}
