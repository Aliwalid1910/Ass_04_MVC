using System.ComponentModel.DataAnnotations;

namespace Demo.BusinessLogic.DTOS
{
    public class CreatedepartmentDto
    {
        [Required] // Name Is Required
        public string Name { get; set; }=string.Empty;

        [Required(ErrorMessage = " Code Is Required !!")]
        public string Code { get; set; } = string.Empty;
        public string? Description { get; set; }

        public DateOnly DateOfCreation { get; set; }
    }
}
