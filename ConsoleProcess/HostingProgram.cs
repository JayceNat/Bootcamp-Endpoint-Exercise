using System;
using System.Net;
using System.ServiceModel;
using BootcampEndpointCodingExercise.Implementations;
using BootcampEndpointCodingExercise.Interfaces;

namespace ConsoleProcess
{
    public class HostingProgram
    {
        private static void Main(string[] args)
        {
            const string baseAddress = "http://localhost:8000/stringReverse";
            
            BasicHttpBinding binding = new BasicHttpBinding();

            ServiceHost serviceHost = new ServiceHost(typeof(StringReverseService));

            try
            {
                // Add a Service endpoint
                serviceHost.AddServiceEndpoint(typeof(IStringReverseService), binding, baseAddress);

                // Start the service.
                serviceHost.Open();
                Console.WriteLine("The service is ready.");

                // Close the ServiceHost to stop the service.
                Console.WriteLine("Press <Enter> to terminate the service.");
                Console.WriteLine();
                Console.ReadLine();
                serviceHost.Close();
            }
            catch (CommunicationException ce)
            {
                Console.WriteLine("An exception occurred: {0}", ce.Message);
                serviceHost.Abort();
            }

            
        }
    }
}
