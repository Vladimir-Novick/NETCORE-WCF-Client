using System;
using System.ServiceModel;
namespace Service.Contract
{
    [ServiceContract]
    public interface ISayHelloService
    {
        [OperationContract]
        SayHelloResponse SayHello(SayHelloRequest request);
        [OperationContractAttribute]
        string SampleMethod(string msg);
        [OperationContractAttribute(AsyncPattern = true)]
        IAsyncResult BeginSampleMethod(string msg, AsyncCallback callback, object asyncState);
        //Note: There is no OperationContractAttribute for the end method.
        string EndSampleMethod(IAsyncResult result);
        [OperationContractAttribute(AsyncPattern = true)]
        IAsyncResult BeginServiceAsyncMethod(string msg, AsyncCallback callback, object asyncState);
        // Note: There is no OperationContractAttribute for the end method.
        string EndServiceAsyncMethod(IAsyncResult result);
    }
}