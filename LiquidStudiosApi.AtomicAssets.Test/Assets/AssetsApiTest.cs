using FluentAssertions;
using LiquidStudiosApi.AtomicAssets.Assets;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicAssets.Test.Assets
{
    [TestFixture]
    public class AssetsApiTest
    {
        [Test]
        public void Assets()
        {
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Should().BeOfType<AssetsDto>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Data.Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Data.Should().HaveCountGreaterOrEqualTo(1);

            AtomicAssetsApiFactory.Version1.AssetsApi.Assets(new AssetsUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<AssetsDto>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Data.Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Assets().Data.Should().HaveCountGreaterOrEqualTo(1);
        }

        [Test]
        public void Asset()
        {
            AtomicAssetsApiFactory.Version1.AssetsApi.Asset("1099566952188").Should().BeOfType<AssetsDto>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Asset("1099566952188").Data.Should().BeOfType<AssetsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.AssetsApi.Asset("1099566952188").Data.Should().HaveCount(1);
        }

        [Test]
        public void AssetStats()
        {
            AtomicAssetsApiFactory.Version1.AssetsApi.AssetStats("1099566952188").Should().BeOfType<StatsDto>();
            AtomicAssetsApiFactory.Version1.AssetsApi.AssetStats("1099566952188").Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        public void AssetLogs()
        {
            AtomicAssetsApiFactory.Version1.AssetsApi.AssetLogs("1099566952188").Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.AssetsApi.AssetLogs("1099566952188").Data.Should().BeOfType<LogsDto.DataDto>();
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