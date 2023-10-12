using LoginProject.Models;
using Microsoft.EntityFrameworkCore;

namespace LoginProject.Database;

public class ApplicationDbContext : DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }

    public DbSet<SignUpModel> users {get; set;}
}