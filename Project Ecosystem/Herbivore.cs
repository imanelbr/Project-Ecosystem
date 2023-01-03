using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    public class Herbivore : Animal
    {
        public Herbivore(double x, double y, bool Sorts) :
            base(Color.Yellow, x, y, Sorts)
        {

        }
        public override int Interaction(Entity proie)
        {
            try
            {
                Plant g = (Plant)proie;
                return Eat(g);
            }
            catch
            {
            }
            try
            {
                Herbivore f = (Herbivore)proie;
                if (f.getSorts() == false)
                {
                    return Breed();
                }
            }
            catch
            {
            }
            return 0;
        }
        public override int Eat(Entity proie)
        {
            return 1;
        }
        public override int Breed()
        {
            return 3;
        }
        public override int Die()
        {
            return 1;
        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), l'herbivore {2} ", this.getX(), this.getY(), this.GetHashCode());
        }
    }
}
