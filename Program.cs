using ConsoleStorage.Data;
using ConsoleStorage.Models.Product;

ApplicationData context = new ApplicationData();

context.Products = new List<Product>() {
    new Product {
        ProductID = 1,
        Name = "Teste",
        Description = "Teste teste",
        Code = "code",
        Price = 14.99m,
        Quantity = 2,
        MinimalQuantity = 1,
        ExpiringDate = DateTime.Now
    },
    new Product {
        ProductID = 2,
        Name = "Teste2",
        Description = "Teste2 teste2",
        Code = "code2",
        Price = 9.99m,
        Quantity = 5,
        MinimalQuantity = 3,
        ExpiringDate = DateTime.Now
    }
};

context.SaveChanges();

Console.WriteLine("Done");
