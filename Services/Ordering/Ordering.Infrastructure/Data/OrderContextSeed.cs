using Microsoft.Extensions.Logging;
using Ordering.Core.Entities;

namespace Ordering.Infrastructure.Data
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext orderContext, ILogger<OrderContextSeed> logger)
        {
            if(!orderContext.Orders.Any())
            {
                orderContext.Orders.AddRange(GetOrders());
                await orderContext.SaveChangesAsync();
                logger.LogInformation($"Ordering Database: {typeof(OrderContext).Name} seeded!!!");
            }
        }

        private static IEnumerable<Order> GetOrders()
        {
            return new List<Order>
            {
                new()
                {
                    UserName = "nigar",
                    FirstName = "Nigar",
                    LastName = "Valikhanova",
                    EmailAdress = "nigarvalikhanova@eCommerce.net",
                    AdressLine = "Baku",
                    Country = "Azerbaijan",
                    TotalPrice = 750,
                    State = "Absheron",
                    ZipCode = "101100",

                    CardName = "Visa",
                    CardNumber = "12345678990123456",
                    CreatedBy = "Nigar",
                    Expiration = "12/29",
                    Cvv = "123",
                    PaymentMethod = 1,
                    LastModifiedBy = "Nigar",
                    LastModifiedDate = new DateTime(),
                }
            };
        }
    }
}
