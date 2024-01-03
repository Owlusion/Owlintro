using Methods;

Product product1 = new Product();

product1.Id = 1;
product1.Name = "QuantumComputer";
product1.Price = 10.45;
product1.Description = "ComputesQuantum";
product1.Stock = 4;

Product product2 = new Product();

product2.Id = 2;
product2.Name = "QuantumMechanism";
product2.Price = 54.50;  
product2.Description = "MechanitesQuantum";
product2.Stock = 8;

Product[] products = new Product[] { product1, product2 };

foreach (var product in products)
{
    Console.WriteLine("ID: " + product.Id);
    Console.WriteLine("Name: " + product.Name);
    Console.WriteLine("Price: " + product.Price);
    Console.WriteLine("Description: " + product.Description);
    Console.WriteLine("Stock: " + product.Stock);
}


Console.WriteLine("----------------------------------------------");

SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(product1);
sepetManager.Ekle(product2);