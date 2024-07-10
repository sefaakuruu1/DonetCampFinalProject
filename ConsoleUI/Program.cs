// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

Console.WriteLine("Hello, World!");

ProductManager productManager = new ProductManager(new EfProductDal());

foreach(var p in productManager.GetByUnitPrice(10,20))
{
    Console.WriteLine(p.ProductName);
}
Console.WriteLine("----------------------------");

foreach (var p in productManager.GetByCategoryId(3))
{
    Console.WriteLine(p.ProductName);
}
Console.WriteLine("----------------------------");

var secondProduct=productManager.GetByProductId(2);
Console.WriteLine(secondProduct.ProductName);
