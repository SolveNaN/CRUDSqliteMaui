using CrudFinanzasMaui;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AppDbContext : DbContext
{
    public DbSet<Movimiento> Movimientos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var path = Path.Combine(FileSystem.AppDataDirectory, "movimientos.db");
        optionsBuilder.UseSqlite($"Data Source={path}");
    }
}
