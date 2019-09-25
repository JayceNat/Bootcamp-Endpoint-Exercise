using System.Net.Http;
using System.ServiceModel;

namespace BootcampEndpointCodingExercise.Interfaces
{
    [ServiceContract]
    public interface IStringReverseService
    {
        [OperationContract]
        HttpResponseMessage ReverseGivenText(string inputText);
    }
}