using System;
using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PetId { get; set; }
        public Pet Pet { get; set; }   

        [Required]
        public string Name { get; set; }
        
        [Required]
        public DateTime DateBorn { get; set; }

        public int Age { get; set; }
    }
}
