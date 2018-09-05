using ServiceReference1;
using System;
using Xunit;
using Xunit.Abstractions;
using System.Linq;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.ServiceModel.Channels;
using System.Collections;
namespace WCF_sample_Client_XUnitTestProject1
{
    public class UnitTest1
    {
        private readonly ITestOutputHelper output;
        public UnitTest1(ITestOutputHelper output)
        {
            this.output = output;
        }
        [Fact]
        public void Wait_120000()
        {
            try
            {
                output.WriteLine("Hello World!");
                System.ServiceModel.BasicHttpBinding binding = new System.ServiceModel.BasicHttpBinding();
                binding.MaxBufferSize = int.MaxValue;
                binding.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                binding.MaxReceivedMessageSize = int.MaxValue;
                binding.SendTimeout = new TimeSpan(0, 5, 0);
                binding.OpenTimeout = new TimeSpan(0, 5, 0);
                binding.CloseTimeout = new TimeSpan(0, 5, 0);
                binding.ReceiveTimeout = new TimeSpan(0, 5, 0);
                binding.AllowCookies = true;
                binding.TransferMode = TransferMode.StreamedResponse;
                EndpointAddress addressEndpoint =
               new EndpointAddress("http://localhost:50703/SayHelloService.svc");
                SayHelloServiceClient client = new SayHelloServiceClient(binding, addressEndpoint);
                client.OpenAsync().GetAwaiter().GetResult();
                var channel = client.InnerChannel;
                client.InnerChannel.OperationTimeout = TimeSpan.FromMinutes(10);
                var result = client.ServiceAsyncMethodAsync("hi").Result;
                output.WriteLine(result);
            }
            catch (Exception ex)
            {
                output.WriteLine(ex.Message);
            }
        }
    }
}
