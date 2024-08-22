using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
     class Program
    {
        static void Main(string[] args)
        {

            InMemoryProductDal _inMemoryProductDal = new InMemoryProductDal();

            ProductManager productManager =new ProductManager(_inMemoryProductDal);

            Console.WriteLine(productManager);

            foreach(var product in productManager.GetAll())
            {

                Console.WriteLine( product.ProductName);



            }
        }
    }
}
