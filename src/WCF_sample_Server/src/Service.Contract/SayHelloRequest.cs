using System.Runtime.Serialization;
namespace Service.Contract
{
    [DataContract]
    public class SayHelloRequest
    {
        [DataMember]
        public string Name { get; set; }
    }
}