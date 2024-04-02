using bc.infura.web3.Ethereum;
using infura.web3.Common;

namespace infura.web3.Ethereum
{
    public sealed class EthereumClient : RPCClient
    {
        const string defaultNetwork = "mainnet";
        public EthereumClient(string networkUrl = defaultNetwork)
        {
            Methods = new[] { "eth_chainId", "eth_gasPrice", "eth_getBalance", "eth_call" };
            NetworkUrl = networkUrl;
        }

        public async Task<string> GetChainId()
        {
            var args = new GetChainIdRequestBody();

            var resp = await CallAsync<GetChainIdRequestBody, GetChainIdResponseBody>(args);
            if (resp != null)
            {
                return resp.Result;
            }
            throw new InvalidOperationException("GetChainId");
        }

        protected override void Dispose()
        {
           // do nothing yet.
        }
    }
}
