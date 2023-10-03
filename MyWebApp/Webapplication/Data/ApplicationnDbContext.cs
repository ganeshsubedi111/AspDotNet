using Microsoft.EntityFrameworkCore;
using Webapplication.Models;
namespace Webapplication.Data;

public class ApplicationnDbContext:DbContext
{
    public ApplicationnDbContext(DbContextOptions<ApplicationnDbContext>options)
        :base(options)
    {
        
    }
    public DbSet<Category> Categories { get;set }
}
