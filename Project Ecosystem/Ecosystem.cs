using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Ecosystem
{
    class Ecosystem
    {

        private List<Entity> system = new List<Entity>();
        public Ecosystem(int carnivore = 5, int herbivore = 8, int food = 10, int plants = 10)
        {
            var rand = new Random();
            for (int i = 0; i < carnivore; i++)
            {
                system.Add(new Carnivore((float)(rand.NextDouble() * 100), (float)(rand.NextDouble() * 100), i % 2 == 0));
            }
            for (int i = 0; i < herbivore; i++)
            {
                system.Add(new Herbivore((float)(rand.NextDouble() * 100), (float)(rand.NextDouble() * 100), i % 2 == 0));
            }
            for (int i = 0; i < food; i++)
            {
                system.Add(new Food((float)(rand.NextDouble() * 100), (float)(rand.NextDouble() * 100), 10));
            }
            for (int i = 0; i < plants; i++)
            {
                system.Add(new Plant((float)(rand.NextDouble() * 100), (float)(rand.NextDouble() * 100)));
            }
        }
        public List<Entity> getSystem() { return system; }
        public void startSystem()
        {
            DateTime now = DateTime.Now;
            foreach (Entity i in system.ToList())
            {
                for (int j = system.IndexOf(i); j < system.Count(); j++)
                {
                    float space = (float)Math.Sqrt((Math.Pow(i.getX() - system[j].getX(), 2) + Math.Pow(i.getY() - system[j].getY(), 2)));
                    if (space <= (float)(i.getContactZone() + system[j].getContactZone()))
                    {

                        if (i.Interaction(system[j]) == 2)
                        {
                            system.Insert(0, new Carnivore((float)system[j].getX() + 10000, (float)system[j].getY() + 10000, now.Second > 30));
                        }
                        else if (i.Interaction(system[j]) == -10)
                        {
                            LifeForm k = (LifeForm)system[j];
                            k.Accident();
                        }
                        else if (i.Interaction(system[j]) == 3)
                        {
                            system.Add(new Herbivore((float)system[j].getX(), (float)system[j].getY(), now.Second > 30));
                        }
                        else if (i.Interaction(system[j]) == 1)
                        {
                            try
                            {
                                LifeForm k = (LifeForm)system[j];
                                k.Healing();
                                system.Remove(system[j]);
                            }
                            catch
                            {
                            }
                        }

                    }
                }
            }
            foreach (Entity i in system)
            {
                try
                {
                    Animal l = (Animal)i;
                    for (int j = system.IndexOf(i); j < system.Count(); j++)
                    {
                        float distance = (float)Math.Sqrt((Math.Pow(i.getX() - system[j].getX(), 2) + Math.Pow(i.getY() - system[j].getY(), 2)));
                        float m = (system[j].getY() - i.getY()) / (system[j].getX() - i.getX());
                        float a = (float)Math.Sqrt(1 / (Math.Pow(m, 2) + 1));
                        if (distance <= l.getZoneView())
                        {
                            l.Move(a, a * m);
                        }
                    }
                }
                catch
                {
                }
                try
                {
                    Plant l = (Plant)i;
                    for (int j = system.IndexOf(i); j < system.Count(); j++)
                    {
                        try
                        {
                            Food n = (Food)system[j];
                            float space = (float)Math.Sqrt((Math.Pow(i.getX() - system[j].getX(), 2) + Math.Pow(i.getY() - system[j].getY(), 2)));
                            if (space <= l.getZoneRoot())
                            {
                                l.Healing();
                                system.Remove(system[j]);
                            }
                        }
                        catch
                        {
                        }
                    }
                }
                catch
                {
                }
                if (i.State() == 2)
                {
                    system.Add(new Food(i.getX(), i.getY(), -1));
                }
                if (i.State() == 1)
                {
                    system.Add(new Plant(i.getX() + 10, i.getY() + 10));
                }
            }
        }
    }
}
