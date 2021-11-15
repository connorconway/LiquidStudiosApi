using FluentAssertions;
using LiquidStudiosApi.AtomicMarket.Config;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicMarket.Test.Config
{
    [TestFixture]
    public class ConfigApiTest
    {
        [Test]
        public void Config()
        {
            AtomicMarketApiFactory.Version1.ConfigApi.Config().Should().BeOfType<ConfigDto>();
            AtomicMarketApiFactory.Version1.ConfigApi.Config().Data.Should().BeOfType<ConfigDto.DataDto>();
        }
    }
}
