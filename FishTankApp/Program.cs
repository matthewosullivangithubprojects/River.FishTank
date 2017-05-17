using System;
using System.Collections.Generic;
using FishTank;
using FishTank.Core;

namespace FishTankApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var fish = new List<IFish>
            {
                new AngelFish("Dave Angel"),
                new BabelFish("Babs"),
                new GoldFish("Ms Hawn"),
                FishFactory.Create("Pond... James Pond", "AngelFish")
            };

            var tank = new ModifiableFishTank(fish);

            Console.WriteLine($"Gee these fish are hungry, they need {tank.Feed()} arbitrary units of food.");

            foreach (var f in tank.Fish)
                Console.WriteLine($"Hello {f.Name}, you're a lovely {f.GetType().Name}. ");

            Console.ReadLine();
        }
    }
}