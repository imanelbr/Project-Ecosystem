using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    public class Carnivore : Animal
    {
        public Carnivore(double x, double y, bool Sorts) :
           base(Colors.Blue, x, y, Sorts)
        {

        }
        public int Attack(Animal proie)
        {
            return -10;
        }
        public override int Eat(Entity proie)
        {
            Food f = (Food)proie;
            if (f.getIsGood() >= 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }

        }
        public override int Die()
        {
            return 1;
        }
        public override int Breed()
        {
            return 2;
        }
        public override int Interaction(Entity proie)
        {
            try
            {
                Food g = (Food)proie;
                return Eat(g);
            }
            catch
            {
            }
            try
            {
                Carnivore h = (Carnivore)proie;
                if (h.getSorts() == false)
                {
                    return Breed();
                }
                else if (h.getSorts() == true)
                {
                    return Attack(h);
                }
            }
            catch
            {
            }
            try
            {
                Animal i = (Animal)proie;
                if (i.getSorts() == true)
                {
                    return Breed();
                }
            }
            catch
            {
            }
            return 0;
        }
        public override string ToString()
        {
            return string.Format("En ({0}, {1}), le Carnivore {2} ", this.getX(), this.getY(), this.GetHashCode());
        }
    }
}
