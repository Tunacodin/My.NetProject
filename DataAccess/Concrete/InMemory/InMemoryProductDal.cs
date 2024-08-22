using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{

    //Dahili bellekten veri erişimi
    public class InMemoryProductDal : IProductDal
    {
        //_products geçerli class için naming convention 
        List<Product> _products;
      
        //Çağırıldığında bellekte referans tutacak ve ürün listesi oluşturacak
         //Constructor new yapıldığında oluştur ve bir değer döndürmez
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product { ProductId=1,CategoryId=2, ProductName="Bardak",  UnitPrice=20, UnitsInStock=3 },
                new Product {ProductId=2,CategoryId=12,ProductName="Tablo",UnitPrice=32, UnitsInStock=4},
                new Product {ProductId=3,CategoryId=5,ProductName="Vazo",UnitPrice=22, UnitsInStock=24},
                new Product {ProductId=4,CategoryId=4,ProductName="Telefon",UnitPrice=132, UnitsInStock=22},
                new Product {ProductId=5,CategoryId=9,ProductName="Çakmak",UnitPrice=2, UnitsInStock=12},

            };
            
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {

            // _products.Remove(product);
            // Bu şekilde değer tipli değişkenler silinebilirken
            //adres tutan referans tipler silinemez

            //LINQ Dile Gömülü Sorgulama

            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);


        }

        public List<Product> GetAll()
        {
            //Veritabanından gelecek veriyi Business a vermek için
            return _products;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=>p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
            productToUpdate.CategoryId = product.CategoryId;



        }
    }
}
