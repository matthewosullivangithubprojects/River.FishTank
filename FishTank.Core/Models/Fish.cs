namespace FishTank.Core
{
    public abstract class Fish : IFish
    {
        protected Fish(string name, decimal requiredfood)
        {
            Name = name;
            RequiredFood = requiredfood;
        }

        public string Name { get; }
        public decimal RequiredFood { get; }
    }
}