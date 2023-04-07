using Microsoft.EntityFrameworkCore;
using ViragokAPI.Models;

namespace ViragokAPI.DataBase
{
    public class SQL : DbContext
    {
        public SQL() : base(new DbContextOptionsBuilder().UseSqlServer(Program.ConnectionString).Options)
        {
        }

        public DbSet<ViragKategoria> viragKategoriak { get; set; }
        public DbSet<Viragok> viragok { get; set; }
        public DbSet<Vevok> vevok { get; set; } 
        public DbSet<Ertekesites> ertekesitesek { get; set;}
        public DbSet<v_viragok> v_viragok { get; set; }
        public DbSet<v_ertekesitesek> v_ertekesitesek { get; set; }

    }
}
