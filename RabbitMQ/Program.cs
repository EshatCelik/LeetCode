using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Threading;

namespace RabbitMQ
{
    class Program
    {
        //public class RabbitMQService
        //{
        //    private readonly string hostName = "localhost";

        //    public IConnection GetRabbitMQConnection()
        //    {
        //        ConnectionFactory conn = new ConnectionFactory() { HostName = hostName };
        //        return conn.CreateConnection();
        //    }
        //}

        //public class Publisher
        //{
        //    private readonly RabbitMQService _rabbitMQService;
        //    public Publisher(string queueName, string message)
        //    {
        //        _rabbitMQService = new RabbitMQService();
        //        using (var connection = _rabbitMQService.GetRabbitMQConnection())
        //        {
        //            using (var channel = connection.CreateModel())
        //            {
        //                channel.QueueDeclare(queueName, false, false, false, null);
        //                channel.BasicPublish("", queueName, null, Encoding.UTF8.GetBytes(message));

        //                Console.WriteLine("{0} queue' su üzerine ,\"{1}\"mesajı yazıldı.", queueName, message);
        //            }
        //        }
        //    }
        //}
        //private static readonly string _queueName = "EshatÇelik";
        
        static void Main(string[] args)
        {

            var @event = new UserEmailChangedEmail()
            {
                OldEmailAddress = null,
                NewEmailAddress = "celikeshat@gmail.com"
            };

            QueueFactory.SendMessageToExchange(exchangeName: RabbitConstant.UserExchangeName
                                               , exchangeType: RabbitConstant.UserExchangeName,
                                               queueName: RabbitConstant.UserEmailChangeQueueName,
                                               obj: @event
                                               );






            //Publisher publisher = new Publisher(_queueName, "hello rabbitmqWord !!!");


            //var factory = new ConnectionFactory() { HostName = "localhost" };
            //string queueName = "samplerMq";

            //var rMqConnection = factory.CreateConnection();
            //var rMqChannel = rMqConnection.CreateModel();

            //rMqChannel.QueueDeclare
            //    (
            //    queue: queueName,
            //    durable: false,
            //    exclusive: false,
            //    autoDelete: false,
            //    arguments: null);

            //rMqChannel.BasicQos(prefetchSize: 0, prefetchCount: 1, global: false);

            //int messageCount = Convert.ToInt32(rMqChannel.MessageCount(queueName));

            //Console.WriteLine(" Listening to the queue. This channels has {0} messages on the queue", messageCount);

            //var consumer = new EventingBasicConsumer(rMqChannel);

            //consumer.Received += (model, ea) =>
            //{
            //    var body = ea.Body.ToArray();
            //    var message = Encoding.UTF8.GetString(body);
            //    Console.WriteLine("Location rreceived:" + message);
            //    rMqChannel.BasicAck(deliveryTag: ea.DeliveryTag, multiple: false);
            //    Thread.Sleep(1000);
            //};

            //rMqChannel.BasicConsume(queue: queueName, autoAck: false, consumer: consumer);
            //Thread.Sleep(1000);
            //Console.WriteLine("Connection Closed , no more message");

            Console.ReadLine();

        }

    }
}
