using Encryptor.API.Configuration;
using System;

namespace Encryptor.API.ResponseModels
{
    public class DemoResponse
    {
        static DemoResponse()
        {
            var rnd = new Random();
            _randomNumber = rnd.Next(0, 100);
        }

        private static readonly int _randomNumber;

        public string Key => CTConfig.Env.Key;
        public string Name => CTConfig.Env.Name;
        public int RandomNumber => _randomNumber;
    }
}
