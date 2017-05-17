using FishTank.Core;
using Xunit;
using Xunit.Abstractions;

namespace FishTank
{
    public class AngelFishTests
    {
        public AngelFishTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _fish = new AngelFish(FishName);
        }

        private readonly ITestOutputHelper _outputHelper;
        private const decimal AngelFishRequiredFood = 0.2m;
        private const string FishName = "Angel of death";
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
            const decimal expected = AngelFishRequiredFood;
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