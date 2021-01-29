using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cucui_Elena_Proiect_Web.Models
{
    public class Order
    {
        [Key]
        public int ID { get; set; }
        public int OrderNumber { get; set; }
        public int ClientID { get; set; }
        public Client Client { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal Total {
            //get; set;
            get
            {
                decimal t = 0;
                if (OrderLines != null) { 
                foreach (var line in OrderLines) 
                {
                    t = t + line.Total;
                }
                }
                return t;
            }

        }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
