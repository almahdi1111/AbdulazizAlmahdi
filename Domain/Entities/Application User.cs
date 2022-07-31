using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Application_User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "ادخل الاسم ")]
        public string Name { get; set; }


        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "ادخل اسم المسنخدم")]
        [Display(Name = "User Name")]
        // [Remote(action: "IsUserNameExist", controller:"Users",ErrorMessage ="اسم المستخدم موجود مسبقا")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "يرجى ادخال كلمة المرور")]
        public string Password { get; set; }
        [Required(ErrorMessage = "يرجى اعادة ادخال كلمة المرور"), Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }
        public int Type { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<ProductsCategories> ProductsCategories { get; set; }



    }
}
