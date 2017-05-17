using System.Collections.Generic;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace FishTank.Core.Tests.Models
{
    public class TankTests
    {
        //private readonly string defaultName = "Mr Fish";
        //private readonly decimal defaultRequirements = 0.5m;
        private readonly ITestOutputHelper _outputHelper;

        public TankTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }
        

        [Fact]
        public void Feed_TwoFishAdded_FeedCorrect()
        {
            var mockFish1 = new Mock<IFish>();
            mockFish1.Setup(f => f.Name).Returns("Bob");
            mockFish1.Setup(f => f.RequiredFood).Returns(0.1m);
            var fish1 = mockFish1.Object;

            var mockFish2 = new Mock<IFish>();
            mockFish2.Setup(f => f.Name).Returns("Bob2");
            mockFish2.Setup(f => f.RequiredFood).Returns(0.3m);
            var fish2 = mockFish2.Object;

            var fishList = new List<IFish> { fish1, fish2 };

            var mockTank = new Mock<Tank>(MockBehavior.Loose, fishList);
            var tank = mockTank.Object;

            var expected = fish1.RequiredFood + fish2.RequiredFood;
            var actual = tank.Feed();

            _outputHelper.WriteLine($"Expected: {expected}, actual:{actual}");

            Assert.Equal(expected, actual);

        }

        [Fact]
        public void Constructor_NullList_ThrowsArgumentNullException()
        {
            //TODO
        }

        //MethodName_StateUnderTest_ExpectedBehavior()
        //{

        //}
        //[Fact]
    }
}