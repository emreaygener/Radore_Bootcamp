using Microsoft.AspNetCore.Connections;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using Radore_RabbitMqProducer.Models;
using System.Diagnostics;
using System.Text;

namespace Radore_RabbitMqProducer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                Port = 5672,
                UserName = "guest",
                Password = "guest"
            };

            using (var connection = factory.CreateConnection())
            {
                using(var channel = connection.CreateModel())
                {
                    try
                    {
                        channel.QueueDeclare(
                            queue: "radoreq",
                            durable: false,
                            exclusive: false,
                            autoDelete: false,
                            arguments: null
                        );

                        Product p1 = new Product { Id = 6, Name = "Product 6", Price = 210 };
                        var json = JsonConvert.SerializeObject(p1);
                        var body = Encoding.UTF8.GetBytes(json);

                        channel.BasicPublish(
                            exchange: "",
                            routingKey: "radoreq",
                            basicProperties: null,
                            body: body
                        );
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                }
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
