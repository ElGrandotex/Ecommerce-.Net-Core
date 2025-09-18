using System.ComponentModel.DataAnnotations;

namespace Ecommerce.Model.Dtos
{
    public class CreateCategoryDto
    {
        //No va porque este se genera en la base de datos
        //public int ID { get; set; }

        [Required(ErrorMessage = "Nombre Obligatorio")]
        [MaxLength(50, ErrorMessage = "El nombre no puede tener mas de 50 caracteres")]
        [MinLength(3, ErrorMessage = "El nombre no puede tener menos de 3 caracteres")]
        public string Name { get; set; } = string.Empty;
        
        //se asgina cuando se utiliza este dto
        //public DateTime CreationDate { get; set; }
    }
}
