using infura.web3.Common;

namespace bc.infura.web3.Ethereum
{
    public class GetGasPriceRequestBody : RequestBodyBase
    {
        public GetGasPriceRequestBody()
        {
            Method = "eth_gasPrice";
            Arguments = Array.Empty<string>();
        }
    }
}
