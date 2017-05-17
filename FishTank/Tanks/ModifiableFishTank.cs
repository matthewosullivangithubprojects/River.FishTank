using System.Collections.Generic;
using FishTank.Core;

namespace FishTank
{
    public class ModifiableFishTank : Tank
    {
        public ModifiableFishTank(IEnumerable<IFish> fish)
            : base(fish)
        {
        }

        public void Add(IFish fish)
        {
            FishCollection.Add(fish);
        }

        public void Remove(IFish fish)
        {
            FishCollection.Remove(fish);
        }
    }
}