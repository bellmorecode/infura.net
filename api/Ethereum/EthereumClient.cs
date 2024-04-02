using bc.infura.web3.Ethereum;
using infura.web3.Common;

namespace infura.web3.Ethereum
{
    public sealed class EthereumClient : RPCClient
    {
        QuantityEncoder enc = new QuantityEncoder();
        const string defaultNetwork = "mainnet";
        public EthereumClient(string networkUrl = defaultNetwork)
        {
            Methods = new[] { "eth_chainId", "eth_gasPrice", "eth_getBalance", "eth_call" };
            NetworkUrl = networkUrl;
        }

        public async Task<string> GetChainId()
        {
            var resp = await CallAsync<GetChainIdRequestBody, GetGasPriceResponseBody>(new GetChainIdRequestBody());
            if (resp != null)
            {
                return resp.Result;
            }
            throw new InvalidOperationException(nameof(GetChainId));
        }

        public async Task<long> GetGasPrice()
        {
            var resp = await CallAsync<GetGasPriceRequestBody, GetGasPriceResponseBody>(new GetGasPriceRequestBody());
            if (resp != null)
            {
                return enc.FromHex(resp.Result);
            }
            throw new InvalidOperationException(nameof(GetGasPrice));
        }

        protected override void Dispose()
        {
           // nothing to dispose of yet.
        }
    }
}
