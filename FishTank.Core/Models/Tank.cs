using System;
using System.Collections.Generic;
using System.Linq;

namespace FishTank.Core
{
    public abstract class Tank : ITank
    {
        protected readonly IList<IFish> FishCollection;

        protected Tank(IEnumerable<IFish> fish)
        {
            if (fish == null) throw new ArgumentNullException(nameof(fish));

            FishCollection = fish.ToList();
        }

        public IEnumerable<IFish> Fish => FishCollection;

        public decimal Feed()
        {
            var totalFoodRequied = FishCollection.Sum(f => f.RequiredFood);

            return totalFoodRequied;
        }
    }
}