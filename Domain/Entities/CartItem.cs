using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CartItem
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double TotalPrice
        {
            get
            {
                return Price * Quantity;
            }
        }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int IdProducts { get; set; }

        Product product { get; set; }
        public int CartId { get; set; }
        public virtual Cart cart { get; set; }


    }
}
