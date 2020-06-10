using System;

namespace AWS_Demo_App.ResponseModels
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
