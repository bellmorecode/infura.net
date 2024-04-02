using System.Text.Json.Serialization;

namespace bc.infura.web3.Common
{
    public abstract class ResponseBodyBase {
        [JsonPropertyName("jsonrpc")]
        public string JsonRPCVersion { get; set; } = "2.0";
        [JsonPropertyName("id")]
        public int Id { get; set; } = 1;
        [JsonPropertyName("result")]
        public string Result { get; set; } = "0x0";
    }
}
