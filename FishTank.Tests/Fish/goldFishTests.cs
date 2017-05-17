using FishTank.Core;
using Xunit;
using Xunit.Abstractions;

namespace FishTank
{
    public class GoldFishTests
    {
        public GoldFishTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _fish = new GoldFish(FishName);
        }

        private readonly ITestOutputHelper _outputHelper;
        private const decimal GoldFishRequiredFood = 0.1m;
        private const string FishName = "Gold fin grr";
        private readonly IFish _fish;

        [Fact]
        public void GetName_FishCreated_NameCorrect()
        {
            const string expected = FishName;
            var fish = _fish;
            var actual = fish.Name;

            _outputHelper.WriteLine($"Expected: {expected}, actual:{actual}");
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetRequiredFood_FishCreated_FoodCorrect()
        {
            const decimal expected = GoldFishRequiredFood;
            var fish = _fish;
            var actual = fish.RequiredFood;

            _outputHelper.WriteLine($"Expected: {expected}, actual:{actual}");
            Assert.Equal(expected, actual);
        }

        //}
        //{
        //MethodName_StateUnderTest_ExpectedBehavior()
        //[Fact]
    }
}