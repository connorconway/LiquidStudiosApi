using FluentAssertions;
using LiquidStudiosApi.AtomicAssets.Assets;
using LiquidStudiosApi.AtomicAssets.Offers;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicAssets.Test.Offers
{
    [TestFixture]
    public class OffersApiTest
    {
        [Test]
        public void Offers()
        {
            AtomicAssetsApiFactory.Version1.OffersApi.Offers().Should().BeOfType<OffersDto>();

            //TODO
            AtomicAssetsApiFactory.Version1.OffersApi.Offers().Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Data.Should().HaveCountGreaterOrEqualTo(1);
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<AssetsDto>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Data.Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Data.Should().HaveCountGreaterOrEqualTo(1);
        }

        [Test]
        public void Offer()
        {
            //TODO
            AtomicAssetsApiFactory.Version1.AssetsApi.Asset("1099566952188").Should().BeOfType<AssetsDto>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Asset("1099566952188").Data.Should().BeOfType<AssetsDto.DataDto[]>();
        }

        [Test]
        public void OfferLogs()
        {
            AtomicAssetsApiFactory.Version1.OffersApi.OfferLogs("1099566952188").Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.OffersApi.OfferLogs("1099566952188").Data.Should().BeOfType<LogsDto.DataDto>();
        }

        [Test]
        public void BuildAssetsParameters()
        {
            new AssetsUriParameterBuilder()
                .Build()
                .Should()
                .BeEquivalentTo("?");

            new AssetsUriParameterBuilder()
                .WithAfter(1)
                .WithBefore(10)
                .WithOnlyDuplicateTemplate(true)
                .WithOwner("me")
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithOrder(SortStrategy.Ascending)
                .Build()
                .Should()
                .BeEquivalentTo("?&owner=me&collection_blacklist=one,two&only_duplicate_templates=True&before=10&after=1&order=asc");
        }
    }
}