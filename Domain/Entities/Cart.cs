using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public double TotalPrice { get; set; }
        [ForeignKey("Application_User")] 
        public int UserId { get; set; }
       // public virtual Application_User User { get; set; }
        public virtual ICollection<CartItem> CartItems { get; set; }


    }
}
