// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

//productTest();
//CategoryTest();

ProductManager productManager = new ProductManager(new EfProductDal());
var result = productManager.GetAll();
if (result.Success)
{
    if (result.Data != null)
    {
        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName + " -- " );
        }
    }
    else
    {
        Console.WriteLine("Data is null.");
    }
}
else
{
    Console.WriteLine(result.Message);
}


static void productTest()
{
    Console.WriteLine("Hello, World!");

    ProductManager productManager = new ProductManager(new EfProductDal());

    foreach (var p in productManager.GetByUnitPrice(10, 20).Data)
    {
        Console.WriteLine(p.ProductName);
    }
    Console.WriteLine("----------------------------");

    foreach (var p in productManager.GetByCategoryId(3).Data)
    {
        Console.WriteLine(p.ProductName);
    }
    Console.WriteLine("----------------------------");

    var secondProduct = productManager.GetByProductId(2).Data;
    Console.WriteLine(secondProduct.ProductName);
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
    foreach (var c in categoryManager.GetAll())
    {
        Console.WriteLine(c.CategoryName);

    }
}