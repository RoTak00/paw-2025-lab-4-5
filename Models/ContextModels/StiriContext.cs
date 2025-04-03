namespace Lab3.Models.ContextModels;
using Microsoft.EntityFrameworkCore;

public class StiriContext : DbContext
{
    public StiriContext(DbContextOptions<StiriContext> options) : base(options)
    {
    }

    public DbSet<Stire> Stiri { get; set; }
    public DbSet<Categorie> Categorii { get; set; }
}