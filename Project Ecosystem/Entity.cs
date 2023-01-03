using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    public abstract class Entity
    {
        private float x;
        private float y;
        private float ContactZone = 15;


        public Entity(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float getX() { return x; }
        public float getY() { return y; }
        public float getContactZone() { return ContactZone; }
        public abstract int Interaction(Entity proie);
        public virtual void Move(float x, float y)
        {
            this.x += x;
            this.y += y;
        }
        public abstract int State();
    }
}