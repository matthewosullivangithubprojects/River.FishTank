using System;
using System.Collections.Generic;
using System.Linq;
using FishTank.Core;

namespace FishTank
{
    public static class FishFactory
    {
        
        public static IFish Create(string fishName, string typeOfFish)
        {
            if(string.IsNullOrWhiteSpace(fishName)) throw new ArgumentNullException(nameof(fishName));
            if(string.IsNullOrWhiteSpace(typeOfFish)) throw  new ArgumentNullException(nameof(typeOfFish));

            try
            {
                var fishTypes = FishTypes.Value.First(
                    fishType => string.Equals(fishType.Name, typeOfFish, StringComparison.CurrentCultureIgnoreCase));

                if (fishTypes != null)
                {
                    return (IFish) Activator.CreateInstance(fishTypes, fishName);
                }
                
            }
            catch
            {
                //TODO - Determine best exceptions to catch and leave any system exceptions to propogate.
            }

            return null;
        }

        private static readonly Lazy<IEnumerable<Type>> FishTypes = new Lazy<IEnumerable<Type>>(GetAvailableFish);

        private static IEnumerable<Type> GetAvailableFish()
        {
            var type = typeof(IFish);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => type.IsAssignableFrom(p) && !p.IsAbstract);

            return types.ToList();
        }
    }
}


