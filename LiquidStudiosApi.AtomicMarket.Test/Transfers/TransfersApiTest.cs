﻿using FluentAssertions;
using LiquidStudiosApi.AtomicMarket.Transfers;
using LiquidStudiosApi.Core;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicMarket.Test.Transfers
{
    [TestFixture]
    public class TransfersApiTest
    {
        [Test]
        public void Transfers()
        {
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers().Should().BeOfType<TransfersDto>();
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers().Data.Should().BeOfType<TransfersDto.DataDto[]>();
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers().Data.Should().HaveCountGreaterThan(1);
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithLimit(1)).Data.Should().HaveCount(1);

            AtomicMarketApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Should().BeOfType<TransfersDto>();
            AtomicMarketApiFactory.Version1.TransfersApi.Transfers(new TransfersUriParameterBuilder().WithOrder(SortStrategy.Ascending)).Data.Should().BeOfType<TransfersDto.DataDto[]>();
        }
    }
}
