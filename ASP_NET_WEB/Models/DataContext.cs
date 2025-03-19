
using ASP_NET_WEB.Models;
using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public DbSet<tblMenu> TblMenus { get; set; }
    public DbSet<viewPostMenu> ViewPostMenus { get; set; }
}