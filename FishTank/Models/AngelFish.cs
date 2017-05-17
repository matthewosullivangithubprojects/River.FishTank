using FishTank.Core;

namespace FishTank.Models
{
    public class AngelFish : Fish
    {
        protected AngelFish(string name) 
            : base(name, 0.2m)
        {
        }
    }
}