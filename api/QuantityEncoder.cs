using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bc.infura.web3
{
    public sealed class QuantityEncoder
    {
        public double WeiToGwei(long value)
        {
            return value / 1000000000.000000;
        }

        public long GweiToWei(double value)
        {
            return (long)Math.Ceiling(value * 1000000000.00);
        }

        public string ToHex(long value)
        {
            var tail = value.ToString("X");
            return $"0x{tail}";
        }

        public long FromHex(string value)
        {
            if (value.StartsWith("0x"))
            {
                var hexVal = value.Substring(2);
                return long.Parse(hexVal, System.Globalization.NumberStyles.HexNumber);
            }
            else
            {
                throw new ArgumentException("Hex values must begin with '0x'.");
            }
        }
    }
}
