using System.Linq;
using System.Net;
using System.Net.Http;
using BootcampEndpointCodingExercise.Interfaces;

namespace BootcampEndpointCodingExercise.Implementations
{
    public class StringReverseService : IStringReverseService
    {
        public HttpResponseMessage ReverseGivenText(string inputText)
        {
            return new HttpResponseMessage(HttpStatusCode.Accepted);
            //return inputText.Reverse().ToString();
        }
    }
}
