using Microsoft.EntityFrameworkCore;

namespace ExtendedMVC.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
}