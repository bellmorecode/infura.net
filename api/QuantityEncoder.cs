using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infura.web3
{
    public sealed class QuantityEncoder
    {
        public string ToHex(int value)
        {
            var tail = value.ToString("X");
            return $"0x{tail}";
        }
    }
}
