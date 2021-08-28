using Jareds.Common;
using Jareds.Common.Encrypt;
using System;

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
            return Base58.Decode(input);
        }

        public string Encode(byte[] buffer)
        {
            return Base58.Encode(buffer);
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
            return buffer.ByteArray2HexString();
        }
    }
}
