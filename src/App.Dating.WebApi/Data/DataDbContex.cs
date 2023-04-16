using App.Dating.WebApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Dating.WebApi.Data;

public class DataDbContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;

    public DataDbContext(DbContextOptions opt) : base(opt)
    {
    }
}
