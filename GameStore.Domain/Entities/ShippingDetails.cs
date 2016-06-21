using System.ComponentModel.DataAnnotations;

namespace GameStore.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Укажите как вас зовут")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вставьте адрес электронной почты")]
        [Display(Name = "Адрес")]
        public string Email { get; set; }

        //public int OrderID { get; set; }

        //public string TotalPrice { get; set; }
    }
}
