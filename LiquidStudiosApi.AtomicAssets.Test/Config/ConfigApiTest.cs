using FluentAssertions;
using LiquidStudiosApi.AtomicAssets.Config;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicAssets.Test.Config
{
    [TestFixture]
    public class ConfigApiTest
    {
        [Test]
        public void Config()
        {
            AtomicAssetsApiFactory.Version1.ConfigApi.Config().Should().BeOfType<ConfigDto>();
        }
    }
}
