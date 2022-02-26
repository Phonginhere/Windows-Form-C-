using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage.Queue;
using Microsoft.WindowsAzure.Storage.Blob;
using Microsoft.WindowsAzure.Storage.Table;
using Microsoft.WindowsAzure.Storage.Auth;
using Microsoft.WindowsAzure.Storage;

namespace ConsoleApplication_Azure_test
{
    class Program
    {
        static String connecString = "DefaultEndpointsProtocol=https;AccountName=sqlvattwtwpybsdjcs;AccountKey=c6zu6LMbzInVAXeag73sG7KcFNuDHsgT55sgjObce8YQHCHagai/E3Pa3Uk+eAwClpTFYsPjg81jHpQ8AqPe6g==;EndpointSuffix=core.windows.net";
        //static String queueName = "queuea1908g";
        static String queueName = "a1908g2";
        static void Main(string[] args)
        {
            CloudStorageAccount cloudstorageaccount = CloudStorageAccount.Parse(connecString);

            if(cloudstorageaccount != null){

                CloudQueueClient cloudqueueclient = cloudstorageaccount.CreateCloudQueueClient();

                CloudQueue cloudQueue = cloudqueueclient.GetQueueReference(queueName);

                CloudQueueMessage cloudqueuemessage = cloudQueue.PeekMessage();

                Console.WriteLine("Message it is" + cloudqueuemessage.AsString);

                Console.ReadLine();
            }
        }
    }
}
