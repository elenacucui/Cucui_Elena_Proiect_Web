using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema;

namespace Cucui_Elena_Proiect_Web.Models
{
    public class Product
    {
        public int ID { get; set;}

        [Required(ErrorMessage = "Numele produsului este obligatoriu"), StringLength(150, MinimumLength = 3)]
        [Display(Name = "Product Name")]
        public string Nume { get; set;}
        public string Descriere{ get; set;}

        [Range(1, 100000, ErrorMessage ="Pret invalid: valoare asteptata intre 1 si 100000")]
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price{ get; set;}

        //[NotMapped]
        public ICollection<ProductCategory> ProductCategories { get; set; }
       
        //[ForeignKey("ProductCateg")]
        //public int ProductCategID { get; set; }
        //public ProductCategory ProductCateg { get; set; }
    }
}
