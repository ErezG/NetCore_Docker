using System;

namespace AWS_Demo_App.ResponseModels
{
    public class EchoResponse : DemoResponse
    {
        public EchoResponse(string echo)
        {
            Echo = echo;
        }
        public string Echo { get; }
    }
}
