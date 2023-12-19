using crud_api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace crud_api.Extensions;

public class MalDbContext : DbContext
{
    public MalDbContext(DbContextOptions<MalDbContext> options) : base(options)
    { }
    public DbSet<MAL> Mal { get; set; }
}