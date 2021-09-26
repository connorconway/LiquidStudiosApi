using FluentAssertions;
using LiquidStudiosApi.AtomicAssets.Transfers;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicAssets.Test.Transfers
{
    [TestFixture]
    public class TransfersApiTest
    {
        [Test]
        public void Transfers()
        {
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers().Should().BeOfType<TransfersDto>();
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers().Data.Should().BeOfType<TransfersDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.TransfersApi.Transfers().Data.Should().HaveCountGreaterOrEqualTo(1);
        }
    }
}
