using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    //Product varlığınını (Entity) veritabanı erişim katmanı burası
    //DAL -- Data Access Layer (.Net)
    //DAO Data Access Object (Java)
    public interface IProductDal
    {

        // List dinamik olarak içerisine veri eklenebilen bir listedir
     
        // Bu noktada Product tipini alabilmesi için access Entities yaptık

        // Eğer sadece Entities yerine Business ya da Consoleuı da seçip ekleseydik
        // Curclar Dependencie olurdu sürekli birbirini referans eden dosyalar haline gelirdi
      
        //Veritabanındaki ürünleri listeler
        List<Product> GetAll();

        //Veritabanına ürün ekler
        void Add(Product product);

        //Veritabanındaki ürünü günceller
        void Update(Product product);

        //Veritabanındaki ürünü siler
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId);

    }
}
