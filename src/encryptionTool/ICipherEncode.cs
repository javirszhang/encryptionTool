using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Javirs.Common;

namespace encryptionTool
{
    public interface ICipherEncode
    {
        string Encode(byte[] buffer);
        byte[] Decode(string input);
    }

    public class Base58CipherEncode : ICipherEncode
    {
        public byte[] Decode(string input)
        {
            return Javirs.Common.Security.Base58.Decode(input);
        }

        public string Encode(byte[] buffer)
        {
            return Javirs.Common.Security.Base58.Encode(buffer);
        }
    }

    public class Base64CipherEncode : ICipherEncode
    {
        public byte[] Decode(string input)
        {
            return Convert.FromBase64String(input);
        }

        public string Encode(byte[] buffer)
        {
            return Convert.ToBase64String(buffer);
        }
    }

    public class HexCipherEncode : ICipherEncode
    {
        public byte[] Decode(string input)
        {
            return input.HexString2ByteArray();
        }

        public string Encode(byte[] buffer)
        {
            return buffer.Byte2HexString();
        }
    }
}
