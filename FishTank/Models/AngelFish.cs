using FishTank.Core;

namespace FishTank.Models
{
    public abstract class AngelFish : Fish
    {
        protected AngelFish(string name) 
            : base(name, 0.2m)
        {
        }

        public string Name { get; }
        public decimal RequiredFood { get; }
    }
}