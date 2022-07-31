using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]

        public string Code { get; set; }
        [Required]

        public double Price { get; set; }
        
        public int DiscountPercentage { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public int IdUser { get; set; }

        public Application_User user { get; set; }
        public int IdCategories { get; set; }
        public virtual ProductsCategories Categorie { get; set; }



    }
}
