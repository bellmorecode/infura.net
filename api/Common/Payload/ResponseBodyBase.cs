using System.Text.Json.Serialization;

namespace infura.web3.Common
{
    public abstract class ResponseBodyBase {
        [JsonPropertyName("jsonrpc")]
        public string JsonRPCVersion { get; set; } = "2.0";
        [JsonPropertyName("id")]
        public int Id { get; set; } = 1;
    }
}
