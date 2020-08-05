using Moq;
using NUnit.Framework;
using Shouldly;

namespace AutoMoq.Tests
{
    public class ConfigTests
    {
        [TestFixture]
        public class MockBehaviorTests
        {
            [Test]
            public void It_should_default_to_loose()
            {
                var config = new Config();
                config.MockBehavior.ShouldBe(MockBehavior.Loose);
            }
        }
    }
}