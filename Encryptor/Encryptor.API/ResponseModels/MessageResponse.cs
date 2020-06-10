using System;

namespace Encryptor.API.ResponseModels
{
    public class MessageResponse : DemoResponse
    {
        public MessageResponse(string text)
        {
            Message = text;
        }
        public string Message { get; }
    }
}
