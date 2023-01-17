namespace Infrustructure.Data;
using  Microsoft.EntityFrameworkCore;
using  Domain.Entities;
public class DataContext : DbContext
{
    public  DataContext (DbContextOptions<DataContext>options):base(options)
    {
        
    }

    public DbSet<Book> Books { get; set; }
}