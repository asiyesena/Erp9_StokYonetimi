using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sy.Core.Abstracts;

namespace Sy.Core.Entities
{
    [Table(name: "Products")]
    public class Product:BaseEntity<Guid>

    {
        public Product()
        {
            this.Id = Guid.NewGuid();
        }
        [Required,StringLength(100)]
        public string ProductName { get; set; }

        [Range(0,9999999)]
        public decimal UnitPrice { get; set; }

        public int CritickStock { get; set; } = 10;     //kritik stok miktarını 10 olarak sabit belirledik 10un altına dustugunde tekrar sipariş verme uyarısı için olusturduk
    }
}
