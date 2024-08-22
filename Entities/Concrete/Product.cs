using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    //varsayılan olarak class'lar internal olarak verilir
    //Internal sadece var olan varlıklar (Entities) erişir
    //private sadece var olan katmanda kullanıma izin verir
    //public diğer katmanlarda da bu class'ın erişimine izin verir

    internal class Product:IEntity // Bu sayede Product bir varlıktır dedik ve veritabanındaki bir tabloya karşılık gelecek
    {
        //Ürün Id
        public int ProductId { get; set; }

        //Ürünün kategori Id
        public int CategoryId { get; set; }

        //Ürün adı
        public string ProductName { get; set; }

        //Ürünün stok adedi
        public short UnitsInStock { get; set; }

        //Ürünün birim fiyatı
        public decimal UnitPrice { get; set; }

        
    }
}
