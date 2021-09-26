using System;
using System.Collections.Generic;
using System.Text;
using LiquidStudiosApi.AtomicAssets.Assets;
using LiquidStudiosApi.AtomicAssets.Collections;
using LiquidStudiosApi.AtomicAssets.Transfers;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicAssets.Test
{
    [TestFixture]
    public class AtomicAssetsApiFactoryTest
    {
        [Test]
        public void AssetsApi()
        {
            Assert.AreEqual(typeof(AssetsApi),AtomicAssetsApiFactory.Version1.AssetsApi.GetType());
        }

        [Test]
        public void CollectionsApi()
        {
            Assert.AreEqual(typeof(CollectionsApi),AtomicAssetsApiFactory.Version1.CollectionsApi.GetType());
        }

        [Test]
        public void TransfersApi()
        {
            Assert.AreEqual(typeof(TransfersApi),AtomicAssetsApiFactory.Version1.TransfersApi.GetType());
        }

    }
}
