namespace Demo.BusinessLogic.DTOS
{
    public class CreatedepartmentDto
    {
        public string Name { get; set; }=string.Empty;
        public string? Description { get; set; }
        public string Code { get; set; }= string.Empty;
        public DateOnly DateOfCreation { get; set; }
    }
}
