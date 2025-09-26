namespace Demo.DataAccess.Models.Shared
{
    public class BaseEntity // Include Common Properties [Parent]
    {
        public int Id { get; set; }
        public int CreatedBy { get; set; }  // User Id
        public DateTime? CreatedOn { get; set; }  // The Date Time Of Creating the Record
        public int ModifiedBy { get; set; }  // User Id
        public DateTime? ModifiedOn { get; set; }  // The Date Time Of Modifing the Record
        public bool IsDeleted { get; set; } // SoftDelete
    }
}
