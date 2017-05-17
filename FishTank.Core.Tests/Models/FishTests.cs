using System;
using Moq;
using Xunit;
using Xunit.Abstractions;

namespace FishTank.Core.Tests.Models
{
    public class FishTests
    {
        private readonly ITestOutputHelper _outputHelper;
        private readonly string defaultName = "Mr Fish";
        private readonly decimal defaultRequirements = 0.5m;

        public FishTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [Fact]
        public void Constructor_EmptyName_ThrowsArgumentNullException()
        {
            //TODO
        }

        [Fact]
        public void Constructor_NullName_ThrowsArgumentNullException()
        {
            //TODO
        }

        [Fact]
        public void Constructor_LessThanZeroFoodRequirements_ThrowsArgumentOutOfRangeException()
        {
            //TODO
        }

        //}
        //{
        //MethodName_StateUnderTest_ExpectedBehavior()
        //[Fact]
    }
}
