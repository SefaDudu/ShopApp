using System;
using System.Collections.Generic;
using System.Text;

namespace ShopApp.Entities
{
    public class ProductCategory
    {
        
        //çoktan çoka ilişki kurmak için harici bir tablo kurup bağlayabiliriz. buna junction tablo denir.
        //idler PK olmalıki tekrardan kaçınalım fluent api ile verilir

        public int CategoryId { get; set; }
        //navigation prop
        public Category Category { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
