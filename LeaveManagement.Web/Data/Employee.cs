using Microsoft.AspNetCore.Identity;

namespace LeaveManagement.Web.Data
{
    //Estou a criar uma classe onde vai usar o identity, ou seja, estamos a extender essa classe
    public class Employee : IdentityUser
    {
        public string? FirstName { get; set; } //se fizer public string? FirstName { get; set; } quer dizer que na BD vai ser nullable
        public string? LastName { get; set; }
        public string? TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
