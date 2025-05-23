using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TODO.Repository;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlite("Data Source=app.db");
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}