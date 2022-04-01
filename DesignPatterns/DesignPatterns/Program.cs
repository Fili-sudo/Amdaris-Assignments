// See https://aka.ms/new-console-template for more information


using DesignPatterns;
using DesignPatterns.StrategySorters;

Product product1 = new Product { Categories = new List<string> { "4 players", "strategy", "dice" }, ProductName = "Catan", Price = 45, Quantity = 15 };
Product product2 = new Product { Categories = new List<string> { "4 players", "strategy", "cards", "dice" }, ProductName = "Root", Price = 60, Quantity = 10 };
Product product3 = new Product { Categories = new List<string> { "cards", "family", "fun" }, ProductName = "Uno", Price = 15, Quantity = 30 };

ISorterStrategy priceSorter = new PriceSorter();
ISorterStrategy nameSorter = new ProductNameSorter();
InMemoryProductRepository productRepository = new InMemoryProductRepository(nameSorter);
productRepository.CreateProduct(product1);
productRepository.CreateProduct(product2);
productRepository.CreateProduct(product3);
List<Product> products = productRepository.GetProducts().ToList();

foreach (Product product in products)
{
    Console.WriteLine(product);
}
Console.WriteLine();
productRepository.Sorter = priceSorter;
products = productRepository.GetProducts().ToList();
foreach (Product product in products)
{
    Console.WriteLine(product);
}



