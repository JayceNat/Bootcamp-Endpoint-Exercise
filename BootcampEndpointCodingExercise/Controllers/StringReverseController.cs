using System.Net;
using System.Net.Http;
using System.Web.Http;
using BootcampEndpointCodingExercise.Interfaces;

namespace BootcampEndpointCodingExercise.Controllers
{
    public class StringReverseController : ApiController
    {
        private readonly IStringReverseService _stringReverseService;

        public StringReverseController(IStringReverseService stringReverseService)
        {
            _stringReverseService = stringReverseService;
        }
        
        /// <summary>
        /// Returns the reversed value of an input string, e.g. "Funny!" -> "!ynnuF"
        /// </summary>
        /// <param name="inputString">the input string to be reversed</param>
        /// <returns>
        /// A string containing the reversed characters of the input string
        /// </returns>
        [HttpGet]
        [Route("reverseString")]
        public HttpResponseMessage ReverseGivenString(string inputString)
        {
            var decodedInput = WebUtility.UrlDecode(inputString);
            return _stringReverseService.ReverseGivenText(decodedInput);
        }
    }
}