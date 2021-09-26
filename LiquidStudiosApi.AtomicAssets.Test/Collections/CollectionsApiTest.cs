using FluentAssertions;
using LiquidStudiosApi.AtomicAssets.Collections;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicAssets.Test.Collections
{
    [TestFixture]
    public class CollectionsApiTest
    {
        [Test]
        public void Collections()
        {
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Should().BeOfType<CollectionsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.Should().BeOfType<CollectionsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.Should().HaveCountGreaterOrEqualTo(1);
        }

        [Test]
        public void Collection()
        {
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collection("test").Should().BeOfType<CollectionsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collection("test").Data.Should().BeOfType<CollectionsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collection("test").Data.Should().HaveCountGreaterOrEqualTo(1);
        }

        [Test]
        public void CollectionStats()
        {
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionStats("test").Should().BeOfType<StatsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionStats("test").Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        public void ColectionLogs()
        {
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionLogs("test").Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionLogs("test").Data.Should().BeOfType<LogsDto.DataDto[]>();
        }

        [Test]
        public void BuildCollectionsParameters()
        {
            AtomicAssetsApiFactory.Version1.CollectionsApi
                .BuildCollectionsParameters()
                .Should()
                .BeEquivalentTo("?");

            AtomicAssetsApiFactory.Version1.CollectionsApi
                .WithAfter(1)
                .WithBefore(10)
                .WithAuthor("me")
                .WithCollectionBlacklist(new []{"one", "two"})
                .WithOrder(CollectionsApi.SortStrategy.Ascending)
                .BuildCollectionsParameters()
                .Should()
                .BeEquivalentTo("?&author=me&collection_blacklist=one,two&before=10&after=1&order=asc");
        }
    }
}