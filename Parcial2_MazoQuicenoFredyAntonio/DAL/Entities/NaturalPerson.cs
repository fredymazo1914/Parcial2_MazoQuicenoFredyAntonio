using System.ComponentModel.DataAnnotations;

namespace Parcial2_MazoQuicenoFredyAntonio.DAL.Entities
{
        public class NaturalPerson : Entity
        {

            [Display(Name = "Nombres y Apellidos")]
            [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caracteres")]
            [Required(ErrorMessage = "El campo {0} es requerido")]
            public string FullName { get; set; }

            [Display(Name = "Correo electrónico")]
            public string? Email { get; set; }

            [Display(Name = "Fecha de Nacimiento")]
            [Required(ErrorMessage = "El campo {0} es requerido")]
            public DateTime BirthYear { get; set; }

            [Display(Name = "Edad")]
            public int Age { get; set; }

        }
    }
