using Service.Contract;
using System;
using System.Threading;
namespace Service.Implementation
{
    // Simple async result implementation.
    class CompletedAsyncResult<T> : IAsyncResult
    {
        T data;
        public CompletedAsyncResult(T data)
        { this.data = data; }
        public T Data
        { get { return data; } }
        #region IAsyncResult Members
        public object AsyncState
        { get { return (object)data; } }
        public WaitHandle AsyncWaitHandle
        { get { throw new Exception("The method or operation is not implemented."); } }
        public bool CompletedSynchronously
        { get { return true; } }
        public bool IsCompleted
        { get { return true; } }
        #endregion
    }
    public class SayHelloService : ISayHelloService
    {
        public SayHelloResponse SayHello(SayHelloRequest request)
        {
            Thread.Sleep(120000);
            return new SayHelloResponse
            {
                HelloMessage = string.Format("Hi {0}",request.Name),
            };
        }
        public string SampleMethod(string msg)
        {
            Thread.Sleep(120000); // Test for long operation
            Console.WriteLine("Called synchronous sample method with \"{0}\"", msg);
            return "The sychronous service greets you: " + msg;
        }
        // This asynchronously implemented operation is never called because 
        // there is a synchronous version of the same method.
        public IAsyncResult BeginSampleMethod(string msg, AsyncCallback callback, object asyncState)
        {
            Console.WriteLine("BeginSampleMethod called with: " + msg);
            return new CompletedAsyncResult<string>(msg);
        }
        public string EndSampleMethod(IAsyncResult r)
        {
            CompletedAsyncResult<string> result = r as CompletedAsyncResult<string>;
            Console.WriteLine("EndSampleMethod called with: " + result.Data);
            return result.Data;
        }
        public IAsyncResult BeginServiceAsyncMethod(string msg, AsyncCallback callback, object asyncState)
        {
            Console.WriteLine("BeginServiceAsyncMethod called with: \"{0}\"", msg);
            return new CompletedAsyncResult<string>(msg);
        }
        public string EndServiceAsyncMethod(IAsyncResult r)
        {
            CompletedAsyncResult<string> result = r as CompletedAsyncResult<string>;
            Console.WriteLine("EndServiceAsyncMethod called with: \"{0}\"", result.Data);
            return result.Data;
        }
    }
}