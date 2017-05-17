using FishTank.Core;
using Xunit;
using Xunit.Abstractions;

namespace FishTank
{
    public class BabelFishTests
    {
        public BabelFishTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _fish = new BabelFish(FishName);
        }

        private readonly ITestOutputHelper _outputHelper;
        private const decimal BabelFishRequiredFood = 0.3m;
        private const string FishName = "Babel... James Babel";
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
            const decimal expected = BabelFishRequiredFood;
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