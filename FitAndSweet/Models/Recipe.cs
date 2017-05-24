using System;
using System.ComponentModel.DataAnnotations;

namespace FitAndSweet.Models
{
    public class Recipe
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser Author { get; set; }

        public DateTime CreationDate { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public string Photo { get; set; }

        [Required]
        public MealType Type { get; set; }
    }
}