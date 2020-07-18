using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AWSService
{
   public class AWSSQSHelper
    {
        private static AmazonSQSClient Client
        {
            get
            {
                var Client = new AmazonSQSClient("", "", RegionEndpoint.USWest2);
                return Client;
            }
        }


        public void SendMessage(string url, Message sqsMessage)
        {
            try
            {
                var sendMessageRequest = new SendMessageRequest
                {
                    QueueUrl = url,
                    MessageBody = JsonConvert.SerializeObject(sqsMessage.Body),
                   // MessageAttributes = attributes.ToDictionary(item => item.Key, item => (MessageAttributeValue)item.Value),


                };
                var sqsSendMessage = Client.SendMessageAsync(sendMessageRequest).Result;
            }

            catch (AmazonSQSException ex)
            {
                throw new Exception(ex.Message);


            }
        }


    }
}
