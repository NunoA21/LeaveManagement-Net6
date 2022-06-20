namespace LeaveManagement.Web.Data
{
    //a partical class can't be instanciated by itself
    public partial class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
