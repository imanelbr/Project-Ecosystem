using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
        public abstract class LifeForm : Entity
        {
            private int LifePoint = 100;
            private int Energy = 100;
            public LifeForm(float x, float y) :
                base(x, y)
            {

            }
            public int getLifePoint() { return LifePoint; }
            public int getEnergy() { return Energy; }
            public abstract int Eat(Entity proie);
            public abstract int Breed();
            public abstract int Die();
            public void Accident()
            {
                LifePoint -= 15;
            }
            public void Healing()
            {
                Energy += 15;
            }
            public override string ToString()
            {
                return string.Format("En ({0}, {1}), la forme de vie {2} ", this.getX(), this.getY(), this.GetHashCode());
            }
            public override int State()
            {
                LifePoint++;
                Energy--;
                return 0;
            }
        }
    }

