using System.Linq;
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

            AtomicAssetsApiFactory.Version1.CollectionsApi.WithOrder(SortStrategy.Ascending).Collections().Should().BeOfType<CollectionsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.Should().BeOfType<CollectionsDto.DataDto[]>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.Should().HaveCountGreaterOrEqualTo(1);

        }

        [Test]
        public void Collection()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.First().CollectionName;
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collection(collectionNameToFind).Should().BeOfType<CollectionDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.Collection(collectionNameToFind).Data.Should().BeOfType<CollectionDto.DataDto>();
        }

        [Test]
        public void CollectionStats()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.First().CollectionName;
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionStats(collectionNameToFind).Should().BeOfType<StatsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionStats(collectionNameToFind).Data.Should().BeOfType<StatsDto.DataDto>();
        }

        [Test]
        public void ColectionLogs()
        {
            var collectionNameToFind = AtomicAssetsApiFactory.Version1.CollectionsApi.Collections().Data.First().CollectionName;
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionLogs(collectionNameToFind).Should().BeOfType<LogsDto>();
            AtomicAssetsApiFactory.Version1.CollectionsApi.CollectionLogs(collectionNameToFind).Data.Should().BeOfType<LogsDto.DataDto[]>();
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
                .WithOrder(SortStrategy.Ascending)
                .BuildCollectionsParameters()
                .Should()
                .BeEquivalentTo("?&author=me&collection_blacklist=one,two&before=10&after=1&order=asc");
        }
    }
}