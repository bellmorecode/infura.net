using infura.web3.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
