using System.Collections.Generic;
using FishTank.Core;

namespace FishTank.Models
{
    public class FishTank : Tank
    {
        public FishTank(IEnumerable<IFish> fish) 
            : base(fish)
        {
        }
    }
}