using System;
using Xunit;
using Xunit.Abstractions;

namespace FishTank
{
    public class FishFactoryTests
    {
        private readonly string defaultName = "Mr chips";
        private readonly string _defaultWrongFishType = "Dodgy Fish";
        private ITestOutputHelper _outputHelper;

        public FishFactoryTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        [Fact]
        public void Create_EmptyName_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => FishFactory.Create("", _defaultWrongFishType));
        }

        [Fact]
        public void Create_EmptyType_ThrowsArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => FishFactory.Create(defaultName, ""));
        }

        [Fact]
        public void Create_AngelFishWithDefaultName_ReturnsAngelfishWithDefaultNameAndCorrectRequirements()
        {
            var fish = FishFactory.Create(defaultName, "AngelFish");

            var expectedName = defaultName;
            var actualName = fish.Name;
            _outputHelper.WriteLine($"Expected: {expectedName}, actual:{actualName}");

            Assert.Equal(expectedName, actualName);

            var expectedRequiredFood = 0.2m;
            var actualRequiredFood = fish.RequiredFood;
            _outputHelper.WriteLine($"Expected: {expectedRequiredFood}, actual:{actualRequiredFood}");

            Assert.Equal(expectedRequiredFood, actualRequiredFood);
        }

        //}
        //{
        //Create_StateUnderTest_ExpectedBehavior()
        //[Fact]
    }
}
