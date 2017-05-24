using System.ComponentModel.DataAnnotations;

namespace FitAndSweet.Models
{
    public class MealType
    {
        public byte Id { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }
    }
}