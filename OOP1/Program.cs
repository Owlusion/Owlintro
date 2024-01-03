// See https://aka.ms/new-console-template for more information

using OOP1;


    Product product1 = new Product
    {
        ProductId = 1,
        ProductName = "QuantumComputer",
        UnitPrice = 27.000,
        UnitsInStock = 1
    };


ProductManager productManager = new ProductManager();

productManager.Add(product1);

int sayi = 100;

productManager.BirSeyYap(sayi);

Console.WriteLine(sayi);
