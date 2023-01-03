using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    internal class Food : Entity
    {
        private int IsGood;
        public Food(float x, float y, int IsGood) :
            base(x, y)
        {
            this.IsGood = IsGood;
        }
        public int getIsGood() { return IsGood; }
        public override int Interaction(Entity proie)
        {
            return 0;
        }
        public override void Move(float x, float y)
        {

        }
        public override int State()
        {
            IsGood--;
            return 0;
        }

    }
}
