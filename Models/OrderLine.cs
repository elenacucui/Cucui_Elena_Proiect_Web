using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace Cucui_Elena_Proiect_Web.Models
{
    public class OrderLine
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public Product Product { get; set; }

        [Range(1, 100000, ErrorMessage = "Pret invalid: valoare asteptata intre 1 si 100000")]
        public decimal UnitPrice { get; set; }

        [Range(1, 100000, ErrorMessage = "Cantitatea trebuie sa fie mai mare ca 1")]
        public decimal Quantity { get; set; }
        public decimal Total
        {
            get
            {
                return UnitPrice * Quantity;
            }
        }

      //  public ICollection<Order> Orders { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
