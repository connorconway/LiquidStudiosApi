using LiquidStudiosApi.AtomicAssets.Accounts;
using LiquidStudiosApi.AtomicAssets.Assets;
using LiquidStudiosApi.AtomicAssets.Burns;
using LiquidStudiosApi.AtomicAssets.Collections;
using LiquidStudiosApi.AtomicAssets.Config;
using LiquidStudiosApi.AtomicAssets.Offers;
using LiquidStudiosApi.AtomicAssets.Schemas;
using LiquidStudiosApi.AtomicAssets.Templates;
using LiquidStudiosApi.AtomicAssets.Transfers;
using NUnit.Framework;

namespace LiquidStudiosApi.AtomicAssets.Test
{
    [TestFixture]
    public class AtomicAssetsApiFactoryTest
    {
        [Test]
        public void AccountsApi() => Assert.AreEqual(typeof(AccountsApi),AtomicAssetsApiFactory.Version1.AccountsApi.GetType());

        [Test]
        public void AssetsApi() => Assert.AreEqual(typeof(AssetsApi),AtomicAssetsApiFactory.Version1.AssetsApi.GetType());

        [Test]
        public void BurnsApi() => Assert.AreEqual(typeof(BurnsApi),AtomicAssetsApiFactory.Version1.BurnsApi.GetType());

        [Test]
        public void CollectionsApi() => Assert.AreEqual(typeof(CollectionsApi),AtomicAssetsApiFactory.Version1.CollectionsApi.GetType());

        [Test]
        public void ConfigApi() => Assert.AreEqual(typeof(ConfigApi),AtomicAssetsApiFactory.Version1.ConfigApi.GetType());

        [Test]
        public void OffersApi() => Assert.AreEqual(typeof(OffersApi),AtomicAssetsApiFactory.Version1.OffersApi.GetType());

        [Test]
        public void SchemasApi() => Assert.AreEqual(typeof(SchemasApi),AtomicAssetsApiFactory.Version1.SchemasApi.GetType());

        [Test]
        public void TemplatesApi() => Assert.AreEqual(typeof(TemplatesApi),AtomicAssetsApiFactory.Version1.TemplatesApi.GetType());

        [Test]
        public void TransfersApi() => Assert.AreEqual(typeof(TransfersApi),AtomicAssetsApiFactory.Version1.TransfersApi.GetType());
    }
}
