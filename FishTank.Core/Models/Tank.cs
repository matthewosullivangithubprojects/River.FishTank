using System.Collections.Generic;
using System.Linq;

namespace FishTank.Core
{
    public abstract class Tank : ITank
    {
        private readonly IEnumerable<IFish> _fish;

        protected Tank(IEnumerable<IFish> fish)
        {
            _fish = fish;
        }

        public decimal Feed()
        {
            var totalFoodRequied = _fish.Sum(f => f.RequiredFood);

            return totalFoodRequied;
        }
    }
}