using bc.infura.web3.Common;

namespace bc.infura.web3.Ethereum
{
    public class GetBalanceRequestBody : RequestBodyBase
    {
        public GetBalanceRequestBody() { }
        public GetBalanceRequestBody(string address)
        {
            Method = "eth_getBalance";
            Arguments = new[] { address, "latest" } ;
        }
    }
}
