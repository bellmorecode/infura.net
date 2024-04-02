using bc.infura.web3.Common;

namespace bc.infura.web3.Ethereum
{
    public class GetChainIdRequestBody : RequestBodyBase
    {
        public GetChainIdRequestBody()
        {
            Method = "eth_chainId";
            Arguments = Array.Empty<string>();
        }
    }
}
