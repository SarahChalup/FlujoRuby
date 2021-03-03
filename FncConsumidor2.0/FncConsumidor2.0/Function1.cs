using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FncConsumidor2._0
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static void Run([ServiceBusTrigger("cola1", Connection = "MyConn")]string myQueueItem, ILogger log)
        {
            log.LogInatiformon($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
