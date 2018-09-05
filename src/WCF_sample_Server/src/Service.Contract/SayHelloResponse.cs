using System.Runtime.Serialization;
namespace Service.Contract
{
    [DataContract]
    public class SayHelloResponse
    {
        [DataMember]
        public string HelloMessage { get; set; }
    }
}