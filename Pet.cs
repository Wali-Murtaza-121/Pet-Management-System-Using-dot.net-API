// Pet.cs
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PMS.Models
{
    public class Pet
    {
        [Key]
        public int PetId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetName { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetAge { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string DateOfAdd { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string DateOfExit { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetGender { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetCategory { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetRoutine { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetFood { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetDietRoutine { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetDose { get; set; } = "";

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        public string PetDoseRoutine { get; set; } = "";
    }
}
