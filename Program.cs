using System.Text;
using System.Text.Json;
using ProducerDemo.Model;
using RabbitMQ.Client;

public class program
{
    public static void Main(string[] args)
    {
        IConnection conexion = null;
        IModel channel = null;
        var connectionFactory = new ConnectionFactory { HostName = "localhost", VirtualHost = "/", Port = 5672, UserName = "guest", Password = "guest" };
        conexion = connectionFactory.CreateConnection();
        channel = conexion.CreateModel();
        
        Aspirante registro = new Aspirante();
        registro.NoExpediente = "EXP-2022001";
        registro.Apellidos = "Mancilla Paz";
        registro.Nombres = "Yolanda";
        registro.Direccion = "Guatemala, Guatemala";
        registro.Email = "ymancilla@gmail.com";

        channel.BasicPublish("exchange-demo", "", null, Encoding.UTF8.GetBytes(JsonSerializer.Serialize(registro)));
        
        Console.WriteLine("Mensaje enviado, presione una tecla para terminar...");
        Console.ReadLine();
    }
}