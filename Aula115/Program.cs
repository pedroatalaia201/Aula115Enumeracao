using System;
using Aula115.Entities;
using Aula115.Entities.Enums;

namespace Aula115 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Enumeração:\n");

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);

            //Converter enum para string:

            string txt = OrderStatus.PendingPayment.ToString();

            Console.WriteLine(txt);

            //Ao contrário, para se converter uma string para enum:

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

            Console.WriteLine(os);
        }
    }
}
