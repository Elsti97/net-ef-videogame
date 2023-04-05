using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace net_ef_videogame.Models;



public class VideogameContext : DbContext
{
    public DbSet<Videogame> Videogames { get; set; }
    public DbSet<SoftwareHouse> SoftwareHouses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
        builder.UseSqlServer("Data Source=localhost;Initial Catalog=db-ef-videogame;Integrated Security=True;Encrypt=False");
    }
}
