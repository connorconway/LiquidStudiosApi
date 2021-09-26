using LiquidStudiosApi.AtomicAssets.Assets;
using LiquidStudiosApi.AtomicAssets.Collections;
using LiquidStudiosApi.AtomicAssets.Transfers;

namespace LiquidStudiosApi.AtomicAssets
{
    public class AtomicAssetsApiFactory
    {
        private readonly string _baseUrl;
        private const string Version1BaseUrl = "http://api.wax.liquidstudios.io/atomicassets/v1";

        private AtomicAssetsApiFactory(string baseUrl) => _baseUrl = baseUrl;

        public static AtomicAssetsApiFactory Version1 => new AtomicAssetsApiFactory(Version1BaseUrl);

        public AssetsApi AssetsApi => new AssetsApi(_baseUrl);

        public CollectionsApi CollectionsApi => new CollectionsApi(_baseUrl);

        public TransfersApi TransfersApi => new TransfersApi(_baseUrl);
    }
}
