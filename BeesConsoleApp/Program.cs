using BeeApp.Repository;
using System;
using System.Collections.Generic;

namespace BeesConsoleApp
{
    class Program
    {
        public static List<Bee> bees = new List<Bee>();

        public static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                var drone = new Drone();
                bees.Add(drone);
            }
            for (int i = 0; i < 10; i++)
            {
                var worker = new Worker();
                bees.Add(worker);
            }

            for (int i = 0; i < 10; i++)
            {
                var queen = new Queen();
                bees.Add(queen);
            }


            for (int i = 0; i < bees.Count; i++)
            {
                Random random = new Random();
                int damageValue = random.Next(0, 100);
                bees[i].Damage(damageValue);
                bees[i].Display();
            }
        }
    }
}
