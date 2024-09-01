using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Radore_RabbitMqConsumer;
using System.Text;

var factory = new ConnectionFactory() 
{ 
    HostName = "localhost", 
    Port=5672,
    UserName = "guest",
    Password = "guest"
};

using(var connection = factory.CreateConnection())
{
    using (var channel = connection.CreateModel())
    {
        channel.QueueDeclare
        (
            queue: "radoreq",
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null
        );

        var consumer = new EventingBasicConsumer(channel);

        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);

            Product gelenProduct = new();
            gelenProduct = JsonConvert.DeserializeObject<Product>(message);

            Console.WriteLine("Okunan Ürün: {0} fiyat: {1}", gelenProduct.Name,gelenProduct.Price);
        };

        channel.BasicConsume(queue: "radoreq", autoAck: false, consumer: consumer);

        Console.WriteLine("Çıkış yapmak için bir tuşa basınız.");
        Console.ReadLine();

    }
}