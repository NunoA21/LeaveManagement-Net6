using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Web.Data
{
    //colocamos IdentityDbContext<Employee> porque queremos que ele use o Employee como um IdentityUser, assim tbm vai adicionar os novos campos na BD
    //o Employee tem de herdar da classe IdentityUser
    public class ApplicationDbContext : IdentityDbContext<Employee>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        //o nome da propriedade é o nome da tabela que vai ser criado
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
    }
}