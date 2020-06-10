using System;
using System.Linq;

namespace Encryptor.BL
{
    public static class Responder
    {
        public static string Echo(string input) => input;
        public static string Reverse(string input) => new string(input.Reverse().ToArray());
    }
}
