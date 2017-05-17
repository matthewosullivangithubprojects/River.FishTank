namespace FishTank.Core
{
    public interface IFish
    {
        string Name { get; }
        decimal RequiredFood { get; }
    }
}