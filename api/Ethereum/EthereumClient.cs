using bc.infura.web3.Ethereum;
using bc.infura.web3.Common;

namespace bc.infura.web3.Ethereum
{
    public class EthereumClient : RPCClient
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
            var resp = await GenericCallAsync<GetChainIdRequestBody, GetGasPriceResponseBody>(new GetChainIdRequestBody());
            if (resp != null)
            {
                return resp.Result;
            }
            throw new InvalidOperationException(nameof(GetChainId));
        }

        public async Task<double> GetGasPrice()
        {
            var resp = await GenericCallAsync<GetGasPriceRequestBody, GetGasPriceResponseBody>(new GetGasPriceRequestBody());
            if (resp != null)
            {
                return enc.FromHex(resp.Result);
            }
            throw new InvalidOperationException(nameof(GetGasPrice));
        }

        public async Task<double> GetBalance(string address)
        {
            var resp = await GenericCallAsync<GetBalanceRequestBody, GetBalanceResponseBody>(new GetBalanceRequestBody(address));
            if (resp != null)
            {
                return enc.FromHex(resp.Result);
            }
            throw new InvalidOperationException(nameof(GetBalance));
        }

        protected async Task<TOutput> GenericCallAsync<TInput, TOutput>(TInput args) where TInput : RequestBodyBase, new()
                                                                                     where TOutput : ResponseBodyBase, new()
        {
            // TODO: add validation
            return await CallAsync<TInput, TOutput>(args);
        }

        protected override void Dispose()
        {
           // nothing to dispose of yet.
        }
    }
}
