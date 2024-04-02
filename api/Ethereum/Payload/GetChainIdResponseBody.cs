using infura.web3.Common;
using System.Text.Json.Serialization;

namespace bc.infura.web3.Ethereum
{
    public class GetChainIdResponseBody : ResponseBodyBase
    {
        [JsonPropertyName("result")]
        public string Result { get; set; } = "0x0";
    }
}
