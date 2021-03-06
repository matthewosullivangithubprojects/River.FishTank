﻿using System;

namespace FishTank.Core
{
    public abstract class Fish : IFish
    {
        protected Fish(string name, decimal requiredfood)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentNullException(nameof(name));
            if (requiredfood <= 0m) throw new ArgumentOutOfRangeException(nameof(requiredfood));

            Name = name;
            RequiredFood = requiredfood;
        }

        public string Name { get; }
        public decimal RequiredFood { get; }
    }
}