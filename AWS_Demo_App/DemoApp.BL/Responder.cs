using System;
using System.Linq;
using System.Threading.Tasks;

namespace DemoApp.BL
{
    public static class Responder
    {
        public static async Task<string> Echo(string input, bool encrypt)
        {
            string output = input;
            if (encrypt)
            {
                var encryptorResponse = await EncryptorClient.Encrypt(output);
                output = encryptorResponse?.Message;
            }
            return output;
        }
        public static async Task<string> Reverse(string input, bool encrypt)
        {
            string output = new string(input.Reverse().ToArray());
            if (encrypt)
            {
                var encryptorResponse = await EncryptorClient.Encrypt(output);
                output = encryptorResponse?.Message;
            }
            return output;
        }
    }
}
