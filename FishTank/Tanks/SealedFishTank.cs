using System.Collections.Generic;
using FishTank.Core;

namespace FishTank
{
    public class SealedFishTank : Tank
    {
        public SealedFishTank(IEnumerable<IFish> fish)
            : base(fish)
        {
        }
    }
}